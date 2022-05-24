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
namespace FormLoaiSach
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        DataTable table = new DataTable();
        string str = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        string DG = "";
        public Form1()
        {
            InitializeComponent();
        }

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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
        }
    }
}
