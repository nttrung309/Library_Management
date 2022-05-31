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

namespace FormTacGia
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
            string cauTruyVan = "SELECT MaTacGia AS [Mã Tác Giả], TenTacGia AS [Tên Tác Giả]" +
               "FROM TACGIA ";
            dgvTacGia.DataSource = ketnoi(cauTruyVan);
            dgvTacGia.AutoGenerateColumns = false;
            myConnection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadDgv();
            dgvTacGia.Enabled = true;
            btnLuu.Enabled = true;
            btnThemMoi.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            txbMaTG.Text = getNextIdDG();
        }

        private void dgvTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbMaTG.Text = dgvTacGia.CurrentRow.Cells[0].Value.ToString();
            txbTenTG.Text = dgvTacGia.CurrentRow.Cells[1].Value.ToString();
            errTenTG.Clear();
            btnLuu.Enabled = false;
            btnThemMoi.Enabled = true;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = true;
        }
        private string getNextIdDG()
        {
            string queryGetId = "SELECT TOP 1 MaTacGia FROM TACGIA ORDER BY MaTacGia DESC";
            ketnoi(queryGetId);
            string fullID = Convert.ToString(myCommand.ExecuteScalar());
            int numberID = Convert.ToInt32(fullID.Substring(3));
            string strNumber = (++numberID).ToString();
            fullID = "MTG" + strNumber.PadLeft(3, '0');
            return fullID;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
                errTenTG.Clear();
                txbMaTG.Text = getNextIdDG();
                txbTenTG.Text = "";
                btnCapNhat.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
        }
        private void themTacGia()
        {
            try
            {

                string themdongsql = "INSERT INTO TACGIA(TenTacGia)" +
                "VALUES (N'" + txbTenTG.Text + "')";
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
            int ck = 0;
            for (int i = 0; i < dgvTacGia.RowCount; i++)
            {

                if (txbTenTG.Text.ToUpper() == dgvTacGia.Rows[i].Cells[1].Value.ToString().ToUpper())
                {
                    ck = 1;
                }
            }
            if (ck == 0)
            {
                xuly = 0;
            {
                if (txbTenTG.Text == "")
                {
                    errTenTG.SetError(txbTenTG, "Vui lòng nhập Tên DG");
                }
                else
                {
                    errTenTG.Clear();
                }

            }

            if (txbTenTG.Text.Length > 0 )
            {
                string query = null;
                if (xuly == 0)
                {
                    themTacGia();
                    query = "SELECT TOP 1 MaTacGia FROM TACGIA ORDER BY MaTacGia DESC ";
                    ketnoi(query);
                    txbMaTG.Text = Convert.ToString(myCommand.ExecuteScalar());
                }

                dgvTacGia.AutoGenerateColumns = false;
                myConnection.Close();
                btnLuu.Enabled = false;
                btnThemMoi.Enabled = true;
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
                dgvTacGia.Enabled = true;
                dgvTacGia.FirstDisplayedScrollingRowIndex = dgvTacGia.RowCount - 1;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông Báo");
                if (txbTenTG.Text.Length == 0)
                    txbTenTG.Focus();
                }
            }
            else
            {
                MessageBox.Show("Tên tác giả đã có, bạn không thể lưu mới");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int ck = 0;
            for (int i = 0; i < dgvTacGia.RowCount; i++)
            {

                if (txbTenTG.Text.ToUpper() == dgvTacGia.Rows[i].Cells[1].Value.ToString().ToUpper())
                {
                    ck = 1;
                }
            }
            if (ck == 0)
            {
                xuly = 1;
            {
                if (txbTenTG.Text == "")
                {
                    errTenTG.SetError(txbTenTG, "Vui lòng nhập Tên DG");
                }
                else
                {
                    errTenTG.Clear();
                }

            }

            if (txbTenTG.Text.Length > 0)
            {
                if (xuly == 1)
                {
                    try
                    { 
                        string capnhatdongsql;
                        capnhatdongsql = "UPDATE TACGIA " +
                            "SET TenTacGia = N'" + txbTenTG.Text +"'" +
                            "WHERE MaTacGia = '" + txbMaTG.Text + "'";
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
                dgvTacGia.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông Báo");
                if (txbTenTG.Text.Length == 0)
                    txbTenTG.Focus();
            }
            }
            else
            {
                MessageBox.Show("Tên tác giả đã có, bạn không thể lưu mới");
            }
        }
        // Phương thức xóa tác giả
        private void xoaTG()
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn xóa.", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    string xoadongsql = "DELETE FROM TACGIA WHERE MaTacGia='" + txbMaTG.Text + "'";
                    ketnoiNonQuery(xoadongsql);
                    MessageBox.Show("Xóa thành công.", "Thông Báo");
                    btnLuu.Enabled = true;
                    btnXoa.Enabled = false;
                    btnThemMoi.Enabled = true;
                    btnCapNhat.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại.\nTrong thư viện, hiện đang có sách của tác giả này.", "Thông Báo");
                }
            }
            loadDgv();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoaTG();
        }

        private void txbTenTG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) ||char.IsSurrogate(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar == 8||e.KeyChar==13)
                e.Handled = false;
        }
    }
}
