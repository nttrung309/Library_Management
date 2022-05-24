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
<<<<<<< HEAD
=======

>>>>>>> 29b454ce8986fe696f8826cfd6570a4573a2699e
namespace FormLoaiSach
{
    public partial class Form1 : Form
    {
<<<<<<< HEAD
        SqlConnection connection;
        SqlCommand command;
        DataTable table = new DataTable();
        string str = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        string DG = "";
=======
        // Khai báo 
        string chuoiKetNoi = @"Data Source=LAPTOP-281DQ5C3\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True";
        private SqlConnection myConnection; // kết nối tới csdl
        private SqlDataAdapter myDataAdapter;   // Vận chuyển csdl qa DataSet
        private DataTable myTable;  // Dùng để lưu bảng lấy từ c#
        SqlCommand myCommand;   // Thực hiện cách lệnh truy vấn
>>>>>>> 29b454ce8986fe696f8826cfd6570a4573a2699e
        public Form1()
        {
            InitializeComponent();
        }
<<<<<<< HEAD

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex.ToString() != "-1")
            {

                row = dgvDanhSachTheLoai.Rows[e.RowIndex];
                DG = Convert.ToString(row.Cells["Mã Loại"].Value);
                    txbTenTheLoaiSach.Text = Convert.ToString(row.Cells["Tên Thể Loại Sách"].Value);
                txbMaTheLoai.Text = Convert.ToString(row.Cells["Mã Loại"].Value);
            }
=======
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
            string query = "SELECT MaTheLoai AS [Mã Thể Loại], TenTheLoai AS [Tên Thể Loại]" +
               "FROM THELOAI ";
            dgvTLSach.DataSource = ketnoi(query);
            dgvTLSach.AutoGenerateColumns = false;
            myConnection.Close();
        }
        private string getNextIdDG()
        {
            string queryGetId = "SELECT TOP 1 MaTheLoai FROM THELOAI ORDER BY MaTheLoai DESC";
            ketnoi(queryGetId);
            string fullID = Convert.ToString(myCommand.ExecuteScalar());
            int numberID = Convert.ToInt32(fullID.Substring(3));
            string strNumber = (++numberID).ToString();
            fullID = "MTG" + strNumber.PadLeft(3, '0');
            return fullID;
>>>>>>> 29b454ce8986fe696f8826cfd6570a4573a2699e
        }

        private void Form1_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            connection = new SqlConnection(str);
            connection.Open();
            loadTheLoai();
        }
        void loadTheLoai()
        {
            DataTable table1 = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select MaTheLoai as [Mã Loại],TenTheLoai as [Tên Thể Loại Sách] from TheLoai";
            adapter.SelectCommand = command;
            table1.Clear();
            adapter.Fill(table1);
            dgvDanhSachTheLoai.DataSource = table1;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txbTenTheLoaiSach.Text = "";
            txbMaTheLoai.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txbTenTheLoaiSach.Text == "")
            { MessageBox.Show("Bạn không thể để trống ô này"); }
            else
            {
                DataTable table11 = new DataTable();
                command = connection.CreateCommand();
     
                    command.CommandText = "select count(*) from THELOAI where TenTheLoai=N'" + txbTenTheLoaiSach.Text + "'"; 
                adapter.SelectCommand = command;
                table11.Clear();
                adapter.Fill(table11);
                int i = int.Parse((table11.Rows[0].ItemArray[0].ToString()));
                DialogResult dlr = new DialogResult();
                if (i > 0)
                {
                    dlr = MessageBox.Show("Loại này đã có trong thư viện,bạn có muốn thêm vào", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                if (dlr == DialogResult.No)
                {
                    MessageBox.Show("Mời bạn nhập lại");
                    txbTenTheLoaiSach.Text = "";
                }
                else
                {
                    MessageBox.Show("Lưu Thành Công");
                  
                        command = connection.CreateCommand();
                        command.CommandText = "insert into THELOAI (TenTheLoai) values (N'" + txbTenTheLoaiSach.Text + "') ";
                        command.ExecuteNonQuery();
                        loadTheLoai();
      
                   
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txbTenTheLoaiSach.Text == "")
            { MessageBox.Show("Bạn không thể để trống ô này"); }
            else
            {
                MessageBox.Show("Sửa Thành Công");
               
                    command = connection.CreateCommand();
                    command.CommandText = "update THELOAI set TenTheLoai =N'" + txbTenTheLoaiSach.Text + "' where MaTheLoai='" + txbMaTheLoai.Text + "'  ";
                    command.ExecuteNonQuery();
                    loadTheLoai();
               
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txbTenTheLoaiSach.Text == "")
            { MessageBox.Show("Bạn không thể để trống ô này"); }
            else
            {


              
                    try
                    {
                        command = connection.CreateCommand();
                        command.CommandText = "delete THELOAI where MaTheLoai='" + DG + "'  ";
                        command.ExecuteNonQuery();
                        MessageBox.Show("xóa Thành Công");
                        loadTheLoai();
                    }
                    catch
                    {
                        // khối này thực thi khi bắt được lỗi
                        MessageBox.Show("Xóa thất bại");
                    }


              

            }
=======
            loadDgv();
            dgvTLSach.Enabled = true;
            btnLuu.Enabled = true;
            btnThemMoi.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            txbMaTLS.Text = getNextIdDG();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            errTenTLS.Clear();
            txbMaTLS.Text = getNextIdDG();
            txbTenTLS.Text = "";
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void dgvTLSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbMaTLS.Text = dgvTLSach.CurrentRow.Cells[0].Value.ToString();
            txbTenTLS.Text = dgvTLSach.CurrentRow.Cells[1].Value.ToString();
            errTenTLS.Clear();
            btnLuu.Enabled = false;
            btnThemMoi.Enabled = true;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = true;
        }
        //Phương thức thêm thể loại sách
        private void themTheLoai()
        {
            try
            {

                string themdongsql = "INSERT INTO THELOAI(TenTheLoai)" +
                "VALUES (N'" + txbTenTLS.Text + "')";
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
                if (txbTenTLS.Text == "")
                {
                    errTenTLS.SetError(txbTenTLS, "Vui lòng nhập Tên DG");
                }
                else
                {
                    errTenTLS.Clear();
                }

            }

            if (txbTenTLS.Text.Length > 0)
            {
                string query = null;
                if (xuly == 0)
                {
                    themTheLoai();
                    query = "SELECT TOP 1 MaTheLoai FROM THELOAI ORDER BY MaTheLoai DESC ";
                    ketnoi(query);
                    txbMaTLS.Text = Convert.ToString(myCommand.ExecuteScalar());
                }

                dgvTLSach.AutoGenerateColumns = false;
                myConnection.Close();
                btnLuu.Enabled = false;
                btnThemMoi.Enabled = true;
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
                dgvTLSach.Enabled = true;
                dgvTLSach.FirstDisplayedScrollingRowIndex = dgvTLSach.RowCount - 1;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông Báo");
                if (txbTenTLS.Text.Length == 0)
                    txbTenTLS.Focus();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            xuly = 1;
            {
                if (txbTenTLS.Text == "")
                {
                    errTenTLS.SetError(txbTenTLS, "Vui lòng nhập Tên DG");
                }
                else
                {
                    errTenTLS.Clear();
                }

            }

            if (txbTenTLS.Text.Length > 0)
            {
                if (xuly == 1)
                {
                    try
                    {
                        string capnhatdongsql;
                        capnhatdongsql = "UPDATE THELOAI " +
                            "SET TenTheLoai = N'" + txbTenTLS.Text + "'" +
                            "WHERE MaTheLoai = '" + txbMaTLS.Text + "'";
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
                dgvTLSach.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông Báo");
                if (txbTenTLS.Text.Length == 0)
                    txbTenTLS.Focus();
            }
        }
        // Phương thức xóa tác giả
        private void xoaTheLoai()
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn xóa.", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    string xoadongsql = "DELETE FROM THELOAI WHERE MaTheLoai='" + txbMaTLS.Text + "'";
                    ketnoiNonQuery(xoadongsql);
                    MessageBox.Show("Xóa thành công.", "Thông Báo");
                    btnLuu.Enabled = true;
                    btnXoa.Enabled = false;
                    btnThemMoi.Enabled = true;
                    btnCapNhat.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại.\nTrong thư viện, hiện đang có thể loại sách này.", "Thông Báo");
                }
            }
            loadDgv();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoaTheLoai();
            errTenTLS.Clear();
>>>>>>> 29b454ce8986fe696f8826cfd6570a4573a2699e
        }
    }
}
