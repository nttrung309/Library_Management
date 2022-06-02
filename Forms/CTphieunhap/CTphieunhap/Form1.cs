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

namespace CTphieunhap
{
    public partial class Form1 : Form
    {

        // Khai báo 
        string chuoiKetNoi = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True";
        private SqlConnection myConnection; // kết nối tới csdl
        private SqlDataAdapter myDataAdapter;   // Vận chuyển csdl qa DataSet
        private DataTable myTable;  // Dùng để lưu bảng lấy từ c#
        SqlCommand myCommand;   // Thực hiện cách lệnh truy vấn
        public Form1()
        {
            InitializeComponent();
        }
        private DataTable ketnoi(string truyvan)
        {
            myConnection = new SqlConnection(chuoiKetNoi);
            myConnection.Open();
            string thuchiencaulenh = truyvan;
            myCommand = new SqlCommand(thuchiencaulenh, myConnection);
            myDataAdapter = new SqlDataAdapter(myCommand);
            myTable = new DataTable();
            myDataAdapter.Fill(myTable);
            return myTable;
        }
        private void ketnoiNonQuery(string nonquery)
        {
            myConnection = new SqlConnection(chuoiKetNoi);
            myConnection.Open();
            string thuchiencaulenh = nonquery;
            myCommand = new SqlCommand(thuchiencaulenh, myConnection);
            myCommand.ExecuteNonQuery();

        }
        private void setSizeCol()
        {
            dgvCTPhieuNS.Columns[0].Width = 140;
            dgvCTPhieuNS.Columns[1].Width = 105;
            dgvCTPhieuNS.Columns[2].Width = 220;
            dgvCTPhieuNS.Columns[3].Width = 170;
            dgvCTPhieuNS.Columns[4].Width = 140;
            dgvCTPhieuNS.Columns[5].Width = 75;
            dgvCTPhieuNS.Columns[6].Width = 60;
            dgvCTPhieuNS.Columns[7].Width = 140;


        }
        void loadDgv()
        {
            string cauTruyVan = "SELECT MaCTPN AS [Mã CTPN], MaPhieuNhapSach AS [Mã PN], TenDauSach AS [Tên Sách], TenTacGia AS [Tác Giả], NhaXuatBan AS [Nhà XB], NamXuatBan AS [Năm XB], CT_PHIEUNHAP.SoLuong AS [Số lượng], DonGia AS [Đơn Giá], ThanhTien AS [Thành Tiền]" +
                                " FROM CT_PHIEUNHAP, DAUSACH, SACH, CTTACGIA, TACGIA " +
                                "WHERE CT_PHIEUNHAP.MaSach = SACH.MaSach " +
                                "AND SACH.MaDauSach = DAUSACH.MaDauSach " +
                                "AND CTTACGIA.MaDauSach = DAUSACH.MaDauSach " +
                                "AND CTTACGIA.MaTacGia = TACGIA.MaTacGia ";
            dgvCTPhieuNS.DataSource = ketnoi(cauTruyVan);
            dgvCTPhieuNS.AutoGenerateColumns = false;
            myConnection.Close();
        }
        private string getNextIdCTPNS()
        {
            string queryGetId = "SELECT TOP 1 MaCTPN FROM CT_PhieuNhap ORDER BY MaCTPN DESC";
            ketnoi(queryGetId);
            string fullID = Convert.ToString(myCommand.ExecuteScalar());
            int numberID = Convert.ToInt32(fullID.Substring(5));
            string strNumber = (++numberID).ToString();
            fullID = "MCTPN" + strNumber.PadLeft(3, '0');
            return fullID;
        }
        void loadMaPN()
        {
            string cauTruyVan = "SELECT MaPhieuNhapSach FROM PHIEUNHAPSACH";
            cbMaPN.DataSource = ketnoi(cauTruyVan);
            cbMaPN.DisplayMember = "MaPhieuNhapSach";
            cbMaPN.SelectedIndex = -1;
        }
        void loadTenDS()
        {
            string cauTruyVan = "SELECT MaSach, TenDauSach FROM DAUSACH, SACH WHERE SACH.MaDauSach = DAUSACH.MaDauSach";
            cbTenSach.DataSource = ketnoi(cauTruyVan);
            cbTenSach.DisplayMember = "TenDauSach";
            cbTenSach.ValueMember = "MaSach";
            cbTenSach.SelectedIndex = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadDgv();
            setSizeCol();
            dgvCTPhieuNS.Enabled = true;
            btnLuu.Enabled = true;
            btnThemMoi.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            txbMaCTPN.Text = getNextIdCTPNS();
            cbMaPN.SelectedIndex = -1;
            cbTenSach.SelectedIndex = -1;
            loadMaPN();
            loadTenDS();
        }

        private void dgvCTPhieuNS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            errDonGia.Clear();
            errMaPN.Clear();
            errSoLuong.Clear();
            errTenDS.Clear();
            txbMaCTPN.Text = dgvCTPhieuNS.CurrentRow.Cells[0].Value.ToString();
            cbMaPN.Text = dgvCTPhieuNS.CurrentRow.Cells[1].Value.ToString();
            cbTenSach.Text = dgvCTPhieuNS.CurrentRow.Cells[2].Value.ToString();
            txbTenTG.Text = dgvCTPhieuNS.CurrentRow.Cells[3].Value.ToString();
            txbNamXB.Text = dgvCTPhieuNS.CurrentRow.Cells[5].Value.ToString();
            txbNhaXB.Text = dgvCTPhieuNS.CurrentRow.Cells[4].Value.ToString();
            txbSoLuong.Text = dgvCTPhieuNS.CurrentRow.Cells[6].Value.ToString();
            txbDonGia.Text = dgvCTPhieuNS.CurrentRow.Cells[7].Value.ToString();
            txbThanhTien.Text = dgvCTPhieuNS.CurrentRow.Cells[8].Value.ToString();
            btnLuu.Enabled = false;
            btnThemMoi.Enabled = true;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = true;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            errDonGia.Clear();
            errMaPN.Clear();
            errTenDS.Clear();
            errSoLuong.Clear();
            txbMaCTPN.Text = getNextIdCTPNS();
            txbTenTG.Text = "";
            txbNhaXB.Text = "";
            txbSoLuong.Text = "";
            txbThanhTien.Text = "";
            txbDonGia.Text = "";
            txbNamXB.Text = "";
            cbMaPN.SelectedIndex = -1;
            cbTenSach.SelectedIndex = -1;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            loadMaPN();

        }
        private void themCuonSach(string maSach, string maCTPN)
        {
            string nonquery = "INSERT INTO CUONSACH(MaSach, TinhTrang, MaCTPN) VALUES ('" + maSach + "' , '0', '" + maCTPN + "')";
            ketnoiNonQuery(nonquery);
        }
        private void themCTPN()
        {
            try
            {
                string query = "INSERT INTO CT_PHIEUNHAP (MaPhieuNhapSach, MaSach, SoLuong, DonGia) VALUES ('" + cbMaPN.Text + "', '" + cbTenSach.SelectedValue.ToString()+ "', " + txbSoLuong.Text + ", " + txbDonGia.Text + ")";
                ketnoiNonQuery(query);
                int ktSoLuong;
                bool isNumberSoLuong = int.TryParse(txbSoLuong.Text, out ktSoLuong);
                for (int i = 0; i < ktSoLuong; i++)
                {
                    themCuonSach(cbTenSach.SelectedValue.ToString(), txbMaCTPN.Text);
                }    
                MessageBox.Show("Thêm thành công.", "Thông Báo");
                myConnection.Close();
            }
            catch
            {
            }
        }
        // Phương thức xóa chi tiết phiếu nhập
        private void xoaCuonSach(string maCTPN)
        {
                string nonquery = "DELETE FROM CUONSACH WHERE MaCTPN = '" + maCTPN + "'";
                ketnoiNonQuery(nonquery);
           
        }
        private void xoaCTPN()
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn xóa.", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    xoaCuonSach(txbMaCTPN.Text);
                    string xoadongSql;
                    xoadongSql = "DELETE FROM CT_PHIEUNHAP WHERE MaCTPN = '" + txbMaCTPN.Text + "'";
                    ketnoiNonQuery(xoadongSql);
                    MessageBox.Show("Xóa thành công.", "Thông Báo");
                    btnLuu.Enabled = true;
                    btnXoa.Enabled = false;
                    btnThemMoi.Enabled = true;
                    btnCapNhat.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại.\nTrong chi tiết nhập sách trên, đã có cuốn sách được mượn.", "Thông Báo");
                }
            }
            loadDgv();
        }
        int xuly;
        private void btnLuu_Click(object sender, EventArgs e)
         {
             xuly = 0;
             if (cbMaPN.Text == "")
             {
                 errMaPN.SetError(cbMaPN, "Vui lòng chọn Mã Phiếu Nhập");
             }
             else
             {
                 errMaPN.Clear();
             }
             if (cbTenSach.Text == "")
             {
                 errTenDS.SetError(cbTenSach, "Vui lòng chọn Tên Sách");
             }
             else
             {
                 errTenDS.Clear();
             }

             if (txbSoLuong.Text == "")
             {
                 errSoLuong.SetError(txbSoLuong, "Vui lòng nhập số lượng sách cần nhập");
             }
             else
             {
                 errSoLuong.Clear();
             }
             if (txbDonGia.Text == "")
             {
                 errDonGia.SetError(txbDonGia, "Vui lòng nhập đơn giá");
             }
             else
             {
                 errDonGia .Clear();
             }

             string query = "SELECT  ThoiGianLuuHanh FROM THAMSO";
             ketnoi(query);
             int tgXB = Convert.ToInt32(myCommand.ExecuteScalar());

             if (txbNamXB.Text!=""&& DateTime.Now.Year - Convert.ToInt32(txbNamXB.Text) > tgXB)
             {
                 MessageBox.Show("Sách đã quá hạn thời gian lưu hành!");
                 return;
             }


            float ktTriGia;
            bool isNumberTriGia = float.TryParse(txbDonGia.Text, out ktTriGia);
            int ktSoLuong;
            bool isNumberSoLuong = int.TryParse(txbSoLuong.Text, out ktSoLuong);
            if (isNumberSoLuong == false || ktSoLuong <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng là số nguyên dương", "Thông Báo");
                return;
            }
            if (isNumberTriGia == false || ktTriGia <= 0)
             {
                 MessageBox.Show("Vui lòng nhập giá tiền lớn hơn 0", "Thông Báo");
                 return;
             }
             if (cbMaPN.Text.Length > 0 && cbTenSach.Text.Length > 0 && txbDonGia.Text.Length > 0 && isNumberTriGia == true && ktTriGia > 0 && txbSoLuong.Text.Length > 0 && isNumberSoLuong == true)
             {
                 if (xuly == 0)
                 {
                     themCTPN();
                 }
                 else if (xuly == 1)
                 {
                     //suaSach();

                 }
                 loadDgv();
                 dgvCTPhieuNS.AutoGenerateColumns = false;
                 myConnection.Close();
                 btnLuu.Enabled = false;
                 btnThemMoi.Enabled = true;
                 btnCapNhat.Enabled = true;
                 btnXoa.Enabled = true;
                 dgvCTPhieuNS.FirstDisplayedScrollingRowIndex = dgvCTPhieuNS.RowCount - 1;

                 errDonGia.Clear();
                 errMaPN.Clear();
                 errSoLuong.Clear();
                 errTenDS.Clear();
             }
             else
             {
                 MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông Báo");
                 if (cbMaPN.Text.Length == 0)
                     cbMaPN.Focus();
                 else if (cbTenSach.Text.Length == 0)
                     cbTenSach.Focus();
                 else if (txbSoLuong.Text.Length == 0)
                     txbSoLuong.Focus();
                 else if (txbDonGia.Text.Length == 0)
                     txbDonGia.Focus();

             }
         }
        int i = 0;
        private void cbTenSach_SelectedValueChanged(object sender, EventArgs e)
        {
            i++;
            if (i > 4 && cbTenSach.SelectedValue != null)
            {
                string cauTruyVan = "SELECT TenTacGia, NhaXuatBan, NamXuatBan " +
                   "FROM SACH, DAUSACH, CTTACGIA, TACGIA " +
                   "WHERE SACH.MaDauSach = DAUSACH.MaDauSach " +
                   "AND DAUSACH.MaDauSach = CTTACGIA.MaDauSach " +
                   "AND TACGIA.MaTacGia = CTTACGIA.MaTacGia " +
                   "AND MaSach = '" + cbTenSach.SelectedValue.ToString() + "'";
                DataTable dt = ketnoi(cauTruyVan);
                txbTenTG.Text = dt.Rows[0].ItemArray[0].ToString();
                txbNhaXB.Text = dt.Rows[0].ItemArray[1].ToString();
                txbNamXB.Text = dt.Rows[0].ItemArray[2].ToString();
            }
            
            
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoaCTPN();
            errDonGia.Clear();
            errMaPN.Clear();
            errSoLuong.Clear();
            errTenDS.Clear();
        }
        private void suaCTPN()
        {
            try
            {
                string capnhatdong;
                xoaCuonSach(txbMaCTPN.Text);
                capnhatdong = "UPDATE  CT_PHIEUNHAP SET MaPhieuNhapSach = '" + cbMaPN.Text + "', MaSach = '" + cbTenSach.SelectedValue.ToString() + "', SoLuong = " + txbSoLuong.Text + ", DonGia = " + txbDonGia.Text + ""+
                                "WHERE MaCTPN = '" + txbMaCTPN.Text + "'";
                ketnoiNonQuery(capnhatdong);
                int ktSoLuong;
                bool isNumberSoLuong = int.TryParse(txbSoLuong.Text, out ktSoLuong);
                for (int i = 0; i < ktSoLuong; i++)
                {
                    themCuonSach(cbTenSach.SelectedValue.ToString(), txbMaCTPN.Text);
                }
                MessageBox.Show("Sửa thành công.", "Thông Báo");
            }
            catch
            {
                MessageBox.Show("Sửa thất bại.\nĐã có cuốn sách trong lần nhập này được mượn.", "Thông Báo");
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            xuly = 1;
            if (cbMaPN.Text == "")
            {
                errMaPN.SetError(cbMaPN, "Vui lòng chọn Mã Phiếu Nhập");
            }
            else
            {
                errMaPN.Clear();
            }
            if (cbTenSach.Text == "")
            {
                errTenDS.SetError(cbTenSach, "Vui lòng chọn Tên Sách");
            }
            else
            {
                errTenDS.Clear();
            }

            if (txbSoLuong.Text == "")
            {
                errSoLuong.SetError(txbSoLuong, "Vui lòng nhập số lượng sách cần nhập");
            }
            else
            {
                errSoLuong.Clear();
            }
            if (txbDonGia.Text == "")
            {
                errDonGia.SetError(txbDonGia, "Vui lòng nhập đơn giá");
            }
            else
            {
                errDonGia.Clear();
            }

            string query = "SELECT  ThoiGianLuuHanh FROM THAMSO";
            ketnoi(query);
            int tgXB = Convert.ToInt32(myCommand.ExecuteScalar());

            if (DateTime.Now.Year - Convert.ToInt32(txbNamXB.Text) > tgXB)
            {
                MessageBox.Show("Sách đã quá hạn thời gian lưu hành!");
                return;
            }


            float ktTriGia;
            bool isNumberTriGia = float.TryParse(txbDonGia.Text, out ktTriGia);
            int ktSoLuong;
            bool isNumberSoLuong = int.TryParse(txbSoLuong.Text, out ktSoLuong);
            if (isNumberSoLuong == false || ktSoLuong <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng là số nguyên dương", "Thông Báo");
                return;
            }
            if (isNumberTriGia == false || ktTriGia <= 0)
            {
                MessageBox.Show("Vui lòng nhập giá tiền lớn hơn 0", "Thông Báo");
                return;
            }
            if (cbMaPN.Text.Length > 0 && cbTenSach.Text.Length > 0 && txbDonGia.Text.Length > 0 && isNumberTriGia == true && ktTriGia > 0 && txbSoLuong.Text.Length > 0 && isNumberSoLuong == true)
            {
                if (xuly == 0)
                {
                    themCTPN();
                }
                else if (xuly == 1)
                {
                    suaCTPN();

                }
                loadDgv();
                dgvCTPhieuNS.AutoGenerateColumns = false;
                myConnection.Close();
                btnLuu.Enabled = false;
                btnThemMoi.Enabled = true;
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
                dgvCTPhieuNS.FirstDisplayedScrollingRowIndex = dgvCTPhieuNS.RowCount - 1;

                errDonGia.Clear();
                errMaPN.Clear();
                errSoLuong.Clear();
                errTenDS.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông Báo");
                if (cbMaPN.Text.Length == 0)
                    cbMaPN.Focus();
                else if (cbTenSach.Text.Length == 0)
                    cbTenSach.Focus();
                else if (txbSoLuong.Text.Length == 0)
                    txbSoLuong.Focus();
                else if (txbDonGia.Text.Length == 0)
                    txbDonGia.Focus();

            }
        }

        private void txbSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txbDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txbSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (txbDonGia.Text!=""&&txbSoLuong.Text!="")
            {
                txbThanhTien.Text = (float.Parse(txbDonGia.Text) * float.Parse(txbSoLuong.Text)).ToString();
            }    
        }

        private void txbDonGia_TextChanged(object sender, EventArgs e)
        {
            if (txbDonGia.Text != "" && txbSoLuong.Text != "")
            {
                txbThanhTien.Text = (float.Parse(txbDonGia.Text) * float.Parse(txbSoLuong.Text)).ToString();
            }
        }
    }
}
