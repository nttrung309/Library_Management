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
    public partial class ViewRecvSlip : Form
    {
        List<ReturnSlip> returnSlips;
        BindingSource binding;
        bool isLocked = true;
        public static string slipCode = "";

        int opt = -1;

        #region Init and Custom
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


        public ViewRecvSlip()
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
        #endregion

        private void ConfirmLendBook_Load(object sender, EventArgs e)
        {
            returnSlips = new List<ReturnSlip>();
            binding = new BindingSource();
            LoadData();
        }
        
        private void LoadData()
        {
            returnSlips.Clear();
            string queryCmd = @"SELECT MaPhieuTraSach, PHIEUTRASACH.MaDocGia, HoTen, NgTra, TienPhatKyNay
                FROM PHIEUTRASACH, DOCGIA
                WHERE PHIEUTRASACH.MaDocGia = DOCGIA.MaDocGia";
            SqlConnection conn = new SqlConnection(DatabaseInfo.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(queryCmd, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    ReturnSlip slip = new ReturnSlip();
                    slip.recvSlipCode = reader.GetString(0);
                    slip.readerCode = reader.GetString(1);
                    slip.readerName = reader.GetString(2);
                    slip.returnDate = reader.GetDateTime(3).ToString("dd/MM/yyyy");
                    slip.fineThisPeriod = (long)reader.GetSqlMoney(4);
                    returnSlips.Add(slip);
                }
            }
            conn.Close();

            returnSlips.OrderBy(o => o.recvSlipCode).ThenBy(o => o.readerCode).ThenBy(o => o.readerName).ToList();
            int stt = 1;
            foreach(ReturnSlip slip in returnSlips)
            {
                slip.stt = stt;
                stt++;
            }

            binding = new BindingSource();
            binding.DataSource = returnSlips;
            dtgv.DataSource = binding;

            if(dtgv.Rows.Count != 0)
            {
                dtgv.Rows[0].Selected = false;
            }
        }

        private string FormatDate(string date)
        {
            string day = date.Substring(8, 2);
            string month = date.Substring(5, 2);
            string year = date.Substring(0, 4);
            return $"{day}/{month}/{year}";
        }

        private void nButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgv_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                lbSlipCode.Text = dtgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                slipCode = lbSlipCode.Text;
                lbReaderCode.Text = dtgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                lbReaderName.Text = dtgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                label4.Text = dtgv.Rows[e.RowIndex].Cells[5].Value.ToString();

                string date = dtgv.Rows[e.RowIndex].Cells[4].Value.ToString();
                DateTime returnDay = new DateTime(int.Parse(date.Substring(6, 4)), int.Parse(date.Substring(3, 2)), int.Parse(date.Substring(0, 2)));
                dtpReturnDate.Value = returnDay;

                isLocked = false;

                pnlSlipCode.Width = lbSlipCode.Width - 6;
                pnlCode.Width = lbReaderCode.Width - 6;
                pnlName.Width = lbReaderName.Width - 6;
                panel1.Width = label4.Width - 6;
            }
        }

        private void dtpBorrowDate_ValueChanged(object sender, EventArgs e)
        {
            
        }






        private void btnDetail_Click(object sender, EventArgs e)
        {
            new ViewDetailBorrowSlip().ShowDialog();
        }
    }
}
