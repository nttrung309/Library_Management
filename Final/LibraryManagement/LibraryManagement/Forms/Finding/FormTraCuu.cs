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
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
namespace TraCuuSach
{
    public partial class FormTraCuu : Form
    {
        SqlConnection connection;
        SqlCommand command;
  System.Data.DataTable table = new System.Data.DataTable();
        string str = $@"{LibraryManagement.Models.DatabaseInfo.connectionString}";
        SqlDataAdapter adapter = new SqlDataAdapter();
        public FormTraCuu()
        {
            InitializeComponent();

        }
        private void export(DataGridView g,string DuongDan, string TenTep)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
for (int i=1;i<=g.Columns.Count;i++)
           {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;

            }    
        for (int i=0;i<g.Rows.Count;i++)
            {
                for (int j=0;j<g.Columns.Count;j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();

                }    
            }
            obj.ActiveWorkbook.SaveCopyAs(DuongDan + TenTep + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
           
        }
        private void disableSortHeader()
        {
            foreach (DataGridViewColumn column in dgvDanhSachCuonSach.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if (this.chkAutoComplete.Checked)
            this.AutoComplete(this.cbMaSach, e, true);
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
            System.Data.DataTable table1 = new System.Data.DataTable();
            System.Data.DataTable table2 = new System.Data.DataTable();
            System.Data.DataTable table3 = new System.Data.DataTable();
            System.Data.DataTable table4 = new System.Data.DataTable();
            System.Data.DataTable table5 = new System.Data.DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select LEFT(MaSach,6) as MS from Sach";
            adapter.SelectCommand = command;
            table1.Clear();
            adapter.Fill(table1);
            cbMaSach.DataSource = table1;
            cbMaSach.DisplayMember = "MS";
            cbMaSach.SelectedIndex = -1;
            //------------------------- load combox theloai
            command.CommandText = "select * from TheLoai";
            adapter.SelectCommand = command;
            table2.Clear();
            adapter.Fill(table2);
            cbTheLoai.DataSource = table2;
            cbTheLoai.DisplayMember = "TenTheLoai";
            cbTheLoai.ValueMember = "MaTheLoai";
            cbTheLoai.SelectedIndex = -1;
            //------------------load combox TenSach
            command.CommandText = "select MaDauSach,TenDauSach from DauSach";
            adapter.SelectCommand = command;
            table3.Clear();
            adapter.Fill(table3);
            cbTenSach.DataSource = table3;
            cbTenSach.DisplayMember = "TenDauSach";
            cbTenSach.ValueMember = "MaDauSach";
            cbTenSach.SelectedIndex = -1;
            //---------------- load combox TacGia
            command.CommandText = "select MaTacGia,TenTacGia from TacGia";
            adapter.SelectCommand = command;
            table4.Clear();
            adapter.Fill(table4);
            cbTacGia.DataSource = table4;
            cbTacGia.DisplayMember = "TenTacGia";
            cbTacGia.ValueMember = "MaTacGia";
            cbTacGia.SelectedIndex = -1;
            //--------------------- load combox TinhTrang
          
        }
        void LoadDataGridView()
        {
            System.Data.DataTable table11 = new System.Data.DataTable();
            System.Data.DataTable table12 = new System.Data.DataTable();
            System.Data.DataTable table13 = new System.Data.DataTable();
            System.Data.DataTable table14 = new System.Data.DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select ROW_NUMBER() OVER (ORDER BY MaSach) AS [Số thứ tự],masach as [Mã Cuốn " +
                "Sách],TenDauSach as [Tên Sách],TenTheLoai as [Thể Loại],TenTacGia as [Tác Giả],TinhTrang as [Tình Trạng] from Tracuu ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvDanhSachCuonSach.DataSource = null;
            dgvDanhSachCuonSach.DataSource = table;
            for (int i=0;i<dgvDanhSachCuonSach.Rows.Count;i++)
            {
                if (dgvDanhSachCuonSach.Rows[i].Cells[5].Value.ToString()=="1")
                {
                    dgvDanhSachCuonSach.Rows[i].Cells[5].Value = "Đang Mượn";
                }    
                else
                    dgvDanhSachCuonSach.Rows[i].Cells[5].Value = "Chưa Mượn";
            }    
          
            command = connection.CreateCommand();
            command.CommandText = "select count (*) from TraCuu";
            adapter.SelectCommand = command;
            table12.Clear();
            adapter.Fill(table12);
            label12.Text = table12.Rows[0].ItemArray[0].ToString();

            command.CommandText = "select count (*) from dausach";
            adapter.SelectCommand = command;
            table13.Clear();
            adapter.Fill(table13);
            label13.Text = table13.Rows[0].ItemArray[0].ToString();

            command.CommandText = "select count(*) from tracuu where TinhTrang=1";
            adapter.SelectCommand = command;
            table14.Clear();
            adapter.Fill(table14);
            label14.Text = table14.Rows[0].ItemArray[0].ToString();
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgvDanhSachCuonSach.RowCount; i++)
            {
                dgvDanhSachCuonSach.AutoResizeRow(i);
                dgvDanhSachCuonSach.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnApDung.Enabled = false;
            btnHuy.Enabled = false;
            connection = new SqlConnection(str);
            connection.Open();
            this.btnHuy.BorderRadius = 20;
            this.btnApDung.BorderRadius = 20;
            this.btnXuatExcel.BorderRadius = 20;
            loadCombobox();
            disableSortHeader();
            command = connection.CreateCommand();
            command.CommandText = "drop table if exists TraCuu ";
            command.ExecuteNonQuery();
          
            command = connection.CreateCommand();
            command.CommandText = "create table TraCuu(MaSach varchar(50),TenDauSach nvarchar(100),TenTheLoai nvarchar(100),TenTacGia nvarchar(100),TinhTrang varchar(50)) ";
            command.ExecuteNonQuery();
            command.CommandText = "insert into TraCuu select left(CS.MaCuonSach, 6) , TenDauSach,TenTheLoai , TenTacGia ,TinhTrang from SACH as S, DAUSACH as DS,CuonSach as CS, TheLoai as TL,TacGia as TG, CTTacGia as CT where CT.MaTacGia=TG.MaTacGia and CT.MaDauSach=DS.MaDauSach and DS.MaTheLoai=TL.MaTheLoai and S.MaSach=CS.MaSach and S.MaDauSach=DS.MaDauSach  ";
            command.ExecuteNonQuery();
           
            LoadDataGridView();
        }
      
        private void but2_Click(object sender, EventArgs e)
        {
             
                string s1 = "", s2 = "", s3 = "", s4 = "", s5 = "";
            if (cbMaSach.Text != "")
                s1 = cbMaSach.Text;//MaSach
            if (cbTheLoai.Text != "")
                s2 = cbTheLoai.Text;//MaTheLoai
            if (cbTenSach.Text != "")
                s3 = cbTenSach.Text; //MaDauSach
            if (cbTacGia.Text != "")//
                s4 = cbTacGia.Text;//MaTacGia
            if (cbTinhTrang.Text != "")
                s5 = cbTinhTrang.Text;//TenTinhTrang
            command.ExecuteNonQuery();
            if ((radioButton1.Checked==true && s1 == "") || (radioButton2.Checked == true && s3 == "") || (radioButton4.Checked == true && s2 == "") || (radioButton3.Checked == true && s4 == "") || (radioButton5.Checked == true && s5 == ""))
            {
                MessageBox.Show("Bạn đang để trống giá trị Lọc");
            }
            if (s1 != "")
            {
                command.CommandText = "Select ROW_NUMBER() OVER (ORDER BY t.MaSach) AS [Số thứ tự],t.masach as [Mã Cuốn Sách],t.TenDauSach as [Tên Sách],t.TenTheLoai as [Thể Loại],t.TenTacGia as [Tác Giả],t.TinhTrang as [Tình Trạng] from TraCuu as t,sach as s,cuonsach as cs where s.MaSach='"+s1+"' and cs.masach=s.masach and t.masach=cs.macuonsach";
                command.ExecuteNonQuery();

            }
            if (s2 != "")
            {
                command.CommandText = "Select ROW_NUMBER() OVER (ORDER BY MaSach) AS [Số thứ tự],masach as [Mã Cuốn Sách],TenDauSach as [Tên Sách],TenTheLoai as [Thể Loại],TenTacGia as [Tác Giả],TinhTrang as [Tình Trạng] from TraCuu where TenTheLoai=N'" + s2 + "'";
                command.ExecuteNonQuery();

            }
            if (s3 != "")
            {
                command.CommandText = "Select ROW_NUMBER() OVER (ORDER BY MaSach) AS [Số thứ tự],masach as [Mã Cuốn Sách],TenDauSach as [Tên Sách],TenTheLoai as [Thể Loại],TenTacGia as [Tác Giả],TinhTrang as [Tình Trạng] from TraCuu where TenDauSach=N'" + s3 + "'";
                command.ExecuteNonQuery();
            }
            if (s4 != "")
            {
                command.CommandText = "Select ROW_NUMBER() OVER (ORDER BY MaSach) AS [Số thứ tự],masach as [Mã Cuốn Sách],TenDauSach as [Tên Sách],TenTheLoai as [Thể Loại],TenTacGia as [Tác Giả],TinhTrang as [Tình Trạng] from TraCuu where TenTacGia=N'" + s4 + "'";
                command.ExecuteNonQuery();
            }
            if (s5 != "")
            {
                if (s5=="Đang Mượn")
                command.CommandText = "Select ROW_NUMBER() OVER (ORDER BY MaSach) AS [Số thứ tự],masach as [Mã Cuốn Sách],TenDauSach as [Tên Sách],TenTheLoai as [Thể Loại],TenTacGia as [Tác Giả],TinhTrang as [Tình Trạng] from TraCuu where TinhTrang='1'";
                else
                    if (s5=="Chưa Mượn")
                    command.CommandText = "Select ROW_NUMBER() OVER (ORDER BY MaSach) AS [Số thứ tự],masach as [Mã Cuốn Sách],TenDauSach as [Tên Sách],TenTheLoai as [Thể Loại],TenTacGia as [Tác Giả],TinhTrang as [Tình Trạng] from TraCuu where TinhTrang='0'";
                command.ExecuteNonQuery();
            }
  
           
            if (s1 != "" || s3 != "" || s2 != "" || s4 != "" || s5 != "")
            {
                MessageBox.Show("Đây là kết quả dựa trên bộ lộc bạn đã chọn");
                table.Clear();
                adapter.Fill(table);

                dgvDanhSachCuonSach.DataSource = table;
                for (int i = 0; i < dgvDanhSachCuonSach.Rows.Count; i++)
                {
                    if (dgvDanhSachCuonSach.Rows[i].Cells[5].Value.ToString() == "1")
                    {
                        dgvDanhSachCuonSach.Rows[i].Cells[5].Value = "Đang Mượn";
                    }
                    else
                        dgvDanhSachCuonSach.Rows[i].Cells[5].Value = "Chưa Mượn";
                }
            }
        }

        private void but1_Click(object sender, EventArgs e)
        {
            //   this.Close();
            cbMaSach.Text = "";
            cbTheLoai.Text = "";
            cbTinhTrang.Text = "";
            cbTacGia.Text = "";
            cbTenSach.Text = "";
            MessageBox.Show("Bạn đã hủy áp dụng bộ lọc thành công");
            command.CommandText = "Select ROW_NUMBER() OVER (ORDER BY MaSach) AS [Số thứ tự],masach as [Mã Cuốn Sách],TenDauSach as [Tên Sách],TenTheLoai as [Thể Loại],TenTacGia as [Tác Giả],TinhTrang as [Tình Trạng] from TraCuu";
            adapter.SelectCommand = command;
            System.Data.DataTable a = new System.Data.DataTable();
            a.Clear();
            adapter.Fill(a);
            dgvDanhSachCuonSach.DataSource = null;
            dgvDanhSachCuonSach.DataSource = a;
        


                for (int i = 0; i < dgvDanhSachCuonSach.Rows.Count; i++)
                {
                    if (dgvDanhSachCuonSach.Rows[i].Cells[5].Value.ToString() == "1")
                    {
                        dgvDanhSachCuonSach.Rows[i].Cells[5].Value = "Đang Mượn";
                    }
                    else
                        dgvDanhSachCuonSach.Rows[i].Cells[5].Value = "Chưa Mượn";
                }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if (this.chkAutoComplete.Checked)
            this.AutoComplete(this.cbTheLoai, e, true);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btnApDung.Enabled = true;
            btnHuy.Enabled = true;
            if (radioButton1.Checked == true)
                cbMaSach.Enabled = true;
            else
                cbMaSach.Enabled = false;
            cbMaSach.Text = "";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            btnApDung.Enabled = true;
            btnHuy.Enabled = true;
            if (radioButton4.Checked == true)
                cbTheLoai.Enabled = true;
            else
                cbTheLoai.Enabled = false;
            cbTheLoai.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            btnApDung.Enabled = true;
            btnHuy.Enabled = true;
            if (radioButton2.Checked == true)
                cbTenSach.Enabled = true;
            else
                cbTenSach.Enabled = false;
            cbTenSach.Text = "";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            btnApDung.Enabled = true;
            btnHuy.Enabled = true;
            if (radioButton3.Checked == true)
                cbTacGia.Enabled = true;
            else
                cbTacGia.Enabled = false;
            cbTacGia.Text = "";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            btnApDung.Enabled = true;
            btnHuy.Enabled = true;
            if (radioButton5.Checked == true)
                cbTinhTrang.Enabled = true;
            else
                cbTinhTrang.Enabled = false;
            cbTinhTrang.Text = "";
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "xlsx files (.xlsx)|.xlsx|All files (.)|*.*";
                sfd.Title = "Save an Excel File";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Xuất File Excel thành công");
                }

                string DuongDan;
                DuongDan = sfd.FileName;

                export(dgvDanhSachCuonSach, DuongDan, "");
            
            }
        
       
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbTenSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.AutoComplete(this.cbTenSach, e, true);
        }

        private void cbTacGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.AutoComplete(this.cbTacGia, e, true);
        }

        private void cbTinhTrang_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

    

  
    }
}
