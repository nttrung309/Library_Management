
namespace FormLoaiSach
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
<<<<<<< HEAD
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDanhSachTheLoai = new System.Windows.Forms.DataGridView();
=======
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
>>>>>>> 29b454ce8986fe696f8826cfd6570a4573a2699e
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMaTLS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbMaTheLoai = new System.Windows.Forms.TextBox();
            this.lbMaTheLoai = new System.Windows.Forms.Label();
            this.lbTenTheLoaiSach = new System.Windows.Forms.Label();
            this.txbTenTheLoaiSach = new System.Windows.Forms.TextBox();
            this.btnXoa = new FormLoaiSach.nButton();
            this.btnCapNhat = new FormLoaiSach.nButton();
            this.btnThemMoi = new FormLoaiSach.nButton();
            this.btnLuu = new FormLoaiSach.nButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTheLoai)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhSachTheLoai
            // 
            this.dgvDanhSachTheLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachTheLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachTheLoai.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDanhSachTheLoai.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDanhSachTheLoai.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachTheLoai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachTheLoai.EnableHeadersVisualStyles = false;
            this.dgvDanhSachTheLoai.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDanhSachTheLoai.Location = new System.Drawing.Point(540, 123);
            this.dgvDanhSachTheLoai.Name = "dgvDanhSachTheLoai";
            this.dgvDanhSachTheLoai.RowHeadersVisible = false;
            this.dgvDanhSachTheLoai.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dgvDanhSachTheLoai.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachTheLoai.RowTemplate.Height = 24;
            this.dgvDanhSachTheLoai.Size = new System.Drawing.Size(708, 589);
            this.dgvDanhSachTheLoai.TabIndex = 6;
            this.dgvDanhSachTheLoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
=======
            this.btnXoa = new FormLoaiSach.nButton();
            this.btnThemMoi = new FormLoaiSach.nButton();
            this.btnCapNhat = new FormLoaiSach.nButton();
            this.btnLuu = new FormLoaiSach.nButton();
            this.dgvTLSach = new System.Windows.Forms.DataGridView();
            this.txbTenTLS = new System.Windows.Forms.TextBox();
            this.errTenTLS = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTLSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenTLS)).BeginInit();
            this.SuspendLayout();
            // 
>>>>>>> 29b454ce8986fe696f8826cfd6570a4573a2699e
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Chocolate;
            this.label9.Location = new System.Drawing.Point(658, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(505, 26);
            this.label9.TabIndex = 4;
            this.label9.Text = "Danh Sách Các Thể Loại Sách Trong Thư Viện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(486, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thông Tin Thể Loại Sách";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbTenTLS);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbMaTLS);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThemMoi);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Chocolate;
            this.groupBox1.Location = new System.Drawing.Point(25, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 596);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Loại Sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(18, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Thể Loại:";
            // 
            // txbMaTLS
            // 
            this.txbMaTLS.BackColor = System.Drawing.Color.LightGray;
            this.txbMaTLS.Enabled = false;
            this.txbMaTLS.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaTLS.Location = new System.Drawing.Point(180, 63);
            this.txbMaTLS.Name = "txbMaTLS";
            this.txbMaTLS.Size = new System.Drawing.Size(296, 34);
            this.txbMaTLS.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(18, 141);
            this.label4.Name = "label4";
<<<<<<< HEAD
            this.label4.Size = new System.Drawing.Size(243, 29);
            this.label4.TabIndex = 48;
            this.label4.Text = "Thông Tin Thể Loại";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbTenTheLoaiSach);
            this.panel3.Controls.Add(this.txbMaTheLoai);
            this.panel3.Controls.Add(this.lbMaTheLoai);
            this.panel3.Controls.Add(this.lbTenTheLoaiSach);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnCapNhat);
            this.panel3.Controls.Add(this.btnThemMoi);
            this.panel3.Controls.Add(this.btnLuu);
            this.panel3.Location = new System.Drawing.Point(18, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(504, 589);
            this.panel3.TabIndex = 47;
            // 
            // txbMaTheLoai
            // 
            this.txbMaTheLoai.BackColor = System.Drawing.SystemColors.Control;
            this.txbMaTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaTheLoai.Location = new System.Drawing.Point(178, 72);
            this.txbMaTheLoai.Name = "txbMaTheLoai";
            this.txbMaTheLoai.Size = new System.Drawing.Size(296, 30);
            this.txbMaTheLoai.TabIndex = 3;
            // 
            // lbMaTheLoai
            // 
            this.lbMaTheLoai.AutoSize = true;
            this.lbMaTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaTheLoai.ForeColor = System.Drawing.Color.Navy;
            this.lbMaTheLoai.Location = new System.Drawing.Point(26, 75);
            this.lbMaTheLoai.Name = "lbMaTheLoai";
            this.lbMaTheLoai.Size = new System.Drawing.Size(128, 25);
            this.lbMaTheLoai.TabIndex = 2;
            this.lbMaTheLoai.Text = "Mã Thể Loại:";
            // 
            // lbTenTheLoaiSach
            // 
            this.lbTenTheLoaiSach.AutoSize = true;
            this.lbTenTheLoaiSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTheLoaiSach.ForeColor = System.Drawing.Color.Navy;
            this.lbTenTheLoaiSach.Location = new System.Drawing.Point(27, 179);
            this.lbTenTheLoaiSach.Name = "lbTenTheLoaiSach";
            this.lbTenTheLoaiSach.Size = new System.Drawing.Size(135, 25);
            this.lbTenTheLoaiSach.TabIndex = 2;
            this.lbTenTheLoaiSach.Text = "Tên Thể Loại:";
            // 
            // txbTenTheLoaiSach
            // 
            this.txbTenTheLoaiSach.BackColor = System.Drawing.SystemColors.Control;
            this.txbTenTheLoaiSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenTheLoaiSach.Location = new System.Drawing.Point(178, 176);
            this.txbTenTheLoaiSach.Name = "txbTenTheLoaiSach";
            this.txbTenTheLoaiSach.Size = new System.Drawing.Size(296, 30);
            this.txbTenTheLoaiSach.TabIndex = 3;
=======
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên Thể Loại:";
>>>>>>> 29b454ce8986fe696f8826cfd6570a4573a2699e
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
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
            this.btnXoa.Location = new System.Drawing.Point(262, 424);
=======
            this.btnXoa.Location = new System.Drawing.Point(276, 365);
>>>>>>> 29b454ce8986fe696f8826cfd6570a4573a2699e
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(175, 50);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
<<<<<<< HEAD
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.btnCapNhat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.btnCapNhat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCapNhat.BorderRadius = 20;
            this.btnCapNhat.BorderSize = 0;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(61, 424);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(175, 50);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.TextColor = System.Drawing.Color.White;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
=======
>>>>>>> 29b454ce8986fe696f8826cfd6570a4573a2699e
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.Color.YellowGreen;
            this.btnThemMoi.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.btnThemMoi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThemMoi.BorderRadius = 20;
            this.btnThemMoi.BorderSize = 0;
            this.btnThemMoi.FlatAppearance.BorderSize = 0;
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
            this.btnThemMoi.Location = new System.Drawing.Point(61, 328);
=======
            this.btnThemMoi.Location = new System.Drawing.Point(64, 284);
>>>>>>> 29b454ce8986fe696f8826cfd6570a4573a2699e
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(175, 50);
            this.btnThemMoi.TabIndex = 2;
            this.btnThemMoi.Text = "Thêm Mới";
            this.btnThemMoi.TextColor = System.Drawing.Color.White;
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
<<<<<<< HEAD
=======
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.btnCapNhat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.btnCapNhat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCapNhat.BorderRadius = 20;
            this.btnCapNhat.BorderSize = 0;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(64, 365);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(175, 50);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.TextColor = System.Drawing.Color.White;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
>>>>>>> 29b454ce8986fe696f8826cfd6570a4573a2699e
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Violet;
            this.btnLuu.BackgroundColor = System.Drawing.Color.Violet;
            this.btnLuu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLuu.BorderRadius = 20;
            this.btnLuu.BorderSize = 0;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
            this.btnLuu.Location = new System.Drawing.Point(262, 328);
=======
            this.btnLuu.Location = new System.Drawing.Point(276, 284);
>>>>>>> 29b454ce8986fe696f8826cfd6570a4573a2699e
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(175, 50);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextColor = System.Drawing.Color.White;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
<<<<<<< HEAD
=======
            // 
            // dgvTLSach
            // 
            this.dgvTLSach.AllowUserToAddRows = false;
            this.dgvTLSach.AllowUserToDeleteRows = false;
            this.dgvTLSach.AllowUserToResizeRows = false;
            this.dgvTLSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTLSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTLSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTLSach.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTLSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTLSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvTLSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTLSach.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvTLSach.EnableHeadersVisualStyles = false;
            this.dgvTLSach.GridColor = System.Drawing.Color.Navy;
            this.dgvTLSach.Location = new System.Drawing.Point(540, 120);
            this.dgvTLSach.Name = "dgvTLSach";
            this.dgvTLSach.ReadOnly = true;
            this.dgvTLSach.RowHeadersVisible = false;
            this.dgvTLSach.RowHeadersWidth = 51;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dgvTLSach.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvTLSach.RowTemplate.Height = 24;
            this.dgvTLSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTLSach.Size = new System.Drawing.Size(719, 589);
            this.dgvTLSach.TabIndex = 50;
            this.dgvTLSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTLSach_CellClick);
            // 
            // txbTenTLS
            // 
            this.txbTenTLS.BackColor = System.Drawing.SystemColors.Control;
            this.txbTenTLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenTLS.Location = new System.Drawing.Point(180, 135);
            this.txbTenTLS.Name = "txbTenTLS";
            this.txbTenTLS.Size = new System.Drawing.Size(296, 34);
            this.txbTenTLS.TabIndex = 5;
            // 
            // errTenTLS
            // 
            this.errTenTLS.ContainerControl = this;
>>>>>>> 29b454ce8986fe696f8826cfd6570a4573a2699e
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1260, 724);
            this.Controls.Add(this.dgvTLSach);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
<<<<<<< HEAD
            this.Controls.Add(this.dgvDanhSachTheLoai);
=======
>>>>>>> 29b454ce8986fe696f8826cfd6570a4573a2699e
            this.ForeColor = System.Drawing.Color.Chocolate;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTheLoai)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
=======
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTLSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenTLS)).EndInit();
>>>>>>> 29b454ce8986fe696f8826cfd6570a4573a2699e
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
<<<<<<< HEAD
        private System.Windows.Forms.DataGridView dgvDanhSachTheLoai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbMaTheLoai;
        private System.Windows.Forms.Label lbMaTheLoai;
        private System.Windows.Forms.Label lbTenTheLoaiSach;
        private FormLoaiSach.nButton btnXoa;
        private FormLoaiSach.nButton btnCapNhat;
        private FormLoaiSach.nButton btnThemMoi;
        private FormLoaiSach.nButton btnLuu;
        private System.Windows.Forms.TextBox txbTenTheLoaiSach;
=======
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private FormLoaiSach.nButton btnXoa;
        private FormLoaiSach.nButton btnCapNhat;
        private FormLoaiSach.nButton btnThemMoi;
        private FormLoaiSach.nButton btnLuu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMaTLS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvTLSach;
        private System.Windows.Forms.TextBox txbTenTLS;
        private System.Windows.Forms.ErrorProvider errTenTLS;
>>>>>>> 29b454ce8986fe696f8826cfd6570a4573a2699e
    }
}

