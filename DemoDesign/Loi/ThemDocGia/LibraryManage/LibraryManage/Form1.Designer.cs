
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbTTDocGia = new System.Windows.Forms.Label();
            this.dgvDSDocGia = new System.Windows.Forms.DataGridView();
            this.colMaDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLapThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDocGia = new System.Windows.Forms.GroupBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbTongNo = new System.Windows.Forms.Label();
            this.lbNgHetHan = new System.Windows.Forms.Label();
            this.lbNgLapThe = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbMaDG = new System.Windows.Forms.Label();
            this.nButton1 = new nhapsach.nButton();
            this.nButton2 = new nhapsach.nButton();
            this.nButton3 = new nhapsach.nButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDocGia)).BeginInit();
            this.gbDocGia.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTTDocGia
            // 
            this.lbTTDocGia.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTTDocGia.ForeColor = System.Drawing.Color.Navy;
            this.lbTTDocGia.Location = new System.Drawing.Point(15, 9);
            this.lbTTDocGia.Name = "lbTTDocGia";
            this.lbTTDocGia.Size = new System.Drawing.Size(421, 62);
            this.lbTTDocGia.TabIndex = 0;
            this.lbTTDocGia.Text = "Thông Tin Độc Giả";
            this.lbTTDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDSDocGia
            // 
            this.dgvDSDocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSDocGia.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSDocGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSDocGia.ColumnHeadersHeight = 40;
            this.dgvDSDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDG,
            this.colHoTen,
            this.colLoaiDG,
            this.colNgaySinh,
            this.colDiaChi,
            this.colEmail,
            this.colNgayLapThe,
            this.colNgayHetHan,
            this.colTongNo});
            this.dgvDSDocGia.EnableHeadersVisualStyles = false;
            this.dgvDSDocGia.GridColor = System.Drawing.Color.Navy;
            this.dgvDSDocGia.Location = new System.Drawing.Point(12, 466);
            this.dgvDSDocGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSDocGia.Name = "dgvDSDocGia";
            this.dgvDSDocGia.RowHeadersVisible = false;
            this.dgvDSDocGia.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dgvDSDocGia.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSDocGia.RowTemplate.Height = 28;
            this.dgvDSDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSDocGia.Size = new System.Drawing.Size(1236, 239);
            this.dgvDSDocGia.TabIndex = 2;
            // 
            // colMaDG
            // 
            this.colMaDG.HeaderText = "Mã Độc Giả";
            this.colMaDG.MinimumWidth = 6;
            this.colMaDG.Name = "colMaDG";
            // 
            // colHoTen
            // 
            this.colHoTen.HeaderText = "Họ Tên";
            this.colHoTen.MinimumWidth = 6;
            this.colHoTen.Name = "colHoTen";
            // 
            // colLoaiDG
            // 
            this.colLoaiDG.HeaderText = "Loại Độc Giả";
            this.colLoaiDG.MinimumWidth = 6;
            this.colLoaiDG.Name = "colLoaiDG";
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.HeaderText = "Ngày Sinh";
            this.colNgaySinh.MinimumWidth = 6;
            this.colNgaySinh.Name = "colNgaySinh";
            // 
            // colDiaChi
            // 
            this.colDiaChi.HeaderText = "Địa Chỉ";
            this.colDiaChi.MinimumWidth = 6;
            this.colDiaChi.Name = "colDiaChi";
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            // 
            // colNgayLapThe
            // 
            this.colNgayLapThe.HeaderText = "Ngày Lập Thẻ";
            this.colNgayLapThe.MinimumWidth = 6;
            this.colNgayLapThe.Name = "colNgayLapThe";
            // 
            // colNgayHetHan
            // 
            this.colNgayHetHan.HeaderText = "Ngày Hết Hạn";
            this.colNgayHetHan.MinimumWidth = 6;
            this.colNgayHetHan.Name = "colNgayHetHan";
            // 
            // colTongNo
            // 
            this.colTongNo.HeaderText = "Tổng Nợ";
            this.colTongNo.MinimumWidth = 6;
            this.colTongNo.Name = "colTongNo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Avo", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(407, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh Sách Thông Tin Độc Giả";
            // 
            // gbDocGia
            // 
            this.gbDocGia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbDocGia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbDocGia.Controls.Add(this.dateTimePicker3);
            this.gbDocGia.Controls.Add(this.dateTimePicker2);
            this.gbDocGia.Controls.Add(this.dateTimePicker1);
            this.gbDocGia.Controls.Add(this.textBox6);
            this.gbDocGia.Controls.Add(this.comboBox1);
            this.gbDocGia.Controls.Add(this.textBox4);
            this.gbDocGia.Controls.Add(this.textBox3);
            this.gbDocGia.Controls.Add(this.textBox2);
            this.gbDocGia.Controls.Add(this.textBox1);
            this.gbDocGia.Controls.Add(this.lbTongNo);
            this.gbDocGia.Controls.Add(this.lbNgHetHan);
            this.gbDocGia.Controls.Add(this.lbNgLapThe);
            this.gbDocGia.Controls.Add(this.lbEmail);
            this.gbDocGia.Controls.Add(this.lbDiaChi);
            this.gbDocGia.Controls.Add(this.lbNgaySinh);
            this.gbDocGia.Controls.Add(this.label3);
            this.gbDocGia.Controls.Add(this.lbHoTen);
            this.gbDocGia.Controls.Add(this.lbMaDG);
            this.gbDocGia.Font = new System.Drawing.Font("UTM Avo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDocGia.ForeColor = System.Drawing.Color.Chocolate;
            this.gbDocGia.Location = new System.Drawing.Point(23, 116);
            this.gbDocGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDocGia.Name = "gbDocGia";
            this.gbDocGia.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDocGia.Size = new System.Drawing.Size(1211, 252);
            this.gbDocGia.TabIndex = 1;
            this.gbDocGia.TabStop = false;
            this.gbDocGia.Text = "Thông Tin Chi Tiết Độc Giả";
            this.gbDocGia.Enter += new System.EventHandler(this.gbDocGia_Enter);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(1018, 119);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(151, 30);
            this.dateTimePicker3.TabIndex = 18;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(1018, 57);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(151, 30);
            this.dateTimePicker2.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.Navy;
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(532, 57);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 30);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.DropDown += new System.EventHandler(this.dateTimePicker1_DropDown);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.Location = new System.Drawing.Point(1018, 179);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(151, 41);
            this.textBox6.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(187, 180);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 42);
            this.comboBox1.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.Location = new System.Drawing.Point(532, 179);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(250, 41);
            this.textBox4.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.Location = new System.Drawing.Point(532, 111);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(250, 41);
            this.textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.Location = new System.Drawing.Point(187, 113);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 41);
            this.textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(187, 60);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 41);
            this.textBox1.TabIndex = 9;
            // 
            // lbTongNo
            // 
            this.lbTongNo.AutoSize = true;
            this.lbTongNo.Font = new System.Drawing.Font("UTM Avo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongNo.ForeColor = System.Drawing.Color.Navy;
            this.lbTongNo.Location = new System.Drawing.Point(853, 188);
            this.lbTongNo.Name = "lbTongNo";
            this.lbTongNo.Size = new System.Drawing.Size(93, 26);
            this.lbTongNo.TabIndex = 8;
            this.lbTongNo.Text = "Tổng Nợ:";
            // 
            // lbNgHetHan
            // 
            this.lbNgHetHan.AutoSize = true;
            this.lbNgHetHan.Font = new System.Drawing.Font("UTM Avo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgHetHan.ForeColor = System.Drawing.Color.Navy;
            this.lbNgHetHan.Location = new System.Drawing.Point(853, 118);
            this.lbNgHetHan.Name = "lbNgHetHan";
            this.lbNgHetHan.Size = new System.Drawing.Size(146, 26);
            this.lbNgHetHan.TabIndex = 7;
            this.lbNgHetHan.Text = "Ngày Hết Hạn:";
            // 
            // lbNgLapThe
            // 
            this.lbNgLapThe.AutoSize = true;
            this.lbNgLapThe.Font = new System.Drawing.Font("UTM Avo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgLapThe.ForeColor = System.Drawing.Color.Navy;
            this.lbNgLapThe.Location = new System.Drawing.Point(852, 57);
            this.lbNgLapThe.Name = "lbNgLapThe";
            this.lbNgLapThe.Size = new System.Drawing.Size(144, 26);
            this.lbNgLapThe.TabIndex = 6;
            this.lbNgLapThe.Text = "Ngày Lập Thẻ:";
            this.lbNgLapThe.Click += new System.EventHandler(this.lbNgLapThe_Click);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("UTM Avo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.Navy;
            this.lbEmail.Location = new System.Drawing.Point(416, 191);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(66, 26);
            this.lbEmail.TabIndex = 5;
            this.lbEmail.Text = "Email:";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("UTM Avo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.ForeColor = System.Drawing.Color.Navy;
            this.lbDiaChi.Location = new System.Drawing.Point(414, 118);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(84, 26);
            this.lbDiaChi.TabIndex = 4;
            this.lbDiaChi.Text = "Địa Chỉ:";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Font = new System.Drawing.Font("UTM Avo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaySinh.ForeColor = System.Drawing.Color.Navy;
            this.lbNgaySinh.Location = new System.Drawing.Point(414, 57);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(109, 26);
            this.lbNgaySinh.TabIndex = 3;
            this.lbNgaySinh.Text = "Ngày Sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Avo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(40, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại Độc Giả:";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("UTM Avo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.ForeColor = System.Drawing.Color.Navy;
            this.lbHoTen.Location = new System.Drawing.Point(40, 127);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(79, 26);
            this.lbHoTen.TabIndex = 1;
            this.lbHoTen.Text = "Họ Tên:";
            this.lbHoTen.Click += new System.EventHandler(this.lbHoTen_Click);
            // 
            // lbMaDG
            // 
            this.lbMaDG.AutoSize = true;
            this.lbMaDG.Font = new System.Drawing.Font("UTM Avo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaDG.ForeColor = System.Drawing.Color.Navy;
            this.lbMaDG.Location = new System.Drawing.Point(40, 60);
            this.lbMaDG.Name = "lbMaDG";
            this.lbMaDG.Size = new System.Drawing.Size(129, 26);
            this.lbMaDG.TabIndex = 0;
            this.lbMaDG.Text = "Mã Độc Giả:";
            // 
            // nButton1
            // 
            this.nButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nButton1.BackColor = System.Drawing.Color.YellowGreen;
            this.nButton1.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.nButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.nButton1.BorderRadius = 20;
            this.nButton1.BorderSize = 0;
            this.nButton1.FlatAppearance.BorderSize = 0;
            this.nButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nButton1.ForeColor = System.Drawing.Color.White;
            this.nButton1.Location = new System.Drawing.Point(879, 63);
            this.nButton1.Name = "nButton1";
            this.nButton1.Size = new System.Drawing.Size(108, 36);
            this.nButton1.TabIndex = 4;
            this.nButton1.Text = "Thêm";
            this.nButton1.TextColor = System.Drawing.Color.White;
            this.nButton1.UseVisualStyleBackColor = false;
            // 
            // nButton2
            // 
            this.nButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nButton2.BackColor = System.Drawing.Color.LightCoral;
            this.nButton2.BackgroundColor = System.Drawing.Color.LightCoral;
            this.nButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.nButton2.BorderRadius = 20;
            this.nButton2.BorderSize = 0;
            this.nButton2.FlatAppearance.BorderSize = 0;
            this.nButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nButton2.ForeColor = System.Drawing.Color.White;
            this.nButton2.Location = new System.Drawing.Point(993, 63);
            this.nButton2.Name = "nButton2";
            this.nButton2.Size = new System.Drawing.Size(108, 36);
            this.nButton2.TabIndex = 5;
            this.nButton2.Text = "Xóa";
            this.nButton2.TextColor = System.Drawing.Color.White;
            this.nButton2.UseVisualStyleBackColor = false;
            // 
            // nButton3
            // 
            this.nButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.nButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.nButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.nButton3.BorderRadius = 20;
            this.nButton3.BorderSize = 0;
            this.nButton3.FlatAppearance.BorderSize = 0;
            this.nButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nButton3.ForeColor = System.Drawing.Color.White;
            this.nButton3.Location = new System.Drawing.Point(1107, 63);
            this.nButton3.Name = "nButton3";
            this.nButton3.Size = new System.Drawing.Size(108, 36);
            this.nButton3.TabIndex = 6;
            this.nButton3.Text = "Sửa";
            this.nButton3.TextColor = System.Drawing.Color.White;
            this.nButton3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1260, 724);
            this.Controls.Add(this.nButton3);
            this.Controls.Add(this.nButton2);
            this.Controls.Add(this.nButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDSDocGia);
            this.Controls.Add(this.gbDocGia);
            this.Controls.Add(this.lbTTDocGia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDocGia)).EndInit();
            this.gbDocGia.ResumeLayout(false);
            this.gbDocGia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTTDocGia;
        private System.Windows.Forms.DataGridView dgvDSDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLapThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayHetHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDocGia;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbTongNo;
        private System.Windows.Forms.Label lbNgHetHan;
        private System.Windows.Forms.Label lbNgLapThe;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbMaDG;
        private nhapsach.nButton nButton1;
        private nhapsach.nButton nButton2;
        private nhapsach.nButton nButton3;
    }
}

