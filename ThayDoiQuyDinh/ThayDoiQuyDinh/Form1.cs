using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace ThayDoiQuyDinh
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
        void loadQD()
        {
            disableSortHeader();
            DataTable table = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select ThoiHanThe,TuoiToiThieu,TuoiToiDa,ThoiGianLuuHanh,SoNgayMuonMax,SoSachMuonMax,format(MucThuTienPhat,'#.') from ThamSo ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            string s = "";
            s += table.Rows[0].ItemArray[0].ToString();
         
                s += " tháng";
            
            label17.Text = s;
            s = "";
            s += table.Rows[0].ItemArray[3].ToString();
            s += " năm";
            label18.Text = s;
            s = "";
            s += table.Rows[0].ItemArray[2].ToString();
            s += " tuổi";
            label19.Text = s;
            s = "";
            s += table.Rows[0].ItemArray[1].ToString();
            s += " tuổi";
            label20.Text = s;
            s = "";
            s += table.Rows[0].ItemArray[4].ToString();
            s += " ngày";
            label21.Text = s;
            s = "";
            s += table.Rows[0].ItemArray[5].ToString();
            s += " cuốn";
            label22.Text = s;

            s = "";
            s += table.Rows[0].ItemArray[6].ToString();
            s += " đồng";
            label23.Text = s;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            nButton4.Hide();
            nButton5.Hide();
            panel3.Hide();
            connection = new SqlConnection(str);
            connection.Open();
         
            loadQD();
           

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void nButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cập nhật quy định thành công");
            if (textBox1.Text != "")
            {
                command = connection.CreateCommand();
                command.CommandText = "update Thamso set ThoiHanThe='" + textBox1.Text + "' ";
                command.ExecuteNonQuery();
            }
            if (textBox2.Text != "")
            {
                command = connection.CreateCommand();
                command.CommandText = "update Thamso set ThoiGianLuuHanh='" + textBox2.Text + "' ";
                command.ExecuteNonQuery();
            }
            if (textBox3.Text != "")
            {
                command = connection.CreateCommand();
                command.CommandText = "update Thamso set TuoiToiDa='" + textBox3.Text + "' ";
                command.ExecuteNonQuery();
            }
            if (textBox5.Text != "")
            {
                command = connection.CreateCommand();
                command.CommandText = "update Thamso set TuoiToiThieu='" + textBox5.Text + "' ";
                command.ExecuteNonQuery();
            }
            if (textBox4.Text != "")
            {
                command = connection.CreateCommand();
                command.CommandText = "update Thamso set SoNgayMuonMax='" + textBox4.Text + "' ";
                command.ExecuteNonQuery();
            }
            if (textBox6.Text != "")
            {
                command = connection.CreateCommand();
                command.CommandText = "update Thamso set SoSachMuonMax='" + textBox6.Text + "' ";
                command.ExecuteNonQuery();
            }
            if (textBox7.Text != "")
            {
                command = connection.CreateCommand();
                command.CommandText = "update Thamso set MucThuTienPhat='" + textBox7.Text + "' ";
                command.ExecuteNonQuery();
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            loadQD();
        
        }

        private void nButton3_Click(object sender, EventArgs e)
        {
            panel4.Hide();
            panel3.Show();
            nButton1.Hide();
            nButton4.Show();
            nButton5.Show();
            panel2.Hide();
            label9.Text = "Danh Sách Loại Độc Giả";
            DataTable table1 = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select MaLoaiDocGia as [Mã Loại],TenLoaiDocGia as [Tên Loại Độc Giả] from LoaiDocGia";
            adapter.SelectCommand = command;
            table1.Clear();
            adapter.Fill(table1);
            dataGridView1.DataSource = table1;

        }

        private void nButton2_Click(object sender, EventArgs e)
        {
            panel4.Show();
            panel3.Hide();
            nButton1.Show();
            nButton4.Hide();
            nButton5.Hide();
            panel2.Show();
            label9.Text = "Quy Định Hiện Hành ";
            dataGridView1.DataSource = null;
        }

        void loadDocGia()
        {
            DataTable table1 = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select MaLoaiDocGia as [Mã Loại],TenLoaiDocGia as [Tên Loại Độc Giả] from LoaiDocGia";
            adapter.SelectCommand = command;
            table1.Clear();
            adapter.Fill(table1);
            dataGridView1.DataSource = table1;
        }
        void loadTheLoai()
        {
            DataTable table1 = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select MaTheLoai as [Mã Loại],TenTheLoai as [Tên Thể Loại Sách] from TheLoai";
            adapter.SelectCommand = command;
            table1.Clear();
            adapter.Fill(table1);
            dataGridView1.DataSource = table1;
        }
        private void nButton4_Click(object sender, EventArgs e)
        {
            label9.Text = "Danh Sách Loại Độc Giả";
            loadDocGia();
            label24.Text = "Tên Loại Độc Giả";
            textBox8.Text = "";
        }

        private void nButton5_Click(object sender, EventArgs e)
        {
            label9.Text = "Danh Sách Thể Loại Sách";
            loadTheLoai();
            label24.Text = "Tên Thể Loại Sách";
            textBox8.Text = "";
        }

        private void nButton6_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";
        }
        private void disableSortHeader()
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void nButton8_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            { MessageBox.Show("Bạn không thể để trống ô này"); }
            else
            {
                DataTable table11 = new DataTable();
                command = connection.CreateCommand();
                if (label24.Text== "Tên Thể Loại Sách")
                command.CommandText = "select count(*) from THELOAI where TenTheLoai=N'"+textBox8.Text+"'";
                else
                    if (label24.Text== "Tên Loại Độc Giả")
                    command.CommandText = "select count(*) from LoaiDocGia where TenLoaiDocGia=N'" + textBox8.Text + "'";
                adapter.SelectCommand = command;
                table11.Clear();
                adapter.Fill(table11);
         int i=int.Parse((table11.Rows[0].ItemArray[0].ToString()));
                DialogResult dlr = new DialogResult();
                if (i > 0)
                {
                     dlr = MessageBox.Show("Loại này đã có trong thư viện,bạn có muốn thêm vào", "IceTea Việt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                    if (dlr == DialogResult.No)
                {
                    MessageBox.Show("Mời bạn nhập lại");
                    textBox8.Text = "";
                }
                else
                {
                    MessageBox.Show("Lưu Thành Công");
                    if (label24.Text == "Tên Thể Loại Sách")
                    {
                        command = connection.CreateCommand();
                        command.CommandText = "insert into THELOAI (TenTheLoai) values (N'" + textBox8.Text + "') ";
                        command.ExecuteNonQuery();
                        loadTheLoai();
                    }
                    else
                         if (label24.Text == "Tên Loại Độc Giả")
                    {
                        command = connection.CreateCommand();
                        command.CommandText = "insert into LOAIDOCGIA (TenLoaiDocGia) values (N'" + textBox8.Text + "') ";
                        command.ExecuteNonQuery();
                        loadDocGia();
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex.ToString() !="-1")
            {
                
                row = dataGridView1.Rows[e.RowIndex];
                DG = Convert.ToString(row.Cells["Mã Loại"].Value);
                if (label24.Text == "Tên Loại Độc Giả")
                    textBox8.Text = Convert.ToString(row.Cells["Tên Loại Độc Giả"].Value);
                else
                   if (label24.Text == "Tên Thể Loại Sách")
                    textBox8.Text = Convert.ToString(row.Cells["Tên Thể Loại Sách"].Value);
            }
        }
        private void nButton9_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            { MessageBox.Show("Bạn không thể để trống ô này"); }
            else
            {
                MessageBox.Show("Sửa Thành Công");
                if (label24.Text == "Tên Thể Loại Sách")
                {
                    command = connection.CreateCommand();
                    command.CommandText = "update THELOAI set TenTheLoai =N'" + textBox8.Text + "' where MaTheLoai='"+DG+"'  ";
                    command.ExecuteNonQuery();
                    loadTheLoai();
                }
                else
                     if (label24.Text == "Tên Loại Độc Giả")
                {
                    command = connection.CreateCommand();
                    command.CommandText = "update LOAIDOCGIA set TenLoaiDocGia =N'" + textBox8.Text + "' Where MaLoaiDocGia='"+DG+"'";
                    command.ExecuteNonQuery();
                    loadDocGia();
                }
            }
        }

        private void nButton10_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            { MessageBox.Show("Bạn không thể để trống ô này"); }
            else
            {


                if (label24.Text == "Tên Thể Loại Sách")
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
                else
                     if (label24.Text == "Tên Loại Độc Giả")
                {
                    try
                    {
                        command = connection.CreateCommand();
                        command.CommandText = "delete LOAIDOCGIA Where MaLoaiDocGia='" + DG + "'";
                        command.ExecuteNonQuery();
                        MessageBox.Show("xóa Thành Công");
                        loadDocGia();
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
}
