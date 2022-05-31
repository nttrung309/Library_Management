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
                    ReturnSlip slip = new ReturnSlip(reader.GetString(0), reader.GetString(1), reader.GetString(2), returnDate, reader.GetSqlMoney(4).Value.ToString());
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

                    if(int.Parse(returnBook.borrowedDays) > Parameters.maxLendDay)
                    {
                        int lateReturnDays = int.Parse(returnBook.borrowedDays) - Parameters.maxLendDay;
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

                chosenBooks.Add(returnBook);
                returnView.RemoveAt(dtgvReturnBook.SelectedRows[0].Index);

                chosenBooks = chosenBooks.OrderBy(o => o.bookCode).ThenBy(o => o.bookName).ToList();
                returnView = returnView.OrderBy(o => o.bookCode).ThenBy(o => o.bookName).ToList();

                int stt = 1;
                foreach(ReturnBook book in chosenBooks)
                {
                    book.stt = stt;
                    stt++;
                }
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

                returnView.Add(returnBook);
                chosenBooks.RemoveAt(dtgvChosen.SelectedRows[0].Index);

                chosenBooks = chosenBooks.OrderBy(o => o.bookCode).ThenBy(o => o.bookName).ToList();
                returnView = returnView.OrderBy(o => o.bookCode).ThenBy(o => o.bookName).ToList();

                int stt = 1;
                foreach (ReturnBook book in chosenBooks)
                {
                    book.stt = stt;
                    stt++;
                }
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

                if (dtgvReturnBook.Rows.Count != 0)
                {
                    dtgvReturnBook.Rows[0].Selected = false;
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
                txbTotalFine.Text = (totalFine - fineThisPeriod).ToString();
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
    }
}
