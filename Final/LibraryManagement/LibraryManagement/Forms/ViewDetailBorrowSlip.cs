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
    public partial class ViewDetailBorrowSlip : Form
    {
        List<DetailBorrowSlip> detailSlips;
        BindingSource binding;

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


        public ViewDetailBorrowSlip()
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
            detailSlips = new List<DetailBorrowSlip>();
            binding = new BindingSource();
            LoadData();
        }
        
        private void LoadData()
        {
            detailSlips.Clear();
            string queryCmd = $@"SELECT MaChiTietPhieuMuon, MaCuonSach, TinhTrangPM
                FROM CTPHIEUMUON, PHIEUMUON
                WHERE PHIEUMUON.MaPhieuMuonSach = '{ViewBorrowSlip.slipCode}' 
                AND PHIEUMUON.MaPhieuMuonSach = CTPHIEUMUON.MaPhieuMuonSach";
            SqlConnection conn = new SqlConnection(DatabaseInfo.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(queryCmd, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    DetailBorrowSlip slip = new DetailBorrowSlip();
                    slip.specSlipCode = reader.GetString(0);
                    slip.bookCode = reader.GetString(1);
                    slip.status = (reader.GetSqlBoolean(2)) ? "Đã trả" : "Chưa trả";

                    detailSlips.Add(slip);
                }
            }
            conn.Close();

            detailSlips.OrderBy(o => o.specSlipCode).ThenBy(o => o.bookCode).ThenBy(o => o.status).ToList();
            int stt = 1;
            foreach(DetailBorrowSlip borrowSlip in detailSlips)
            {
                borrowSlip.stt = stt;
                stt++;
            }

            binding = new BindingSource();
            binding.DataSource = detailSlips;
            dtgv.DataSource = binding;

            if(dtgv.Rows.Count != 0)
            {
                dtgv.Rows[0].Selected = false;
            }
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
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
            if (e.RowIndex != -1)
            {

                lbSlipCode.Text = ViewBorrowSlip.slipCode;
                lbSpecCode.Text = dtgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                lbBookCode.Text = dtgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                lbStatus.Text = dtgv.Rows[e.RowIndex].Cells[3].Value.ToString();

                if (lbStatus.Text == "Chưa trả")
                {
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = true;
                }

                pnlSlipCode.Width = lbSlipCode.Width - 6;
                pnlSpecCode.Width = lbSpecCode.Width - 6;
                pnlBookCode.Width = lbBookCode.Width - 6;
                pnlStatus.Width = lbStatus.Width - 6;
            }
        }
        private void UpdataData()
        {
            string queryUpdateCmd = $@"DELETE FROM CTPHIEUMUON
                WHERE MaChiTietPhieuMuon = '{lbSpecCode.Text}'

                UPDATE CUONSACH
                SET TinhTrang = 0
                WHERE MaCuonSach = '{lbBookCode.Text}'";

            SqlConnection conn = new SqlConnection(DatabaseInfo.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(queryUpdateCmd, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdataData();
            ViewBorrowSlip.dataChanged = true;
            MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            lbSlipCode.Text = "";
            lbSpecCode.Text = "";
            lbBookCode.Text = "";
            lbStatus.Text = "";
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnUpdate.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            btnUpdate.Enabled = false;
        }
    }
}
