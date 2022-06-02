
namespace PhieuThuTien
{
    partial class FormThuTien
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThuTien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.lbTieuDe2 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.dgvDLPhieuThuTienPhat = new System.Windows.Forms.DataGridView();
            this.btnCapNhat = new PhieuThuTien.nButton();
            this.btnLuu = new PhieuThuTien.nButton();
            this.btnThem = new PhieuThuTien.nButton();
            this.btnIn = new PhieuThuTien.nButton();
            this.gbThongTinPhieu = new PhieuThuTien.VBButton();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.txbConLai = new System.Windows.Forms.TextBox();
            this.lbConLai = new System.Windows.Forms.Label();
            this.dtpNgayThu = new System.Windows.Forms.DateTimePicker();
            this.cbMaDocGia = new System.Windows.Forms.ComboBox();
            this.txbTongNo = new System.Windows.Forms.TextBox();
            this.lbNgayThu = new System.Windows.Forms.Label();
            this.lbTongNo = new System.Windows.Forms.Label();
            this.lbMaDocGia = new System.Windows.Forms.Label();
            this.txbTienThu = new System.Windows.Forms.TextBox();
            this.lbSoTienThu = new System.Windows.Forms.Label();
            this.txbMaPhieuthu = new System.Windows.Forms.TextBox();
            this.lbMaPhieuThu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDLPhieuThuTienPhat)).BeginInit();
            this.gbThongTinPhieu.SuspendLayout();
            this.SuspendLayout();
            // 
            // d
            // 
            this.d.HeaderText = "Mã Sách";
            this.d.MinimumWidth = 6;
            this.d.Name = "d";
            this.d.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Thể Loại";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(70, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 29);
            this.label4.TabIndex = 45;
            this.label4.Text = "Thông Tin Phiếu";
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lbTieuDe.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.lbTieuDe.ForeColor = System.Drawing.Color.Navy;
            this.lbTieuDe.Location = new System.Drawing.Point(44, 16);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(379, 51);
            this.lbTieuDe.TabIndex = 33;
            this.lbTieuDe.Text = "Phiếu Thu Tiền Phạt";
            // 
            // lbTieuDe2
            // 
            this.lbTieuDe2.AutoSize = true;
            this.lbTieuDe2.BackColor = System.Drawing.Color.Transparent;
            this.lbTieuDe2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbTieuDe2.ForeColor = System.Drawing.Color.Chocolate;
            this.lbTieuDe2.Location = new System.Drawing.Point(428, 321);
            this.lbTieuDe2.Name = "lbTieuDe2";
            this.lbTieuDe2.Size = new System.Drawing.Size(416, 41);
            this.lbTieuDe2.TabIndex = 46;
            this.lbTieuDe2.Text = "Dữ Liệu Phiếu Thu Tiền Phạt";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // dgvDLPhieuThuTienPhat
            // 
            this.dgvDLPhieuThuTienPhat.AllowUserToAddRows = false;
            this.dgvDLPhieuThuTienPhat.AllowUserToDeleteRows = false;
            this.dgvDLPhieuThuTienPhat.AllowUserToResizeRows = false;
            this.dgvDLPhieuThuTienPhat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDLPhieuThuTienPhat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDLPhieuThuTienPhat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDLPhieuThuTienPhat.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDLPhieuThuTienPhat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDLPhieuThuTienPhat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDLPhieuThuTienPhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDLPhieuThuTienPhat.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDLPhieuThuTienPhat.EnableHeadersVisualStyles = false;
            this.dgvDLPhieuThuTienPhat.GridColor = System.Drawing.Color.Navy;
            this.dgvDLPhieuThuTienPhat.Location = new System.Drawing.Point(34, 378);
            this.dgvDLPhieuThuTienPhat.Name = "dgvDLPhieuThuTienPhat";
            this.dgvDLPhieuThuTienPhat.ReadOnly = true;
            this.dgvDLPhieuThuTienPhat.RowHeadersVisible = false;
            this.dgvDLPhieuThuTienPhat.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dgvDLPhieuThuTienPhat.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDLPhieuThuTienPhat.RowTemplate.Height = 24;
            this.dgvDLPhieuThuTienPhat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDLPhieuThuTienPhat.Size = new System.Drawing.Size(1191, 326);
            this.dgvDLPhieuThuTienPhat.TabIndex = 53;
            this.dgvDLPhieuThuTienPhat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dgvDLPhieuThuTienPhat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDLPhieuThuTienPhat_CellContentClick_1);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.btnCapNhat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.btnCapNhat.BorderColor = System.Drawing.Color.Navy;
            this.btnCapNhat.BorderRadius = 20;
            this.btnCapNhat.BorderSize = 0;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(989, 50);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(114, 42);
            this.btnCapNhat.TabIndex = 52;
            this.btnCapNhat.Text = "Xóa";
            this.btnCapNhat.TextColor = System.Drawing.Color.White;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.nButton4_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Violet;
            this.btnLuu.BackgroundColor = System.Drawing.Color.Violet;
            this.btnLuu.BorderColor = System.Drawing.Color.Navy;
            this.btnLuu.BorderRadius = 20;
            this.btnLuu.BorderSize = 0;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(859, 50);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(122, 42);
            this.btnLuu.TabIndex = 51;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextColor = System.Drawing.Color.White;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.nButton1_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.YellowGreen;
            this.btnThem.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.btnThem.BorderColor = System.Drawing.Color.Navy;
            this.btnThem.BorderRadius = 20;
            this.btnThem.BorderSize = 0;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(729, 50);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(122, 42);
            this.btnThem.TabIndex = 51;
            this.btnThem.Text = "Thêm Mới";
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.nButton2_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.LightCoral;
            this.btnIn.BackgroundColor = System.Drawing.Color.LightCoral;
            this.btnIn.BorderColor = System.Drawing.Color.Navy;
            this.btnIn.BorderRadius = 20;
            this.btnIn.BorderSize = 0;
            this.btnIn.FlatAppearance.BorderSize = 0;
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnIn.ForeColor = System.Drawing.Color.White;
            this.btnIn.Location = new System.Drawing.Point(1110, 50);
            this.btnIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(117, 42);
            this.btnIn.TabIndex = 50;
            this.btnIn.Text = "In Phiếu thu";
            this.btnIn.TextColor = System.Drawing.Color.White;
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // gbThongTinPhieu
            // 
            this.gbThongTinPhieu.BackColor = System.Drawing.Color.Transparent;
            this.gbThongTinPhieu.BackgroundColor = System.Drawing.Color.Transparent;
            this.gbThongTinPhieu.BorderColor = System.Drawing.Color.Navy;
            this.gbThongTinPhieu.BorderRadius = 0;
            this.gbThongTinPhieu.BorderSize = 1;
            this.gbThongTinPhieu.Controls.Add(this.txbHoTen);
            this.gbThongTinPhieu.Controls.Add(this.lbHoTen);
            this.gbThongTinPhieu.Controls.Add(this.txbConLai);
            this.gbThongTinPhieu.Controls.Add(this.lbConLai);
            this.gbThongTinPhieu.Controls.Add(this.dtpNgayThu);
            this.gbThongTinPhieu.Controls.Add(this.cbMaDocGia);
            this.gbThongTinPhieu.Controls.Add(this.txbTongNo);
            this.gbThongTinPhieu.Controls.Add(this.lbNgayThu);
            this.gbThongTinPhieu.Controls.Add(this.lbTongNo);
            this.gbThongTinPhieu.Controls.Add(this.lbMaDocGia);
            this.gbThongTinPhieu.Controls.Add(this.txbTienThu);
            this.gbThongTinPhieu.Controls.Add(this.lbSoTienThu);
            this.gbThongTinPhieu.Controls.Add(this.txbMaPhieuthu);
            this.gbThongTinPhieu.Controls.Add(this.lbMaPhieuThu);
            this.gbThongTinPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.gbThongTinPhieu.ForeColor = System.Drawing.Color.Navy;
            this.gbThongTinPhieu.Location = new System.Drawing.Point(34, 106);
            this.gbThongTinPhieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbThongTinPhieu.Name = "gbThongTinPhieu";
            this.gbThongTinPhieu.Size = new System.Drawing.Size(1191, 201);
            this.gbThongTinPhieu.TabIndex = 35;
            this.gbThongTinPhieu.TextColor = System.Drawing.Color.Navy;
            // 
            // txbHoTen
            // 
            this.txbHoTen.BackColor = System.Drawing.SystemColors.Control;
            this.txbHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHoTen.Location = new System.Drawing.Point(162, 157);
            this.txbHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(227, 34);
            this.txbHoTen.TabIndex = 46;
            this.txbHoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.BackColor = System.Drawing.Color.Transparent;
            this.lbHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Location = new System.Drawing.Point(14, 162);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(99, 29);
            this.lbHoTen.TabIndex = 45;
            this.lbHoTen.Text = "Họ Tên:";
            // 
            // txbConLai
            // 
            this.txbConLai.BackColor = System.Drawing.SystemColors.Control;
            this.txbConLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConLai.Location = new System.Drawing.Point(553, 157);
            this.txbConLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbConLai.Name = "txbConLai";
            this.txbConLai.Size = new System.Drawing.Size(227, 34);
            this.txbConLai.TabIndex = 46;
            this.txbConLai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // lbConLai
            // 
            this.lbConLai.AutoSize = true;
            this.lbConLai.BackColor = System.Drawing.Color.Transparent;
            this.lbConLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConLai.Location = new System.Drawing.Point(407, 162);
            this.lbConLai.Name = "lbConLai";
            this.lbConLai.Size = new System.Drawing.Size(101, 29);
            this.lbConLai.TabIndex = 45;
            this.lbConLai.Text = "Còn Lại:";
            // 
            // dtpNgayThu
            // 
            this.dtpNgayThu.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dtpNgayThu.CustomFormat = "dd-MM-yyyy";
            this.dtpNgayThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayThu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayThu.Location = new System.Drawing.Point(901, 53);
            this.dtpNgayThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayThu.Name = "dtpNgayThu";
            this.dtpNgayThu.Size = new System.Drawing.Size(221, 34);
            this.dtpNgayThu.TabIndex = 44;
            // 
            // cbMaDocGia
            // 
            this.cbMaDocGia.BackColor = System.Drawing.SystemColors.Control;
            this.cbMaDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaDocGia.FormattingEnabled = true;
            this.cbMaDocGia.Location = new System.Drawing.Point(162, 105);
            this.cbMaDocGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMaDocGia.Name = "cbMaDocGia";
            this.cbMaDocGia.Size = new System.Drawing.Size(227, 37);
            this.cbMaDocGia.TabIndex = 43;
            this.cbMaDocGia.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            this.cbMaDocGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox3_KeyPress);
            // 
            // txbTongNo
            // 
            this.txbTongNo.BackColor = System.Drawing.SystemColors.Control;
            this.txbTongNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTongNo.Location = new System.Drawing.Point(553, 55);
            this.txbTongNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTongNo.Name = "txbTongNo";
            this.txbTongNo.Size = new System.Drawing.Size(227, 34);
            this.txbTongNo.TabIndex = 36;
            this.txbTongNo.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.txbTongNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // lbNgayThu
            // 
            this.lbNgayThu.AutoSize = true;
            this.lbNgayThu.BackColor = System.Drawing.Color.Transparent;
            this.lbNgayThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayThu.Location = new System.Drawing.Point(791, 56);
            this.lbNgayThu.Name = "lbNgayThu";
            this.lbNgayThu.Size = new System.Drawing.Size(123, 29);
            this.lbNgayThu.TabIndex = 35;
            this.lbNgayThu.Text = "Ngày Thu:";
            // 
            // lbTongNo
            // 
            this.lbTongNo.AutoSize = true;
            this.lbTongNo.BackColor = System.Drawing.Color.Transparent;
            this.lbTongNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongNo.Location = new System.Drawing.Point(406, 55);
            this.lbTongNo.Name = "lbTongNo";
            this.lbTongNo.Size = new System.Drawing.Size(114, 29);
            this.lbTongNo.TabIndex = 34;
            this.lbTongNo.Text = "Tổng Nợ:";
            // 
            // lbMaDocGia
            // 
            this.lbMaDocGia.AutoSize = true;
            this.lbMaDocGia.BackColor = System.Drawing.Color.Transparent;
            this.lbMaDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaDocGia.Location = new System.Drawing.Point(14, 110);
            this.lbMaDocGia.Name = "lbMaDocGia";
            this.lbMaDocGia.Size = new System.Drawing.Size(144, 29);
            this.lbMaDocGia.TabIndex = 33;
            this.lbMaDocGia.Text = "Mã Độc Giả:";
            // 
            // txbTienThu
            // 
            this.txbTienThu.BackColor = System.Drawing.SystemColors.Control;
            this.txbTienThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTienThu.Location = new System.Drawing.Point(553, 110);
            this.txbTienThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTienThu.Name = "txbTienThu";
            this.txbTienThu.Size = new System.Drawing.Size(227, 34);
            this.txbTienThu.TabIndex = 32;
            this.txbTienThu.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txbTienThu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // lbSoTienThu
            // 
            this.lbSoTienThu.AutoSize = true;
            this.lbSoTienThu.BackColor = System.Drawing.Color.Transparent;
            this.lbSoTienThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTienThu.Location = new System.Drawing.Point(406, 113);
            this.lbSoTienThu.Name = "lbSoTienThu";
            this.lbSoTienThu.Size = new System.Drawing.Size(152, 29);
            this.lbSoTienThu.TabIndex = 30;
            this.lbSoTienThu.Text = "Số Tiền Thu:";
            // 
            // txbMaPhieuthu
            // 
            this.txbMaPhieuthu.BackColor = System.Drawing.SystemColors.Control;
            this.txbMaPhieuthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaPhieuthu.Location = new System.Drawing.Point(161, 50);
            this.txbMaPhieuthu.Name = "txbMaPhieuthu";
            this.txbMaPhieuthu.Size = new System.Drawing.Size(228, 34);
            this.txbMaPhieuthu.TabIndex = 28;
            this.txbMaPhieuthu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMaPhieuthu_KeyPress);
            // 
            // lbMaPhieuThu
            // 
            this.lbMaPhieuThu.AutoSize = true;
            this.lbMaPhieuThu.BackColor = System.Drawing.Color.Transparent;
            this.lbMaPhieuThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPhieuThu.ForeColor = System.Drawing.Color.Navy;
            this.lbMaPhieuThu.Location = new System.Drawing.Point(14, 53);
            this.lbMaPhieuThu.Name = "lbMaPhieuThu";
            this.lbMaPhieuThu.Size = new System.Drawing.Size(168, 29);
            this.lbMaPhieuThu.TabIndex = 27;
            this.lbMaPhieuThu.Text = "Mã Phiếu Thu:";
            // 
            // FormThuTien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1260, 724);
            this.Controls.Add(this.dgvDLPhieuThuTienPhat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.lbTieuDe2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTieuDe);
            this.Controls.Add(this.gbThongTinPhieu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThuTien";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDLPhieuThuTienPhat)).EndInit();
            this.gbThongTinPhieu.ResumeLayout(false);
            this.gbThongTinPhieu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn d;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private VBButton gbThongTinPhieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTienThu;
        private System.Windows.Forms.Label lbSoTienThu;
        private System.Windows.Forms.TextBox txbMaPhieuthu;
        private System.Windows.Forms.Label lbMaPhieuThu;
        private System.Windows.Forms.DateTimePicker dtpNgayThu;
        private System.Windows.Forms.ComboBox cbMaDocGia;
        private System.Windows.Forms.TextBox txbTongNo;
        private System.Windows.Forms.Label lbNgayThu;
        private System.Windows.Forms.Label lbTongNo;
        private System.Windows.Forms.Label lbMaDocGia;
        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.Label lbTieuDe2;
        private nButton btnIn;
        private nButton btnThem;
        private nButton btnCapNhat;
        private System.Windows.Forms.TextBox txbConLai;
        private System.Windows.Forms.Label lbConLai;
        private nButton btnLuu;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridView dgvDLPhieuThuTienPhat;
    }
}
