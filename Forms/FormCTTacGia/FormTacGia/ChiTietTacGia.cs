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

namespace FormChiTietTacGia
{
    public partial class ChiTietTacGia : Form
    {
        // Khai báo 
        string chuoiKetNoi = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True";
        private SqlConnection myConnection; // kết nối tới csdl
        private SqlDataAdapter myDataAdapter;   // Vận chuyển csdl qa DataSet
        private DataTable myTable;  // Dùng để lưu bảng lấy từ c#
        SqlCommand myCommand;   // Thực hiện cách lệnh truy vấn
        public ChiTietTacGia()
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
        private bool ketnoiNonQuery(string nonquery)
        {
            myConnection = new SqlConnection(chuoiKetNoi);
            myConnection.Open();
            string thuchiencaulenh = nonquery;
            myCommand = new SqlCommand(thuchiencaulenh, myConnection);
            return myCommand.ExecuteNonQuery() > 0;

        }
        void loadDgv()
        {
            string cauTruyVan = "SELECT DAUSACH.MaDauSach AS [Mã Đầu Sách], TenDauSach AS [Tên Đầu Sách], TACGIA.MaTacGia AS [Mã Tác Giả], TenTacGia AS [Tên Tác Giả]" +
               "FROM DAUSACH, TACGIA, CTTACGIA WHERE DAUSACH.MaDauSach = CTTACGIA.MaDauSach and CTTACGIA.MaTacGia = TACGIA.MaTacGia ";
            dgvChiTietTacGia.DataSource = ketnoi(cauTruyVan);
            dgvChiTietTacGia.AutoGenerateColumns = false;
            myConnection.Close();
        }
        void loadTenTacGia()
        {
            string cauTruyVan = "SELECT TenTacGia FROM TACGIA";
            cbTenTacGia.DataSource = ketnoi(cauTruyVan);
            cbTenTacGia.DisplayMember = "TenTacGia";
            cbTenTacGia.SelectedIndex = -1;
        }
        void loadTenDauSach()
        {
            string cauTruyVan = "SELECT TenDauSach FROM DAUSACH";
            cbTenSach.DataSource = ketnoi(cauTruyVan);
            cbTenSach.DisplayMember = "TenDauSach";
            cbTenSach.SelectedIndex = -1;
        }

        private void ChiTietTacGia_Load(object sender, EventArgs e)
        {
            loadDgv();
            loadTenDauSach();
            loadTenTacGia();
            dgvChiTietTacGia.Enabled = true;
            btnLuu.Enabled = true;
            btnThemMoi.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;

        }
        string maDauSachHT = null;
        string maTacGiaHT = null;
        private void dgvChiTietTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbTenSach.Text  = dgvChiTietTacGia.CurrentRow.Cells[1].Value.ToString();
            cbTenTacGia.Text = dgvChiTietTacGia.CurrentRow.Cells[3].Value.ToString();
            maDauSachHT = dgvChiTietTacGia.CurrentRow.Cells[0].Value.ToString();
            maTacGiaHT = dgvChiTietTacGia.CurrentRow.Cells[2].Value.ToString();
            errTenDS.Clear();
            errTenTG.Clear();
            btnLuu.Enabled = false;
            btnThemMoi.Enabled = true;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = true;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            errTenTG.Clear();
            errTenDS.Clear();
            cbTenSach.SelectedIndex = -1;
            cbTenTacGia.SelectedIndex = -1;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }
        private void themCTTacGia()
        {
            try
            {
                string query = "SELECT MaDauSach FROM DAUSACH WHERE TenDauSach = N'" + cbTenSach.Text + "'";
                ketnoi(query);
                string maDS = Convert.ToString(myCommand.ExecuteScalar());
                query = "SELECT MaTacGia FROM TACGIA WHERE TenTacGia = N'" + cbTenTacGia.Text + "'";
                ketnoi(query);
                string maTG = Convert.ToString(myCommand.ExecuteScalar());
                string themdongsql = "INSERT INTO CTTACGIA(MaDauSach, MaTacGia)" +
                "VALUES ('" + maDS + "', '" + maTG + "')";
                ketnoiNonQuery(themdongsql);
                MessageBox.Show("Thêm thành công.", "Thông Báo");
                loadDgv();
                btnLuu.Enabled = false;
                btnThemMoi.Enabled = true;
                btnCapNhat.Enabled = false;
                btnXoa.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có chi tiết tác giả này trong CSDL", "Thông báo");
            }
        }
        public int xuly;

        private void btnLuu_Click(object sender, EventArgs e)
        {
            xuly = 0;
            {
                if (cbTenSach.Text == "")
                {
                    errTenDS.SetError(cbTenSach, "Vui lòng nhập Tên Đầu Sách");
                }
                else
                {
                    errTenDS.Clear();
                }
                if (cbTenTacGia.Text == "")
                {
                    errTenTG.SetError(cbTenTacGia, "Vui lòng chọn Tên Tác Giả");
                }
                else
                {
                    errTenTG.Clear();
                }
               
            }

            if (cbTenSach.Text.Length > 0 && cbTenTacGia.Text.Length > 0)
            {
                string query = null;
                if (xuly == 0)
                {
                    themCTTacGia();
                }

                dgvChiTietTacGia.AutoGenerateColumns = false;
                myConnection.Close();
                dgvChiTietTacGia.Enabled = true;
                dgvChiTietTacGia.FirstDisplayedScrollingRowIndex = dgvChiTietTacGia.RowCount - 1;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông Báo");
                if (cbTenTacGia.Text.Length == 0)
                    cbTenTacGia.Focus();
                else if (cbTenSach.Text.Length == 0)
                    cbTenSach.Focus();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            xuly = 1;
            {
                if (cbTenSach.Text == "")
                {
                    errTenDS.SetError(cbTenSach, "Vui lòng nhập Tên Đầu Sách");
                }
                else
                {
                    errTenDS.Clear();
                }
                if (cbTenTacGia.Text == "")
                {
                    errTenTG.SetError(cbTenTacGia, "Vui lòng chọn Tên Tác Giả");
                }
                else
                {
                    errTenTG.Clear();
                }
            }

            if (cbTenSach.Text.Length > 0 && cbTenTacGia.Text.Length > 0)
            {
                if (xuly == 1)
                {
                    try
                    {
                        string query = "SELECT MaDauSach FROM DAUSACH WHERE TenDauSach = N'" + cbTenSach.Text + "'";
                        ketnoi(query);
                        string maDS = Convert.ToString(myCommand.ExecuteScalar());
                        query = "SELECT MaTacGia FROM TACGIA WHERE TenTacGia = N'" + cbTenTacGia.Text + "'";
                        ketnoi(query);
                        string maTG = Convert.ToString(myCommand.ExecuteScalar());
                        string capnhatdongsql;
                        capnhatdongsql = "UPDATE CTTACGIA " +
                            "SET MaDauSach = '" + maDS + "', MaTacGia = '" + maTG + "'" +
                            "WHERE MaDauSach = '" + maDauSachHT + "' and MaTacGia = '" + maTacGiaHT + "'";
                        ketnoi(capnhatdongsql);
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show("Sửa thành công.", "Thông Báo");
                        loadDgv();
                    }
                    catch
                    {
                        MessageBox.Show("Sửa thất bại.\nĐã có chi tiết tác giả này trong CSDL.", "Thông Báo");
                    }
                }
                btnThemMoi.Enabled = true;
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
                dgvChiTietTacGia.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông Báo");
                if (cbTenSach.Text.Length == 0)
                    cbTenSach.Focus();
                else if (cbTenSach.Text.Length == 0)
                    cbTenSach.Focus();
            }
        }
        // Phương thức xóa đầu sách
        private void xoaCTTG()
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn xóa.", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    string query = "SELECT MaDauSach FROM DAUSACH WHERE TenDauSach = N'" + cbTenSach.Text + "'";
                    ketnoi(query);
                    string maDS = Convert.ToString(myCommand.ExecuteScalar());
                    query = "SELECT MaTacGia FROM TACGIA WHERE TenTacGia = N'" + cbTenTacGia.Text + "'";
                    ketnoi(query);
                    string maTG = Convert.ToString(myCommand.ExecuteScalar());
                    string xoadongsql = "DELETE FROM CTTACGIA WHERE MaDauSach = '" + maDS + "' and MaTacGia = '" + maTG + "'";
                    if(ketnoiNonQuery(xoadongsql))
                    {
                        MessageBox.Show("Xóa thành công.", "Thông Báo");
                        btnLuu.Enabled = true;
                        btnXoa.Enabled = false;
                        btnThemMoi.Enabled = true;
                        btnCapNhat.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại.\nHiện không có chi tiết tác giả nào với thông tin như trên", "Thông Báo");
                    }    
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại.\nHiện không có chi tiết tác giả nào với thông tin như trên", "Thông Báo");
                }
            }
            loadDgv();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoaCTTG();
            errTenDS.Clear();
            errTenTG.Clear();
        }
    }
}
