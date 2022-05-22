using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagement.Models;
using LibraryManagement.Reports;
using LibraryManagement.Forms;

namespace LibraryManagement.Forms
{
    public partial class ConfirmLendBook : Form
    {
        BindingSource bindingChosen;

        public static BorrowSlip borrowSlip;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // height of ellipse
          int nHeightEllipse // width of ellipse
        );

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }


        public ConfirmLendBook()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
        }
        //Drag Form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ConfirmLendBook_Load(object sender, EventArgs e)
        {
            lbSlipCode.Text = borrowSlip.slipCode;
            lbReaderCode.Text = borrowSlip.code;
            lbReaderName.Text = borrowSlip.name;
            lbBorrowDate.Text = FormatDate(borrowSlip.borrowDate);
            lbReturnDay.Text = FormatDate(borrowSlip.returnDate);
            lbAmount.Text = borrowSlip.amount;

            pnlCode.Width = lbReaderCode.Width - 6;
            pnlName.Width = lbReaderName.Width - 6;
            pnlBorrowDate.Width = lbBorrowDate.Width - 6;
            pnlReturnDate.Width = lbReturnDay.Width - 6;
            pnlAmount.Width = lbAmount.Width - 8;

            bindingChosen = new BindingSource();
            bindingChosen.DataSource = borrowSlip.chosenBooks;
            dtgvChosenBook.DataSource = bindingChosen;
        }
        private string FormatDate(string date)
        {
            string day = date.Substring(8, 2);
            string month = date.Substring(5, 2);
            string year = date.Substring(0, 4);
            return $"{day}/{month}/{year}";
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            UpdataData();
            
        }

        private void UpdataData()
        {
            string createBorrowSlipCmd = $@"INSERT INTO PHIEUMUON (MaDocGia, NgMuon, HanTra) VALUES('{borrowSlip.code}','{borrowSlip.borrowDate}','{borrowSlip.returnDate}')";
            string insertSlipDetail = "";
            string updateBookState = "";

            foreach(Book book in borrowSlip.chosenBooks)
            {
                insertSlipDetail = insertSlipDetail + $@"INSERT INTO CTPHIEUMUON(MaPhieuMuonSach, MaCuonSach, TinhTrangPM) VALUES('{borrowSlip.slipCode}','{book.specCode}', 0)" + "\n";
                updateBookState = updateBookState + $@"UPDATE CUONSACH SET TinhTrang = 1 WHERE MaCuonSach = '{book.specCode}'" + "\n";
            }
            
            SqlConnection conn = new SqlConnection(DatabaseInfo.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(createBorrowSlipCmd, conn);
            cmd.ExecuteNonQuery();
            cmd.CommandText = insertSlipDetail;
            cmd.ExecuteNonQuery();
            cmd.CommandText = updateBookState;
            cmd.ExecuteNonQuery();
            conn.Close();
            
            DemoDesign.LendBook.lendState = "Success";
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
