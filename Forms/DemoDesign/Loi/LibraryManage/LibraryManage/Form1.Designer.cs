namespace LibraryManage
{
    partial class Form1
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
            this.lbTTDocGia = new System.Windows.Forms.Label();
            this.dgvDSDocGia = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDocGia = new System.Windows.Forms.GroupBox();
            this.txbNgayHetHan = new System.Windows.Forms.TextBox();
            this.btnXoa = new nhapsach.nButton();
            this.btnCapNhat = new nhapsach.nButton();
            this.btnLuu = new nhapsach.nButton();
            this.dtpNgLapThe = new System.Windows.Forms.DateTimePicker();
            this.dtpNgSinh = new System.Windows.Forms.DateTimePicker();
            this.btnThemMoi = new nhapsach.nButton();
            this.txbTongNo = new System.Windows.Forms.TextBox();
            this.cbLoaiDG = new System.Windows.Forms.ComboBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbDChi = new System.Windows.Forms.TextBox();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.txbMaDG = new System.Windows.Forms.TextBox();
            this.lbTongNo = new System.Windows.Forms.Label();
            this.lbNgHetHan = new System.Windows.Forms.Label();
            this.lbNgLapThe = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbMaDG = new System.Windows.Forms.Label();
            this.errTenDG = new System.Windows.Forms.ErrorProvider(this.components);
            this.errEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDC = new System.Windows.Forms.ErrorProvider(this.components);
            this.errLoaiDG = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDocGia)).BeginInit();
            this.gbDocGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errTenDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLoaiDG)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTTDocGia
            // 
            this.lbTTDocGia.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTTDocGia.ForeColor = System.Drawing.Color.Navy;
            this.lbTTDocGia.Location = new System.Drawing.Point(404, -9);
            this.lbTTDocGia.Name = "lbTTDocGia";
            this.lbTTDocGia.Size = new System.Drawing.Size(421, 62);
            this.lbTTDocGia.TabIndex = 0;
            this.lbTTDocGia.Text = "Thông Tin Độc Giả";
            this.lbTTDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDSDocGia
            // 
            this.dgvDSDocGia.AllowUserToAddRows = false;
            this.dgvDSDocGia.AllowUserToDeleteRows = false;
            this.dgvDSDocGia.AllowUserToResizeRows = false;
            this.dgvDSDocGia.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSDocGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSDocGia.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSDocGia.GridColor = System.Drawing.Color.Navy;
            this.dgvDSDocGia.Location = new System.Drawing.Point(12, 416);
            this.dgvDSDocGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSDocGia.Name = "dgvDSDocGia";
            this.dgvDSDocGia.ReadOnly = true;
            this.dgvDSDocGia.RowHeadersVisible = false;
            this.dgvDSDocGia.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dgvDSDocGia.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDSDocGia.RowTemplate.Height = 28;
            this.dgvDSDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSDocGia.Size = new System.Drawing.Size(1236, 289);
            this.dgvDSDocGia.TabIndex = 2;
            this.dgvDSDocGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDocGia_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(420, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh Sách Thông Tin Độc Giả";
            // 
            // gbDocGia
            // 
            this.gbDocGia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbDocGia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbDocGia.Controls.Add(this.txbNgayHetHan);
            this.gbDocGia.Controls.Add(this.btnXoa);
            this.gbDocGia.Controls.Add(this.btnCapNhat);
            this.gbDocGia.Controls.Add(this.btnLuu);
            this.gbDocGia.Controls.Add(this.dtpNgLapThe);
            this.gbDocGia.Controls.Add(this.dtpNgSinh);
            this.gbDocGia.Controls.Add(this.btnThemMoi);
            this.gbDocGia.Controls.Add(this.txbTongNo);
            this.gbDocGia.Controls.Add(this.cbLoaiDG);
            this.gbDocGia.Controls.Add(this.txbEmail);
            this.gbDocGia.Controls.Add(this.txbDChi);
            this.gbDocGia.Controls.Add(this.txbHoTen);
            this.gbDocGia.Controls.Add(this.txbMaDG);
            this.gbDocGia.Controls.Add(this.lbTongNo);
            this.gbDocGia.Controls.Add(this.lbNgHetHan);
            this.gbDocGia.Controls.Add(this.lbNgLapThe);
            this.gbDocGia.Controls.Add(this.lbEmail);
            this.gbDocGia.Controls.Add(this.lbDiaChi);
            this.gbDocGia.Controls.Add(this.lbNgaySinh);
            this.gbDocGia.Controls.Add(this.label3);
            this.gbDocGia.Controls.Add(this.lbHoTen);
            this.gbDocGia.Controls.Add(this.lbMaDG);
            this.gbDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDocGia.ForeColor = System.Drawing.Color.Chocolate;
            this.gbDocGia.Location = new System.Drawing.Point(24, 43);
            this.gbDocGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDocGia.Name = "gbDocGia";
            this.gbDocGia.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDocGia.Size = new System.Drawing.Size(1211, 309);
            this.gbDocGia.TabIndex = 1;
            this.gbDocGia.TabStop = false;
            this.gbDocGia.Text = "Thông Tin Chi Tiết Độc Giả";
            // 
            // txbNgayHetHan
            // 
            this.txbNgayHetHan.BackColor = System.Drawing.Color.LightGray;
            this.txbNgayHetHan.Enabled = false;
            this.txbNgayHetHan.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNgayHetHan.Location = new System.Drawing.Point(940, 122);
            this.txbNgayHetHan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNgayHetHan.Name = "txbNgayHetHan";
            this.txbNgayHetHan.Size = new System.Drawing.Size(250, 34);
            this.txbNgayHetHan.TabIndex = 18;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.LightCoral;
            this.btnXoa.BackgroundColor = System.Drawing.Color.LightCoral;
            this.btnXoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoa.BorderRadius = 20;
            this.btnXoa.BorderSize = 0;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(799, 250);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(140, 40);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.btnCapNhat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.btnCapNhat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCapNhat.BorderRadius = 20;
            this.btnCapNhat.BorderSize = 0;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(632, 250);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(140, 40);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.TextColor = System.Drawing.Color.White;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackColor = System.Drawing.Color.Violet;
            this.btnLuu.BackgroundColor = System.Drawing.Color.Violet;
            this.btnLuu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLuu.BorderRadius = 20;
            this.btnLuu.BorderSize = 0;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(466, 250);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(140, 40);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextColor = System.Drawing.Color.White;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dtpNgLapThe
            // 
            this.dtpNgLapThe.CustomFormat = "dd/MM/yyyy";
            this.dtpNgLapThe.Font = new System.Drawing.Font("Arial", 14F);
            this.dtpNgLapThe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgLapThe.Location = new System.Drawing.Point(940, 53);
            this.dtpNgLapThe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgLapThe.Name = "dtpNgLapThe";
            this.dtpNgLapThe.Size = new System.Drawing.Size(250, 34);
            this.dtpNgLapThe.TabIndex = 15;
            this.dtpNgLapThe.ValueChanged += new System.EventHandler(this.dtpNgLapThe_ValueChanged);
            // 
            // dtpNgSinh
            // 
            this.dtpNgSinh.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpNgSinh.CalendarTitleForeColor = System.Drawing.Color.Navy;
            this.dtpNgSinh.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpNgSinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgSinh.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgSinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgSinh.Location = new System.Drawing.Point(532, 53);
            this.dtpNgSinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgSinh.Name = "dtpNgSinh";
            this.dtpNgSinh.Size = new System.Drawing.Size(250, 34);
            this.dtpNgSinh.TabIndex = 12;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMoi.BackColor = System.Drawing.Color.YellowGreen;
            this.btnThemMoi.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.btnThemMoi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThemMoi.BorderRadius = 20;
            this.btnThemMoi.BorderSize = 0;
            this.btnThemMoi.FlatAppearance.BorderSize = 0;
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.ForeColor = System.Drawing.Color.White;
            this.btnThemMoi.Location = new System.Drawing.Point(305, 250);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(140, 40);
            this.btnThemMoi.TabIndex = 4;
            this.btnThemMoi.Text = "Thêm Mới";
            this.btnThemMoi.TextColor = System.Drawing.Color.White;
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // txbTongNo
            // 
            this.txbTongNo.BackColor = System.Drawing.Color.LightGray;
            this.txbTongNo.Enabled = false;
            this.txbTongNo.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTongNo.Location = new System.Drawing.Point(940, 192);
            this.txbTongNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTongNo.Name = "txbTongNo";
            this.txbTongNo.Size = new System.Drawing.Size(250, 34);
            this.txbTongNo.TabIndex = 15;
            this.txbTongNo.Text = " ";
            // 
            // cbLoaiDG
            // 
            this.cbLoaiDG.BackColor = System.Drawing.SystemColors.Control;
            this.cbLoaiDG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiDG.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiDG.FormattingEnabled = true;
            this.cbLoaiDG.Location = new System.Drawing.Point(168, 192);
            this.cbLoaiDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLoaiDG.Name = "cbLoaiDG";
            this.cbLoaiDG.Size = new System.Drawing.Size(221, 34);
            this.cbLoaiDG.TabIndex = 11;
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txbEmail.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(532, 192);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(250, 34);
            this.txbEmail.TabIndex = 14;
            // 
            // txbDChi
            // 
            this.txbDChi.BackColor = System.Drawing.SystemColors.Control;
            this.txbDChi.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDChi.Location = new System.Drawing.Point(532, 122);
            this.txbDChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbDChi.Name = "txbDChi";
            this.txbDChi.Size = new System.Drawing.Size(250, 34);
            this.txbDChi.TabIndex = 13;
            // 
            // txbHoTen
            // 
            this.txbHoTen.BackColor = System.Drawing.SystemColors.Control;
            this.txbHoTen.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHoTen.Location = new System.Drawing.Point(168, 122);
            this.txbHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(221, 34);
            this.txbHoTen.TabIndex = 10;
            // 
            // txbMaDG
            // 
            this.txbMaDG.BackColor = System.Drawing.Color.LightGray;
            this.txbMaDG.Enabled = false;
            this.txbMaDG.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaDG.Location = new System.Drawing.Point(168, 52);
            this.txbMaDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbMaDG.Name = "txbMaDG";
            this.txbMaDG.Size = new System.Drawing.Size(221, 34);
            this.txbMaDG.TabIndex = 9;
            // 
            // lbTongNo
            // 
            this.lbTongNo.AutoSize = true;
            this.lbTongNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongNo.ForeColor = System.Drawing.Color.Navy;
            this.lbTongNo.Location = new System.Drawing.Point(800, 200);
            this.lbTongNo.Name = "lbTongNo";
            this.lbTongNo.Size = new System.Drawing.Size(90, 24);
            this.lbTongNo.TabIndex = 8;
            this.lbTongNo.Text = "Tổng Nợ:";
            // 
            // lbNgHetHan
            // 
            this.lbNgHetHan.AutoSize = true;
            this.lbNgHetHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgHetHan.ForeColor = System.Drawing.Color.Navy;
            this.lbNgHetHan.Location = new System.Drawing.Point(800, 130);
            this.lbNgHetHan.Name = "lbNgHetHan";
            this.lbNgHetHan.Size = new System.Drawing.Size(133, 24);
            this.lbNgHetHan.TabIndex = 7;
            this.lbNgHetHan.Text = "Ngày Hết Hạn:";
            // 
            // lbNgLapThe
            // 
            this.lbNgLapThe.AutoSize = true;
            this.lbNgLapThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgLapThe.ForeColor = System.Drawing.Color.Navy;
            this.lbNgLapThe.Location = new System.Drawing.Point(800, 60);
            this.lbNgLapThe.Name = "lbNgLapThe";
            this.lbNgLapThe.Size = new System.Drawing.Size(134, 24);
            this.lbNgLapThe.TabIndex = 6;
            this.lbNgLapThe.Text = "Ngày Lập Thẻ:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.Navy;
            this.lbEmail.Location = new System.Drawing.Point(420, 200);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(62, 24);
            this.lbEmail.TabIndex = 5;
            this.lbEmail.Text = "Email:";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.ForeColor = System.Drawing.Color.Navy;
            this.lbDiaChi.Location = new System.Drawing.Point(415, 130);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(75, 24);
            this.lbDiaChi.TabIndex = 4;
            this.lbDiaChi.Text = "Địa Chỉ:";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaySinh.ForeColor = System.Drawing.Color.Navy;
            this.lbNgaySinh.Location = new System.Drawing.Point(415, 60);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(102, 24);
            this.lbNgaySinh.TabIndex = 3;
            this.lbNgaySinh.Text = "Ngày Sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(40, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại Độc Giả:";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.ForeColor = System.Drawing.Color.Navy;
            this.lbHoTen.Location = new System.Drawing.Point(40, 130);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(79, 24);
            this.lbHoTen.TabIndex = 1;
            this.lbHoTen.Text = "Họ Tên:";
            // 
            // lbMaDG
            // 
            this.lbMaDG.AutoSize = true;
            this.lbMaDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaDG.ForeColor = System.Drawing.Color.Navy;
            this.lbMaDG.Location = new System.Drawing.Point(40, 60);
            this.lbMaDG.Name = "lbMaDG";
            this.lbMaDG.Size = new System.Drawing.Size(113, 24);
            this.lbMaDG.TabIndex = 0;
            this.lbMaDG.Text = "Mã Độc Giả:";
            // 
            // errTenDG
            // 
            this.errTenDG.ContainerControl = this;
            // 
            // errEmail
            // 
            this.errEmail.ContainerControl = this;
            // 
            // errDC
            // 
            this.errDC.ContainerControl = this;
            // 
            // errLoaiDG
            // 
            this.errLoaiDG.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1260, 724);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDSDocGia);
            this.Controls.Add(this.gbDocGia);
            this.Controls.Add(this.lbTTDocGia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDocGia)).EndInit();
            this.gbDocGia.ResumeLayout(false);
            this.gbDocGia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errTenDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLoaiDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTTDocGia;
        private System.Windows.Forms.DataGridView dgvDSDocGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDocGia;
        private System.Windows.Forms.DateTimePicker dtpNgLapThe;
        private System.Windows.Forms.DateTimePicker dtpNgSinh;
        private System.Windows.Forms.TextBox txbTongNo;
        private System.Windows.Forms.ComboBox cbLoaiDG;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbDChi;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.Label lbTongNo;
        private System.Windows.Forms.Label lbNgHetHan;
        private System.Windows.Forms.Label lbNgLapThe;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbMaDG;
        private nhapsach.nButton btnThemMoi;
        private nhapsach.nButton btnXoa;
        private nhapsach.nButton btnCapNhat;
        private System.Windows.Forms.TextBox txbMaDG;
        private nhapsach.nButton btnLuu;
        private System.Windows.Forms.ErrorProvider errTenDG;
        private System.Windows.Forms.ErrorProvider errEmail;
        private System.Windows.Forms.ErrorProvider errDC;
        private System.Windows.Forms.ErrorProvider errLoaiDG;
        private System.Windows.Forms.TextBox txbNgayHetHan;
    }
}