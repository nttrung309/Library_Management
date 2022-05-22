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
        private void disableSortHeader()
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if (this.chkAutoComplete.Checked)
            this.AutoComplete(this.comboBox11, e, true);
        }



        private void AutoComplete(ComboBox cb, System.Windows.Forms.KeyPressEventArgs e)
        {
            this.AutoComplete(cb, e, false);
        }
        private void AutoComplete(ComboBox cb, System.Windows.Forms.KeyPressEventArgs e, bool blnLimitToList)
        {
            string strFindStr = "";

            if (e.KeyChar == (char)8)
            {
                if (cb.SelectionStart <= 1)
                {
                    cb.Text = "";
                    return;
                }

                if (cb.SelectionLength == 0)
                    strFindStr = cb.Text.Substring(0, cb.Text.Length - 1);
                else
                    strFindStr = cb.Text.Substring(0, cb.SelectionStart - 1);
            }
            else
            {
                if (cb.SelectionLength == 0)
                    strFindStr = cb.Text + e.KeyChar;
                else
                    strFindStr = cb.Text.Substring(0, cb.SelectionStart) + e.KeyChar;
            }

            int intIdx = -1;

            // Search the string in the ComboBox list.

            intIdx = cb.FindString(strFindStr);

            if (intIdx != -1)
            {
                cb.SelectedText = "";
                cb.SelectedIndex = intIdx;
                cb.SelectionStart = strFindStr.Length;
                cb.SelectionLength = cb.Text.Length;
                e.Handled = true;
            }
            else
            {
                e.Handled = blnLimitToList;
            }

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
            command.CommandText = "select LEFT(MaCuonSach,6) as MS from CuonSach";
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
            DataTable table11 = new DataTable();
            DataTable table12 = new DataTable();
            DataTable table13 = new DataTable();
            DataTable table14 = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select ROW_NUMBER() OVER (ORDER BY MaCuonSach) AS [Số thứ tự],TenDauSach as [Tên Sách],TenTheLoai as [Thể Loại],TenTacGia as [Tác Giả],TinhTrang as [Tình Trạng] from Tracuu ";
            adapter.SelectCommand = command;
            table11.Clear();
            adapter.Fill(table11);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = table11;

            command = connection.CreateCommand();
            command.CommandText = "select count (*) from TraCuu";
            adapter.SelectCommand = command;
            table12.Clear();
            adapter.Fill(table12);
            label12.Text = table12.Rows[0].ItemArray[0].ToString();

            command.CommandText = "select count (*) as sl from (select count(*) as SH from TRACUU group by TenTheLoai) as B";
            adapter.SelectCommand = command;
            table13.Clear();
            adapter.Fill(table13);
            label13.Text = table13.Rows[0].ItemArray[0].ToString();

            command.CommandText = "select count (*) as sl1 from (select count(*) as SH1 from TRACUU group by TenTacGia) as T";
            adapter.SelectCommand = command;
            table14.Clear();
            adapter.Fill(table14);
            label14.Text = table14.Rows[0].ItemArray[0].ToString();
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
            this.but1.BorderRadius = 20;
            this.but2.BorderRadius = 20; 
            loadCombobox();
            disableSortHeader();
            command = connection.CreateCommand();
            command.CommandText = "drop table TraCuu ";
            command.ExecuteNonQuery();
            command = connection.CreateCommand();
            command.CommandText = "drop table TraCuu2 ";
            command.ExecuteNonQuery();
            command.CommandText = "drop table TraCuu3 ";
            command.ExecuteNonQuery();

            command = connection.CreateCommand();
            command.CommandText = "create table TraCuu(MaCuonSach varchar(50),TenDauSach nvarchar(100),TenTheLoai nvarchar(100),TenTacGia nvarchar(100),TinhTrang bit) ";
            command.ExecuteNonQuery();
            command.CommandText = "insert into TraCuu select left(CS.MaCuonSach, 6) , TenDauSach,TenTheLoai , TenTacGia ,TinhTrang from SACH as S, DAUSACH as DS,CuonSach as CS, TheLoai as TL,TacGia as TG, CTTacGia as CT where CT.MaTacGia=TG.MaTacGia and CT.MaDauSach=DS.MaDauSach and DS.MaTheLoai=TL.MaTheLoai and S.MaSach=CS.MaSach and S.MaDauSach=DS.MaDauSach  ";
            command.ExecuteNonQuery();
            command = connection.CreateCommand();
            command.CommandText = "create table TraCuu2(MaCuonSach varchar(50),TenDauSach nvarchar(100),TenTheLoai nvarchar(100),TenTacGia nvarchar(100),TinhTrang bit) ";
            command.ExecuteNonQuery();
            command = connection.CreateCommand();
            command.CommandText = "create table TraCuu3(MaCuonSach varchar(50),TenDauSach nvarchar(100),TenTheLoai nvarchar(100),TenTacGia nvarchar(100),TinhTrang bit) ";
            command.ExecuteNonQuery();
            LoadDataGridView();
        }
      
        private void but2_Click(object sender, EventArgs e)
        {
            string s1 = "", s2 = "", s3 = "", s4 = "", s5 = "";
            if (comboBox11.Text != "")
                s1 = comboBox11.Text;//MaSach
            if (comboBox2.Text != "")
                s2 = comboBox2.Text;//MaTheLoai
            if (comboBox6.Text != "")
                s3 = comboBox6.Text; //MaDauSach
            if (comboBox5.Text != "")//
                s4 = comboBox5.Text;//MaTacGia
            if (comboBox3.Text != "")
                s5 = comboBox3.Text;//TenTinhTrang
            command.CommandText = "insert into Tracuu2 select *from Tracuu";
            command.ExecuteNonQuery();
            if (s1 != "")
            {
                command.CommandText = "insert into Tracuu3 select *from Tracuu where MaCuonSach='"+s1+"'intersect select * from TraCuu2";
                command.ExecuteNonQuery();
                command.CommandText = "delete TraCuu2";
                command.ExecuteNonQuery();
                command.CommandText = "insert into TraCuu2 select * from TraCuu3";
                command.ExecuteNonQuery();
                command.CommandText = "delete TraCuu3";
                command.ExecuteNonQuery();
            }
            if (s2 != "")
            {
                command.CommandText = "insert into Tracuu3 select *from Tracuu2 intersect select * from TraCuu where TenTheLoai=N'" + s2 + "' ";
                command.ExecuteNonQuery();
                command.CommandText = "delete TraCuu2";
                command.ExecuteNonQuery();
                command.CommandText = "insert into TraCuu2 select * from TraCuu3";
                command.ExecuteNonQuery();
                command.CommandText = "delete TraCuu3";
                command.ExecuteNonQuery();

            }
            if (s3 != "")
            {
                command.CommandText = "insert into Tracuu3 select *from Tracuu2 intersect select * from TraCuu where TenDauSach=N'" + s3 + "' ";
                command.ExecuteNonQuery();
                command.CommandText = "delete TraCuu2";
                command.ExecuteNonQuery();
                command.CommandText = "insert into TraCuu2 select * from TraCuu3";
                command.ExecuteNonQuery();
                command.CommandText = "delete TraCuu3";
                command.ExecuteNonQuery();
            }
            if (s4 != "")
            {
                command.CommandText = "insert into Tracuu3 select *from Tracuu2 intersect select * from TraCuu where TenTacGia=N'" + s4 + "' ";
                command.ExecuteNonQuery();
                command.CommandText = "delete TraCuu2";
                command.ExecuteNonQuery();
                command.CommandText = "insert into TraCuu2 select * from TraCuu3";
                command.ExecuteNonQuery();
                command.CommandText = "delete TraCuu3";
                command.ExecuteNonQuery();
            }
            if (s5 != "")
            {
                if (s5 == "Đang Mượn")
                    command.CommandText = "insert into Tracuu3 select *from Tracuu2 intersect select * from TraCuu where TinhTrang='1' ";
                else
                    if (s5 == "Đã Trả")
                    command.CommandText = "insert into Tracuu3 select *from Tracuu2 intersect select * from TraCuu where TinhTrang='0' ";
                command.ExecuteNonQuery();
                command.CommandText = "delete TraCuu2";
                command.ExecuteNonQuery();
                command.CommandText = "insert into TraCuu2 select * from TraCuu3";
                command.ExecuteNonQuery();
                command.CommandText = "delete TraCuu3";
                command.ExecuteNonQuery();
            }
            DataTable table10 = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select count (*) from TraCuu2";
            adapter.SelectCommand = command;
            table10.Clear();
            adapter.Fill(table10);
            if (table10.Rows[0].ItemArray[0].ToString() == "0")
                MessageBox.Show("Không tìm thấy nội dung thỏa yêu cầu");
            else
                MessageBox.Show("Đây là kết quả dựa trên bộ lộc bạn đã chọn");
            command.CommandText = "Select ROW_NUMBER() OVER (ORDER BY MaCuonSach) AS [Số thứ tự],TenDauSach as [Tên Sách],TenTheLoai as [Thể Loại],TenTacGia as [Tác Giả],TinhTrang as [Tình Trạng] from TraCuu2";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

      
            command.CommandText = "delete TraCuu2";
            command.ExecuteNonQuery();
            command.CommandText = "delete TraCuu3";
            command.ExecuteNonQuery();

          
        }

        private void but1_Click(object sender, EventArgs e)
        {
            //   this.Close();
            comboBox11.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            MessageBox.Show("Bạn đã hủy áp dụng bộ lọc thành công");
            command.CommandText = "Select ROW_NUMBER() OVER (ORDER BY MaCuonSach) AS [Số thứ tự],TenDauSach as [Tên Sách],TenTheLoai as [Thể Loại],TenTacGia as [Tác Giả],TinhTrang as [Tình Trạng] from TraCuu";
            adapter.SelectCommand = command;
            DataTable a = new DataTable();
            a.Clear();
            adapter.Fill(a);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = a;

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if (this.chkAutoComplete.Checked)
            this.AutoComplete(this.comboBox2, e, true);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                comboBox11.Enabled = true;
            else
                comboBox11.Enabled = false;
            comboBox11.Text = "";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
                comboBox2.Enabled = true;
            else
                comboBox2.Enabled = false;
            comboBox2.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
                comboBox6.Enabled = true;
            else
                comboBox6.Enabled = false;
            comboBox6.Text = "";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
                comboBox5.Enabled = true;
            else
                comboBox5.Enabled = false;
            comboBox5.Text = "";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
                comboBox3.Enabled = true;
            else
                comboBox3.Enabled = false;
            comboBox3.Text = "";
        }
    }
}
