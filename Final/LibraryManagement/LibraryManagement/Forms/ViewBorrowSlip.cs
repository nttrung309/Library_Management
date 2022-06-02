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
    public partial class ViewBorrowSlip : Form
    {
        List<BorrowSlip> borrowSlips;
        BindingSource binding;
        bool isLocked = true;
        public static bool dataChanged = false;
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


        public ViewBorrowSlip()
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
            borrowSlips = new List<BorrowSlip>();
            binding = new BindingSource();
            dataChanged = false;
            LoadData();
        }
        
        private void LoadData()
        {
            borrowSlips.Clear();
            string queryCmd = @"SELECT MaPhieuMuonSach, PHIEUMUON.MaDocGia, HoTen, NgMuon, HanTra
                FROM PHIEUMUON, DOCGIA
                WHERE PHIEUMUON.MaDocGia = DOCGIA.MaDocGia";
            SqlConnection conn = new SqlConnection(DatabaseInfo.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(queryCmd, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    BorrowSlip slip = new BorrowSlip();
                    slip.slipCode = reader.GetString(0);
                    slip.code = reader.GetString(1);
                    slip.name = reader.GetString(2);
                    slip.borrowDate = reader.GetDateTime(3).ToString("dd/MM/yyyy");
                    slip.returnDate = reader.GetDateTime(4).ToString("dd/MM/yyyy");

                    borrowSlips.Add(slip);
                }
            }
            conn.Close();

            borrowSlips.OrderBy(o => o.slipCode).ThenBy(o => o.code).ThenBy(o => o.name).ToList();
            int stt = 1;
            foreach(BorrowSlip borrowSlip in borrowSlips)
            {
                borrowSlip.stt = stt;
                stt++;
            }

            binding = new BindingSource();
            binding.DataSource = borrowSlips;
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
            if (dataChanged)
            {
                this.Hide();
                LibraryManagement.fHome.SwitchForm(new LendBook());
                MessageBox.Show("Dữ liệu vừa được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void dtgv_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                isLocked = true;
                btnSave.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = true;
                btnDetail.Enabled = true;

                lbSlipCode.Text = dtgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                slipCode = lbSlipCode.Text;
                lbReaderCode.Text = dtgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                lbReaderName.Text = dtgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                string date = dtgv.Rows[e.RowIndex].Cells[4].Value.ToString();
                DateTime borrowDate = new DateTime(int.Parse(date.Substring(6, 4)), int.Parse(date.Substring(3, 2)), int.Parse(date.Substring(0, 2)));
                date = dtgv.Rows[e.RowIndex].Cells[5].Value.ToString();
                DateTime returnDay = new DateTime(int.Parse(date.Substring(6, 4)), int.Parse(date.Substring(3, 2)), int.Parse(date.Substring(0, 2)));
                dtpBorrowDate.Value = borrowDate;
                dtpReturnDate.Value = returnDay;

                isLocked = false;

                pnlSlipCode.Width = lbSlipCode.Width - 6;
                pnlCode.Width = lbReaderCode.Width - 6;
                pnlName.Width = lbReaderName.Width - 6;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            opt = 1;
            btnUpdate.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
        }
        private void UpdataData()
        {
            string queryUpdateCmd = "";
            if (opt == 1)
            {
                queryUpdateCmd = $@"UPDATE PHIEUMUON
                SET NgMuon = {dtpBorrowDate.Value}, HanTra = {dtpReturnDate.Value}
                WHERE MaPhieuMuonSach = '{lbSlipCode}'";
            }
            else if (opt == 2)
            {
                queryUpdateCmd = $@"
                    UPDATE CUONSACH
                    SET TinhTrang = 1
                    WHERE CUONSACH.MaCuonSach IN (SELECT CTPHIEUMUON.MaCuonSach
		                    FROM CTPHIEUMUON
		                    WHERE CTPHIEUMUON.MaPhieuMuonSach = '{lbSlipCode.Text}')

                    DELETE FROM CTPHIEUMUON
                    WHERE MaPhieuMuonSach = '{lbSlipCode.Text}'

                    DELETE FROM CTPT
                    WHERE MaPhieuMuonSach = '{lbSlipCode.Text}'
                    
                    DELETE FROM PHIEUMUON
                    WHERE MaPhieuMuonSach = '{lbSlipCode.Text}'";
            }

            SqlConnection conn = new SqlConnection(DatabaseInfo.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(queryUpdateCmd, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void dtpBorrowDate_ValueChanged(object sender, EventArgs e)
        {
            if (!isLocked)
            {
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
            }
        }

        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
        {
            if (!isLocked)
            {
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdataData();
            dataChanged = true;
            MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
            opt = -1;

            lbSlipCode.Text = "";
            lbReaderCode.Text = "";
            lbReaderName.Text = "";
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            opt = 2;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = false;

            string date = dtgv.SelectedRows[0].Cells[4].Value.ToString();
            DateTime borrowDate = new DateTime(int.Parse(date.Substring(6, 4)), int.Parse(date.Substring(3, 2)), int.Parse(date.Substring(0, 2)));
            date = dtgv.SelectedRows[0].Cells[5].Value.ToString();
            DateTime returnDay = new DateTime(int.Parse(date.Substring(6, 4)), int.Parse(date.Substring(3, 2)), int.Parse(date.Substring(0, 2)));
            dtpBorrowDate.Value = borrowDate;
            dtpReturnDate.Value = returnDay;
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            new ViewDetailBorrowSlip().ShowDialog();
        }
    }
}
