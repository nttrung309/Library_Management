
namespace formdausach
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
            this.gb_TtDauSach = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxTacGia = new System.Windows.Forms.ListBox();
            this.cbTacGia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTenTL = new System.Windows.Forms.ComboBox();
            this.cbMaTL = new System.Windows.Forms.ComboBox();
            this.lbMaTL = new System.Windows.Forms.Label();
            this.txb_MaDauSach = new System.Windows.Forms.TextBox();
            this.lb_TenTheLoai = new System.Windows.Forms.Label();
            this.txb_TenDauSach = new System.Windows.Forms.TextBox();
            this.lb_MaDauSach = new System.Windows.Forms.Label();
            this.lb_TenDauSach = new System.Windows.Forms.Label();
            this.lb_TTDauSach = new System.Windows.Forms.Label();
            this.lb_DSDauSach = new System.Windows.Forms.Label();
            this.errTenDS = new System.Windows.Forms.ErrorProvider(this.components);
            this.errMaTL = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTenTL = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvDauSach = new System.Windows.Forms.DataGridView();
            this.errTacGia = new System.Windows.Forms.ErrorProvider(this.components);
            this.vbButton1 = new CustomButton.VBButton();
            this.btnUp = new CustomButton.VBButton();
            this.btnDown = new CustomButton.VBButton();
            this.btnXoa = new CustomButton.VBButton();
            this.btnCapNhat = new CustomButton.VBButton();
            this.btnLuu = new CustomButton.VBButton();
            this.btnThemMoi = new CustomButton.VBButton();
            this.gb_TtDauSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errTenDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMaTL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenTL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDauSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTacGia)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_TtDauSach
            // 
            this.gb_TtDauSach.Controls.Add(this.vbButton1);
            this.gb_TtDauSach.Controls.Add(this.label2);
            this.gb_TtDauSach.Controls.Add(this.btnUp);
            this.gb_TtDauSach.Controls.Add(this.btnDown);
            this.gb_TtDauSach.Controls.Add(this.lbxTacGia);
            this.gb_TtDauSach.Controls.Add(this.cbTacGia);
            this.gb_TtDauSach.Controls.Add(this.label1);
            this.gb_TtDauSach.Controls.Add(this.cbTenTL);
            this.gb_TtDauSach.Controls.Add(this.cbMaTL);
            this.gb_TtDauSach.Controls.Add(this.lbMaTL);
            this.gb_TtDauSach.Controls.Add(this.btnXoa);
            this.gb_TtDauSach.Controls.Add(this.btnCapNhat);
            this.gb_TtDauSach.Controls.Add(this.btnLuu);
            this.gb_TtDauSach.Controls.Add(this.btnThemMoi);
            this.gb_TtDauSach.Controls.Add(this.txb_MaDauSach);
            this.gb_TtDauSach.Controls.Add(this.lb_TenTheLoai);
            this.gb_TtDauSach.Controls.Add(this.txb_TenDauSach);
            this.gb_TtDauSach.Controls.Add(this.lb_MaDauSach);
            this.gb_TtDauSach.Controls.Add(this.lb_TenDauSach);
            this.gb_TtDauSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_TtDauSach.ForeColor = System.Drawing.Color.Chocolate;
            this.gb_TtDauSach.Location = new System.Drawing.Point(12, 78);
            this.gb_TtDauSach.Name = "gb_TtDauSach";
            this.gb_TtDauSach.Size = new System.Drawing.Size(509, 600);
            this.gb_TtDauSach.TabIndex = 57;
            this.gb_TtDauSach.TabStop = false;
            this.gb_TtDauSach.Text = "Thông Tin Đầu Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(18, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tác Giả Của Sách:";
            // 
            // lbxTacGia
            // 
            this.lbxTacGia.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxTacGia.FormattingEnabled = true;
            this.lbxTacGia.ItemHeight = 26;
            this.lbxTacGia.Location = new System.Drawing.Point(177, 352);
            this.lbxTacGia.Name = "lbxTacGia";
            this.lbxTacGia.Size = new System.Drawing.Size(264, 134);
            this.lbxTacGia.TabIndex = 18;
            // 
            // cbTacGia
            // 
            this.cbTacGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTacGia.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTacGia.FormattingEnabled = true;
            this.cbTacGia.Items.AddRange(new object[] {
            "hi"});
            this.cbTacGia.Location = new System.Drawing.Point(177, 268);
            this.cbTacGia.Name = "cbTacGia";
            this.cbTacGia.Size = new System.Drawing.Size(264, 34);
            this.cbTacGia.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(18, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tác Giả:";
            // 
            // cbTenTL
            // 
            this.cbTenTL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenTL.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenTL.FormattingEnabled = true;
            this.cbTenTL.Location = new System.Drawing.Point(177, 149);
            this.cbTenTL.Name = "cbTenTL";
            this.cbTenTL.Size = new System.Drawing.Size(264, 34);
            this.cbTenTL.TabIndex = 15;
            this.cbTenTL.SelectedValueChanged += new System.EventHandler(this.cbTenTL_SelectedValueChanged);
            // 
            // cbMaTL
            // 
            this.cbMaTL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaTL.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaTL.FormattingEnabled = true;
            this.cbMaTL.Location = new System.Drawing.Point(177, 210);
            this.cbMaTL.Name = "cbMaTL";
            this.cbMaTL.Size = new System.Drawing.Size(264, 34);
            this.cbMaTL.TabIndex = 14;
            this.cbMaTL.SelectedValueChanged += new System.EventHandler(this.cbMaTL_SelectedValueChanged);
            // 
            // lbMaTL
            // 
            this.lbMaTL.AutoSize = true;
            this.lbMaTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaTL.ForeColor = System.Drawing.Color.Navy;
            this.lbMaTL.Location = new System.Drawing.Point(18, 214);
            this.lbMaTL.Name = "lbMaTL";
            this.lbMaTL.Size = new System.Drawing.Size(128, 25);
            this.lbMaTL.TabIndex = 13;
            this.lbMaTL.Text = "Mã Thể Loại:";
            // 
            // txb_MaDauSach
            // 
            this.txb_MaDauSach.BackColor = System.Drawing.Color.LightGray;
            this.txb_MaDauSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_MaDauSach.Location = new System.Drawing.Point(177, 34);
            this.txb_MaDauSach.Name = "txb_MaDauSach";
            this.txb_MaDauSach.Size = new System.Drawing.Size(264, 34);
            this.txb_MaDauSach.TabIndex = 7;
            // 
            // lb_TenTheLoai
            // 
            this.lb_TenTheLoai.AutoSize = true;
            this.lb_TenTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenTheLoai.ForeColor = System.Drawing.Color.Navy;
            this.lb_TenTheLoai.Location = new System.Drawing.Point(18, 153);
            this.lb_TenTheLoai.Name = "lb_TenTheLoai";
            this.lb_TenTheLoai.Size = new System.Drawing.Size(135, 25);
            this.lb_TenTheLoai.TabIndex = 5;
            this.lb_TenTheLoai.Text = "Tên Thể Loại:";
            // 
            // txb_TenDauSach
            // 
            this.txb_TenDauSach.BackColor = System.Drawing.SystemColors.Control;
            this.txb_TenDauSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_TenDauSach.Location = new System.Drawing.Point(177, 89);
            this.txb_TenDauSach.Name = "txb_TenDauSach";
            this.txb_TenDauSach.Size = new System.Drawing.Size(264, 34);
            this.txb_TenDauSach.TabIndex = 4;
            // 
            // lb_MaDauSach
            // 
            this.lb_MaDauSach.AutoSize = true;
            this.lb_MaDauSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaDauSach.ForeColor = System.Drawing.Color.Navy;
            this.lb_MaDauSach.Location = new System.Drawing.Point(18, 40);
            this.lb_MaDauSach.Name = "lb_MaDauSach";
            this.lb_MaDauSach.Size = new System.Drawing.Size(138, 25);
            this.lb_MaDauSach.TabIndex = 2;
            this.lb_MaDauSach.Text = "Mã Đầu Sách:";
            // 
            // lb_TenDauSach
            // 
            this.lb_TenDauSach.AutoSize = true;
            this.lb_TenDauSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenDauSach.ForeColor = System.Drawing.Color.Navy;
            this.lb_TenDauSach.Location = new System.Drawing.Point(18, 95);
            this.lb_TenDauSach.Name = "lb_TenDauSach";
            this.lb_TenDauSach.Size = new System.Drawing.Size(145, 25);
            this.lb_TenDauSach.TabIndex = 2;
            this.lb_TenDauSach.Text = "Tên Đầu Sách:";
            // 
            // lb_TTDauSach
            // 
            this.lb_TTDauSach.AutoSize = true;
            this.lb_TTDauSach.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TTDauSach.ForeColor = System.Drawing.Color.Navy;
            this.lb_TTDauSach.Location = new System.Drawing.Point(430, 10);
            this.lb_TTDauSach.Name = "lb_TTDauSach";
            this.lb_TTDauSach.Size = new System.Drawing.Size(376, 51);
            this.lb_TTDauSach.TabIndex = 56;
            this.lb_TTDauSach.Text = "Thông Tin Đầu Sách";
            // 
            // lb_DSDauSach
            // 
            this.lb_DSDauSach.AutoSize = true;
            this.lb_DSDauSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DSDauSach.ForeColor = System.Drawing.Color.Chocolate;
            this.lb_DSDauSach.Location = new System.Drawing.Point(696, 61);
            this.lb_DSDauSach.Name = "lb_DSDauSach";
            this.lb_DSDauSach.Size = new System.Drawing.Size(408, 26);
            this.lb_DSDauSach.TabIndex = 54;
            this.lb_DSDauSach.Text = "Danh Sách Đầu Sách Trong Thư Viện";
            // 
            // errTenDS
            // 
            this.errTenDS.ContainerControl = this;
            // 
            // errMaTL
            // 
            this.errMaTL.ContainerControl = this;
            // 
            // errTenTL
            // 
            this.errTenTL.ContainerControl = this;
            // 
            // dgvDauSach
            // 
            this.dgvDauSach.AllowUserToAddRows = false;
            this.dgvDauSach.AllowUserToDeleteRows = false;
            this.dgvDauSach.AllowUserToResizeRows = false;
            this.dgvDauSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDauSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDauSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDauSach.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDauSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDauSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDauSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDauSach.EnableHeadersVisualStyles = false;
            this.dgvDauSach.GridColor = System.Drawing.Color.Navy;
            this.dgvDauSach.Location = new System.Drawing.Point(529, 94);
            this.dgvDauSach.Name = "dgvDauSach";
            this.dgvDauSach.ReadOnly = true;
            this.dgvDauSach.RowHeadersVisible = false;
            this.dgvDauSach.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dgvDauSach.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDauSach.RowTemplate.Height = 24;
            this.dgvDauSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDauSach.Size = new System.Drawing.Size(719, 589);
            this.dgvDauSach.TabIndex = 58;
            this.dgvDauSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDauSach_CellClick);
            // 
            // errTacGia
            // 
            this.errTacGia.ContainerControl = this;
            // 
            // vbButton1
            // 
            this.vbButton1.BackColor = System.Drawing.Color.Green;
            this.vbButton1.BackgroundColor = System.Drawing.Color.Green;
            this.vbButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton1.BorderRadius = 20;
            this.vbButton1.BorderSize = 0;
            this.vbButton1.FlatAppearance.BorderSize = 0;
            this.vbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbButton1.ForeColor = System.Drawing.Color.White;
            this.vbButton1.Location = new System.Drawing.Point(444, 267);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(59, 35);
            this.vbButton1.TabIndex = 22;
            this.vbButton1.Text = "Thêm";
            this.vbButton1.TextColor = System.Drawing.Color.White;
            this.vbButton1.UseVisualStyleBackColor = false;
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUp.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnUp.BackgroundImage = global::formdausach.Properties.Resources._186407_arrow_up_icon;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUp.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUp.BorderRadius = 20;
            this.btnUp.BorderSize = 0;
            this.btnUp.FlatAppearance.BorderSize = 0;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.ForeColor = System.Drawing.Color.White;
            this.btnUp.Location = new System.Drawing.Point(324, 309);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(56, 40);
            this.btnUp.TabIndex = 20;
            this.btnUp.TextColor = System.Drawing.Color.White;
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.LightGreen;
            this.btnDown.BackgroundColor = System.Drawing.Color.LightGreen;
            this.btnDown.BackgroundImage = global::formdausach.Properties.Resources.down_icon_1320166862644492688;
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDown.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDown.BorderRadius = 20;
            this.btnDown.BorderSize = 0;
            this.btnDown.FlatAppearance.BorderSize = 0;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.ForeColor = System.Drawing.Color.White;
            this.btnDown.Location = new System.Drawing.Point(252, 309);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(56, 40);
            this.btnDown.TabIndex = 19;
            this.btnDown.TextColor = System.Drawing.Color.White;
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(280, 554);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(175, 38);
            this.btnXoa.TabIndex = 12;
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
            this.btnCapNhat.Location = new System.Drawing.Point(67, 554);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(175, 38);
            this.btnCapNhat.TabIndex = 11;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.TextColor = System.Drawing.Color.White;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click_1);
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
            this.btnLuu.Location = new System.Drawing.Point(280, 510);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(175, 38);
            this.btnLuu.TabIndex = 10;
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
            this.btnThemMoi.Location = new System.Drawing.Point(67, 510);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(175, 38);
            this.btnThemMoi.TabIndex = 9;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.TextColor = System.Drawing.Color.White;
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1260, 724);
            this.Controls.Add(this.dgvDauSach);
            this.Controls.Add(this.gb_TtDauSach);
            this.Controls.Add(this.lb_TTDauSach);
            this.Controls.Add(this.lb_DSDauSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_TtDauSach.ResumeLayout(false);
            this.gb_TtDauSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errTenDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMaTL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenTL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDauSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTacGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_TtDauSach;
        private System.Windows.Forms.TextBox txb_TenDauSach;
        private System.Windows.Forms.Label lb_MaDauSach;
        private System.Windows.Forms.Label lb_TenDauSach;
        private System.Windows.Forms.Label lb_TTDauSach;
        private System.Windows.Forms.Label lb_DSDauSach;
        private System.Windows.Forms.Label lb_TenTheLoai;
        private System.Windows.Forms.TextBox txb_MaDauSach;
        private CustomButton.VBButton btnXoa;
        private CustomButton.VBButton btnCapNhat;
        private CustomButton.VBButton btnLuu;
        private CustomButton.VBButton btnThemMoi;
        private System.Windows.Forms.ComboBox cbMaTL;
        private System.Windows.Forms.Label lbMaTL;
        private System.Windows.Forms.ErrorProvider errTenDS;
        private System.Windows.Forms.ErrorProvider errMaTL;
        private System.Windows.Forms.ComboBox cbTenTL;
        private System.Windows.Forms.ErrorProvider errTenTL;
        private System.Windows.Forms.DataGridView dgvDauSach;
        private System.Windows.Forms.ComboBox cbTacGia;
        private System.Windows.Forms.Label label1;
        private CustomButton.VBButton btnUp;
        private CustomButton.VBButton btnDown;
        private System.Windows.Forms.ListBox lbxTacGia;
        private System.Windows.Forms.ErrorProvider errTacGia;
        private System.Windows.Forms.Label label2;
        private CustomButton.VBButton vbButton1;
    }
}

