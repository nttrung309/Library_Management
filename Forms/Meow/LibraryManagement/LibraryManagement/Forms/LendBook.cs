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
using LibraryManagement.Models;
using LibraryManagement.Forms;
using System.Text.RegularExpressions;
using System.Threading;

namespace DemoDesign
{
    public partial class LendBook : Form
    {
        List<Book> stockBooks;
        List<Book> findBooks;
        List<Book> chosenBooks;
        List<Reader> readers;


        string slipCode = "";
        string readerName = "";
        bool lockReaderName = true;
        public static string lendState = "";
        public static bool askBeforePrint = true;

        Thread tdGetBookSlip;

        BindingSource bindingStock;
        BindingSource bindingChosen;
        enum BtnOption
        {
            ChooseBook,
            UnchooseBook
        }

        public LendBook()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void LendBook_Load(object sender, EventArgs e)
        {
            Parameters.LoadParam();

            returnDate.Value = borrowDate.Value.AddDays(Parameters.maxLendDay);
            lbMaxBorrow.Text = $"Số sách được mượn tối đa: {Parameters.maxBorrowBook}";
            LoadData();
        }

        private void LoadData()
        {
            stockBooks = new List<Book>();
            findBooks = new List<Book>();
            chosenBooks = new List<Book>();
            readers = new List<Reader>();

            bindingStock = new BindingSource();

            lbAmount.Text = $"Số lượng: {chosenBooks.Count}";

            Thread tdLoadReaders = new Thread(new ThreadStart(LoadReaders));
            Thread tdLoadStockBooks = new Thread(new ThreadStart(LoadStockBooks));
            tdGetBookSlip = new Thread(new ThreadStart(GetSlipCode));

            tdLoadReaders.Start();
            tdLoadStockBooks.Start();
            tdGetBookSlip.Start();

            tdLoadReaders.Join();
            //LoadReaders();
            //LoadStockBooks();
            UpdateComboBoxReaders();
            AddControlEvent();
        }

        private void UpdateComboBoxReaders()
        {
            foreach(Reader reader in readers)
            {
                cbbReaderCode.Items.Add(reader.code);
            }
        }

        private void AddControlEvent()
        {
            
        }
        private void btnAddRemove_Click(object sender, EventArgs e)
        {
            
        }

        private void GetSlipCode()
        {
            SqlConnection conn = new SqlConnection(DatabaseInfo.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(DatabaseInfo.getBookSlipCode, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    slipCode = reader.GetString(0);
                }
            }
            conn.Close();
            int stt = int.Parse(slipCode.Substring(4, 3)) + 1;
            slipCode = $"MPMS{stt:000}";
        }

        private void LoadReaders()
        {
            SqlConnection conn = new SqlConnection(DatabaseInfo.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(DatabaseInfo.readersQueryCmd, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    readers.Add(new Reader(reader.GetString(0), reader.GetString(1), reader.GetDateTime(2), reader.GetString(3)));
                }
            }
            conn.Close();
            //dtgvStock.Refresh();
        }

        void LoadStockBooks()
        {
            SqlConnection conn = new SqlConnection(DatabaseInfo.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(DatabaseInfo.bookStockQueryCmd, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                int stt = 1;
                while (reader.Read())
                {
                    stockBooks.Add(new Book(stt, reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4)));
                    stt++;
                }
            }
            conn.Close();

            stockBooks = stockBooks.OrderBy(o => o.code).ThenBy(o => o.name).ToList();
            bindingStock.DataSource = stockBooks;
            dtgvStock.DataSource = bindingStock;

            if (dtgvStock.Rows.Count != 0)
            {
                dtgvStock.Rows[0].Selected = false;
            }
            //dtgvStock.Refresh();
        }

        private void borrowDate_ValueChanged(object sender, EventArgs e)
        {
            Parameters.LoadParam();
            returnDate.Value = borrowDate.Value.AddDays(Parameters.maxLendDay);
        }

        private void btnChooseBook_Click(object sender, EventArgs e)
        {
            Parameters.LoadParam();
            if ((chosenBooks.Count + 1 > Parameters.maxBorrowBook) && (tgBtnAllowMax.CheckState == CheckState.Checked))
            {
                MessageBox.Show($"Không được mượn quá {Parameters.maxBorrowBook} quyển sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txbFindBook.Text.Length == 0)
                {
                    SelectFromNormalView();
                }
                else
                {
                    SelectFromFindingView();
                }
            }
        }

        private void SelectFromFindingView()
        {
            try
            {
                int stt = 1;
                Book bookChosen = new Book();

                bookChosen.stt = chosenBooks.Count + 1;
                bookChosen.code = dtgvStock.SelectedRows[0].Cells[1].Value.ToString();
                bookChosen.name = dtgvStock.SelectedRows[0].Cells[2].Value.ToString();
                bookChosen.category = dtgvStock.SelectedRows[0].Cells[3].Value.ToString();
                bookChosen.author = dtgvStock.SelectedRows[0].Cells[4].Value.ToString();
                bookChosen.specCode = findBooks[dtgvStock.SelectedRows[0].Index].specCode;

                chosenBooks.Add(bookChosen);

                int index = 0;
                foreach(Book book in stockBooks)
                {
                    if(bookChosen.code == book.code)
                    {
                        break;
                    }
                    index++;
                }
                stockBooks.RemoveAt(index);
                findBooks.RemoveAt(dtgvStock.SelectedRows[0].Index);

                findBooks = findBooks.OrderBy(o => o.code).ThenBy(o => o.name).ToList();
                chosenBooks = chosenBooks.OrderBy(o => o.code).ThenBy(o => o.name).ToList();

                foreach (Book book in findBooks)
                {
                    book.stt = stt;
                    stt++;
                }

                stt = 1;
                foreach (Book book in chosenBooks)
                {
                    book.stt = stt;
                    stt++;
                }

                stt = 1;
                foreach (Book book in stockBooks)
                {
                    book.stt = stt;
                    stt++;
                }

                bindingStock = new BindingSource();
                bindingStock.DataSource = findBooks;
                dtgvStock.DataSource = bindingStock;

                bindingChosen = new BindingSource();
                bindingChosen.DataSource = chosenBooks;
                dtgvBookChosen.DataSource = bindingChosen;
                //dtgvBookChosen.Update();
                //dtgvBookChosen.Refresh();

                lbAmount.Text = $"Số lượng: {chosenBooks.Count}";

                if (dtgvStock.Rows.Count != 0)
                {
                    dtgvStock.Rows[0].Selected = false;
                }

                foreach (DataGridViewRow row in dtgvBookChosen.Rows)
                {
                    if (row.Cells[1].Value.ToString() == bookChosen.code)
                    {
                        dtgvBookChosen.Rows[row.Index].Selected = true;
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show($"Vui lòng chọn 1 quyển sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SelectFromNormalView()
        {
            try
            {
                Book bookChosen = new Book();

                bookChosen.stt = chosenBooks.Count + 1;
                bookChosen.code = dtgvStock.SelectedRows[0].Cells[1].Value.ToString();
                bookChosen.name = dtgvStock.SelectedRows[0].Cells[2].Value.ToString();
                bookChosen.category = dtgvStock.SelectedRows[0].Cells[3].Value.ToString();
                bookChosen.author = dtgvStock.SelectedRows[0].Cells[4].Value.ToString();
                bookChosen.specCode = stockBooks[dtgvStock.SelectedRows[0].Index].specCode;

                chosenBooks.Add(bookChosen);

                UpdateData(BtnOption.ChooseBook);
                if (dtgvStock.Rows.Count != 0)
                {
                    dtgvStock.Rows[0].Selected = false;
                }
                    
                foreach (DataGridViewRow row in dtgvBookChosen.Rows)
                {
                    if (row.Cells[1].Value.ToString() == bookChosen.code)
                    {
                        dtgvBookChosen.Rows[row.Index].Selected = true;
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show($"Vui lòng chọn 1 quyển sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnUnchooseBook_Click(object sender, EventArgs e)
        {
            if(txbFindBook.Text == "")
            {
                DeselectFromNormalView();
            }
            else
            {
                DeselectFromFindingView();
            }
        }

        private void DeselectFromFindingView()
        {
            try
            {
                int stt = 1;
                Book bookUnchosen = new Book();

                bookUnchosen.stt = stockBooks.Count + 1;
                bookUnchosen.code = dtgvBookChosen.SelectedRows[0].Cells[1].Value.ToString();
                bookUnchosen.name = dtgvBookChosen.SelectedRows[0].Cells[2].Value.ToString();
                bookUnchosen.category = dtgvBookChosen.SelectedRows[0].Cells[3].Value.ToString();
                bookUnchosen.author = dtgvBookChosen.SelectedRows[0].Cells[4].Value.ToString();
                bookUnchosen.specCode = chosenBooks[dtgvBookChosen.SelectedRows[0].Index].specCode;

                findBooks.Add(bookUnchosen);
                stockBooks.Add(bookUnchosen);
                chosenBooks.RemoveAt(dtgvBookChosen.SelectedRows[0].Index);

                findBooks = findBooks.OrderBy(o => o.code).ThenBy(o => o.name).ToList();
                chosenBooks = chosenBooks.OrderBy(o => o.code).ThenBy(o => o.name).ToList();

                foreach (Book book in findBooks)
                {
                    book.stt = stt;
                    stt++;
                }

                stt = 1;
                foreach (Book book in chosenBooks)
                {
                    book.stt = stt;
                    stt++;
                }

                stt = 1;
                foreach (Book book in stockBooks)
                {
                    book.stt = stt;
                    stt++;
                }

                bindingStock = new BindingSource();
                bindingStock.DataSource = findBooks;
                dtgvStock.DataSource = bindingStock;

                bindingChosen = new BindingSource();
                bindingChosen.DataSource = chosenBooks;
                dtgvBookChosen.DataSource = bindingChosen;
                //dtgvBookChosen.Update();
                //dtgvBookChosen.Refresh();

                lbAmount.Text = $"Số lượng: {chosenBooks.Count}";
                if (dtgvBookChosen.Rows.Count != 0)
                {
                    dtgvBookChosen.Rows[0].Selected = false;
                }
                foreach (DataGridViewRow row in dtgvStock.Rows)
                {
                    if (row.Cells[1].Value.ToString() == bookUnchosen.code)
                    {
                        dtgvStock.Rows[row.Index].Selected = true;
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show($"Vui lòng chọn 1 quyển sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeselectFromNormalView()
        {
            try
            {
                Book bookUnchosen = new Book();

                bookUnchosen.stt = stockBooks.Count + 1;
                bookUnchosen.code = dtgvBookChosen.SelectedRows[0].Cells[1].Value.ToString();
                bookUnchosen.name = dtgvBookChosen.SelectedRows[0].Cells[2].Value.ToString();
                bookUnchosen.category = dtgvBookChosen.SelectedRows[0].Cells[3].Value.ToString();
                bookUnchosen.author = dtgvBookChosen.SelectedRows[0].Cells[4].Value.ToString();
                bookUnchosen.specCode = chosenBooks[dtgvBookChosen.SelectedRows[0].Index].specCode;

                stockBooks.Add(bookUnchosen);

                UpdateData(BtnOption.UnchooseBook);
                if (dtgvBookChosen.Rows.Count != 0)
                {
                    dtgvBookChosen.Rows[0].Selected = false;
                }
                foreach (DataGridViewRow row in dtgvStock.Rows)
                {
                    if (row.Cells[1].Value.ToString() == bookUnchosen.code)
                    {
                        dtgvStock.Rows[row.Index].Selected = true;
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show($"Vui lòng chọn 1 quyển sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateData(BtnOption btnOption)
        {
            int stt = 1;
            if (btnOption == BtnOption.ChooseBook)
            {
                stockBooks.RemoveAt(dtgvStock.SelectedRows[0].Index);
            }
            else
            {
                chosenBooks.RemoveAt(dtgvBookChosen.SelectedRows[0].Index);
            }

            stockBooks = stockBooks.OrderBy(o => o.code).ThenBy(o => o.name).ToList();
            chosenBooks = chosenBooks.OrderBy(o => o.code).ThenBy(o => o.name).ToList();
            
            foreach (Book book in stockBooks)
            {
                book.stt = stt;
                stt++;
            }
            stt = 1;
            foreach (Book book in chosenBooks)
            {
                book.stt = stt;
                stt++;
            }

            bindingStock = new BindingSource();
            bindingStock.DataSource = stockBooks;
            dtgvStock.DataSource = bindingStock;

            bindingChosen = new BindingSource();
            bindingChosen.DataSource = chosenBooks;
            dtgvBookChosen.DataSource = bindingChosen;
            //dtgvBookChosen.Update();
            //dtgvBookChosen.Refresh();

            lbAmount.Text = $"Số lượng: {chosenBooks.Count}";
        }

        private void cbbReaderCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            lockReaderName = false;
            txbReaderName.Text = readers[cbbReaderCode.SelectedIndex].name;
            lockReaderName = true;
        }

        private void txbReaderName_MouseDown(object sender, MouseEventArgs e)
        {
            readerName = txbReaderName.Text.ToString();
        }

        private void returnDay_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }

        private void txbReaderName_TextChanged(object sender, EventArgs e)
        {
            if (lockReaderName)
            {
                txbReaderName.Text = readerName;
            }
        }

        private void cbbReaderCode_TextChanged(object sender, EventArgs e)
        {
            if(cbbReaderCode.Text != "")
            {
                ComboBox cbb = (ComboBox)sender;
                string text = cbb.Text.ToString();
                cbb.Text = text.ToUpper();
                cbb.Select(cbb.Text.Length, 0);

                string readerCode = cbbReaderCode.Text;
                bool isFound = false;
                foreach (Reader reader in readers)
                {
                    if (readerCode == reader.code)
                    {
                        isFound = true;
                        break;
                    }
                }
                lbWCode.Visible = (isFound) ? false : true;
            }
        }
        public static string RemoveUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
            "đ",
            "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
            "í","ì","ỉ","ĩ","ị",
            "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
            "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
            "ý","ỳ","ỷ","ỹ","ỵ",};
                    string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
            "d",
            "e","e","e","e","e","e","e","e","e","e","e",
            "i","i","i","i","i",
            "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
            "u","u","u","u","u","u","u","u","u","u","u",
            "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }

        private void txbFindBook_TextChanged(object sender, EventArgs e)
        {
            TextBox txb = (TextBox)sender;
            if(txb.Text.Length == 0)
            {
                bindingStock = new BindingSource();
                bindingStock.DataSource = stockBooks;
                dtgvStock.DataSource = bindingStock;
            }
            else
            {
                String findText = txb.Text;
                String code, name, category, author;
                findText = RemoveUnicode(findText.ToLower());


                findBooks.Clear();
                int stt = 1;
                bool found = false;
                foreach(Book book in stockBooks)
                {
                    found = false;

                    code = RemoveUnicode(book.code.ToLower());
                    name = RemoveUnicode(book.name.ToLower());
                    category = RemoveUnicode(book.category.ToLower());
                    author = RemoveUnicode(book.author.ToLower());

                    if (code.Contains(findText) || name.Contains(findText) || category.Contains(findText) || author.Contains(findText))
                    {
                        found = true;
                    }
                    else if(book.code.ToLower().Contains(findText) || book.name.ToLower().Contains(findText) || book.category.ToLower().Contains(findText) || book.author.ToLower().Contains(findText))
                    {
                        found = true;
                    }
                    if (found)
                    {
                        Book findBook = new Book(book);
                        findBook.stt = stt;
                        stt++;
                        findBooks.Add(findBook);
                        findBooks = findBooks.OrderBy(o => o.code).ThenBy(o => o.name).ToList();
                    }
                }

                bindingStock = new BindingSource();
                bindingStock.DataSource = findBooks;
                dtgvStock.DataSource = bindingStock;
                if (dtgvStock.Rows.Count != 0)
                {
                    dtgvStock.Rows[0].Selected = false;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txbFindBook.Text = "";
            txbFindBook.Select();
        }

        public enum Valid
        {
            Valid,
            MissingCode,
            MissingBook,
            BorrowedMax,
            LendDayPast
        }

        private void btnLend_Click(object sender, EventArgs e)
        {
            switch (IsValid())
            {
                case Valid.Valid:
                    {
                        ShowConfirmForm();
                        break;
                    }
                case Valid.MissingCode:
                    {
                        MessageBox.Show("Vui lòng nhập mã độc giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                case Valid.MissingBook:
                    {
                        MessageBox.Show("Vui chọn 1 quyển sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                case Valid.BorrowedMax:
                    {
                        MessageBox.Show($"Độc giả này đã mượn tối đa {Parameters.maxBorrowBook} quyển sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
            }
        }

        private Valid IsValid()
        {
            if(cbbReaderCode.SelectedIndex == -1)
            {
                return Valid.MissingCode;
            }
            else if (dtgvBookChosen.Rows.Count == 0)
            {
                return Valid.MissingBook;
            }
            else
            {
                if(tgBtnAllowMax.CheckState == CheckState.Checked)
                {
                    int numborrowedBooks = -1;
                    Parameters.LoadParam();
                    SqlConnection conn = new SqlConnection(DatabaseInfo.connectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(DatabaseInfo.GetNumOfBooksBorrowed(cbbReaderCode.Text), conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            numborrowedBooks = reader.GetInt32(0);
                        }
                    }
                    conn.Close();

                    if (numborrowedBooks >= Parameters.maxBorrowBook)
                    {
                        return Valid.BorrowedMax;
                    }
                }
            }
            return Valid.Valid;
        }

        private void ShowConfirmForm()
        {
            tdGetBookSlip.Join();
            string code = cbbReaderCode.Text.ToString();
            string name = txbReaderName.Text.ToString();
            string email = readers[cbbReaderCode.SelectedIndex].email;
            string lendDate = borrowDate.Value.ToString("yyyy-MM-dd");
            string backDate = returnDate.Value.ToString("yyyy-MM-dd");
            string amount = chosenBooks.Count.ToString();

            ConfirmLendBook.borrowSlip = new BorrowSlip(slipCode, code, name, email, lendDate, backDate, amount, chosenBooks);
            new ConfirmLendBook().ShowDialog();

            if(lendState == "Success")
            {
                MessageBox.Show("Cho mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnLend.Enabled = false;

                //chosenBooks.Clear();
                //bindingChosen = new BindingSource();
                //bindingChosen.DataSource = chosenBooks;
                //dtgvBookChosen.DataSource = bindingChosen;

                lendState = "";
                tdGetBookSlip = new Thread(new ThreadStart(GetSlipCode));
                tdGetBookSlip.Start();
            }
            //String returnDay = 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LibraryManagement.fHome.SwitchForm(new LendBook());
        }

        private void tgBtnAskBeforePrint_CheckedChanged(object sender, EventArgs e)
        {
            askBeforePrint = (tgBtnAskBeforePrint.CheckState == CheckState.Checked) ? true : false;
        }

        private void tgBtnAllowMax_CheckedChanged(object sender, EventArgs e)
        {
            string temp = "Số sách được mượn tối đa: ";
            if(tgBtnAllowMax.CheckState == CheckState.Checked)
            {
                lbMaxBorrow.Text = temp + $"{Parameters.maxBorrowBook}";
            }
            else
            {
                lbMaxBorrow.Text = temp + "Không";
            }
        }

        private void btnViewBorrowSlip_Click(object sender, EventArgs e)
        {

        }
    }
}
