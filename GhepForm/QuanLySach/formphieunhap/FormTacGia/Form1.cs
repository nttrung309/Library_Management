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

namespace FormNhapSach
{
    public partial class Form1 : Form
    {
        // Khai báo 
        string chuoiKetNoi = @"Data Source=LAPTOP-281DQ5C3\SQLEXPRESS;Initial Catalog=QLTV_re;Integrated Security=True";
        private SqlConnection myConnection; // kết nối tới csdl
        private SqlDataAdapter myDataAdapter;   // Vận chuyển csdl qa DataSet
        private DataTable myTable;  // Dùng để lưu bảng lấy từ c#
        SqlCommand myCommand;   // Thực hiện cách lệnh truy vấn Khai báo 

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
        void loadDgv()
        {
            string cauTruyVan = "SELECT MaPhieuNhapSach AS [Mã Phiếu Nhập Sách], NgLap AS [Ngày Lập], TongTien AS [Tổng tiền] FROM PHIEUNHAPSACH ";
            dgvPhieuNhap.DataSource = ketnoi(cauTruyVan);
            dgvPhieuNhap.AutoGenerateColumns = false;
            myConnection.Close();
        }
        private string getNextId()
        {
            string queryGetId = "SELECT TOP 1 MaPhieuNhapSach FROM PHIEUNHAPSACH ORDER BY MaPhieuNhapSach DESC";
            ketnoi(queryGetId);
            string fullID = Convert.ToString(myCommand.ExecuteScalar());
            int numberID = Convert.ToInt32(fullID.Substring(4));
            string strNumber = (++numberID).ToString();
            fullID = "MPNS" + strNumber.PadLeft(3, '0');
            return fullID;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            loadDgv();
            dgvPhieuNhap.Enabled = true;
            btnLuu.Enabled = true;
            btnThemMoi.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            txbTongTien.Text = "0.0000";
            dtp_NgayNhap.Text = "";
            txbMaPhieuNhap.Text = getNextId();
            dgvPhieuNhap.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void dgvTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbMaPhieuNhap.Text = dgvPhieuNhap.CurrentRow.Cells[0].Value.ToString();
            dtp_NgayNhap.Text = dgvPhieuNhap.CurrentRow.Cells[1].Value.ToString();
            txbTongTien.Text = dgvPhieuNhap.CurrentRow.Cells[2].Value.ToString();
            btnLuu.Enabled = false;
            btnThemMoi.Enabled = true;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = true;
        }
  

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txbMaPhieuNhap.Text = getNextId();
            txbTongTien.Text = "0.0000";
            dtp_NgayNhap.Text = "";
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }
        private void themPhieuNS()
        {
            try
            {
                string themdongsql = "INSERT INTO PHIEUNHAPSACH(NgLap)" +
                "VALUES ('" + dtp_NgayNhap.Value.Date.ToString("MM/dd/yyyy") + "')";
                ketnoiNonQuery(themdongsql);
                loadDgv();
            }
            catch (Exception)
            {

            }
        }

        int xuly;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            xuly = 0;

                string query = null;
                if (xuly == 0)
                {
                    themPhieuNS();
                    query = "SELECT TOP 1 MaPhieuNhapSach FROM PHIEUNHAPSACH ORDER BY MaPhieuNhapSach DESC ";
                    ketnoi(query);
                    txbMaPhieuNhap.Text = Convert.ToString(myCommand.ExecuteScalar());
                }

                dgvPhieuNhap.AutoGenerateColumns = false;
                myConnection.Close();
                btnLuu.Enabled = false;
                btnThemMoi.Enabled = true;
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
                dgvPhieuNhap.Enabled = true;
                dgvPhieuNhap.FirstDisplayedScrollingRowIndex = dgvPhieuNhap.RowCount - 1;
            query = "DROP TABLE IF EXISTS MAPN CREATE TABLE MAPN(MaPhieuNhap VARCHAR(50)) INSERT INTO MAPN VALUES ('" + txbMaPhieuNhap.Text + "')";
            ketnoiNonQuery(query);
            formCTPN ne = new formCTPN();
            ne.Show();
            ne.FormClosed += (formCTPN_FormClosed);


        }

        private void formCTPN_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadDgv();
            for (int i=0;i<dgvPhieuNhap.RowCount;i++)
            {
                if (dgvPhieuNhap.Rows[i].Cells[0].Value.ToString()==txbMaPhieuNhap.Text)
                {
                    txbTongTien.Text = dgvPhieuNhap.Rows[i].Cells[2].Value.ToString();
                    break;
                }    
            }    
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
         
            /*xuly = 1;
           
                    try
                    {
                        string capnhatdongsql;
                        capnhatdongsql = "UPDATE PHIEUNHAPSACH " +
                            "SET NgLap = '" + dtp_NgayNhap.Value.Date.ToString("MM/dd/yyyy") + "'" +
                            "WHERE MaPhieuNhapSach = '" + txbMaPhieuNhap.Text + "'";
                        ketnoi(capnhatdongsql);
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show("Sửa thành công.", "Thông Báo");
                        loadDgv();
                    }
                    catch
                    {
                        MessageBox.Show("Sửa thất bại.\nVui lòng kiểm tra lại dữ liệu.", "Thông Báo");
                    }
                */
            btnLuu.Enabled = false;
                btnThemMoi.Enabled = true;
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
                dgvPhieuNhap.Enabled = true;
            string query = "DROP TABLE IF EXISTS MAPN CREATE TABLE MAPN(MaPhieuNhap VARCHAR(50)) INSERT INTO MAPN VALUES ('" + txbMaPhieuNhap.Text + "')";
            ketnoiNonQuery(query);
            formCTPN ne = new formCTPN();
            ne.Show();
            ne.FormClosed += (formCTPN_FormClosed);

        }
        // Phương thức xóa tác giả
        private void xoaPhieuNhap()
        {

        DialogResult dlr;
        dlr = MessageBox.Show("Bạn chắc chắn muốn xóa.", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (dlr == DialogResult.Yes)
        {
            try
            {
                    string xoadongsql = "IF EXISTS ( SELECT * FROM CT_PHIEUNHAP WHERE MaPhieuNhapSach = '" + txbMaPhieuNhap.Text + "') BEGIN SELECT 1 END ELSE BEGIN SELECT 2 END";
                    ketnoiNonQuery(xoadongsql);
                    int xoa = Convert.ToInt32(myCommand.ExecuteScalar());
                    if (xoa == 2)
                    {

                        xoadongsql = "DELETE FROM PHIEUNHAPSACH WHERE MaPhieuNhapSach='" + txbMaPhieuNhap.Text + "'";
                        ketnoiNonQuery(xoadongsql);
                        MessageBox.Show("Xóa thành công.", "Thông Báo");
                        btnLuu.Enabled = true;
                        btnXoa.Enabled = false;
                        btnThemMoi.Enabled = true;
                        btnCapNhat.Enabled = false;
                    }
                    else
                        MessageBox.Show("Đã có chi tiết phiếu nhập trong phiếu nhập trên!", "Thông báo");

            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại.\nHiện vẫn còn thông tin chi tiết phiếu nhập của phiếu nhập này.", "Thông Báo");
            }
        }
        loadDgv();
    }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoaPhieuNhap();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formCTPN ne = new formCTPN();
            ne.Show();
        }
    }
}
