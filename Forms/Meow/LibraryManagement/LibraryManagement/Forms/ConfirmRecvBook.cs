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
using DemoDesign;
using System.Drawing.Printing;

namespace LibraryManagement.Forms
{
    public partial class ConfirmRecvBook : Form
    {
        BindingSource bindingChosen;

        public static ReturnSlip returnSlip;

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


        public ConfirmRecvBook()
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
            lbSlipCode.Text = returnSlip.recvSlipCode;
            lbReaderCode.Text = returnSlip.readerCode;
            lbReaderName.Text = returnSlip.readerName;
            lbReturnDate.Text = FormatDate(returnSlip.returnDate);
            lbFineThisPeriod.Text = returnSlip.fineThisPeriod.ToString();
            lbTotalFine.Text = returnSlip.totalFine.ToString();

            pnlSlipCode.Width = lbSlipCode.Width - 6;
            pnlCode.Width = lbReaderCode.Width - 6;
            pnlName.Width = lbReaderName.Width - 6;
            pnlReturnDate.Width = lbReturnDate.Width - 6;
            pnlFineThisPeriod.Width = lbFineThisPeriod.Width - 8;
            pnlTotalFine.Width = lbTotalFine.Width - 8;

            bindingChosen = new BindingSource();
            bindingChosen.DataSource = returnSlip.returnBooks;
            dtgvChosenBook.DataSource = bindingChosen;

            if(dtgvChosenBook.Rows.Count != 0)
            {
                dtgvChosenBook.Rows[0].Selected = false;
            }
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
            if (RecvBook.needPrint)
            {
                PrintSlip();
            }
            UpdataData();
        }

        Bitmap bmp;

        private void PrintSlip()
        {
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("MyPaper", this.Size.Width + 30, 581 - 74);
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, 581 - 74, g);
            Graphics mg = Graphics.FromImage(bmp);
            Size size = new Size(this.Size.Width, 581 - 74);
            mg.CopyFromScreen(this.Location.X, this.Location.Y + 25, 0, 0, size);
            printPreviewDialog1.ShowDialog();
        }

        private void UpdataData()
        {
            string createReturnSlip = $@"INSERT INTO PHIEUTRASACH(MaDocGia, NgTra, TienPhatKyNay) VALUES('{returnSlip.readerCode}', '{returnSlip.returnDate}', {returnSlip.fineThisPeriod})";
            string createReturnSlipDetail = @"";
            string setBookAndSlipDetailStatus = @"";

            foreach (ReturnBook book in returnSlip.returnBooks)
            {
                createReturnSlipDetail += $@"INSERT INTO CTPT(MaPhieuTraSach, MaCuonSach, MaPhieuMuonSach, SoNgayMuon, TienPhat) VALUES('{returnSlip.recvSlipCode}','{book.specBookCode}','{returnSlip.borrowSlipCode}','{book.borrowedDays}','{book.fine}')" + "\n";
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

            DemoDesign.RecvBook.recvState = "Success";
            //SendMail();
            this.Close();
        }

        private void SendMail()
        {
            //string slipTitle = "<b>THÔNG TIN PHIẾU MƯỢN</b><br/><br/>";
            //string readerCode = $"<b>Mã độc giả</b>: {returnSlip.code}<br/>";
            //string readerName = $"<b>Họ tên</b>: {returnSlip.name}<br/>";
            //string borrowDate = $"<b>Ngày mượn</b>: {FormatDate(returnSlip.borrowDate)}<br/>";
            //string returnDate = $"<b>Ngày trả</b>: {FormatDate(returnSlip.returnDate)}<br/>";
            //string borrowBooksTitle = $"<br/><b>SÁCH ĐÃ MƯỢN:</b><br/>";
            //string borrowBooks = "";
            //foreach (ReturnBook book in returnSlip.returnBooks)
            //{
            //    string bookInfo = $"<b>Mã sách:</b> {book.bookCode}&emsp;&emsp;<b>Tên sách:</b> {book.bookName}&emsp;&emsp;<b>Tác giả:</b> {book.author}<br/>";
            //    borrowBooks += bookInfo;
            //}

            //string msg = slipTitle + readerCode + readerName + borrowDate + returnDate + borrowBooksTitle + borrowBooks;
            //MailService.SendMail(returnSlip.email, msg, returnSlip.readerName);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DemoDesign.RecvBook.recvState = "Cancelled";
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
