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

namespace formdausach
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
        DataTable dt = new DataTable();
         
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
            string cauTruyVan = "SELECT MaDauSach AS [Mã ĐS], TenDauSach AS [Tên Đầu Sách], DAUSACH.MaTheLoai AS [Mã Thể Loại], TenTheLoai AS [Thể Loại]" +
               "FROM DAUSACH, THELOAI WHERE DAUSACH.MaTheLoai = THELOAI.MaTheLoai ";
            dgvDauSach.DataSource = ketnoi(cauTruyVan);
            dgvDauSach.AutoGenerateColumns = false;
            myConnection.Close();
        }
        void loadMaTheLoai()
        {
            string cauTruyVan = "SELECT MaTheLoai FROM THELOAI";
            cbMaTL.DataSource = ketnoi(cauTruyVan);
            cbMaTL.DisplayMember = "MaTheLoai";
            cbMaTL.SelectedIndex = -1;
        }
        void loadTenTheLoai()
        {
            string cauTruyVan = "SELECT TenTheLoai FROM THELOAI";
            cbTenTL.DataSource = ketnoi(cauTruyVan);
            cbTenTL.DisplayMember = "TenTheLoai";
            cbTenTL.SelectedIndex = -1;
        }
        void loadTenTG()
        {
            string cauTruyVan = "SELECT TenTacGia, MaTacGia FROM TACGIA";
            cbTacGia.DataSource = ketnoi(cauTruyVan);
            cbTacGia.DisplayMember = "TenTacGia";
            cbTacGia.ValueMember = "MaTacGia";
            cbTacGia.SelectedIndex = -1;
        }
        void setSizeCol()
        {
            dgvDauSach.Columns[0].Width = 60;
            dgvDauSach.Columns[1].Width = 200;
            dgvDauSach.Columns[2].Width = 80;
            dgvDauSach.Columns[3].Width = 200;
        }
        private string getNextIdDS()
        {
            string queryGetId = "SELECT TOP 1 MaDauSach FROM DAUSACH ORDER BY MaDauSach DESC";
            ketnoi(queryGetId);
            string fullID = Convert.ToString(myCommand.ExecuteScalar());
            int numberID = Convert.ToInt32(fullID.Substring(3));
            string strNumber = (++numberID).ToString();
            fullID = "MDS" + strNumber.PadLeft(3, '0');
            return fullID;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadDgv();
            loadMaTheLoai();
            loadTenTheLoai();
            setSizeCol();
            loadTenTG();
            //label2.Text = "Tác Giả \n Của Sách:";
            dt.Columns.Add("MaTacGia");
            cbTenTL.SelectedIndex = -1;
            cbMaTL.SelectedIndex = -1;
            dgvDauSach.Enabled = true;
            btnLuu.Enabled = true;
            btnThemMoi.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            txb_MaDauSach.Text = getNextIdDS();
        }

        private void dgvDauSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbxTacGia.DataSource = null;
            lbxTacGia.Items.Clear();
            txb_MaDauSach.Text = dgvDauSach.CurrentRow.Cells[0].Value.ToString();
            txb_TenDauSach.Text = dgvDauSach.CurrentRow.Cells[1].Value.ToString();
            cbMaTL.Text = dgvDauSach.CurrentRow.Cells[2].Value.ToString();
            cbTenTL.Text = dgvDauSach.CurrentRow.Cells[3].Value.ToString();
            string cauTruyVan = "SELECT TacGia.MaTacGia AS [MaTacGia], TenTacGia " +
                                "FROM DAUSACH, TACGIA, CTTACGIA " +
                                "WHERE DAUSACH.MaDauSach = CTTACGIA.MaDauSach AND "+
                                "CTTACGIA.MaTacGia = TACGIA.MaTacGia AND "+
                                "CTTACGIA.MaDauSach = '" + txb_MaDauSach.Text + "'";
            ketnoi(cauTruyVan);
            cbTacGia.SelectedIndex = -1;
            dt.Clear();
            myDataAdapter.Fill(dt);
            for(int i =0; i< dt.Rows.Count; i++)
            {
                lbxTacGia.Items.Add(dt.Rows[i].ItemArray[1].ToString());
            }    
            errMaTL.Clear();
            errTenTL.Clear();
            errTenDS.Clear();
            errTacGia.Clear();
            btnLuu.Enabled = false;
            btnThemMoi.Enabled = true;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = true;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            errMaTL.Clear();
            errTenDS.Clear();
            errTenTL.Clear();
            errTacGia.Clear();
            loadTenTG();
            loadMaTheLoai();
            loadTenTheLoai();
            lbxTacGia.DataSource = null;
            lbxTacGia.Items.Clear();
            txb_MaDauSach.Text = getNextIdDS();
            cbMaTL.SelectedIndex = -1;
            cbTenTL.SelectedIndex = -1;
            txb_TenDauSach.Text = "";
            txb_TenDauSach.Focus();
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }
        private void themDauSach()
        {
            try
            {

                string themdongsql = "INSERT INTO DAUSACH(TenDauSach, MaTheLoai)" +
                "VALUES (N'" + txb_TenDauSach.Text + "', '" + cbMaTL.Text + "')";
                ketnoiNonQuery(themdongsql);
                MessageBox.Show("Thêm thành công.", "Thông Báo");
                loadDgv();
            }
            catch (Exception)
            {

            }
        }
        private void xoaCTTacGia(string maDS)
        {
            string nonquery = "DELETE FROM CTTACGIA WHERE MaDauSach = '" + maDS + "'";
            ketnoiNonQuery(nonquery);

        }
        private void ThemCTTacGia(string maDS, string maTG)
        {
            string nonquery = "INSERT INTO CTTacGia(MaDauSach, MaTacGia) VALUES ('" + maDS + "', '" + maTG + "')";
            ketnoiNonQuery(nonquery);
        }
        public int xuly;

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int ck = 0;
            for (int i = 0; i < dgvDauSach.RowCount; i++)
            {

                if (txb_TenDauSach.Text.ToUpper() == dgvDauSach.Rows[i].Cells[1].Value.ToString().ToUpper())
                {
                    ck = 1;
                }
            }
            if (ck == 0)
            {
                xuly = 0;
                {
                    if (txb_TenDauSach.Text == "")
                    {
                        errTenDS.SetError(txb_TenDauSach, "Vui lòng nhập Tên Đầu Sách");
                    }
                    else
                    {
                        errTenDS.Clear();
                    }
                    if (cbMaTL.Text == "")
                    {
                        errMaTL.SetError(cbMaTL, "Vui lòng chọn Mã Thể Loại Sách");
                    }
                    else
                    {
                        errMaTL.Clear();
                    }
                    if (cbTenTL.Text == "")
                    {
                        errTenTL.SetError(cbTenTL, "Vui lòng chọn Tên Thể Loại Sách");
                    }
                    else
                    {
                        errTenTL.Clear();
                    }
                    if (lbxTacGia.Items.Count == 0)
                    {
                        errTacGia.SetError(lbxTacGia, "Vui lòng chọn tác giả cho sách");
                    }
                    else
                    {
                        errTacGia.Clear();
                    }

                }

                if (txb_TenDauSach.Text.Length > 0 && cbMaTL.Text.Length > 0 && cbTenTL.Text.Length > 0 && lbxTacGia.Items.Count > 0)
                {
                    string query = null;
                    if (xuly == 0)
                    {
                        themDauSach();
                        query = "SELECT TOP 1 MaDauSach FROM DAUSACH ORDER BY MaDauSach DESC ";
                        ketnoi(query);
                        txb_MaDauSach.Text = Convert.ToString(myCommand.ExecuteScalar());
                        for (int i = 0; i < lbxTacGia.Items.Count; i++)
                        {
                            ThemCTTacGia(txb_MaDauSach.Text, dt.Rows[i].ItemArray[0].ToString());
                        }
                    }

                    dgvDauSach.AutoGenerateColumns = false;
                    myConnection.Close();
                    btnLuu.Enabled = false;
                    btnThemMoi.Enabled = true;
                    btnCapNhat.Enabled = true;
                    btnXoa.Enabled = true;
                    dgvDauSach.Enabled = true;
                    dgvDauSach.FirstDisplayedScrollingRowIndex = dgvDauSach.RowCount - 1;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông Báo");
                    if (txb_TenDauSach.Text.Length == 0)
                        txb_TenDauSach.Focus();
                }
            }
            else MessageBox.Show("Tên đầu sách đã có, bạn không thể lưu mới");
        }
        // Phương thức xóa đầu sách
        private void xoaDauSach()
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn xóa.", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    //string xoadongsql = "DELETE FROM DAUSACH WHERE MaDauSach = '" + txb_MaDauSach.Text + "'";
                    string xoadongsql = "IF EXISTS(SELECT * FROM SACH WHERE MaDauSach = '" +txb_MaDauSach.Text + "' AND SoLuong > 0) " +
                                         "BEGIN SELECT 1 END ELSE BEGIN SELECT 2 END";
                    ketnoi(xoadongsql);
                    int number = Convert.ToInt32(myCommand.ExecuteScalar());
                    if (number == 1)
                    {
                        MessageBox.Show("Xóa thất bại.\nTrong thư viện, hiện đang có sách của đầu sách này.", "Thông Báo");
                    }
                    else
                    {
                        xoadongsql = "DELETE FROM CTTACGIA WHERE MaDauSach = '" + txb_MaDauSach.Text + "'";
                        ketnoiNonQuery(xoadongsql);
                        xoadongsql = "DELETE FROM SACH WHERE MaDauSach = '" + txb_MaDauSach.Text + "'";
                        ketnoiNonQuery(xoadongsql);
                        xoadongsql = "DELETE FROM DAUSACH WHERE MaDauSach = '" + txb_MaDauSach.Text + "'";
                        ketnoiNonQuery(xoadongsql);
                        MessageBox.Show("Xóa thành công.", "Thông Báo");
                        btnLuu.Enabled = true;
                        btnXoa.Enabled = false;
                        btnThemMoi.Enabled = true;
                        btnCapNhat.Enabled = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại.\nTrong thư viện, hiện đang có sách của đầu sách này.", "Thông Báo");
                }
            }
            loadDgv();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoaDauSach();
            errMaTL.Clear();
            errTenDS.Clear();
            errTenTL.Clear();
        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            int ck = 0;
            for (int i = 0; i < dgvDauSach.RowCount; i++)
            {

                if (txb_TenDauSach.Text.ToUpper() == dgvDauSach.Rows[i].Cells[1].Value.ToString().ToUpper()&&txb_MaDauSach.Text!=dgvDauSach.Rows[i].Cells[0].Value.ToString())
                {
                    ck=1 ;
                }
            }
            if (ck == 0)
            {
                xuly = 1;
                {
                    if (txb_TenDauSach.Text == "")
                    {
                        errTenDS.SetError(txb_TenDauSach, "Vui lòng nhập Tên Đầu Sách");
                    }
                    else
                    {
                        errTenDS.Clear();
                    }
                    if (cbMaTL.Text == "")
                    {
                        errMaTL.SetError(cbMaTL, "Vui lòng chọn Mã Thể Loại Sách");
                    }
                    else
                    {
                        errMaTL.Clear();
                    }
                    if (lbxTacGia.Items.Count == 0)
                    {
                        errTacGia.SetError(lbxTacGia, "Vui lòng chọn tác giả cho sách");
                    }
                    else
                    {
                        errTacGia.Clear();
                    }
                    if (cbTenTL.Text == "")
                    {
                        errTenTL.SetError(cbTenTL, "Vui lòng chọn Tên Thể Loại Sách");
                    }
                    else
                    {
                        errTenTL.Clear();
                    }
                }

                if (txb_TenDauSach.Text.Length > 0 && cbMaTL.Text.Length > 0 && cbTenTL.Text.Length > 0 && lbxTacGia.Items.Count > 0)
                {
                    if (xuly == 1)
                    {
                        try
                        {
                            xoaCTTacGia(txb_MaDauSach.Text);
                            string capnhatdongsql;
                            capnhatdongsql = "UPDATE DAUSACH " +
                                "SET TenDauSach = N'" + txb_TenDauSach.Text + "', MaTheLoai = '" + cbMaTL.Text + "'" +
                                "WHERE MaDauSach = '" + txb_MaDauSach.Text + "'";
                            ketnoi(capnhatdongsql);
                            myCommand.ExecuteNonQuery();
                            for (int i = 0; i < lbxTacGia.Items.Count; i++)
                            {
                                ThemCTTacGia(txb_MaDauSach.Text, dt.Rows[i].ItemArray[0].ToString());
                            }
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
                    dgvDauSach.Enabled = true;
                }

                else
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông Báo");
                    if (txb_TenDauSach.Text.Length == 0)
                        txb_TenDauSach.Focus();
                }
            }
            else
                MessageBox.Show("Tên đầu sách đã có, bạn không thể cập nhật");
            
            

        }

        private void cbMaTL_SelectedValueChanged(object sender, EventArgs e)
        {
            string cauTruyVan = "SELECT TenTheLoai FROM THELOAI WHERE MaTheLoai = '" + this.cbMaTL.GetItemText(this.cbMaTL.SelectedItem) + "'";
            ketnoi(cauTruyVan);
            string tenTL = Convert.ToString(myCommand.ExecuteScalar());
            cbTenTL.Text = tenTL;
        }

        private void cbTenTL_SelectedValueChanged(object sender, EventArgs e)
        {
            string cauTruyVan = "SELECT MaTheLoai FROM THELOAI WHERE TenTheLoai = N'" + this.cbTenTL.GetItemText(this.cbTenTL.SelectedItem) + "'";
            ketnoi(cauTruyVan);
            string maTL = Convert.ToString(myCommand.ExecuteScalar());
            cbMaTL.Text = maTL;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (cbTacGia.Text != "")
            {
                if (lbxTacGia.Items.Count == 0)
                {
                    lbxTacGia.Items.Add(cbTacGia.Text);
                    dt.Rows.Add(cbTacGia.SelectedValue.ToString());
                    cbTacGia.SelectedIndex = -1;
                }
                else
                {
                    for (int i = 0; i < lbxTacGia.Items.Count; i++)
                    {
                        if (lbxTacGia.Items[i].ToString() == cbTacGia.Text)
                        {
                            MessageBox.Show(string.Format("{0} đã có!", cbTacGia.Text));
                            return;
                        }

                    }
                    dt.Rows.Add(cbTacGia.SelectedValue.ToString());
                    lbxTacGia.Items.Add(cbTacGia.Text);
                    cbTacGia.SelectedIndex = -1;
                }
            }
            else
                MessageBox.Show("Vui lòng chọn tác giả trước");

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (lbxTacGia.SelectedIndex >= 0)
            {
                
                dt.Rows.RemoveAt(lbxTacGia.SelectedIndex);
                lbxTacGia.Items.RemoveAt(lbxTacGia.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tác giả bên dưới!", "Thông báo");
            }
            
        }

        
    }
}
