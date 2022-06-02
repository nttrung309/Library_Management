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

namespace FormSach
{
    public partial class Form1 : Form
    {

        // Khai báo 
        string chuoiKetNoi = @"Data Source=LAPTOP-281DQ5C3\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True";
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
        private void setSizeCol()
        {
            dgvSach.Columns[0].Width = 80;
            dgvSach.Columns[1].Width = 105;
            dgvSach.Columns[2].Width = 250;
            dgvSach.Columns[3].Width = 170;
            dgvSach.Columns[4].Width = 70;
            dgvSach.Columns[5].Width = 200;
            dgvSach.Columns[6].Width = 60;
            dgvSach.Columns[7].Width = 140;


        }
        void loadDgv()
        {
            string cauTruyVan = "SELECT MaSach AS[Mã Sách], DAUSACH.MaDauSach AS [Mã ĐS], TenDauSach AS [Tên ĐS], STRING_AGG(TenTacGia, ', ') AS [Tác Giả], NamXuatBan AS [Năm XB], NhaXuatBan AS [Nhà XB], SoLuong AS [SL Tồn], TriGia AS [Giá Tiền]" +
                        " FROM TACGIA, CTTACGIA, DAUSACH, SACH" +
                        " WHERE TACGIA.MaTacGia = CTTACGIA.MaTacGia AND CTTACGIA.MaDauSach = DAUSACH.MaDauSach AND SACH.MaDauSach = DAUSACH.MaDauSach" +
                        " GROUP BY DAUSACH.TenDauSach, DAUSACH.MaDauSach, MaSach, NamXuatBan, NhaXuatBan, SoLuong, TriGia";
            dgvSach.DataSource = ketnoi(cauTruyVan);
            dgvSach.AutoGenerateColumns = false;
            myConnection.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            loadDgv();
            setSizeCol();
            dgvSach.Enabled = true;
            btnLuu.Enabled = true;
            btnThemMoi.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            txbMaSach.Text = getNextIdSach();
            txbSoLuongTon.Text = "0";
            loadMaDS();
            loadTenDS();
            cbMaDS.SelectedIndex = -1;
            cbTenSach.SelectedIndex = -1;

        }
        private string getNextIdSach()
        {
            string queryGetId = "SELECT TOP 1 MaSach FROM SACH ORDER BY MaSach DESC";
            ketnoi(queryGetId);
            string fullID = Convert.ToString(myCommand.ExecuteScalar());
            int numberID = Convert.ToInt32(fullID.Substring(2));
            string strNumber = (++numberID).ToString();
            fullID = "MS" + strNumber.PadLeft(3, '0');
            return fullID;
        }

        void loadMaDS()
        {
            string cauTruyVan = "SELECT MaDauSach FROM DAUSACH";
            cbMaDS.DataSource = ketnoi(cauTruyVan);
            cbMaDS.DisplayMember = "MaDauSach";
            cbMaDS.SelectedIndex = -1;
        }
        void loadTenDS()
        {
            string cauTruyVan = "SELECT TenDauSach FROM DAUSACH";
            cbTenSach.DataSource = ketnoi(cauTruyVan);
            cbTenSach.DisplayMember = "TenDauSach";
            cbTenSach.SelectedIndex = -1;
        }


        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            errMaDS.Clear();
            errNXB.Clear();
            errTenDS.Clear();
            errGiaTien.Clear();
            txbMaSach.Text = getNextIdSach();
            cbMaDS.SelectedIndex = -1;
            cbTenSach.SelectedIndex = -1;
            txbTenTG.Text = "";
            txbNhaXuatBan.Text = "";
            txbSoLuongTon.Text = "0";
            txbGiaTien.Text = "";
            dtpNamXuatBan.Text = "";
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;

        }
        
        private void themSach()
        {
            try
            {
                string query = "INSERT INTO SACH (MaDauSach, NhaXuatBan, NamXuatBan, SoLuong, TriGia) VALUES ('" + cbMaDS.Text + "', N'" + txbNhaXuatBan.Text + "', " + dtpNamXuatBan.Text + ", 0, " + txbGiaTien.Text + ")";
                ketnoiNonQuery(query);
                MessageBox.Show("Thêm thành công.", "Thông Báo");
                myConnection.Close();
            }
            catch
            {
            }
        }
        private void suaSach()
        {
            try
            {
                string capnhatdong;
                capnhatdong = "UPDATE  SACH SET MaDauSach = '" + cbMaDS.Text + "', NhaXuatBan = N'" + txbNhaXuatBan.Text + "', NamXuatBan = " + dtpNamXuatBan.Text + ", TriGia = " + txbGiaTien.Text +
                                "WHERE MaSach = '" + txbMaSach.Text + "'";
                ketnoiNonQuery(capnhatdong);
                MessageBox.Show("Sửa thành công.", "Thông Báo");
            }
            catch
            {
                MessageBox.Show("Sửa thất bại.\nVui lòng kiểm tra lại dữ liệu.", "Thông Báo");
            }
        }
        int xuly;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            int ck = 0;
            for (int i = 0; i < dgvSach.RowCount; i++)
            {

                if (cbMaDS.Text == dgvSach.Rows[i].Cells[1].Value.ToString() && txbNhaXuatBan.Text.ToUpper() == dgvSach.Rows[i].Cells[5].Value.ToString().ToUpper() &&
                    dtpNamXuatBan.Text == dgvSach.Rows[i].Cells[4].Value.ToString())
                {
                    ck = 1;
                }
            }
            if (ck == 0)
            {
                xuly = 0;
                if (cbMaDS.Text == "")
                {
                    errMaDS.SetError(cbMaDS, "Vui lòng nhập Mã Đầu Sách");
                }
                else
                {
                    errMaDS.Clear();
                }
                if (cbTenSach.Text == "")
                {
                    errTenDS.SetError(cbTenSach, "Vui lòng nhập Chủ Đề");
                }
                else
                {
                    errTenDS.Clear();
                }

                if (txbNhaXuatBan.Text == "")
                {
                    errNXB.SetError(txbNhaXuatBan, "Vui lòng nhập NXB");
                }
                else
                {
                    errNXB.Clear();
                }
                if (txbGiaTien.Text == "")
                {
                    errGiaTien.SetError(txbGiaTien, "Vui lòng nhập Năm XB");
                }
                else
                {
                    errGiaTien.Clear();
                }

                string query = "SELECT  ThoiGianLuuHanh FROM THAMSO";
                ketnoi(query);
                int tgXB = Convert.ToInt32(myCommand.ExecuteScalar());

                if (DateTime.Now.Year - Convert.ToInt32(dtpNamXuatBan.Text) > tgXB)
                {
                    MessageBox.Show("Chỉ nhận sách xuất bản trong vòng " + tgXB.ToString() + " năm!");
                    return;
                }


                float ktTriGia;
                bool isNumberTriGia = float.TryParse(txbGiaTien.Text, out ktTriGia);

                if (isNumberTriGia == false || ktTriGia <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số dương lớn hơn 0 trong ô:\nGiá Tiền.", "Thông Báo");
                    return;
                }
                if (cbMaDS.Text.Length > 0 && cbTenSach.Text.Length > 0 && txbTenTG.Text.Length > 0 && txbNhaXuatBan.Text.Length > 0 && txbGiaTien.Text.Length > 0 && isNumberTriGia == true && ktTriGia > 0)
                {
                    if (xuly == 0)
                    {
                        themSach();
                    }
                    else if (xuly == 1)
                    {
                        suaSach();

                    }
                    loadDgv();
                    dgvSach.AutoGenerateColumns = false;
                    myConnection.Close();
                    btnLuu.Enabled = false;
                    btnThemMoi.Enabled = true;
                    btnCapNhat.Enabled = true;
                    btnXoa.Enabled = true;
                    dgvSach.Enabled = true;
                    dgvSach.FirstDisplayedScrollingRowIndex = dgvSach.RowCount - 1;

                    errGiaTien.Clear();
                    errMaDS.Clear();
                    errNXB.Clear();
                    errTenDS.Clear();



                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông Báo");
                    if (cbMaDS.Text.Length == 0)
                        cbMaDS.Focus();
                    else if (cbTenSach.Text.Length == 0)
                        cbTenSach.Focus();
                    else if (txbNhaXuatBan.Text.Length == 0)
                        txbNhaXuatBan.Focus();
                    else if (txbGiaTien.Text.Length == 0)
                        txbGiaTien.Focus();

                }
            } 
            else { MessageBox.Show("Phiên bản sách này đã có trong thư viện, bạn không thể lưu mới"); }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int ck = 0;
            for (int i = 0; i < dgvSach.RowCount; i++)
            {

                if (cbMaDS.Text == dgvSach.Rows[i].Cells[1].Value.ToString() && txbNhaXuatBan.Text.ToUpper() == dgvSach.Rows[i].Cells[5].Value.ToString().ToUpper() &&
                    dtpNamXuatBan.Text == dgvSach.Rows[i].Cells[4].Value.ToString())
                {
                    ck = 1;
                }
            }
            if (ck == 0)
            {
                xuly = 1;
                if (cbMaDS.Text == "")
                {
                    errMaDS.SetError(cbMaDS, "Vui lòng nhập Mã Đầu Sách");
                }
                else
                {
                    errMaDS.Clear();
                }
                if (cbTenSach.Text == "")
                {
                    errTenDS.SetError(cbTenSach, "Vui lòng nhập Chủ Đề");
                }
                else
                {
                    errTenDS.Clear();
                }

                if (txbNhaXuatBan.Text.Length == 0)
                {
                    errNXB.SetError(txbNhaXuatBan, "Vui lòng nhập NXB");
                }
                else
                {
                    errNXB.Clear();
                }
                if (txbGiaTien.Text == "")
                {
                    errGiaTien.SetError(txbGiaTien, "Vui lòng nhập Năm XB");
                }
                else
                {
                    errGiaTien.Clear();
                }

                string query = "SELECT  ThoiGianLuuHanh FROM THAMSO";
                ketnoi(query);
                int tgXB = Convert.ToInt32(myCommand.ExecuteScalar());

                if (DateTime.Now.Year - Convert.ToInt32(dtpNamXuatBan.Text) > tgXB)
                {
                    MessageBox.Show("Chỉ nhận sách xuất bản trong vòng " +tgXB.ToString() + " năm!");
                    return;
                }


                float ktTriGia;
                bool isNumberTriGia = float.TryParse(txbGiaTien.Text, out ktTriGia);

                if (isNumberTriGia == false || ktTriGia <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số dương lớn hơn 0 trong ô:\nGiá Tiền.", "Thông Báo");
                    return;
                }
                if (cbMaDS.Text.Length > 0 && cbTenSach.Text.Length > 0 && txbTenTG.Text.Length > 0 && txbNhaXuatBan.Text.Length > 0 && txbGiaTien.Text.Length > 0 && isNumberTriGia == true && ktTriGia > 0)
                {
                    if (xuly == 0)
                    {
                        themSach();
                    }
                    else if (xuly == 1)
                    {
                        suaSach();

                    }
                    loadDgv();
                    dgvSach.AutoGenerateColumns = false;
                    myConnection.Close();
                    btnLuu.Enabled = false;
                    btnThemMoi.Enabled = true;
                    btnCapNhat.Enabled = true;
                    btnXoa.Enabled = true;
                    dgvSach.Enabled = true;
                    dgvSach.FirstDisplayedScrollingRowIndex = dgvSach.RowCount - 1;

                    errGiaTien.Clear();
                    errMaDS.Clear();
                    errNXB.Clear();
                    errTenDS.Clear();


                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông Báo");
                    if (cbMaDS.Text.Length == 0)
                        cbMaDS.Focus();
                    else if (cbTenSach.Text.Length == 0)
                        cbTenSach.Focus();
                    else if (txbNhaXuatBan.Text.Length == 0)
                        txbNhaXuatBan.Focus();
                    else if (txbGiaTien.Text.Length == 0)
                        txbGiaTien.Focus();

                }
            }
            else
                MessageBox.Show("Phiên bản sách này đã có trong thư viện, bạn không thể cập nhật");


        }


        // Phương thức xóa sachs
        private void xoaSach()
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn xóa.", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    string xoadongSql;
                    xoadongSql = "DELETE FROM SACH WHERE MaSach = '" + txbMaSach.Text + "'";
                    ketnoiNonQuery(xoadongSql);
                    MessageBox.Show("Xóa thành công.", "Thông Báo");
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại.\nTrong thư viện, hiện đang có cuốn sách này.", "Thông Báo");
                }
            }
            loadDgv();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoaSach();
            errMaDS.Clear();
            errGiaTien.Clear();
            errNXB.Clear();
            errTenDS.Clear();
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            errMaDS.Clear();
            errGiaTien.Clear();
            errNXB.Clear();
            errTenDS.Clear();
            txbMaSach.Text = dgvSach.CurrentRow.Cells[0].Value.ToString();
            cbMaDS.Text = dgvSach.CurrentRow.Cells[1].Value.ToString();
            cbTenSach.Text = dgvSach.CurrentRow.Cells[2].Value.ToString();
            txbTenTG.Text = dgvSach.CurrentRow.Cells[3].Value.ToString();
            dtpNamXuatBan.Value = DateTime.ParseExact(dgvSach.CurrentRow.Cells[4].Value.ToString(),"yyyy", System.Globalization.CultureInfo.InvariantCulture);
            txbNhaXuatBan.Text = dgvSach.CurrentRow.Cells[5].Value.ToString();
            txbSoLuongTon.Text = dgvSach.CurrentRow.Cells[6].Value.ToString();
            txbGiaTien.Text = dgvSach.CurrentRow.Cells[7].Value.ToString();
            errMaDS.Clear();
            btnLuu.Enabled = false;
            btnThemMoi.Enabled = true;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = true;
        }

        private void cbMaDS_SelectedValueChanged(object sender, EventArgs e)
        {
            string cauTruyVan = "SELECT TenDauSach FROM DAUSACH WHERE MaDauSach = '" + this.cbMaDS.GetItemText(this.cbMaDS.SelectedItem) + "'";
            ketnoi(cauTruyVan);
            string tenDS = Convert.ToString(myCommand.ExecuteScalar());
            cbTenSach.Text = tenDS;
            cauTruyVan = "SELECT STRING_AGG(TenTacGia, ', ') AS TenTG FROM TACGIA, CTTACGIA, DAUSACH WHERE DAUSACH.MaDauSach = CTTACGIA.MaDauSach  AND TACGIA.MaTacGia = CTTACGIA.MaTacGia AND DAUSACH.MaDauSach = '" + this.cbMaDS.GetItemText(this.cbMaDS.SelectedItem) + "'";
            ketnoi(cauTruyVan);
            string tenTG = Convert.ToString(myCommand.ExecuteScalar());
            txbTenTG.Text = tenTG;

        }

        private void cbTenSach_SelectedValueChanged(object sender, EventArgs e)
        {
            string cauTruyVan = "SELECT MaDauSach FROM DAUSACH WHERE TenDauSach = N'" + this.cbTenSach.GetItemText(this.cbTenSach.SelectedItem) + "'";
            ketnoi(cauTruyVan);
            string maDS = Convert.ToString(myCommand.ExecuteScalar());
            cbMaDS.Text = maDS;
            
           cbMaDS_SelectedValueChanged(this, e);
        }

        private void txbTenTG_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txbMaSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txbSoLuongTon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
