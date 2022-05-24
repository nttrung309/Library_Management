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
namespace PhieuThuTien
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        DataTable table = new DataTable();
        string str = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        string cu = "";
        float own = 0;
        ToolTip tip = new ToolTip() { IsBalloon = true };
        public Form1()
        {
            InitializeComponent();
          

        }
        void loadcbDocGia ()
        {
            DataTable table4 = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select MADocGia,hoten from docgia where TongNo>0";
            adapter.SelectCommand = command;
            table4.Clear();
            adapter.Fill(table4);
            comboBox3.DataSource = table4;
            comboBox3.DisplayMember = "MaDocGia";
            comboBox3.ValueMember = "HoTen";
            comboBox3.SelectedIndex = -1;
        }
        void loadmagia ()
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into PhieuThuTien (MaDocGia,NgThu,SoTienThu,ConLai) values ('DG001','2/5/2022','3','4')";
            command.ExecuteNonQuery();


            DataTable table1 = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select top 1 MaPhieuThu from PhieuThuTien order by MaPhieuThu desc";
            adapter.SelectCommand = command;
            table1.Clear();
            adapter.Fill(table1);
            textBox1.Text = table1.Rows[0].ItemArray[0].ToString();

            command = connection.CreateCommand();
            command.CommandText = " delete PhieuThuTien where MaPhieuThu in ( select top 1 MaPhieuThu from PhieuThuTien order by MaPhieuthu desc)";
            command.ExecuteNonQuery();
        }
        private void nButton2_Click(object sender, EventArgs e)
        {
            comboBox3.Text = "";
            txbTienThu.Text = "";
            txbConLai.Text = "";
            txbTongNo.Text = "";
            textBox4.Text = "";
            loadmagia();
            loadcbDocGia();
        }

        private void nButton1_Click(object sender, EventArgs e)
        {
            DateTime a= new DateTime();
            a = dateTimePicker1.Value;
            string[] formattedStrings = a.GetDateTimeFormats();

            if (comboBox3.Text==""||txbTienThu.Text==""||dateTimePicker1.Text=="")
            {
                MessageBox.Show("Bạn không thể để trống ô nào cả");
            }
            else
            {
                float k = float.Parse(txbTongNo.Text) - float.Parse(txbTienThu.Text);
                if (k < 0)
                {
                    MessageBox.Show("Mời bạn nhập lại, số tiền thu không được lớn hơn số tiền nợ của độc giả");
                }
              
                else
                {
                    float c = float.Parse(txbTongNo.Text) - float.Parse(txbTienThu.Text);
                    command = connection.CreateCommand();
                    command.CommandText = "insert into PhieuThuTien (MaDocGia,NgThu,SoTienThu,ConLai) values ('" + comboBox3.Text + "','" + formattedStrings[6] + "','" + float.Parse(txbTienThu.Text) + "','" + c + "')";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công");
                    loadPhieuThu();
                    command = connection.CreateCommand();
                    command.CommandText = "update docgia set TongNo='" + float.Parse(txbConLai.Text) + "' where madocgia='" + comboBox3.Text + "'";
                    command.ExecuteNonQuery();

                }            }
            txbTongNo.Text = txbConLai.Text;
            txbConLai.Text = (float.Parse(txbTongNo.Text) - float.Parse(txbTienThu.Text)).ToString();

        }
        void loadPhieuThu()
        {
            DataTable table = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select MaPhieuThu as [Mã Phiếu Thu],MaDocGia as [Mã Độc Giả],NgThu as [Ngày Thu],SoTienThu as [Số Tiền Thu],ConLai as [Số Tiền Còn Nợ] from PhieuThuTien";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
         
            connection = new SqlConnection(str);
            connection.Open();
            loadPhieuThu();
            loadcbDocGia();
            loadmagia();
        }

      

        private void nButton4_Click(object sender, EventArgs e)
        {
            DateTime a = new DateTime();
            a = dateTimePicker1.Value;
            string[] formattedStrings = a.GetDateTimeFormats();
            float c = float.Parse(txbTongNo.Text) - float.Parse(txbTienThu.Text);
            command = connection.CreateCommand();
            command.CommandText = "update docgia set TongNo+='" + own + "' where madocgia='" + cu + "'";
            command.ExecuteNonQuery();

            command = connection.CreateCommand();
            command.CommandText = "update phieuthutien set MaDocGia='"+comboBox3.Text+"',SoTienThu='"+txbTienThu.Text+"',ConLai='"+c+"',ngthu='"+ formattedStrings[6] + "' where maphieuthu='"+textBox1.Text+"'";
            command.ExecuteNonQuery();

            command = connection.CreateCommand();
            command.CommandText = "update docgia set TongNo='" + float.Parse(txbConLai.Text) + "' where madocgia='" + comboBox3.Text + "'";
            command.ExecuteNonQuery();
            loadPhieuThu();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txbTienThu.Text != "" && txbTongNo.Text != "")
            {
                float k = float.Parse(txbTongNo.Text) - float.Parse(txbTienThu.Text);
                if (k<0)
                {
                    MessageBox.Show("Mời bạn nhập lại, số tiền thu không được lớn hơn số tiền nợ của độc giả");
                }    
                else
                txbConLai.Text = k.ToString();
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (txbTongNo.Text!=""&&txbTienThu.Text!="")
            txbConLai.Text = (float.Parse(txbTongNo.Text) - float.Parse(txbTienThu.Text)).ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbTongNo.Text = "";
            textBox4.Text = "";
            DataTable table3 = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select TongNo from DocGia where MaDocGia='" + comboBox3.Text + "' ";
            adapter.SelectCommand = command;
            table3.Clear();
            adapter.Fill(table3);

            if (table3.Rows.Count != 0)
            {
                txbTongNo.Text = table3.Rows[0].ItemArray[0].ToString();
                textBox4.Text = comboBox3.SelectedValue.ToString();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex.ToString() != "-1")
            {

                row = dataGridView1.Rows[e.RowIndex];
                    textBox1.Text = Convert.ToString(row.Cells["Mã Phiếu Thu"].Value);
                    txbTienThu.Text = Convert.ToString(row.Cells["Số Tiền Thu"].Value);
                    txbConLai.Text= Convert.ToString(row.Cells["Số Tiền Còn nợ"].Value);
                comboBox3.Text= Convert.ToString(row.Cells["Mã Độc Giả"].Value);
                dateTimePicker1.Value= Convert.ToDateTime(row.Cells["Ngày Thu"].Value);
                txbTongNo.Text = (float.Parse(txbConLai.Text) + float.Parse(txbTienThu.Text)).ToString();
                
                DataTable table5 = new DataTable();
                command = connection.CreateCommand();
                command.CommandText = "select hoten from docgia where madocgia='"+comboBox3.Text+"'";
                adapter.SelectCommand = command;
                table5.Clear();
                adapter.Fill(table5);
                textBox4.Text = table5.Rows[0].ItemArray[0].ToString();
                cu = comboBox3.Text;
                own = float.Parse(txbTienThu.Text);
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void nButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
