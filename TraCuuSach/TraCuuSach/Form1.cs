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
namespace TraCuuSach
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        DataTable table = new DataTable();
        string str = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        public Form1()
        {
            InitializeComponent();

        }
        void loadCombobox()
        {
            //-------------------- load combox mã sách
            DataTable table1 = new DataTable();
            DataTable table2 = new DataTable();
            DataTable table3 = new DataTable();
            DataTable table4 = new DataTable();
            DataTable table5 = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select LEFT(MaSach,5) as MS from Sach";
            adapter.SelectCommand = command;
            table1.Clear();
            adapter.Fill(table1);
            comboBox11.DataSource = table1;
            comboBox11.DisplayMember = "MS";
            comboBox11.SelectedIndex = -1;
            //------------------------- load combox theloai
            command.CommandText = "select * from TheLoai";
            adapter.SelectCommand = command;
            table2.Clear();
            adapter.Fill(table2);
            comboBox2.DataSource = table2;
            comboBox2.DisplayMember = "TenTheLoai";
            comboBox2.ValueMember = "MaTheLoai";
            comboBox2.SelectedIndex = -1;
            //------------------load combox TenSach
            command.CommandText = "select MaDauSach,TenDauSach from DauSach";
            adapter.SelectCommand = command;
            table3.Clear();
            adapter.Fill(table3);
            comboBox6.DataSource = table3;
            comboBox6.DisplayMember = "TenDauSach";
            comboBox6.ValueMember = "MaDauSach";
            comboBox6.SelectedIndex = -1;
            //---------------- load combox TacGia
            command.CommandText = "select MaTacGia,TenTacGia from TacGia";
            adapter.SelectCommand = command;
            table4.Clear();
            adapter.Fill(table4);
            comboBox5.DataSource = table4;
            comboBox5.DisplayMember = "TenTacGia";
            comboBox5.ValueMember = "MaTacGia";
            comboBox5.SelectedIndex = -1;
            //--------------------- load combox TinhTrang
          
        }
        void LoadDataGridView()
        {
            command = connection.CreateCommand();
            command.CommandText = "select ROW_NUMBER() OVER (ORDER BY S.MaSach) AS [Số thứ tự],left(S.MaSach,5) as [Mã Sách], TenDauSach as [Tên Sách],TenTheLoai as [Thể Loại], TenTacGia as [Tác Giả],TinhTrang as [Tình Trạng] from SACH as S,DAUSACH as DS,THELOAI as TL,TACGIA as TG,CTTACGIA as CT,CUONSACH AS CS where CT.MaDauSach=DS.MaDauSach and CT.MaTacGia=TG.MaTacGia and  CS.MaSach=S.MaSach and S.MaDauSach=DS.MaDauSach and Ds.MaTheLoai=TL.MaTheLoai ";
            adapter.SelectCommand = command;
            table.Clear();
            command = connection.CreateCommand(); adapter.Fill(table);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = table;
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.AutoResizeRow(i);
                dataGridView1.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.AutoResizeRow(i);
                dataGridView1.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
            loadCombobox();
        }

        private void but2_Click(object sender, EventArgs e)
        {
         
            command = connection.CreateCommand();
            command.CommandText = "select ROW_NUMBER() OVER (ORDER BY S.MaSach) AS [Số thứ tự],left(S.MaSach,5) as [Mã Sách], TenDauSach as [Tên Sách],TenTheLoai as [Thể Loại], TenTacGia as [Tác Giả],TinhTrang as [Tình Trạng] from SACH as S,DAUSACH as DS,THELOAI as TL,TACGIA as TG,CTTACGIA as CT,CUONSACH AS CS where CT.MaDauSach=DS.MaDauSach and CT.MaTacGia=TG.MaTacGia and  CS.MaSach=S.MaSach and S.MaDauSach=DS.MaDauSach and Ds.MaTheLoai=TL.MaTheLoai  ";
            adapter.SelectCommand = command;
            table.Clear();
            command = connection.CreateCommand(); adapter.Fill(table);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = table;
        }

        private void but1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
