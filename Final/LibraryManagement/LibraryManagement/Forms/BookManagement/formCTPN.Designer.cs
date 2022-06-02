
namespace FormNhapSach
{
   partial class formCTPN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_ThongtinPN = new System.Windows.Forms.Label();
            this.gb_CTpNhap = new System.Windows.Forms.GroupBox();
            this.cbMaPN = new System.Windows.Forms.TextBox();
            this.cbMaSach = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbThanhTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTenTG = new System.Windows.Forms.TextBox();
            this.txbNamXB = new System.Windows.Forms.TextBox();
            this.txbNhaXB = new System.Windows.Forms.TextBox();
            this.cbTenSach = new System.Windows.Forms.ComboBox();
            this.btnXoa = new FormNhapSach.VBButton();
            this.btnCapNhat = new FormNhapSach.VBButton();
            this.btnLuu = new FormNhapSach.VBButton();
            this.btnThemMoi = new FormNhapSach.VBButton();
            this.txbDonGia = new System.Windows.Forms.TextBox();
            this.txbMaCTPN = new System.Windows.Forms.TextBox();
            this.txbSoLuong = new System.Windows.Forms.TextBox();
            this.lb_DonGia = new System.Windows.Forms.Label();
            this.lb_SoLuong = new System.Windows.Forms.Label();
            this.lb_NamXB = new System.Windows.Forms.Label();
            this.lb_NhaXB = new System.Windows.Forms.Label();
            this.lb_TenTacGia = new System.Windows.Forms.Label();
            this.lb_TenCuonSach = new System.Windows.Forms.Label();
            this.lb_maPN = new System.Windows.Forms.Label();
            this.lb_MaCTPN = new System.Windows.Forms.Label();
            this.lb_CTPhieuNhap = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errMaPN = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTenDS = new System.Windows.Forms.ErrorProvider(this.components);
            this.errSoLuong = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDonGia = new System.Windows.Forms.ErrorProvider(this.components);
            this.nButton1 = new ThayDoiQuyDinh.nButton();
            this.dgvCTPhieuNS = new System.Windows.Forms.DataGridView();
            this.gb_CTpNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMaPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPhieuNS)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_ThongtinPN
            // 
            this.lb_ThongtinPN.AutoSize = true;
            this.lb_ThongtinPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThongtinPN.ForeColor = System.Drawing.Color.Chocolate;
            this.lb_ThongtinPN.Location = new System.Drawing.Point(356, 379);
            this.lb_ThongtinPN.Name = "lb_ThongtinPN";
            this.lb_ThongtinPN.Size = new System.Drawing.Size(553, 32);
            this.lb_ThongtinPN.TabIndex = 15;
            this.lb_ThongtinPN.Text = "Danh Sách Thông Tin Phiếu Nhập Sách";
            this.lb_ThongtinPN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gb_CTpNhap
            // 
            this.gb_CTpNhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gb_CTpNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gb_CTpNhap.Controls.Add(this.cbMaPN);
            this.gb_CTpNhap.Controls.Add(this.cbMaSach);
            this.gb_CTpNhap.Controls.Add(this.label3);
            this.gb_CTpNhap.Controls.Add(this.txbThanhTien);
            this.gb_CTpNhap.Controls.Add(this.label1);
            this.gb_CTpNhap.Controls.Add(this.txbTenTG);
            this.gb_CTpNhap.Controls.Add(this.txbNamXB);
            this.gb_CTpNhap.Controls.Add(this.txbNhaXB);
            this.gb_CTpNhap.Controls.Add(this.cbTenSach);
            this.gb_CTpNhap.Controls.Add(this.btnXoa);
            this.gb_CTpNhap.Controls.Add(this.btnCapNhat);
            this.gb_CTpNhap.Controls.Add(this.btnLuu);
            this.gb_CTpNhap.Controls.Add(this.btnThemMoi);
            this.gb_CTpNhap.Controls.Add(this.txbDonGia);
            this.gb_CTpNhap.Controls.Add(this.txbMaCTPN);
            this.gb_CTpNhap.Controls.Add(this.txbSoLuong);
            this.gb_CTpNhap.Controls.Add(this.lb_DonGia);
            this.gb_CTpNhap.Controls.Add(this.lb_SoLuong);
            this.gb_CTpNhap.Controls.Add(this.lb_NamXB);
            this.gb_CTpNhap.Controls.Add(this.lb_NhaXB);
            this.gb_CTpNhap.Controls.Add(this.lb_TenTacGia);
            this.gb_CTpNhap.Controls.Add(this.lb_TenCuonSach);
            this.gb_CTpNhap.Controls.Add(this.lb_maPN);
            this.gb_CTpNhap.Controls.Add(this.lb_MaCTPN);
            this.gb_CTpNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_CTpNhap.ForeColor = System.Drawing.Color.Chocolate;
            this.gb_CTpNhap.Location = new System.Drawing.Point(26, 52);
            this.gb_CTpNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_CTpNhap.Name = "gb_CTpNhap";
            this.gb_CTpNhap.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_CTpNhap.Size = new System.Drawing.Size(1211, 309);
            this.gb_CTpNhap.TabIndex = 14;
            this.gb_CTpNhap.TabStop = false;
            this.gb_CTpNhap.Text = "Thông Tin Chi Tiết Phiếu Nhập Sách";
            // 
            // cbMaPN
            // 
            this.cbMaPN.BackColor = System.Drawing.Color.LightGray;
            this.cbMaPN.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaPN.Location = new System.Drawing.Point(235, 120);
            this.cbMaPN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMaPN.Name = "cbMaPN";
            this.cbMaPN.Size = new System.Drawing.Size(229, 34);
            this.cbMaPN.TabIndex = 38;
            // 
            // cbMaSach
            // 
            this.cbMaSach.BackColor = System.Drawing.SystemColors.Control;
            this.cbMaSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaSach.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaSach.FormattingEnabled = true;
            this.cbMaSach.Location = new System.Drawing.Point(235, 253);
            this.cbMaSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMaSach.Name = "cbMaSach";
            this.cbMaSach.Size = new System.Drawing.Size(229, 34);
            this.cbMaSach.TabIndex = 37;
            this.cbMaSach.SelectedValueChanged += new System.EventHandler(this.cbMaSach_SelectedValueChanged);
            this.cbMaSach.TextChanged += new System.EventHandler(this.cbMaSach_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(48, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 36;
            this.label3.Text = "Mã Sách:";
            // 
            // txbThanhTien
            // 
            this.txbThanhTien.BackColor = System.Drawing.Color.LightGray;
            this.txbThanhTien.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbThanhTien.Location = new System.Drawing.Point(961, 190);
            this.txbThanhTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbThanhTien.Name = "txbThanhTien";
            this.txbThanhTien.Size = new System.Drawing.Size(229, 34);
            this.txbThanhTien.TabIndex = 35;
            this.txbThanhTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbThanhTien_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(865, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "Thành Tiền:";
            // 
            // txbTenTG
            // 
            this.txbTenTG.BackColor = System.Drawing.Color.LightGray;
            this.txbTenTG.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenTG.Location = new System.Drawing.Point(620, 54);
            this.txbTenTG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTenTG.Multiline = true;
            this.txbTenTG.Name = "txbTenTG";
            this.txbTenTG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbTenTG.Size = new System.Drawing.Size(229, 47);
            this.txbTenTG.TabIndex = 33;
            this.txbTenTG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTenTG_KeyPress);
            // 
            // txbNamXB
            // 
            this.txbNamXB.BackColor = System.Drawing.Color.LightGray;
            this.txbNamXB.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNamXB.Location = new System.Drawing.Point(620, 190);
            this.txbNamXB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNamXB.Name = "txbNamXB";
            this.txbNamXB.Size = new System.Drawing.Size(229, 34);
            this.txbNamXB.TabIndex = 32;
            this.txbNamXB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNamXB_KeyPress);
            // 
            // txbNhaXB
            // 
            this.txbNhaXB.BackColor = System.Drawing.Color.LightGray;
            this.txbNhaXB.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNhaXB.Location = new System.Drawing.Point(620, 120);
            this.txbNhaXB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNhaXB.Name = "txbNhaXB";
            this.txbNhaXB.Size = new System.Drawing.Size(229, 34);
            this.txbNhaXB.TabIndex = 31;
            this.txbNhaXB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNhaXB_KeyPress);
            // 
            // cbTenSach
            // 
            this.cbTenSach.BackColor = System.Drawing.SystemColors.Control;
            this.cbTenSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenSach.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenSach.FormattingEnabled = true;
            this.cbTenSach.Location = new System.Drawing.Point(235, 190);
            this.cbTenSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTenSach.Name = "cbTenSach";
            this.cbTenSach.Size = new System.Drawing.Size(229, 34);
            this.cbTenSach.TabIndex = 30;
            this.cbTenSach.SelectedIndexChanged += new System.EventHandler(this.cbTenSach_SelectedIndexChanged);
            this.cbTenSach.SelectedValueChanged += new System.EventHandler(this.cbTenSach_SelectedValueChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightCoral;
            this.btnXoa.BackgroundColor = System.Drawing.Color.LightCoral;
            this.btnXoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoa.BorderRadius = 20;
            this.btnXoa.BorderSize = 0;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(1022, 248);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(140, 40);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.btnCapNhat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.btnCapNhat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCapNhat.BorderRadius = 20;
            this.btnCapNhat.BorderSize = 0;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(849, 248);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(140, 40);
            this.btnCapNhat.TabIndex = 27;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.TextColor = System.Drawing.Color.White;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AccessibleName = "BtLuu";
            this.btnLuu.BackColor = System.Drawing.Color.Violet;
            this.btnLuu.BackgroundColor = System.Drawing.Color.Violet;
            this.btnLuu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLuu.BorderRadius = 20;
            this.btnLuu.BorderSize = 0;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(674, 248);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(140, 40);
            this.btnLuu.TabIndex = 26;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextColor = System.Drawing.Color.White;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.AccessibleName = "BtThemmoi";
            this.btnThemMoi.BackColor = System.Drawing.Color.YellowGreen;
            this.btnThemMoi.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.btnThemMoi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThemMoi.BorderRadius = 20;
            this.btnThemMoi.BorderSize = 0;
            this.btnThemMoi.FlatAppearance.BorderSize = 0;
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnThemMoi.ForeColor = System.Drawing.Color.White;
            this.btnThemMoi.Location = new System.Drawing.Point(499, 248);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(140, 40);
            this.btnThemMoi.TabIndex = 25;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.TextColor = System.Drawing.Color.White;
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // txbDonGia
            // 
            this.txbDonGia.BackColor = System.Drawing.SystemColors.Control;
            this.txbDonGia.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDonGia.Location = new System.Drawing.Point(961, 124);
            this.txbDonGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbDonGia.Name = "txbDonGia";
            this.txbDonGia.Size = new System.Drawing.Size(229, 34);
            this.txbDonGia.TabIndex = 24;
            this.txbDonGia.TextChanged += new System.EventHandler(this.txbDonGia_TextChanged);
            this.txbDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDonGia_KeyPress);
            // 
            // txbMaCTPN
            // 
            this.txbMaCTPN.BackColor = System.Drawing.Color.LightGray;
            this.txbMaCTPN.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaCTPN.Location = new System.Drawing.Point(235, 54);
            this.txbMaCTPN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbMaCTPN.Name = "txbMaCTPN";
            this.txbMaCTPN.Size = new System.Drawing.Size(229, 34);
            this.txbMaCTPN.TabIndex = 23;
            this.txbMaCTPN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMaCTPN_KeyPress);
            // 
            // txbSoLuong
            // 
            this.txbSoLuong.BackColor = System.Drawing.SystemColors.Control;
            this.txbSoLuong.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSoLuong.Location = new System.Drawing.Point(961, 56);
            this.txbSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSoLuong.Name = "txbSoLuong";
            this.txbSoLuong.Size = new System.Drawing.Size(229, 34);
            this.txbSoLuong.TabIndex = 22;
            this.txbSoLuong.TextChanged += new System.EventHandler(this.txbSoLuong_TextChanged);
            this.txbSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSoLuong_KeyPress);
            // 
            // lb_DonGia
            // 
            this.lb_DonGia.AutoSize = true;
            this.lb_DonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DonGia.ForeColor = System.Drawing.Color.Navy;
            this.lb_DonGia.Location = new System.Drawing.Point(865, 130);
            this.lb_DonGia.Name = "lb_DonGia";
            this.lb_DonGia.Size = new System.Drawing.Size(83, 24);
            this.lb_DonGia.TabIndex = 7;
            this.lb_DonGia.Text = "Đơn Giá:";
            // 
            // lb_SoLuong
            // 
            this.lb_SoLuong.AutoSize = true;
            this.lb_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoLuong.ForeColor = System.Drawing.Color.Navy;
            this.lb_SoLuong.Location = new System.Drawing.Point(865, 60);
            this.lb_SoLuong.Name = "lb_SoLuong";
            this.lb_SoLuong.Size = new System.Drawing.Size(97, 24);
            this.lb_SoLuong.TabIndex = 6;
            this.lb_SoLuong.Text = "Số Lượng:";
            // 
            // lb_NamXB
            // 
            this.lb_NamXB.AutoSize = true;
            this.lb_NamXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NamXB.ForeColor = System.Drawing.Color.Navy;
            this.lb_NamXB.Location = new System.Drawing.Point(481, 196);
            this.lb_NamXB.Name = "lb_NamXB";
            this.lb_NamXB.Size = new System.Drawing.Size(137, 24);
            this.lb_NamXB.TabIndex = 5;
            this.lb_NamXB.Text = "Năm Xuất Bản:";
            // 
            // lb_NhaXB
            // 
            this.lb_NhaXB.AutoSize = true;
            this.lb_NhaXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NhaXB.ForeColor = System.Drawing.Color.Navy;
            this.lb_NhaXB.Location = new System.Drawing.Point(482, 130);
            this.lb_NhaXB.Name = "lb_NhaXB";
            this.lb_NhaXB.Size = new System.Drawing.Size(132, 24);
            this.lb_NhaXB.TabIndex = 4;
            this.lb_NhaXB.Text = "Nhà Xuất Bản:";
            // 
            // lb_TenTacGia
            // 
            this.lb_TenTacGia.AutoSize = true;
            this.lb_TenTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenTacGia.ForeColor = System.Drawing.Color.Navy;
            this.lb_TenTacGia.Location = new System.Drawing.Point(482, 62);
            this.lb_TenTacGia.Name = "lb_TenTacGia";
            this.lb_TenTacGia.Size = new System.Drawing.Size(119, 24);
            this.lb_TenTacGia.TabIndex = 3;
            this.lb_TenTacGia.Text = "Tên Tác Giả:";
            // 
            // lb_TenCuonSach
            // 
            this.lb_TenCuonSach.AutoSize = true;
            this.lb_TenCuonSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenCuonSach.ForeColor = System.Drawing.Color.Navy;
            this.lb_TenCuonSach.Location = new System.Drawing.Point(48, 196);
            this.lb_TenCuonSach.Name = "lb_TenCuonSach";
            this.lb_TenCuonSach.Size = new System.Drawing.Size(136, 24);
            this.lb_TenCuonSach.TabIndex = 2;
            this.lb_TenCuonSach.Text = "Tên Đầu Sách:";
            // 
            // lb_maPN
            // 
            this.lb_maPN.AutoSize = true;
            this.lb_maPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maPN.ForeColor = System.Drawing.Color.Navy;
            this.lb_maPN.Location = new System.Drawing.Point(48, 126);
            this.lb_maPN.Name = "lb_maPN";
            this.lb_maPN.Size = new System.Drawing.Size(146, 24);
            this.lb_maPN.TabIndex = 1;
            this.lb_maPN.Text = "Mã Phiếu Nhập:";
            // 
            // lb_MaCTPN
            // 
            this.lb_MaCTPN.AutoSize = true;
            this.lb_MaCTPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaCTPN.ForeColor = System.Drawing.Color.Navy;
            this.lb_MaCTPN.Location = new System.Drawing.Point(48, 62);
            this.lb_MaCTPN.Name = "lb_MaCTPN";
            this.lb_MaCTPN.Size = new System.Drawing.Size(215, 24);
            this.lb_MaCTPN.TabIndex = 0;
            this.lb_MaCTPN.Text = "Mã Chi Tiết Phiếu Nhập:";
            // 
            // lb_CTPhieuNhap
            // 
            this.lb_CTPhieuNhap.AutoSize = true;
            this.lb_CTPhieuNhap.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CTPhieuNhap.ForeColor = System.Drawing.Color.Navy;
            this.lb_CTPhieuNhap.Location = new System.Drawing.Point(401, -1);
            this.lb_CTPhieuNhap.Name = "lb_CTPhieuNhap";
            this.lb_CTPhieuNhap.Size = new System.Drawing.Size(469, 51);
            this.lb_CTPhieuNhap.TabIndex = 13;
            this.lb_CTPhieuNhap.Text = "Chi Tiết Phiếu Nhập Sách";
            this.lb_CTPhieuNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(490, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 36);
            this.label2.TabIndex = 12;
            // 
            // errMaPN
            // 
            this.errMaPN.ContainerControl = this;
            // 
            // errTenDS
            // 
            this.errTenDS.ContainerControl = this;
            // 
            // errSoLuong
            // 
            this.errSoLuong.ContainerControl = this;
            // 
            // errDonGia
            // 
            this.errDonGia.ContainerControl = this;
            // 
            // nButton1
            // 
            this.nButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.nButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.nButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.nButton1.BorderRadius = 20;
            this.nButton1.BorderSize = 0;
            this.nButton1.FlatAppearance.BorderSize = 0;
            this.nButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nButton1.ForeColor = System.Drawing.Color.White;
            this.nButton1.Location = new System.Drawing.Point(26, 7);
            this.nButton1.Name = "nButton1";
            this.nButton1.Size = new System.Drawing.Size(150, 40);
            this.nButton1.TabIndex = 17;
            this.nButton1.Text = "THOÁT";
            this.nButton1.TextColor = System.Drawing.Color.White;
            this.nButton1.UseVisualStyleBackColor = false;
            this.nButton1.Click += new System.EventHandler(this.nButton1_Click);
            // 
            // dgvCTPhieuNS
            // 
            this.dgvCTPhieuNS.AllowUserToAddRows = false;
            this.dgvCTPhieuNS.AllowUserToDeleteRows = false;
            this.dgvCTPhieuNS.AllowUserToResizeRows = false;
            this.dgvCTPhieuNS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCTPhieuNS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTPhieuNS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCTPhieuNS.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCTPhieuNS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTPhieuNS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCTPhieuNS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTPhieuNS.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCTPhieuNS.EnableHeadersVisualStyles = false;
            this.dgvCTPhieuNS.GridColor = System.Drawing.Color.Navy;
            this.dgvCTPhieuNS.Location = new System.Drawing.Point(12, 414);
            this.dgvCTPhieuNS.Name = "dgvCTPhieuNS";
            this.dgvCTPhieuNS.ReadOnly = true;
            this.dgvCTPhieuNS.RowHeadersVisible = false;
            this.dgvCTPhieuNS.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dgvCTPhieuNS.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCTPhieuNS.RowTemplate.Height = 24;
            this.dgvCTPhieuNS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTPhieuNS.Size = new System.Drawing.Size(1236, 328);
            this.dgvCTPhieuNS.TabIndex = 18;
            this.dgvCTPhieuNS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTPhieuNS_CellClick);
            // 
            // formCTPN
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1260, 724);
            this.Controls.Add(this.dgvCTPhieuNS);
            this.Controls.Add(this.nButton1);
            this.Controls.Add(this.lb_ThongtinPN);
            this.Controls.Add(this.gb_CTpNhap);
            this.Controls.Add(this.lb_CTPhieuNhap);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formCTPN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formCTPN_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_CTpNhap.ResumeLayout(false);
            this.gb_CTpNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMaPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPhieuNS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_ThongtinPN;
        private System.Windows.Forms.GroupBox gb_CTpNhap;
        private System.Windows.Forms.Label lb_DonGia;
        private System.Windows.Forms.Label lb_SoLuong;
        private System.Windows.Forms.Label lb_NamXB;
        private System.Windows.Forms.Label lb_NhaXB;
        private System.Windows.Forms.Label lb_TenTacGia;
        private System.Windows.Forms.Label lb_TenCuonSach;
        private System.Windows.Forms.Label lb_maPN;
        private System.Windows.Forms.Label lb_MaCTPN;
        private System.Windows.Forms.Label lb_CTPhieuNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbDonGia;
        private System.Windows.Forms.TextBox txbMaCTPN;
        private System.Windows.Forms.TextBox txbSoLuong;
        private FormNhapSach.VBButton btnXoa;
        private FormNhapSach.VBButton btnCapNhat;
        private FormNhapSach.VBButton btnLuu;
        private FormNhapSach.VBButton btnThemMoi;
        private System.Windows.Forms.TextBox txbNamXB;
        private System.Windows.Forms.TextBox txbNhaXB;
        private System.Windows.Forms.ComboBox cbTenSach;
        private System.Windows.Forms.TextBox txbTenTG;
        private System.Windows.Forms.TextBox txbThanhTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errMaPN;
        private System.Windows.Forms.ErrorProvider errTenDS;
        private System.Windows.Forms.ErrorProvider errSoLuong;
        private System.Windows.Forms.ErrorProvider errDonGia;
        private ThayDoiQuyDinh.nButton nButton1;
        private System.Windows.Forms.ComboBox cbMaSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCTPhieuNS;
        private System.Windows.Forms.TextBox cbMaPN;
    }
}