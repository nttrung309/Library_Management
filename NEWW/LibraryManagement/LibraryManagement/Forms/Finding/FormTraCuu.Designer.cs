
namespace TraCuuSach
{
    partial class FormTraCuu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbTieude1 = new System.Windows.Forms.Label();
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDanhSachCuonSach = new System.Windows.Forms.DataGridView();
            this.gbThongKe = new TraCuuSach.VBButton();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbTongSoSach = new System.Windows.Forms.Label();
            this.lbTongSoTheLoai = new System.Windows.Forms.Label();
            this.lbTongSoTacGia = new System.Windows.Forms.Label();
            this.gbBoLoc = new TraCuuSach.VBButton();
            this.radioButton5 = new TraCuuSach.RJRadioButton();
            this.radioButton3 = new TraCuuSach.RJRadioButton();
            this.radioButton2 = new TraCuuSach.RJRadioButton();
            this.radioButton1 = new TraCuuSach.RJRadioButton();
            this.radioButton4 = new TraCuuSach.RJRadioButton();
            this.cbTenSach = new System.Windows.Forms.ComboBox();
            this.btnXuatExcel = new TraCuuSach.But();
            this.btnHuy = new TraCuuSach.But();
            this.btnApDung = new TraCuuSach.But();
            this.lbTenSach = new System.Windows.Forms.Label();
            this.lbMaSach = new System.Windows.Forms.Label();
            this.lbTacGia = new System.Windows.Forms.Label();
            this.lbTheLoai = new System.Windows.Forms.Label();
            this.cbTacGia = new System.Windows.Forms.ComboBox();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.cbMaSach = new System.Windows.Forms.ComboBox();
            this.cbTheLoai = new System.Windows.Forms.ComboBox();
            this.lbTinhTrang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCuonSach)).BeginInit();
            this.gbThongKe.SuspendLayout();
            this.gbBoLoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTieude1
            // 
            this.lbTieude1.AutoSize = true;
            this.lbTieude1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbTieude1.ForeColor = System.Drawing.Color.Chocolate;
            this.lbTieude1.Location = new System.Drawing.Point(463, 392);
            this.lbTieude1.Name = "lbTieude1";
            this.lbTieude1.Size = new System.Drawing.Size(306, 32);
            this.lbTieude1.TabIndex = 2;
            this.lbTieude1.Text = "Danh Sách Các Cuốn Sách";
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lbTieuDe.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.ForeColor = System.Drawing.Color.Navy;
            this.lbTieuDe.Location = new System.Drawing.Point(515, 10);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(234, 47);
            this.lbTieuDe.TabIndex = 3;
            this.lbTieuDe.Text = "Tra Cứu Sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Chocolate;
            this.label3.Location = new System.Drawing.Point(73, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bộ Loc";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgvDanhSachCuonSach
            // 
            this.dgvDanhSachCuonSach.AllowUserToAddRows = false;
            this.dgvDanhSachCuonSach.AllowUserToDeleteRows = false;
            this.dgvDanhSachCuonSach.AllowUserToResizeRows = false;
            this.dgvDanhSachCuonSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachCuonSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachCuonSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDanhSachCuonSach.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDanhSachCuonSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachCuonSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachCuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachCuonSach.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachCuonSach.EnableHeadersVisualStyles = false;
            this.dgvDanhSachCuonSach.GridColor = System.Drawing.Color.Navy;
            this.dgvDanhSachCuonSach.Location = new System.Drawing.Point(42, 436);
            this.dgvDanhSachCuonSach.Name = "dgvDanhSachCuonSach";
            this.dgvDanhSachCuonSach.ReadOnly = true;
            this.dgvDanhSachCuonSach.RowHeadersVisible = false;
            this.dgvDanhSachCuonSach.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachCuonSach.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachCuonSach.RowTemplate.Height = 24;
            this.dgvDanhSachCuonSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachCuonSach.Size = new System.Drawing.Size(1176, 276);
            this.dgvDanhSachCuonSach.TabIndex = 21;
            this.dgvDanhSachCuonSach.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // gbThongKe
            // 
            this.gbThongKe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbThongKe.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbThongKe.BorderColor = System.Drawing.Color.Navy;
            this.gbThongKe.BorderRadius = 20;
            this.gbThongKe.BorderSize = 1;
            this.gbThongKe.Controls.Add(this.label14);
            this.gbThongKe.Controls.Add(this.label13);
            this.gbThongKe.Controls.Add(this.label12);
            this.gbThongKe.Controls.Add(this.lbTongSoSach);
            this.gbThongKe.Controls.Add(this.lbTongSoTheLoai);
            this.gbThongKe.Controls.Add(this.lbTongSoTacGia);
            this.gbThongKe.ForeColor = System.Drawing.Color.White;
            this.gbThongKe.Location = new System.Drawing.Point(907, 73);
            this.gbThongKe.Name = "gbThongKe";
            this.gbThongKe.Size = new System.Drawing.Size(341, 294);
            this.gbThongKe.TabIndex = 20;
            this.gbThongKe.TextColor = System.Drawing.Color.White;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(296, 197);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 26);
            this.label14.TabIndex = 20;
            this.label14.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(296, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 26);
            this.label13.TabIndex = 20;
            this.label13.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(296, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 26);
            this.label12.TabIndex = 20;
            this.label12.Text = "0";
            // 
            // lbTongSoSach
            // 
            this.lbTongSoSach.AutoSize = true;
            this.lbTongSoSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongSoSach.ForeColor = System.Drawing.Color.Navy;
            this.lbTongSoSach.Location = new System.Drawing.Point(18, 64);
            this.lbTongSoSach.Name = "lbTongSoSach";
            this.lbTongSoSach.Size = new System.Drawing.Size(155, 26);
            this.lbTongSoSach.TabIndex = 20;
            this.lbTongSoSach.Text = "Tổng Số Sách:";
            // 
            // lbTongSoTheLoai
            // 
            this.lbTongSoTheLoai.AutoSize = true;
            this.lbTongSoTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongSoTheLoai.ForeColor = System.Drawing.Color.Navy;
            this.lbTongSoTheLoai.Location = new System.Drawing.Point(18, 129);
            this.lbTongSoTheLoai.Name = "lbTongSoTheLoai";
            this.lbTongSoTheLoai.Size = new System.Drawing.Size(201, 26);
            this.lbTongSoTheLoai.TabIndex = 21;
            this.lbTongSoTheLoai.Text = "Tổng Số Đầu Sách:";
            // 
            // lbTongSoTacGia
            // 
            this.lbTongSoTacGia.AutoSize = true;
            this.lbTongSoTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongSoTacGia.ForeColor = System.Drawing.Color.Navy;
            this.lbTongSoTacGia.Location = new System.Drawing.Point(18, 197);
            this.lbTongSoTacGia.Name = "lbTongSoTacGia";
            this.lbTongSoTacGia.Size = new System.Drawing.Size(273, 26);
            this.lbTongSoTacGia.TabIndex = 22;
            this.lbTongSoTacGia.Text = "Tổng Số Sách Đang Mượn:";
            // 
            // gbBoLoc
            // 
            this.gbBoLoc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbBoLoc.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbBoLoc.BorderColor = System.Drawing.Color.Navy;
            this.gbBoLoc.BorderRadius = 20;
            this.gbBoLoc.BorderSize = 1;
            this.gbBoLoc.Controls.Add(this.radioButton5);
            this.gbBoLoc.Controls.Add(this.radioButton3);
            this.gbBoLoc.Controls.Add(this.radioButton2);
            this.gbBoLoc.Controls.Add(this.radioButton1);
            this.gbBoLoc.Controls.Add(this.radioButton4);
            this.gbBoLoc.Controls.Add(this.cbTenSach);
            this.gbBoLoc.Controls.Add(this.btnXuatExcel);
            this.gbBoLoc.Controls.Add(this.btnHuy);
            this.gbBoLoc.Controls.Add(this.btnApDung);
            this.gbBoLoc.Controls.Add(this.lbTenSach);
            this.gbBoLoc.Controls.Add(this.lbMaSach);
            this.gbBoLoc.Controls.Add(this.lbTacGia);
            this.gbBoLoc.Controls.Add(this.lbTheLoai);
            this.gbBoLoc.Controls.Add(this.cbTacGia);
            this.gbBoLoc.Controls.Add(this.cbTinhTrang);
            this.gbBoLoc.Controls.Add(this.cbMaSach);
            this.gbBoLoc.Controls.Add(this.cbTheLoai);
            this.gbBoLoc.Controls.Add(this.lbTinhTrang);
            this.gbBoLoc.ForeColor = System.Drawing.Color.White;
            this.gbBoLoc.Location = new System.Drawing.Point(38, 73);
            this.gbBoLoc.Name = "gbBoLoc";
            this.gbBoLoc.Size = new System.Drawing.Size(847, 294);
            this.gbBoLoc.TabIndex = 8;
            this.gbBoLoc.TextColor = System.Drawing.Color.White;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButton5.CheckedColor = System.Drawing.Color.MidnightBlue;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(211, 169);
            this.radioButton5.MinimumSize = new System.Drawing.Size(0, 21);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radioButton5.Size = new System.Drawing.Size(24, 21);
            this.radioButton5.TabIndex = 23;
            this.radioButton5.TabStop = true;
            this.radioButton5.UnCheckedColor = System.Drawing.Color.Black;
            this.radioButton5.UseVisualStyleBackColor = false;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButton3.CheckedColor = System.Drawing.Color.MidnightBlue;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(474, 99);
            this.radioButton3.MinimumSize = new System.Drawing.Size(0, 21);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radioButton3.Size = new System.Drawing.Size(24, 21);
            this.radioButton3.TabIndex = 23;
            this.radioButton3.TabStop = true;
            this.radioButton3.UnCheckedColor = System.Drawing.Color.Black;
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButton2.CheckedColor = System.Drawing.Color.MidnightBlue;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(38, 99);
            this.radioButton2.MinimumSize = new System.Drawing.Size(0, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radioButton2.Size = new System.Drawing.Size(24, 21);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.TabStop = true;
            this.radioButton2.UnCheckedColor = System.Drawing.Color.Black;
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButton1.CheckedColor = System.Drawing.Color.MidnightBlue;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(38, 32);
            this.radioButton1.MinimumSize = new System.Drawing.Size(0, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radioButton1.Size = new System.Drawing.Size(24, 21);
            this.radioButton1.TabIndex = 23;
            this.radioButton1.TabStop = true;
            this.radioButton1.UnCheckedColor = System.Drawing.Color.Black;
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButton4.CheckedColor = System.Drawing.Color.MidnightBlue;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(474, 34);
            this.radioButton4.MinimumSize = new System.Drawing.Size(0, 21);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radioButton4.Size = new System.Drawing.Size(24, 21);
            this.radioButton4.TabIndex = 23;
            this.radioButton4.TabStop = true;
            this.radioButton4.UnCheckedColor = System.Drawing.Color.Black;
            this.radioButton4.UseVisualStyleBackColor = false;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // cbTenSach
            // 
            this.cbTenSach.Enabled = false;
            this.cbTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenSach.FormattingEnabled = true;
            this.cbTenSach.ItemHeight = 22;
            this.cbTenSach.Location = new System.Drawing.Point(176, 98);
            this.cbTenSach.Name = "cbTenSach";
            this.cbTenSach.Size = new System.Drawing.Size(265, 30);
            this.cbTenSach.TabIndex = 0;
            this.cbTenSach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTenSach_KeyPress);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuatExcel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnXuatExcel.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnXuatExcel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXuatExcel.BorderRadius = 20;
            this.btnXuatExcel.BorderSize = 0;
            this.btnXuatExcel.FlatAppearance.BorderSize = 0;
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.Location = new System.Drawing.Point(530, 232);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(156, 47);
            this.btnXuatExcel.TabIndex = 1;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.TextColor = System.Drawing.Color.White;
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BackColor = System.Drawing.Color.LightCoral;
            this.btnHuy.BackgroundColor = System.Drawing.Color.LightCoral;
            this.btnHuy.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHuy.BorderRadius = 20;
            this.btnHuy.BorderSize = 0;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(346, 232);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(156, 47);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextColor = System.Drawing.Color.White;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.but1_Click);
            // 
            // btnApDung
            // 
            this.btnApDung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApDung.BackColor = System.Drawing.Color.YellowGreen;
            this.btnApDung.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.btnApDung.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnApDung.BorderRadius = 20;
            this.btnApDung.BorderSize = 0;
            this.btnApDung.FlatAppearance.BorderSize = 0;
            this.btnApDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApDung.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.btnApDung.ForeColor = System.Drawing.Color.White;
            this.btnApDung.Location = new System.Drawing.Point(157, 232);
            this.btnApDung.Name = "btnApDung";
            this.btnApDung.Size = new System.Drawing.Size(156, 47);
            this.btnApDung.TabIndex = 11;
            this.btnApDung.Text = "Áp Dụng ";
            this.btnApDung.TextColor = System.Drawing.Color.White;
            this.btnApDung.UseVisualStyleBackColor = false;
            this.btnApDung.Click += new System.EventHandler(this.but2_Click);
            // 
            // lbTenSach
            // 
            this.lbTenSach.AutoSize = true;
            this.lbTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSach.ForeColor = System.Drawing.Color.Navy;
            this.lbTenSach.Location = new System.Drawing.Point(66, 97);
            this.lbTenSach.Name = "lbTenSach";
            this.lbTenSach.Size = new System.Drawing.Size(110, 26);
            this.lbTenSach.TabIndex = 19;
            this.lbTenSach.Text = "Tên Sách:";
            // 
            // lbMaSach
            // 
            this.lbMaSach.AutoSize = true;
            this.lbMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSach.ForeColor = System.Drawing.Color.Navy;
            this.lbMaSach.Location = new System.Drawing.Point(71, 32);
            this.lbMaSach.Name = "lbMaSach";
            this.lbMaSach.Size = new System.Drawing.Size(104, 26);
            this.lbMaSach.TabIndex = 18;
            this.lbMaSach.Text = "Mã Sách:";
            // 
            // lbTacGia
            // 
            this.lbTacGia.AutoSize = true;
            this.lbTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTacGia.ForeColor = System.Drawing.Color.Navy;
            this.lbTacGia.Location = new System.Drawing.Point(498, 99);
            this.lbTacGia.Name = "lbTacGia";
            this.lbTacGia.Size = new System.Drawing.Size(93, 26);
            this.lbTacGia.TabIndex = 17;
            this.lbTacGia.Text = "Tác Giả:";
            // 
            // lbTheLoai
            // 
            this.lbTheLoai.AutoSize = true;
            this.lbTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTheLoai.ForeColor = System.Drawing.Color.Navy;
            this.lbTheLoai.Location = new System.Drawing.Point(497, 33);
            this.lbTheLoai.Name = "lbTheLoai";
            this.lbTheLoai.Size = new System.Drawing.Size(101, 26);
            this.lbTheLoai.TabIndex = 16;
            this.lbTheLoai.Text = "Thể Loại:";
            // 
            // cbTacGia
            // 
            this.cbTacGia.Enabled = false;
            this.cbTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTacGia.FormattingEnabled = true;
            this.cbTacGia.Location = new System.Drawing.Point(599, 99);
            this.cbTacGia.Name = "cbTacGia";
            this.cbTacGia.Size = new System.Drawing.Size(235, 30);
            this.cbTacGia.TabIndex = 0;
            this.cbTacGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTacGia_KeyPress);
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.Enabled = false;
            this.cbTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Items.AddRange(new object[] {
            "Đang Mượn",
            "Chưa Mượn"});
            this.cbTinhTrang.Location = new System.Drawing.Point(363, 169);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(257, 30);
            this.cbTinhTrang.TabIndex = 0;
            this.cbTinhTrang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTinhTrang_KeyPress);
            // 
            // cbMaSach
            // 
            this.cbMaSach.Enabled = false;
            this.cbMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaSach.FormattingEnabled = true;
            this.cbMaSach.Location = new System.Drawing.Point(176, 33);
            this.cbMaSach.Name = "cbMaSach";
            this.cbMaSach.Size = new System.Drawing.Size(265, 30);
            this.cbMaSach.TabIndex = 0;
            this.cbMaSach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // cbTheLoai
            // 
            this.cbTheLoai.Enabled = false;
            this.cbTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTheLoai.FormattingEnabled = true;
            this.cbTheLoai.Location = new System.Drawing.Point(600, 34);
            this.cbTheLoai.Name = "cbTheLoai";
            this.cbTheLoai.Size = new System.Drawing.Size(234, 30);
            this.cbTheLoai.TabIndex = 0;
            this.cbTheLoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox2_KeyPress);
            // 
            // lbTinhTrang
            // 
            this.lbTinhTrang.AutoSize = true;
            this.lbTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTinhTrang.ForeColor = System.Drawing.Color.Navy;
            this.lbTinhTrang.Location = new System.Drawing.Point(234, 168);
            this.lbTinhTrang.Name = "lbTinhTrang";
            this.lbTinhTrang.Size = new System.Drawing.Size(120, 26);
            this.lbTinhTrang.TabIndex = 15;
            this.lbTinhTrang.Text = "Tình Trạng:";
            // 
            // FormTraCuu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1260, 724);
            this.Controls.Add(this.dgvDanhSachCuonSach);
            this.Controls.Add(this.gbThongKe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbBoLoc);
            this.Controls.Add(this.lbTieuDe);
            this.Controls.Add(this.lbTieude1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Chocolate;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTraCuu";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCuonSach)).EndInit();
            this.gbThongKe.ResumeLayout(false);
            this.gbThongKe.PerformLayout();
            this.gbBoLoc.ResumeLayout(false);
            this.gbBoLoc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTieude1;
        private System.Windows.Forms.Label lbTieuDe;
        private VBButton gbBoLoc;
        private System.Windows.Forms.ComboBox cbTenSach;
        private System.Windows.Forms.ComboBox cbTacGia;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.ComboBox cbTheLoai;
        private System.Windows.Forms.Label lbTongSoTacGia;
        private System.Windows.Forms.Label lbTongSoTheLoai;
        private System.Windows.Forms.Label lbTongSoSach;
        private System.Windows.Forms.Label lbTenSach;
        private System.Windows.Forms.Label lbMaSach;
        private System.Windows.Forms.Label lbTacGia;
        private System.Windows.Forms.Label lbTheLoai;
        private System.Windows.Forms.Label lbTinhTrang;
        private System.Windows.Forms.Label label3;
        private But btnApDung;
        private VBButton gbThongKe;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbMaSach;
        private But btnHuy;
        private But btnXuatExcel;
        private System.Windows.Forms.DataGridView dgvDanhSachCuonSach;
        private RJRadioButton radioButton4;
        private RJRadioButton radioButton3;
        private RJRadioButton radioButton5;
        private RJRadioButton radioButton2;
        private RJRadioButton radioButton1;
    }
}