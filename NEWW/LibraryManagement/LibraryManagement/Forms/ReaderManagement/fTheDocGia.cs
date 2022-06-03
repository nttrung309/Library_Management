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
using System.Text.RegularExpressions;

namespace LibraryManage
{
    public partial class Form1 : Form
    {
        // Khai báo 
        string chuoiKetNoi = $@"{LibraryManagement.Models.DatabaseInfo.connectionString}";
        private SqlConnection myConnection; // kết nối tới csdl
        private SqlDataAdapter myDataAdapter;   // Vận chuyển csdl qa DataSet
        private DataTable myTable;  // Dùng để lưu bảng lấy từ c#
        SqlCommand myCommand;   // Thực hiện cách lệnh truy vấn

        // Phương thức hiển thị các thuộc tính bảng Độc Giả lên txt
        public string maDG, tenDG,email, ngaySinhDG, diaChiDG, loaiDG, NgLapThe;
        public Form1()
        {
            InitializeComponent();
           
            foreach (DataGridViewColumn col in dgvDSDocGia.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            dgvDSDocGia.EnableHeadersVisualStyles = false;
            
              
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
        // gán kích thước cho từng column
        private void setSizeCol()
        {
            dgvDSDocGia.Columns[0].Width = 80;
            dgvDSDocGia.Columns[1].Width = 210;
            dgvDSDocGia.Columns[2].Width = 110;
            dgvDSDocGia.Columns[3].Width = 120;
            dgvDSDocGia.Columns[4].Width = 130;
            dgvDSDocGia.Columns[5].Width = 230;
            dgvDSDocGia.Columns[6].Width = 120;
            dgvDSDocGia.Columns[7].Width = 120;
        }
        //check email
        public bool checkIsMail(string email)
        {
            string match = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            Regex reg = new Regex(match);
            return reg.IsMatch(email);
        }
        // lấy mã độc giả kế tiếp trước khi thêm 
        private string getNextIdDG()
        {
            string queryGetId = "SELECT TOP 1 MaDocGia FROM DOCGIA ORDER BY MaDocGia DESC";
            ketnoi(queryGetId);
            string fullID = Convert.ToString(myCommand.ExecuteScalar());
            int numberID = Convert.ToInt32(fullID.Substring(2));
            string strNumber = (++numberID).ToString();
            fullID = "DG" + strNumber.PadLeft(3, '0');
            return fullID;
        }    
        void loadDgv()
        {
            string cauTruyVan = "SELECT MaDocGia AS [Mã ĐG], HoTen AS [Tên ĐG], TenLoaiDocGia AS [Loại ĐG], NgSinh AS [Ngày Sinh], DChi AS [Địa Chỉ], Email AS [Email], NgLapThe AS [N.Lập Thẻ], NgHetHan AS [N.Hết Hạn], TongNo AS [Tổng Nợ] " +
               "FROM dbo.DOCGIA, dbo.LOAIDOCGIA " +
               "WHERE DOCGIA.MaLoaiDocGia = dbo.LOAIDOCGIA.MaLoaiDocGia";
            dgvDSDocGia.DataSource = ketnoi(cauTruyVan);
            dgvDSDocGia.AutoGenerateColumns = false;
            myConnection.Close();
        }    

        void setFormatDMY()
        {
            dgvDSDocGia.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDSDocGia.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDSDocGia.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
        string tranferFormatTextBox(string s)
        {
            DateTime temp;
            temp = Convert.ToDateTime(s);
            return temp.ToString("dd/MM/yyyy");
        }

        private void dgvDSDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbMaDG.Text = dgvDSDocGia.CurrentRow.Cells[0].Value.ToString();
            txbHoTen.Text = dgvDSDocGia.CurrentRow.Cells[1].Value.ToString();
            cbLoaiDG.Text = dgvDSDocGia.CurrentRow.Cells[2].Value.ToString();
            dtpNgSinh.Text = dgvDSDocGia.CurrentRow.Cells[3].Value.ToString();
            txbDChi.Text = dgvDSDocGia.CurrentRow.Cells[4].Value.ToString();
            txbEmail.Text = dgvDSDocGia.CurrentRow.Cells[5].Value.ToString();
            dtpNgLapThe.Text = dgvDSDocGia.CurrentRow.Cells[6].Value.ToString();
            txbNgayHetHan.Text = tranferFormatTextBox(dgvDSDocGia.CurrentRow.Cells[7].Value.ToString());
            txbTongNo.Text = dgvDSDocGia.CurrentRow.Cells[8].Value.ToString();
            errDC.Clear();
            errEmail.Clear();
            errLoaiDG.Clear();
            errTenDG.Clear();
            btnLuu.Enabled = false;
            btnThemMoi.Enabled = true;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = true;

        }

        void loadLoaiDG()
        {
            string cauTruyVan = "SELECT TenLoaiDocGia FROM LOAIDOCGIA";
            cbLoaiDG.DataSource = ketnoi(cauTruyVan);
            cbLoaiDG.DisplayMember = "TenLoaiDocGia";
            cbLoaiDG.SelectedIndex = -1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoaDG();
            
        }
        // Lưu
        public string SaveStringSQL(string pQuery)
        {
            myConnection = new SqlConnection(chuoiKetNoi);
            myConnection.Open();
            string thuchiencaulenh = pQuery;
            myCommand = new SqlCommand(thuchiencaulenh, myConnection);
            var SavedString = (string)myCommand.ExecuteScalar();

            //myConnection.Close();

            return SavedString;
        }
        private void themDG()
        {
            string queryMLDG = "SELECT MaLoaiDocGia FROM LOAIDOCGIA WHERE TenLoaiDocGia = N'" + cbLoaiDG.Text + "'";
            ketnoi(queryMLDG);
            string maLDG = Convert.ToString(myCommand.ExecuteScalar());

            try
            {
                
                string themdongsql = "INSERT INTO DOCGIA(HoTen, MaLoaiDocGia, NgSinh, DChi, Email, NgLapThe, TongNo)" +
                "VALUES (N'" + txbHoTen.Text + "', '" + maLDG + "', '" + dtpNgSinh.Value.Date.ToString("MM/dd/yyyy") + "', N'" + txbDChi.Text + "', '" + txbEmail.Text + "', '" + dtpNgLapThe.Value.Date.ToString("MM/dd/yyyy") + "', 0)";
                ketnoiNonQuery(themdongsql);
                MessageBox.Show("Thêm thành công.", "Thông Báo");
                loadDgv();
            }
            catch (Exception)
            {

            }
        }

        private void dtpNgLapThe_ValueChanged(object sender, EventArgs e)
        {
            string query = "SELECT ThoiHanThe FROM THAMSO ";
            ketnoi(query);
            int ThoiHanThe = Convert.ToInt32(myCommand.ExecuteScalar());
            DateTime ngLapThe = dtpNgLapThe.Value.Date;
            DateTime ngHetHan = ngLapThe.AddMonths(ThoiHanThe);
            txbNgayHetHan.Text = tranferFormatTextBox(ngHetHan.ToString());
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (txbMaDG.Text == "" || txbHoTen.Text == "" || txbNgayHetHan.Text == "" || dtpNgLapThe.Text == "" || dtpNgSinh.Text == "" || cbLoaiDG.Text == "" )
            {
                MessageBox.Show("vui lòng chọn 1 bộ dữ liệu bên dưới để tiến hành in");
            }
            else
            {
                e.Graphics.DrawString("Thẻ Độc Giả", new Font("Arial", 25, FontStyle.Bold), Brushes.Blue, new Point(320, 80));
                e.Graphics.DrawString(lbMaDG.Text + " " + txbMaDG.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(150, 190));
                e.Graphics.DrawString("....................................................................", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(332, 196));

                e.Graphics.DrawString(lbHoTen.Text + "      " + txbHoTen.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(150, 260));
                e.Graphics.DrawString(".......................................................................", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(300, 272));

                e.Graphics.DrawString(lbNgaySinh.Text + "    " + dtpNgSinh.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(150, 330));
                e.Graphics.DrawString(".....................................................................", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(315, 340));

                e.Graphics.DrawString(lbNgLapThe.Text + "            " + dtpNgLapThe.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(150, 400));
                e.Graphics.DrawString(".........................................................................", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(290, 410));

                e.Graphics.DrawString(lbNgHetHan.Text + "        " + txbNgayHetHan.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(150, 470));
                e.Graphics.DrawString(".......................................................................", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(290, 476));
                e.Graphics.DrawString("Độc giả", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(90, 700));
                e.Graphics.DrawString("(Ký ghi rõ họ tên)", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(105, 735));
                e.Graphics.DrawString("Người Lập thẻ", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(550, 700));
                e.Graphics.DrawString("(Ký ghi rõ họ tên)", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(565, 735));
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Height = this.Height;
            printPreviewDialog1.Width = this.Width;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            xuly = 1;
            {
                if (txbHoTen.Text == "")
                {
                    errTenDG.SetError(txbHoTen, "Vui lòng nhập Tên DG");
                }
                else
                {
                    errTenDG.Clear();
                }

                if (txbEmail.Text == "")
                {
                    errEmail.SetError(txbEmail, "Vui lòng nhập Email");
                }
                else
                {
                    errEmail.Clear();
                }
                if (!checkIsMail(txbEmail.Text))
                {
                    errEmail.SetError(txbEmail, "Vui lòng nhập Email");
                    MessageBox.Show("Vui lòng nhập đúng định dạng email!", "Thông báo");
                    return;
                }
                else
                {
                    errEmail.Clear();
                }
                if (txbDChi.Text == "")
                {
                    errDC.SetError(txbDChi, "Vui lòng nhập Địa chỉ");
                }
                else
                {
                    errDC.Clear();
                }

                if (cbLoaiDG.Text == "")
                {
                    errLoaiDG.SetError(cbLoaiDG, "Vui lòng nhập Loại ĐG");
                }
                else
                {
                    errLoaiDG.Clear();
                }
            }

            if (txbHoTen.Text.Length > 0 && txbDChi.Text.Length > 0 && txbEmail.Text.Length > 0 && dtpNgSinh.Text.Length > 0 && cbLoaiDG.Text.Length > 0 && dtpNgLapThe.Text.Length > 0)
            {
                string query = "SELECT TuoiToiThieu FROM THAMSO ";
                ketnoi(query);
                int tuoiMin = Convert.ToInt32(myCommand.ExecuteScalar());

                query = "SELECT TuoiToiDa FROM THAMSO";
                ketnoi(query);
                int tuoiMax = Convert.ToInt32(myCommand.ExecuteScalar());

                string[] nam = dtpNgSinh.Text.Split('/');
                int NamSinh = Convert.ToInt32(nam[2]);
                int tuoi = DateTime.Now.Year - NamSinh;

                if (tuoi < tuoiMin || tuoi > tuoiMax)
                {
                    MessageBox.Show("Số tuổi không hợp lệ!");
                    return;
                }

                
                if (xuly == 1)
                {
                    try
                    {
                        string queryMLDG = "SELECT MaLoaiDocGia FROM LOAIDOCGIA WHERE TenLoaiDocGia = N'" + cbLoaiDG.Text + "'";
                        ketnoi(queryMLDG);
                        string maLDG = Convert.ToString(myCommand.ExecuteScalar());
                        string capnhatdongsql;
                        capnhatdongsql = "UPDATE DOCGIA " +
                            "SET HoTen = N'" + txbHoTen.Text + "', MaLoaiDocGia = '" + maLDG + "', NgSinh = '" + dtpNgSinh.Value.Date.ToString("MM/dd/yyyy") + "', DChi = N'" + txbDChi.Text + "', Email = '" + txbEmail.Text + "', NgLapThe = '" + dtpNgLapThe.Value.Date.ToString("MM/dd/yyyy")+ "', TongNo = 0 " +
                            "WHERE MaDocGia = '" + txbMaDG.Text + "'";
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
                //setControls(false);
                dgvDSDocGia.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông Báo");
                if (txbHoTen.Text.Length == 0)
                    txbHoTen.Focus();
                else if (txbDChi.Text.Length == 0)
                    txbDChi.Focus();
                else if (txbEmail.Text.Length == 0)
                    txbEmail.Focus();

            }
        }

        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            xuly = 0;
            {
                if (txbHoTen.Text == "")
                {
                    errTenDG.SetError(txbHoTen, "Vui lòng nhập Tên DG");
                }
                else
                {
                    errTenDG.Clear();
                }

                if (txbEmail.Text == "")
                {
                    errEmail.SetError(txbEmail, "Vui lòng nhập Email");
                }
                else
                {
                    errEmail.Clear();
                }
                if(!checkIsMail(txbEmail.Text))
                {
                    errEmail.SetError(txbEmail, "Vui lòng nhập Email");
                    MessageBox.Show("Vui lòng nhập đúng định dạng email!", "Thông báo");
                    return;
                }    
                else
                {
                    errEmail.Clear();
                }

                if (txbDChi.Text == "")
                {
                    errDC.SetError(txbDChi, "Vui lòng nhập Địa chỉ");
                }
                else
                {
                    errDC.Clear();
                }

                if (cbLoaiDG.Text == "")
                {
                    errLoaiDG.SetError(cbLoaiDG, "Vui lòng nhập Loại ĐG");
                }
                else
                {
                    errLoaiDG.Clear();
                }
            }

            if ( txbHoTen.Text.Length > 0 && txbDChi.Text.Length > 0 && dtpNgSinh.Text.Length > 0 && cbLoaiDG.Text.Length > 0 && dtpNgLapThe.Text.Length > 0)
            {
                string query = "SELECT TuoiToiThieu FROM THAMSO ";
                ketnoi(query);
                int tuoiMin = Convert.ToInt32(myCommand.ExecuteScalar());

                query = "SELECT TuoiToiDa FROM THAMSO";
                ketnoi(query);
                int tuoiMax = Convert.ToInt32(myCommand.ExecuteScalar());

                string[] nam = dtpNgSinh.Text.Split('/');
                int NamSinh = Convert.ToInt32(nam[2]);
                int tuoi = DateTime.Now.Year - NamSinh;

                if (tuoi < tuoiMin || tuoi > tuoiMax)
                {
                    MessageBox.Show("Số tuổi không hợp lệ!");
                    return;
                }

                if (xuly == 0)
                {
                    themDG();
                    query = "SELECT TOP 1 MaDocGia FROM DOCGIA ORDER BY MaDocGia DESC ";
                    ketnoi(query);
                    txbMaDG.Text = Convert.ToString(myCommand.ExecuteScalar());
                    query = "SELECT NgHetHan FROM DOCGIA WHERE MaDocGia = '" + txbMaDG.Text + "'"; ;
                    ketnoi(query);
                    txbNgayHetHan.Text =  tranferFormatTextBox(Convert.ToString(myCommand.ExecuteScalar()));
                    txbTongNo.Text = "0.0000";
                }
               
                dgvDSDocGia.AutoGenerateColumns = false;
                 myConnection.Close();
                btnLuu.Enabled = false;
                btnThemMoi.Enabled = true;
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
                //setControls(false);
                dgvDSDocGia.Enabled = true;
                dgvDSDocGia.FirstDisplayedScrollingRowIndex = dgvDSDocGia.RowCount - 1;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông Báo");
                if (txbHoTen.Text.Length == 0)
                    txbHoTen.Focus();
                else if (txbDChi.Text.Length == 0)
                    txbDChi.Focus();
                else if (txbEmail.Text.Length == 0)
                    txbEmail.Focus();
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadDgv();
            dgvDSDocGia.Enabled = true;
            btnLuu.Enabled = true;
            btnThemMoi.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            txbTongNo.Text = "0.0000";
            txbMaDG.Text = getNextIdDG();
            dtpNgLapThe_ValueChanged(this, e);
            setFormatDMY();
            loadLoaiDG();
            setSizeCol();
            
            
        }
        // Phương thức thêm ĐG
        public int xuly;
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            errTenDG.Clear();
            errLoaiDG.Clear();
            errEmail.Clear();
            errDC.Clear();
            txbMaDG.Text = getNextIdDG();
            txbHoTen.Text = "";
            txbEmail.Text = "";
            txbDChi.Text = "";
            dtpNgSinh.Text = "";
            cbLoaiDG.SelectedItem = null;
            dtpNgLapThe.Text = "";
            txbNgayHetHan.Text = "";
            txbTongNo.Text = "0.0000";
            txbHoTen.Focus();
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            //btnThem.Enabled = false;
            btnLuu.Enabled = true;
            xuly = 0;
            dtpNgLapThe_ValueChanged(this, e);
        }
        // Phương thức xóa độc giả
        private void xoaDG()
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn xóa.", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    string xoadongsql = "DELETE FROM DOCGIA WHERE MaDocGia='" + txbMaDG.Text + "'";
                    ketnoiNonQuery(xoadongsql);
                    MessageBox.Show("Xóa thành công.", "Thông Báo");
                    btnLuu.Enabled = true;
                    btnXoa.Enabled = false;
                    btnThemMoi.Enabled = true;
                    btnCapNhat.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại.\nĐộc Giả này đang mượn sách.", "Thông Báo");
                }
            }
            loadDgv();
        }
    }
}
