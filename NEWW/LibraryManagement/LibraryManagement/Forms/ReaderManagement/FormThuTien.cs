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
    public partial class FormThuTien : Form
    {
        SqlConnection connection;
        SqlCommand command;
        DataTable table = new DataTable();
        string str = $@"{LibraryManagement.Models.DatabaseInfo.connectionString}";
        SqlDataAdapter adapter = new SqlDataAdapter();
        string cu = "";
        float own = 0;
        int Docgia = 0;
        int tienthu = 0;
        ToolTip tip = new ToolTip() { IsBalloon = true };
        public FormThuTien()
        {
            InitializeComponent();
          

        }
        void setFormatDMY()
        {
            dgvDLPhieuThuTienPhat.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
        void loadcbDocGia ()
        {
            DataTable table4 = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select MADocGia,hoten from docgia where TongNo>0";
            adapter.SelectCommand = command;
            table4.Clear();
            adapter.Fill(table4);
            cbMaDocGia.DataSource = table4;
            cbMaDocGia.DisplayMember = "MaDocGia";
            cbMaDocGia.ValueMember = "HoTen";
            cbMaDocGia.SelectedIndex = -1;
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
            txbMaPhieuthu.Text = table1.Rows[0].ItemArray[0].ToString();

            command = connection.CreateCommand();
            command.CommandText = " delete PhieuThuTien where MaPhieuThu in ( select top 1 MaPhieuThu from PhieuThuTien order by MaPhieuthu desc)";
            command.ExecuteNonQuery();
        }
        private void nButton2_Click(object sender, EventArgs e)
        {
            cbMaDocGia.Enabled = true;
            cbMaDocGia.Text = "";
            txbTienThu.Text = "";
            txbConLai.Text = "";
            txbTongNo.Text = "";
            txbHoTen.Text = "";
            btnCapNhat.Enabled = false;
            btnLuu.Enabled = true;
            loadmagia();
            loadcbDocGia();
        }

        private void nButton1_Click(object sender, EventArgs e)
        {

            btnCapNhat.Enabled = true;
            btnLuu.Enabled = false;
                DateTime a = new DateTime();
                a = dtpNgayThu.Value;
                string[] formattedStrings = a.GetDateTimeFormats();

                if (cbMaDocGia.Text == "" || txbTienThu.Text == "" || dtpNgayThu.Text == "")
                {
                    MessageBox.Show("Bạn không thể để trống ô nào cả");
                }
                else
                {

                    float k = float.Parse(txbTongNo.Text) - float.Parse(txbTienThu.Text);
                    if (k < 0)
                    {
                        MessageBox.Show("Mời bạn nhập lại, số tiền thu không được lớn hơn số tiền nợ của độc giả");
                    txbTienThu.Text = "";
                    }

                    else
                    {

                        command = connection.CreateCommand();
                        command.CommandText = "insert into PhieuThuTien (MaDocGia,NgThu,SoTienThu,ConLai) values ('" + cbMaDocGia.Text + "','" + formattedStrings[6] + "','" + float.Parse(txbTienThu.Text) + "','" + k + "')";
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thanh toán thành công");
                        loadPhieuThu();
                        command = connection.CreateCommand();
                        command.CommandText = "update docgia set TongNo-='" + float.Parse(txbTienThu.Text) + "' where madocgia='" + cbMaDocGia.Text + "'";
                        command.ExecuteNonQuery();

                    }
                }

            
        }
        void loadPhieuThu()
        {
            DataTable table = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select MaPhieuThu as [Mã Phiếu Thu],MaDocGia as [Mã Độc Giả],NgThu as [Ngày Thu],format(SoTienThu,'#.') as [Số Tiền Thu],format(conlai,'0.') as [Số Tiền Còn Nợ] from PhieuThuTien";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvDLPhieuThuTienPhat.DataSource = table;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnCapNhat.Enabled = false;
            connection = new SqlConnection(str);
            connection.Open();
            
            loadPhieuThu();
            loadcbDocGia();
            loadmagia();
            setFormatDMY();
        }

      

        private void nButton4_Click(object sender, EventArgs e)
        {

                command = connection.CreateCommand();
                command.CommandText = "update docgia set TongNo+='" + own + "' where madocgia='" + cu + "'";
                command.ExecuteNonQuery();
            cu = "";

            command = connection.CreateCommand();
            command.CommandText = "delete phieuthutien where maphieuthu='"+txbMaPhieuthu.Text+"'";
            command.ExecuteNonQuery();
            loadPhieuThu();
            cbMaDocGia.Enabled = true;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txbTienThu.Text == "")
                txbConLai.Text = "";
            if (txbTienThu.Text != "" && txbTongNo.Text != ""&&txbTienThu.Text!=".")
            {
                float k = float.Parse(txbTongNo.Text) - float.Parse(txbTienThu.Text);
                if (k < 0)
                {
                    MessageBox.Show("Mời bạn nhập lại, số tiền thu không được lớn hơn số tiền nợ của độc giả");
                    txbTienThu.Text = "";
                }
                else
                    txbConLai.Text = k.ToString();
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //if (txbTongNo.Text!=""&&txbTienThu.Text!="")
            //txbConLai.Text = (float.Parse(txbTongNo.Text) - float.Parse(txbTienThu.Text)).ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbTongNo.Text = "";
            txbHoTen.Text = "";
            DataTable table3 = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select format(TongNo,'#.') from DocGia where MaDocGia='" + cbMaDocGia.Text + "' ";
            adapter.SelectCommand = command;
            table3.Clear();
            adapter.Fill(table3);

            if (table3.Rows.Count != 0)
            {
                txbTongNo.Text = table3.Rows[0].ItemArray[0].ToString();
                txbHoTen.Text = cbMaDocGia.SelectedValue.ToString();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            //MessageBox.Show(txbTienThu.Text);
            //if (txbTienThu.Text == "")
            //    txbConLai.Text = "";
            //if (txbTienThu.Text != "" && txbTongNo.Text != "")
            //{
            //    float k = float.Parse(txbTongNo.Text) - float.Parse(txbTienThu.Text);
            //    if (k < 0)
            //    {
            //        MessageBox.Show("Mời bạn nhập lại, số tiền thu không được lớn hơn số tiền nợ của độc giả");
            //        txbTienThu.Text = "";
            //    }
            //    else
            //        txbConLai.Text = k.ToString();
            //}
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbMaDocGia.Text = "";
            txbTienThu.Text = "";
            txbConLai.Text = "";
            txbTongNo.Text = "";
            txbHoTen.Text = "";
            btnCapNhat.Enabled = true;
            btnLuu.Enabled = false;
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex.ToString() != "-1")
            {

                row = dgvDLPhieuThuTienPhat.Rows[e.RowIndex];
                txbMaPhieuthu.Text = Convert.ToString(row.Cells["Mã Phiếu Thu"].Value);
                txbTienThu.Text = Convert.ToString(row.Cells["Số Tiền Thu"].Value);
                txbConLai.Text = Convert.ToString(row.Cells["Số Tiền Còn nợ"].Value);
                cbMaDocGia.Text = Convert.ToString(row.Cells["Mã Độc Giả"].Value);
                dtpNgayThu.Value = Convert.ToDateTime(row.Cells["Ngày Thu"].Value);

                    txbTongNo.Text = (float.Parse(Convert.ToString(row.Cells["Số Tiền Thu"].Value)) + float.Parse(Convert.ToString(row.Cells["Số Tiền Còn nợ"].Value))).ToString();

                DataTable table5 = new DataTable();
                command = connection.CreateCommand();
                command.CommandText = "select hoten from docgia where madocgia='" + cbMaDocGia.Text + "'";
                adapter.SelectCommand = command;
                table5.Clear();
                adapter.Fill(table5);
                txbHoTen.Text = table5.Rows[0].ItemArray[0].ToString();
                try {
                    cu = cbMaDocGia.Text;
                    own = float.Parse(txbTienThu.Text);
                }
                catch { }
                }
            cbMaDocGia.Enabled = false;
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

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txbMaPhieuthu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (txbMaPhieuthu.Text == "" || txbHoTen.Text == "" || txbTienThu.Text == "" || txbTongNo.Text == "" || txbConLai.Text == "" || cbMaDocGia.Text == "" || dtpNgayThu.Text == "")
            {
                MessageBox.Show("vui lòng chọn 1 bộ dữ liệu bên dưới để tiến hành in");
            }
            else
            {
                e.Graphics.DrawString("Phiếu Thu Tiền", new Font("Arial", 25, FontStyle.Bold), Brushes.Blue, new Point(320, 80));
                e.Graphics.DrawString(lbMaPhieuThu.Text+" "+ txbMaPhieuthu.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(150, 190));
                e.Graphics.DrawString( "...................................................................." , new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(332, 196));

                e.Graphics.DrawString(lbMaDocGia.Text + "      " + cbMaDocGia.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(150, 260));
                e.Graphics.DrawString(".......................................................................", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(300, 272));

                e.Graphics.DrawString(lbSoTienThu.Text + "    " + txbTienThu.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(150, 330));
                e.Graphics.DrawString(".....................................................................", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(315, 340));

                e.Graphics.DrawString(lbConLai.Text + "            " + txbConLai.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(150, 400));
                e.Graphics.DrawString("................................................................................", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(250, 410));
                
                e.Graphics.DrawString(lbNgayThu.Text + "        " +dtpNgayThu.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(150, 470));
                e.Graphics.DrawString("..............................................................................", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(270, 476));
                e.Graphics.DrawString("Người Đóng Tiền", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(90, 700));
                e.Graphics.DrawString("(Ký ghi rõ họ tên)", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(105, 735));
                e.Graphics.DrawString("Người Lập Phiếu", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(550, 700));
                e.Graphics.DrawString("(Ký ghi rõ họ tên)", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(565, 735));
            }
        }
        [System.ComponentModel.Browsable(false)]
   
        private void btnIn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Height = this.Height;
            printPreviewDialog1.Width = this.Width;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
          
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void dgvDLPhieuThuTienPhat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDLPhieuThuTienPhat_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
