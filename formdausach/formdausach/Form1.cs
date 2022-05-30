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

namespace formdausach
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
        void loadDgv()
        {
            string cauTruyVan = "SELECT MaDauSach AS [Mã Đầu Sách], TenDauSach AS [Tên Đầu Sách], DAUSACH.MaTheLoai AS [Mã Thể Loại], TenTheLoai AS [Thể Loại]" +
               "FROM DAUSACH, THELOAI WHERE DAUSACH.MaTheLoai = THELOAI.MaTheLoai ";
            dgvDauSach.DataSource = ketnoi(cauTruyVan);
            dgvDauSach.AutoGenerateColumns = false;
            myConnection.Close();
        }
        void loadMaTheLoai()
        {
            string cauTruyVan = "SELECT MaTheLoai FROM THELOAI";
            cbMaTL.DataSource = ketnoi(cauTruyVan);
            cbMaTL.DisplayMember = "MaTheLoai";
            cbMaTL.SelectedIndex = -1;
        }
        void loadTenTheLoai()
        {
            string cauTruyVan = "SELECT TenTheLoai FROM THELOAI";
            cbTenTL.DataSource = ketnoi(cauTruyVan);
            cbTenTL.DisplayMember = "TenTheLoai";
            cbTenTL.SelectedIndex = -1;
        }
        private string getNextIdDS()
        {
            string queryGetId = "SELECT TOP 1 MaDauSach FROM DAUSACH ORDER BY MaDauSach DESC";
            ketnoi(queryGetId);
            string fullID = Convert.ToString(myCommand.ExecuteScalar());
            int numberID = Convert.ToInt32(fullID.Substring(3));
            string strNumber = (++numberID).ToString();
            fullID = "MDS" + strNumber.PadLeft(3, '0');
            return fullID;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadDgv();
            loadMaTheLoai();
            loadTenTheLoai();
            cbTenTL.SelectedIndex = -1;
            cbMaTL.SelectedIndex = -1;
            dgvDauSach.Enabled = true;
            btnLuu.Enabled = true;
            btnThemMoi.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            txb_MaDauSach.Text = getNextIdDS();
        }

        private void dgvDauSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_MaDauSach.Text = dgvDauSach.CurrentRow.Cells[0].Value.ToString();
            txb_TenDauSach.Text = dgvDauSach.CurrentRow.Cells[1].Value.ToString();
            cbMaTL.Text = dgvDauSach.CurrentRow.Cells[2].Value.ToString();
            cbTenTL.Text = dgvDauSach.CurrentRow.Cells[3].Value.ToString();
            errMaTL.Clear();
            errTenTL.Clear();
            errTenDS.Clear();
            btnLuu.Enabled = false;
            btnThemMoi.Enabled = true;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = true;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            errMaTL.Clear();
            errTenDS.Clear();
            errTenTL.Clear();
            txb_MaDauSach.Text = getNextIdDS();
            cbMaTL.SelectedIndex = -1;
            cbTenTL.SelectedIndex = -1;
            txb_TenDauSach.Text = "";
            txb_TenDauSach.Focus();
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }
        private void themDauSach()
        {
            try
            {

                string themdongsql = "INSERT INTO DAUSACH(TenDauSach, MaTheLoai)" +
                "VALUES (N'" + txb_TenDauSach.Text + "', '" + cbMaTL.Text + "')";
                ketnoiNonQuery(themdongsql);
                MessageBox.Show("Thêm thành công.", "Thông Báo");
                loadDgv();
            }
            catch (Exception)
            {

            }
        }
        public int xuly;

        private void btnLuu_Click(object sender, EventArgs e)
        {
            xuly = 0;
            {
                if (txb_TenDauSach.Text == "")
                {
                    errTenDS.SetError(txb_TenDauSach, "Vui lòng nhập Tên Đầu Sách");
                }
                else
                {
                    errTenDS.Clear();
                }
                if (cbMaTL.Text == "")
                {
                    errMaTL.SetError(cbMaTL, "Vui lòng chọn Mã Thể Loại Sách");
                }
                else
                {
                    errMaTL.Clear();
                }
                if (cbTenTL.Text == "")
                {
                    errTenTL.SetError(cbTenTL, "Vui lòng chọn Tên Thể Loại Sách");
                }
                else
                {
                    errTenTL.Clear();
                }

            }

            if (txb_TenDauSach.Text.Length > 0 && cbMaTL.Text.Length > 0 && cbTenTL.Text.Length > 0)
            {
                string query = null;
                if (xuly == 0)
                {
                    themDauSach();
                    query = "SELECT TOP 1 MaDauSach FROM DAUSACH ORDER BY MaDauSach DESC ";
                    ketnoi(query);
                    txb_MaDauSach .Text = Convert.ToString(myCommand.ExecuteScalar());
                }

                dgvDauSach.AutoGenerateColumns = false;
                myConnection.Close();
                btnLuu.Enabled = false;
                btnThemMoi.Enabled = true;
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
                dgvDauSach.Enabled = true;
                dgvDauSach.FirstDisplayedScrollingRowIndex = dgvDauSach.RowCount - 1;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông Báo");
                if (txb_TenDauSach.Text.Length == 0)
                    txb_TenDauSach.Focus();
            }
        }
        // Phương thức xóa đầu sách
        private void xoaDauSach()
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn xóa.", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    string xoadongsql = "DELETE FROM DAUSACH WHERE MaDauSach = '" + txb_MaDauSach.Text + "'";
                    ketnoiNonQuery(xoadongsql);
                    MessageBox.Show("Xóa thành công.", "Thông Báo");
                    btnLuu.Enabled = true;
                    btnXoa.Enabled = false;
                    btnThemMoi.Enabled = true;
                    btnCapNhat.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại.\nTrong thư viện, hiện đang có sách của đầu sách này.", "Thông Báo");
                }
            }
            loadDgv();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoaDauSach();
            errMaTL.Clear();
            errTenDS.Clear();
            errTenTL.Clear();
        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            xuly = 1;
            {
                if (txb_TenDauSach.Text == "")
                {
                    errTenDS.SetError(txb_TenDauSach, "Vui lòng nhập Tên Đầu Sách");
                }
                else
                {
                    errTenDS.Clear();
                }
                if (cbMaTL.Text == "")
                {
                    errMaTL.SetError(cbMaTL, "Vui lòng chọn Mã Thể Loại Sách");
                }
                else
                {
                    errMaTL.Clear();
                }
                if (cbTenTL.Text == "")
                {
                    errTenTL.SetError(cbTenTL, "Vui lòng chọn Tên Thể Loại Sách");
                }
                else
                {
                    errTenTL.Clear();
                }
            }

            if (txb_TenDauSach.Text.Length > 0 && cbMaTL.Text.Length > 0 && cbTenTL.Text.Length > 0)
            {
                if (xuly == 1)
                {
                    try
                    {
                        string capnhatdongsql;
                        capnhatdongsql = "UPDATE DAUSACH " +
                            "SET TenDauSach = N'" + txb_TenDauSach.Text + "', MaTheLoai = '" + cbMaTL.Text + "'" +
                            "WHERE MaDauSach = '" + txb_MaDauSach.Text + "'";
                        ketnoi(capnhatdongsql);
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show("Sửa thành công.", "Thông Báo");
                        loadDgv();
                    }
                    catch
                    {
                        MessageBox.Show("Sửa thất bại.\nVui lòng kiểm tra lại dữ liệu.", "Thông Báo");
                    }
                }
                btnLuu.Enabled = false;
                btnThemMoi.Enabled = true;
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
                dgvDauSach.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông Báo");
                if (txb_TenDauSach.Text.Length == 0)
                    txb_TenDauSach.Focus();
            }
        }

        private void cbMaTL_SelectedValueChanged(object sender, EventArgs e)
        {
            string cauTruyVan = "SELECT TenTheLoai FROM THELOAI WHERE MaTheLoai = '" + this.cbMaTL.GetItemText(this.cbMaTL.SelectedItem) + "'";
            ketnoi(cauTruyVan);
            string tenTL = Convert.ToString(myCommand.ExecuteScalar());
            cbTenTL.Text = tenTL;
        }

        private void cbTenTL_SelectedValueChanged(object sender, EventArgs e)
        {
            string cauTruyVan = "SELECT MaTheLoai FROM THELOAI WHERE TenTheLoai = N'" + this.cbTenTL.GetItemText(this.cbTenTL.SelectedItem) + "'";
            ketnoi(cauTruyVan);
            string maTL = Convert.ToString(myCommand.ExecuteScalar());
            cbMaTL.Text = maTL;
        }

        private void txb_TenDauSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
