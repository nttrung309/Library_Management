using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using LibraryManagement.Forms;
using LibraryManagement.Models;

namespace DemoDesign
{
    public partial class RecvBook : Form
    {
        public List<ReturnSlip> returnSlips;
        public List<ReturnBook> returnBooks;
        public List<ReturnBook> returnView;
        public List<ReturnBook> chosenBooks;
        BindingSource bindingReturn;
        BindingSource bindingChosen;

        List<int> selectedIndex = new List<int>();

        public static string recvState = "";
        public static bool needPrint = true;

        Thread tdGetNewSlipCode;

        string newReturnSlipCode = "";
        long fineThisPeriod = 0;
        long totalFine = 0;

        public RecvBook()
        {
            InitializeComponent();
        }

        private void RecvBook_Load(object sender, EventArgs e)
        {
            returnSlips = new List<ReturnSlip>();
            returnBooks = new List<ReturnBook>();
            returnView = new List<ReturnBook>();
            chosenBooks = new List<ReturnBook>();
            bindingReturn = new BindingSource();
            bindingChosen = new BindingSource();
            selectedIndex = new List<int>();

            returnDate.Value = DateTime.Now;

            tdGetNewSlipCode= new Thread(new ThreadStart(GetNewReturnSlipCode));

            tdGetNewSlipCode.Start();
            LoadBorrowSlip();
        }

        private void LoadBorrowSlip()
        {
            Parameters.LoadParam();
            SqlConnection conn = new SqlConnection(DatabaseInfo.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(DatabaseInfo.borrowSlipQuery, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    DateTime dt = reader.GetDateTime(3);
                    string returnDate = dt.ToString("dd/MM/yyyy");
                    ReturnSlip slip = new ReturnSlip(reader.GetString(0), reader.GetString(1), reader.GetString(2), returnDate, ((long)reader.GetSqlMoney(4).Value).ToString());
                    slip.lateReturnDays = DateTime.Now.Subtract(dt).Days;
                    slip.fineThisPeriod = CalFineThisPeriod(slip.lateReturnDays);

                    returnSlips.Add(slip);
                    cbbSlipCode.Items.Add(slip.borrowSlipCode);
                }
            }

            cmd.CommandText = DatabaseInfo.borrowedBooksQuery;
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    ReturnBook returnBook = new ReturnBook();
                    returnBook.borrowSlipCode = reader.GetString(0);
                    returnBook.bookCode = reader.GetString(1);
                    returnBook.bookName = reader.GetString(2);
                    DateTime dt = reader.GetDateTime(3);
                    returnBook.borrowDate = dt.ToString("dd/MM/yyyy");
                    returnBook.borrowedDays = Math.Abs(dt.Subtract(DateTime.Now).Days).ToString();
                    returnBook.specBookCode = reader.GetString(4);
                    returnBook.detailSlipCode = reader.GetString(5);
                    if(int.Parse(returnBook.borrowedDays) > Parameters.maxLendDay)
                    {
                        int lateReturnDays = int.Parse(returnBook.borrowedDays) - Parameters.maxLendDay;
                        returnBook.lateReturnDays = lateReturnDays;
                        returnBook.fine = CalFineThisPeriod(lateReturnDays);
                    }
                    returnBooks.Add(returnBook);
                }
            }

            conn.Close();

        }

        private long CalFineThisPeriod(int lateReturnDays)
        {
            long fine = Parameters.finePerDay * lateReturnDays;
            return fine;
        }

        string readerCode = "";
        string readerName = "";
        private void cbbSlipCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            readerCode = returnSlips[cbbSlipCode.SelectedIndex].readerCode;
            readerName = returnSlips[cbbSlipCode.SelectedIndex].readerName;
            txbReaderCode.Text = readerCode;
            txbReaderName.Text = readerName;
            txbFineThisPeriod.Text = "0";

            returnDate.Value = DateTime.ParseExact(returnSlips[cbbSlipCode.SelectedIndex].returnDate, "dd/MM/yyyy", null);
            txbTotalFine.Text = returnSlips[cbbSlipCode.SelectedIndex].totalFine;

            fineThisPeriod = 0;
            chosenBooks.Clear();

            UpdateData();
        }

        private void UpdateData()
        {
            int stt = 1;
            returnView.Clear();
            foreach(ReturnBook returnBook in returnBooks)
            {
                if(returnBook.borrowSlipCode == cbbSlipCode.Text)
                {
                    ReturnBook data = new ReturnBook(returnBook);
                    data.specBookCode = returnBook.specBookCode;
                    data.detailSlipCode = returnBook.detailSlipCode;
                    data.lateReturnDays = returnBook.lateReturnDays;
                    returnView.Add(data);
                }
            }
            returnView = returnView.OrderBy(o => o.bookCode).ThenBy(o => o.bookName).ToList();

            foreach (ReturnBook book in returnView)
            {
                book.stt = stt;
                stt++;
            }

            bindingReturn = new BindingSource();
            bindingReturn.DataSource = returnView;
            dtgvReturnBook.DataSource = bindingReturn;

            bindingChosen = new BindingSource();
            bindingChosen.DataSource = chosenBooks;
            dtgvChosen.DataSource = bindingChosen;

            if (dtgvReturnBook.Rows.Count != 0)
            {
                dtgvReturnBook.Rows[0].Selected = false;
            }

        }

        private void txbReaderCode_TextChanged(object sender, EventArgs e)
        {
            if(txbReaderCode.Text != readerCode)
            {
                txbReaderCode.Text = readerCode;
            }
        }

        private void txbReaderName_TextChanged(object sender, EventArgs e)
        {
            if (txbReaderName.Text != readerName)
            {
                txbReaderName.Text = readerName;
            }
        }

        private void returnDate_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }

        private void dtgvReturnBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dtgvReturnBook.Rows[e.RowIndex].Selected == true)
            {
                dtgvReturnBook.Rows[e.RowIndex].Selected = false;
            }
            else
            {
                //Add just selected row to selectedIndex list if not existed
                if (e.RowIndex != -1)
                {
                    bool isExisted = false;
                    foreach (int index in selectedIndex)
                    {
                        if (index == e.RowIndex)
                        {
                            isExisted = true;
                            break;
                        }
                    }
                    if (!isExisted)
                    {
                        selectedIndex.Add(e.RowIndex);
                    }
                }
                //Hightlight the selected rows
                foreach (int index in selectedIndex)
                {
                    dtgvReturnBook.Rows[index].Selected = true;
                }
            }
        }

        private void btnChooseBook_Click(object sender, EventArgs e)
        {
            try
            {
                ReturnBook returnBook = new ReturnBook();
                returnBook.bookCode = dtgvReturnBook.SelectedRows[0].Cells[1].Value.ToString();
                returnBook.bookName =   dtgvReturnBook.SelectedRows[0].Cells[2].Value.ToString();
                returnBook.borrowDate = dtgvReturnBook.SelectedRows[0].Cells[3].Value.ToString();
                returnBook.borrowedDays = dtgvReturnBook.SelectedRows[0].Cells[4].Value.ToString();
                returnBook.fine = long.Parse(dtgvReturnBook.SelectedRows[0].Cells[5].Value.ToString());
                returnBook.specBookCode = returnView[dtgvReturnBook.SelectedRows[0].Index].specBookCode;
                returnBook.detailSlipCode = returnView[dtgvReturnBook.SelectedRows[0].Index].detailSlipCode;
                returnBook.lateReturnDays = returnView[dtgvReturnBook.SelectedRows[0].Index].lateReturnDays;

                chosenBooks.Add(returnBook);
                returnView.RemoveAt(dtgvReturnBook.SelectedRows[0].Index);

                chosenBooks = chosenBooks.OrderBy(o => o.bookCode).ThenBy(o => o.bookName).ToList();
                returnView = returnView.OrderBy(o => o.bookCode).ThenBy(o => o.bookName).ToList();

                int stt = 1;
                int totalLateReturnDays = 0;
                foreach(ReturnBook book in chosenBooks)
                {
                    totalLateReturnDays += book.lateReturnDays;
                    book.stt = stt;
                    stt++;
                }

                lbLateDays.Text = totalLateReturnDays.ToString();

                stt = 1;
                foreach (ReturnBook book in returnView)
                {
                    book.stt = stt;
                    stt++;
                }

                bindingReturn = new BindingSource();
                bindingReturn.DataSource = returnView;
                dtgvReturnBook.DataSource = bindingReturn;

                bindingChosen = new BindingSource();
                bindingChosen.DataSource = chosenBooks;
                dtgvChosen.DataSource = bindingChosen;

                if(dtgvReturnBook.Rows.Count != 0)
                {
                    dtgvReturnBook.Rows[0].Selected = false;
                }
                foreach(DataGridViewRow row in dtgvChosen.Rows)
                {
                    if (row.Cells[1].Value.ToString() == returnBook.bookCode)
                    {
                        dtgvChosen.Rows[row.Index].Selected = true;
                        break;
                    }
                }

                fineThisPeriod += returnBook.fine;
                txbFineThisPeriod.Text = fineThisPeriod.ToString();
                txbTotalFine.Text = (totalFine + fineThisPeriod).ToString();
            }
            catch
            {
                MessageBox.Show($"Vui lòng chọn 1 quyển sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUnchooseBook_Click(object sender, EventArgs e)
        {
            try
            {
                ReturnBook returnBook = new ReturnBook();
                returnBook.bookCode = dtgvChosen.SelectedRows[0].Cells[1].Value.ToString();
                returnBook.bookName = dtgvChosen.SelectedRows[0].Cells[2].Value.ToString();
                returnBook.borrowDate = dtgvChosen.SelectedRows[0].Cells[3].Value.ToString();
                returnBook.borrowedDays = dtgvChosen.SelectedRows[0].Cells[4].Value.ToString();
                returnBook.fine = long.Parse(dtgvChosen.SelectedRows[0].Cells[5].Value.ToString());
                returnBook.specBookCode = chosenBooks[dtgvChosen.SelectedRows[0].Index].specBookCode;
                returnBook.detailSlipCode = chosenBooks[dtgvChosen.SelectedRows[0].Index].detailSlipCode;
                returnBook.lateReturnDays = returnView[dtgvReturnBook.SelectedRows[0].Index].lateReturnDays;

                returnView.Add(returnBook);
                chosenBooks.RemoveAt(dtgvChosen.SelectedRows[0].Index);

                chosenBooks = chosenBooks.OrderBy(o => o.bookCode).ThenBy(o => o.bookName).ToList();
                returnView = returnView.OrderBy(o => o.bookCode).ThenBy(o => o.bookName).ToList();

                int stt = 1;
                int totalLateReturnDays = 0;
                foreach (ReturnBook book in chosenBooks)
                {
                    book.stt = stt;
                    totalLateReturnDays += book.lateReturnDays;
                    stt++;
                }

                lbLateDays.Text = totalLateReturnDays.ToString();

                stt = 1;
                foreach (ReturnBook book in returnView)
                {
                    book.stt = stt;
                    stt++;
                }

                bindingReturn = new BindingSource();
                bindingReturn.DataSource = returnView;
                dtgvReturnBook.DataSource = bindingReturn;

                bindingChosen = new BindingSource();
                bindingChosen.DataSource = chosenBooks;
                dtgvChosen.DataSource = bindingChosen;

                if (dtgvChosen.Rows.Count != 0)
                {
                    dtgvChosen.Rows[0].Selected = false;
                }
                foreach (DataGridViewRow row in dtgvReturnBook.Rows)
                {
                    if (row.Cells[1].Value.ToString() == returnBook.bookCode)
                    {
                        dtgvReturnBook.Rows[row.Index].Selected = true;
                        break;
                    }
                }

                fineThisPeriod -= returnBook.fine;
                txbFineThisPeriod.Text = fineThisPeriod.ToString();
                txbTotalFine.Text = (totalFine + fineThisPeriod).ToString();
            }
            catch
            {
                MessageBox.Show($"Vui lòng chọn 1 quyển sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LibraryManagement.fHome.SwitchForm(new DemoDesign.RecvBook());
        }
        public enum Valid
        {
            MissingInfo,
            MissingBook,
            Success
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            switch (isValid())
            {
                case Valid.MissingInfo:
                    {
                        MessageBox.Show($"Vui lòng nhập mã phiếu mượn sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                case Valid.MissingBook:
                    {
                            MessageBox.Show($"Vui lòng chọn 1 quyển sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                case Valid.Success:
                    {
                        ShowConfirmForm();
                        break;
                    }
            }
        }
        private Valid isValid()
        {
            if(cbbSlipCode.SelectedIndex == -1)
            {
                return Valid.MissingInfo;
            }
            else if(dtgvChosen.Rows.Count == 0)
            {
                return Valid.MissingBook;
            }
            return Valid.Success;
        }
        private void CreateReturnSlip()
        {
            string createReturnSlip = $@"INSERT INTO PHIEUTRASACH(MaDocGia, NgTra, TienPhatKyNay) VALUES('{txbReaderCode.Text}', '{returnDate.Value.ToString("yyyy-MM-dd")}', {txbFineThisPeriod.Text})";
            string createReturnSlipDetail = @"";
            string setBookAndSlipDetailStatus = @"";

            foreach(ReturnBook book in chosenBooks)
            {
                createReturnSlipDetail += $@"INSERT INTO CTPT(MaPhieuTraSach, MaCuonSach, MaPhieuMuonSach, SoNgayMuon, TienPhat) VALUES('{newReturnSlipCode}','{book.specBookCode}','{cbbSlipCode.Text}','{book.borrowedDays}','{book.fine}')" + "\n";
                setBookAndSlipDetailStatus += $@"UPDATE CTPHIEUMUON SET TinhTrangPM = 1  WHERE MaChiTietPhieuMuon = '{book.detailSlipCode}'" + "\n" + $@"UPDATE CUONSACH SET TinhTrang = 1 WHERE MaCuonSach = '{book.specBookCode}'";
            }

            SqlConnection conn = new SqlConnection(DatabaseInfo.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(createReturnSlip, conn);
            cmd.ExecuteNonQuery();
            cmd.CommandText = createReturnSlipDetail;
            cmd.ExecuteNonQuery();
            cmd.CommandText = setBookAndSlipDetailStatus;
            cmd.ExecuteNonQuery();

        }
        private void GetNewReturnSlipCode()
        {
            string currCode = "";
            SqlConnection conn = new SqlConnection(DatabaseInfo.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(DatabaseInfo.getNewReturnSlipCode, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    currCode = reader.GetString(0);
                }
            }
            int stt = int.Parse(currCode.Substring(4, 3)) + 1;
            newReturnSlipCode = $"MPTS{stt:000}";
        }
        private void ShowConfirmForm()
        {
            tdGetNewSlipCode.Join();
            ConfirmRecvBook.returnSlip = new ReturnSlip(cbbSlipCode.Text, txbReaderCode.Text, txbReaderName.Text, returnDate.Value.ToString("yyyy-MM-dd"), txbTotalFine.Text, txbFineThisPeriod.Text, chosenBooks);
            ConfirmRecvBook.returnSlip.recvSlipCode = newReturnSlipCode;
            ConfirmRecvBook.returnSlip.email = "";

            new ConfirmRecvBook().ShowDialog();
            if (recvState == "Success")
            {
                MessageBox.Show("Trả sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                chosenBooks.Clear();

                btnReturn.Enabled = false;

                //bindingChosen = new BindingSource();
                //bindingChosen.DataSource = chosenBooks;
                //dtgvChosen.DataSource = bindingChosen;

                recvState = "";
                tdGetNewSlipCode = new Thread(new ThreadStart(GetNewReturnSlipCode));
                tdGetNewSlipCode.Start();
            }
        }

        private void tgBtnPrint_CheckedChanged(object sender, EventArgs e)
        {
            needPrint = (tgBtnPrint.Checked == true) ? true : false;
        }
    }
}
