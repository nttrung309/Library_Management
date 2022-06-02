
namespace FormSach
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
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.lbTieude2 = new System.Windows.Forms.Label();
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.txbMaSach = new System.Windows.Forms.TextBox();
            this.lbMaSach = new System.Windows.Forms.Label();
            this.lbTenSach = new System.Windows.Forms.Label();
            this.gbThongTinSach = new System.Windows.Forms.GroupBox();
            this.cbTenSach = new System.Windows.Forms.ComboBox();
            this.cbMaDS = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNamXuatBan = new System.Windows.Forms.DateTimePicker();
            this.txbGiaTien = new System.Windows.Forms.TextBox();
            this.txbSoLuongTon = new System.Windows.Forms.TextBox();
            this.txbNhaXuatBan = new System.Windows.Forms.TextBox();
            this.lbTenTacGia = new System.Windows.Forms.Label();
            this.lbGiaTien = new System.Windows.Forms.Label();
            this.lbSoLuongTon = new System.Windows.Forms.Label();
            this.lbNhaXuatBan = new System.Windows.Forms.Label();
            this.lbNamXuatBan = new System.Windows.Forms.Label();
            this.txbTenTG = new System.Windows.Forms.TextBox();
            this.errMaDS = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTenDS = new System.Windows.Forms.ErrorProvider(this.components);
            this.errNXB = new System.Windows.Forms.ErrorProvider(this.components);
            this.errGiaTien = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCapNhat = new ThayDoiQuyDinh.nButton();
            this.btnLuu = new ThayDoiQuyDinh.nButton();
            this.btnThemMoi = new ThayDoiQuyDinh.nButton();
            this.btnXoa = new ThayDoiQuyDinh.nButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.gbThongTinSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMaDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNXB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errGiaTien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSach
            // 
            this.dgvSach.AllowUserToAddRows = false;
            this.dgvSach.AllowUserToDeleteRows = false;
            this.dgvSach.AllowUserToResizeRows = false;
            this.dgvSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSach.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSach.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSach.EnableHeadersVisualStyles = false;
            this.dgvSach.GridColor = System.Drawing.Color.Navy;
            this.dgvSach.Location = new System.Drawing.Point(12, 384);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.RowHeadersVisible = false;
            this.dgvSach.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dgvSach.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSach.RowTemplate.Height = 24;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.Size = new System.Drawing.Size(1236, 328);
            this.dgvSach.TabIndex = 6;
            this.dgvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellClick);
            // 
            // lbTieude2
            // 
            this.lbTieude2.AutoSize = true;
            this.lbTieude2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieude2.ForeColor = System.Drawing.Color.Chocolate;
            this.lbTieude2.Location = new System.Drawing.Point(448, 355);
            this.lbTieude2.Name = "lbTieude2";
            this.lbTieude2.Size = new System.Drawing.Size(323, 26);
            this.lbTieude2.TabIndex = 4;
            this.lbTieude2.Text = "Dữ Liệu Sách Trong Thư Viện";
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.ForeColor = System.Drawing.Color.Navy;
            this.lbTieuDe.Location = new System.Drawing.Point(494, 9);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(241, 36);
            this.lbTieuDe.TabIndex = 7;
            this.lbTieuDe.Text = "Thông Tin Sách";
            this.lbTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbMaSach
            // 
            this.txbMaSach.BackColor = System.Drawing.Color.LightGray;
            this.txbMaSach.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaSach.Location = new System.Drawing.Point(159, 53);
            this.txbMaSach.Name = "txbMaSach";
            this.txbMaSach.Size = new System.Drawing.Size(267, 34);
            this.txbMaSach.TabIndex = 3;
            this.txbMaSach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMaSach_KeyPress);
            // 
            // lbMaSach
            // 
            this.lbMaSach.AutoSize = true;
            this.lbMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSach.ForeColor = System.Drawing.Color.Navy;
            this.lbMaSach.Location = new System.Drawing.Point(37, 57);
            this.lbMaSach.Name = "lbMaSach";
            this.lbMaSach.Size = new System.Drawing.Size(97, 25);
            this.lbMaSach.TabIndex = 2;
            this.lbMaSach.Text = "Mã Sách:";
            // 
            // lbTenSach
            // 
            this.lbTenSach.AutoSize = true;
            this.lbTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSach.ForeColor = System.Drawing.Color.Navy;
            this.lbTenSach.Location = new System.Drawing.Point(36, 125);
            this.lbTenSach.Name = "lbTenSach";
            this.lbTenSach.Size = new System.Drawing.Size(104, 25);
            this.lbTenSach.TabIndex = 2;
            this.lbTenSach.Text = "Tên Sách:";
            // 
            // gbThongTinSach
            // 
            this.gbThongTinSach.Controls.Add(this.cbTenSach);
            this.gbThongTinSach.Controls.Add(this.cbMaDS);
            this.gbThongTinSach.Controls.Add(this.label1);
            this.gbThongTinSach.Controls.Add(this.dtpNamXuatBan);
            this.gbThongTinSach.Controls.Add(this.btnCapNhat);
            this.gbThongTinSach.Controls.Add(this.txbGiaTien);
            this.gbThongTinSach.Controls.Add(this.btnLuu);
            this.gbThongTinSach.Controls.Add(this.txbSoLuongTon);
            this.gbThongTinSach.Controls.Add(this.txbNhaXuatBan);
            this.gbThongTinSach.Controls.Add(this.btnThemMoi);
            this.gbThongTinSach.Controls.Add(this.lbTenTacGia);
            this.gbThongTinSach.Controls.Add(this.btnXoa);
            this.gbThongTinSach.Controls.Add(this.lbGiaTien);
            this.gbThongTinSach.Controls.Add(this.lbMaSach);
            this.gbThongTinSach.Controls.Add(this.lbSoLuongTon);
            this.gbThongTinSach.Controls.Add(this.lbNhaXuatBan);
            this.gbThongTinSach.Controls.Add(this.txbMaSach);
            this.gbThongTinSach.Controls.Add(this.lbTenSach);
            this.gbThongTinSach.Controls.Add(this.lbNamXuatBan);
            this.gbThongTinSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTinSach.ForeColor = System.Drawing.Color.Chocolate;
            this.gbThongTinSach.Location = new System.Drawing.Point(12, 38);
            this.gbThongTinSach.Name = "gbThongTinSach";
            this.gbThongTinSach.Size = new System.Drawing.Size(1237, 314);
            this.gbThongTinSach.TabIndex = 48;
            this.gbThongTinSach.TabStop = false;
            this.gbThongTinSach.Text = "Thông Tin Sách";
            // 
            // cbTenSach
            // 
            this.cbTenSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenSach.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenSach.FormattingEnabled = true;
            this.cbTenSach.Location = new System.Drawing.Point(159, 119);
            this.cbTenSach.Name = "cbTenSach";
            this.cbTenSach.Size = new System.Drawing.Size(266, 34);
            this.cbTenSach.TabIndex = 4;
            this.cbTenSach.SelectedValueChanged += new System.EventHandler(this.cbTenSach_SelectedValueChanged);
            // 
            // cbMaDS
            // 
            this.cbMaDS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaDS.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaDS.FormattingEnabled = true;
            this.cbMaDS.Location = new System.Drawing.Point(160, 187);
            this.cbMaDS.Name = "cbMaDS";
            this.cbMaDS.Size = new System.Drawing.Size(266, 34);
            this.cbMaDS.TabIndex = 8;
            this.cbMaDS.SelectedValueChanged += new System.EventHandler(this.cbMaDS_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(36, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã Đầu Sách:";
            // 
            // dtpNamXuatBan
            // 
            this.dtpNamXuatBan.CustomFormat = "yyyy";
            this.dtpNamXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNamXuatBan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNamXuatBan.Location = new System.Drawing.Point(965, 49);
            this.dtpNamXuatBan.Name = "dtpNamXuatBan";
            this.dtpNamXuatBan.ShowUpDown = true;
            this.dtpNamXuatBan.Size = new System.Drawing.Size(266, 34);
            this.dtpNamXuatBan.TabIndex = 6;
            // 
            // txbGiaTien
            // 
            this.txbGiaTien.BackColor = System.Drawing.SystemColors.Control;
            this.txbGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGiaTien.Location = new System.Drawing.Point(555, 185);
            this.txbGiaTien.Name = "txbGiaTien";
            this.txbGiaTien.Size = new System.Drawing.Size(267, 34);
            this.txbGiaTien.TabIndex = 6;
            // 
            // txbSoLuongTon
            // 
            this.txbSoLuongTon.BackColor = System.Drawing.Color.LightGray;
            this.txbSoLuongTon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSoLuongTon.Location = new System.Drawing.Point(967, 117);
            this.txbSoLuongTon.Name = "txbSoLuongTon";
            this.txbSoLuongTon.Size = new System.Drawing.Size(267, 34);
            this.txbSoLuongTon.TabIndex = 4;
            this.txbSoLuongTon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSoLuongTon_KeyPress);
            // 
            // txbNhaXuatBan
            // 
            this.txbNhaXuatBan.BackColor = System.Drawing.SystemColors.Control;
            this.txbNhaXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNhaXuatBan.Location = new System.Drawing.Point(555, 117);
            this.txbNhaXuatBan.Name = "txbNhaXuatBan";
            this.txbNhaXuatBan.Size = new System.Drawing.Size(267, 34);
            this.txbNhaXuatBan.TabIndex = 5;
            // 
            // lbTenTacGia
            // 
            this.lbTenTacGia.AutoSize = true;
            this.lbTenTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTacGia.ForeColor = System.Drawing.Color.Navy;
            this.lbTenTacGia.Location = new System.Drawing.Point(449, 57);
            this.lbTenTacGia.Name = "lbTenTacGia";
            this.lbTenTacGia.Size = new System.Drawing.Size(127, 25);
            this.lbTenTacGia.TabIndex = 2;
            this.lbTenTacGia.Text = "Tên Tác Giả:";
            // 
            // lbGiaTien
            // 
            this.lbGiaTien.AutoSize = true;
            this.lbGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaTien.ForeColor = System.Drawing.Color.Navy;
            this.lbGiaTien.Location = new System.Drawing.Point(449, 191);
            this.lbGiaTien.Name = "lbGiaTien";
            this.lbGiaTien.Size = new System.Drawing.Size(92, 25);
            this.lbGiaTien.TabIndex = 2;
            this.lbGiaTien.Text = "Giá Tiền:";
            // 
            // lbSoLuongTon
            // 
            this.lbSoLuongTon.AutoSize = true;
            this.lbSoLuongTon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuongTon.ForeColor = System.Drawing.Color.Navy;
            this.lbSoLuongTon.Location = new System.Drawing.Point(846, 123);
            this.lbSoLuongTon.Name = "lbSoLuongTon";
            this.lbSoLuongTon.Size = new System.Drawing.Size(143, 25);
            this.lbSoLuongTon.TabIndex = 2;
            this.lbSoLuongTon.Text = "Số Lượng Tồn:";
            // 
            // lbNhaXuatBan
            // 
            this.lbNhaXuatBan.AutoSize = true;
            this.lbNhaXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhaXuatBan.ForeColor = System.Drawing.Color.Navy;
            this.lbNhaXuatBan.Location = new System.Drawing.Point(449, 123);
            this.lbNhaXuatBan.Name = "lbNhaXuatBan";
            this.lbNhaXuatBan.Size = new System.Drawing.Size(140, 25);
            this.lbNhaXuatBan.TabIndex = 2;
            this.lbNhaXuatBan.Text = "Nhà Xuất Bản:";
            // 
            // lbNamXuatBan
            // 
            this.lbNamXuatBan.AutoSize = true;
            this.lbNamXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNamXuatBan.ForeColor = System.Drawing.Color.Navy;
            this.lbNamXuatBan.Location = new System.Drawing.Point(844, 57);
            this.lbNamXuatBan.Name = "lbNamXuatBan";
            this.lbNamXuatBan.Size = new System.Drawing.Size(145, 25);
            this.lbNamXuatBan.TabIndex = 2;
            this.lbNamXuatBan.Text = "Năm Xuất Bản:";
            // 
            // txbTenTG
            // 
            this.txbTenTG.BackColor = System.Drawing.Color.LightGray;
            this.txbTenTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenTG.Location = new System.Drawing.Point(567, 87);
            this.txbTenTG.Multiline = true;
            this.txbTenTG.Name = "txbTenTG";
            this.txbTenTG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbTenTG.Size = new System.Drawing.Size(267, 54);
            this.txbTenTG.TabIndex = 10;
            this.txbTenTG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTenTG_KeyPress);
            // 
            // errMaDS
            // 
            this.errMaDS.ContainerControl = this;
            // 
            // errTenDS
            // 
            this.errTenDS.ContainerControl = this;
            // 
            // errNXB
            // 
            this.errNXB.ContainerControl = this;
            // 
            // errGiaTien
            // 
            this.errGiaTien.ContainerControl = this;
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
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(661, 248);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(145, 50);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.TextColor = System.Drawing.Color.White;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
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
            this.btnLuu.Location = new System.Drawing.Point(509, 248);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(145, 50);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextColor = System.Drawing.Color.White;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
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
            this.btnThemMoi.Location = new System.Drawing.Point(355, 248);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(145, 50);
            this.btnThemMoi.TabIndex = 2;
            this.btnThemMoi.Text = "Thêm Mới";
            this.btnThemMoi.TextColor = System.Drawing.Color.White;
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(810, 248);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(145, 50);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1260, 724);
            this.Controls.Add(this.txbTenTG);
            this.Controls.Add(this.gbThongTinSach);
            this.Controls.Add(this.lbTieuDe);
            this.Controls.Add(this.lbTieude2);
            this.Controls.Add(this.dgvSach);
            this.ForeColor = System.Drawing.Color.Chocolate;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.gbThongTinSach.ResumeLayout(false);
            this.gbThongTinSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMaDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNXB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errGiaTien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.Label lbTieude2;
        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.TextBox txbMaSach;
        private System.Windows.Forms.Label lbMaSach;
        private System.Windows.Forms.Label lbTenSach;
        private ThayDoiQuyDinh.nButton btnXoa;
        private ThayDoiQuyDinh.nButton btnCapNhat;
        private ThayDoiQuyDinh.nButton btnThemMoi;
        private ThayDoiQuyDinh.nButton btnLuu;
        private System.Windows.Forms.GroupBox gbThongTinSach;
        private System.Windows.Forms.ErrorProvider errMaDS;
        private System.Windows.Forms.TextBox txbGiaTien;
        private System.Windows.Forms.TextBox txbSoLuongTon;
        private System.Windows.Forms.TextBox txbNhaXuatBan;
        private System.Windows.Forms.Label lbNamXuatBan;
        private System.Windows.Forms.Label lbTenTacGia;
        private System.Windows.Forms.Label lbGiaTien;
        private System.Windows.Forms.Label lbSoLuongTon;
        private System.Windows.Forms.Label lbNhaXuatBan;
        private System.Windows.Forms.DateTimePicker dtpNamXuatBan;
        private System.Windows.Forms.ComboBox cbMaDS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTenSach;
        private System.Windows.Forms.ErrorProvider errTenDS;
        private System.Windows.Forms.ErrorProvider errNXB;
        private System.Windows.Forms.ErrorProvider errGiaTien;
        private System.Windows.Forms.TextBox txbTenTG;
    }
}

