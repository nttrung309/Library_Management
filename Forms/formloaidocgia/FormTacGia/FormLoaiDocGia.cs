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

namespace FormLoaiDocGia
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
            string cauTruyVan = "SELECT MaLoaiDocGia AS [Mã Loại Độc Giả], TenLoaiDocGia AS [Tên Loại Độc Giả]" +
               "FROM LOAIDOCGIA ";
            dgvLoaiDocGia.DataSource = ketnoi(cauTruyVan);
            dgvLoaiDocGia.AutoGenerateColumns = false;
            myConnection.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            loadDgv();
            dgvLoaiDocGia.Enabled = true;
            btnLuu.Enabled = true;
            btnThemMoi.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            txbMaLoaiDocGia.Text = getNextIdLDG();
        }
        private string getNextIdLDG()
        {
            string queryGetId = "SELECT TOP 1 MaLoaiDocGia FROM LOAIDOCGIA ORDER BY MaLoaiDocGia DESC";
            ketnoi(queryGetId);
            string fullID = Convert.ToString(myCommand.ExecuteScalar());
            int numberID = Convert.ToInt32(fullID.Substring(4));
            string strNumber = (++numberID).ToString();
            fullID = "MLDG" + strNumber.PadLeft(3, '0');
            return fullID;
        }



        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            errTenLDG.Clear();
            txbMaLoaiDocGia.Text = getNextIdLDG();
            txbTenLoaiDocGia.Text = "";
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }
        private void themLoaiDG()
        {
            try
            {

                string themdongsql = "INSERT INTO LOAIDOCGIA(TenLoaiDocGia)" +
                "VALUES (N'" + txbTenLoaiDocGia.Text + "')";
                ketnoiNonQuery(themdongsql);
                MessageBox.Show("Thêm thành công.", "Thông Báo");
                loadDgv();
            }
            catch (Exception)
            {

            }
        }

        int xuly;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            int ck = 0;
            for (int i = 0; i < dgvLoaiDocGia.RowCount; i++)
            {

                if (txbTenLoaiDocGia.Text.ToUpper() == dgvLoaiDocGia.Rows[i].Cells[1].Value.ToString().ToUpper())
                {
                    ck = 1;
                }
            }
            if (ck == 0)
            {
                xuly = 0;
                {
                    if (txbTenLoaiDocGia.Text == "")
                    {
                        errTenLDG.SetError(txbTenLoaiDocGia, "Vui lòng nhập Tên DG");
                    }
                    else
                    {
                        errTenLDG.Clear();
                    }

                }

                if (txbTenLoaiDocGia.Text.Length > 0)
                {
                    string query = null;
                    if (xuly == 0)
                    {
                        themLoaiDG();
                        query = "SELECT TOP 1 MaLoaiDocGia FROM LOAIDOCGIA ORDER BY MaLoaiDocGia DESC ";
                        ketnoi(query);
                        txbMaLoaiDocGia.Text = Convert.ToString(myCommand.ExecuteScalar());
                    }

                    dgvLoaiDocGia.AutoGenerateColumns = false;
                    myConnection.Close();
                    btnLuu.Enabled = false;
                    btnThemMoi.Enabled = true;
                    btnCapNhat.Enabled = true;
                    btnXoa.Enabled = true;
                    dgvLoaiDocGia.Enabled = true;
                    dgvLoaiDocGia.FirstDisplayedScrollingRowIndex = dgvLoaiDocGia.RowCount - 1;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông Báo");
                    if (txbTenLoaiDocGia.Text.Length == 0)
                        txbTenLoaiDocGia.Focus();
                }
            }
            else
                MessageBox.Show("Tên loại độc giả này đã có, bạn không thể lưu mới");
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int ck = 0;
            for (int i = 0; i < dgvLoaiDocGia.RowCount; i++)
            {

                if (txbTenLoaiDocGia.Text.ToUpper() == dgvLoaiDocGia.Rows[i].Cells[1].Value.ToString().ToUpper())
                {
                    ck = 1;
                }
            }
            if (ck == 0)
            {
                xuly = 1;
            {
                if (txbTenLoaiDocGia.Text == "")
                {
                    errTenLDG.SetError(txbTenLoaiDocGia, "Vui lòng nhập Tên DG");
                }
                else
                {
                    errTenLDG.Clear();
                }

            }

            if (txbTenLoaiDocGia.Text.Length > 0)
            {
                if (xuly == 1)
                {
                    try
                    {
                        string capnhatdongsql;
                        capnhatdongsql = "UPDATE LOAIDOCGIA " +
                            "SET TenLoaiDocGia = N'" + txbTenLoaiDocGia.Text + "'" +
                            "WHERE MaLoaiDocGia = '" + txbMaLoaiDocGia.Text + "'";
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
                dgvLoaiDocGia.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông Báo");
                if (txbTenLoaiDocGia.Text.Length == 0)
                    txbTenLoaiDocGia.Focus();
            }
            }
            else
                MessageBox.Show("Tên loại độc giả này đã có, bạn không thể lưu mới");
        }


        // Phương thức xóa tác giả
        private void xoaLoaiDG()
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn xóa.", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    string xoadongsql = "DELETE FROM LOAIDOCGIA WHERE MaLoaiDocGia='" + txbMaLoaiDocGia.Text + "'";
                    ketnoiNonQuery(xoadongsql);
                    MessageBox.Show("Xóa thành công.", "Thông Báo");
                    btnLuu.Enabled = true;
                    btnXoa.Enabled = false;
                    btnThemMoi.Enabled = true;
                    btnCapNhat.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại.\nTrong thư viện, hiện đang tồn tại thẻ độc giả tương ứng loại độc giả này.", "Thông Báo");
                }
            }
            loadDgv();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoaLoaiDG();
            errTenLDG.Clear();
        }

        private void dgvLoaiDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbMaLoaiDocGia.Text = dgvLoaiDocGia.CurrentRow.Cells[0].Value.ToString();
            txbTenLoaiDocGia.Text = dgvLoaiDocGia.CurrentRow.Cells[1].Value.ToString();
            errTenLDG.Clear();
            btnLuu.Enabled = false;
            btnThemMoi.Enabled = true;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = true;
        }
    }
}
