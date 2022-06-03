
namespace FormNhapSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.labelDuLieuPhieuNhapSach = new System.Windows.Forms.Label();
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.txbMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.lbMaPhieuNhap = new System.Windows.Forms.Label();
            this.lbNgayNhap = new System.Windows.Forms.Label();
            this.gbPhieuNhap = new System.Windows.Forms.GroupBox();
            this.txbTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.btnXoa = new ThayDoiQuyDinh.nButton();
            this.btnCapNhat = new ThayDoiQuyDinh.nButton();
            this.btnLuu = new ThayDoiQuyDinh.nButton();
            this.btnThemMoi = new ThayDoiQuyDinh.nButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.gbPhieuNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.AllowUserToAddRows = false;
            this.dgvPhieuNhap.AllowUserToDeleteRows = false;
            this.dgvPhieuNhap.AllowUserToResizeRows = false;
            this.dgvPhieuNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuNhap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPhieuNhap.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPhieuNhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhieuNhap.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhieuNhap.EnableHeadersVisualStyles = false;
            this.dgvPhieuNhap.GridColor = System.Drawing.Color.Navy;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(529, 123);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.ReadOnly = true;
            this.dgvPhieuNhap.RowHeadersVisible = false;
            this.dgvPhieuNhap.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dgvPhieuNhap.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhieuNhap.RowTemplate.Height = 24;
            this.dgvPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(719, 589);
            this.dgvPhieuNhap.TabIndex = 6;
            this.dgvPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTacGia_CellClick);
            // 
            // labelDuLieuPhieuNhapSach
            // 
            this.labelDuLieuPhieuNhapSach.AutoSize = true;
            this.labelDuLieuPhieuNhapSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuLieuPhieuNhapSach.ForeColor = System.Drawing.Color.Chocolate;
            this.labelDuLieuPhieuNhapSach.Location = new System.Drawing.Point(738, 78);
            this.labelDuLieuPhieuNhapSach.Name = "labelDuLieuPhieuNhapSach";
            this.labelDuLieuPhieuNhapSach.Size = new System.Drawing.Size(286, 26);
            this.labelDuLieuPhieuNhapSach.TabIndex = 4;
            this.labelDuLieuPhieuNhapSach.Text = "Dữ Liệu Phiếu Nhập Sách";
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.AutoSize = true;
            this.labelTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTieuDe.ForeColor = System.Drawing.Color.Navy;
            this.labelTieuDe.Location = new System.Drawing.Point(483, 21);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(214, 29);
            this.labelTieuDe.TabIndex = 7;
            this.labelTieuDe.Text = "Phiếu Nhập Sách";
            // 
            // txbMaPhieuNhap
            // 
            this.txbMaPhieuNhap.BackColor = System.Drawing.Color.LightGray;
            this.txbMaPhieuNhap.Enabled = false;
            this.txbMaPhieuNhap.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaPhieuNhap.Location = new System.Drawing.Point(177, 63);
            this.txbMaPhieuNhap.Name = "txbMaPhieuNhap";
            this.txbMaPhieuNhap.Size = new System.Drawing.Size(296, 29);
            this.txbMaPhieuNhap.TabIndex = 3;
            // 
            // lbMaPhieuNhap
            // 
            this.lbMaPhieuNhap.AutoSize = true;
            this.lbMaPhieuNhap.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPhieuNhap.ForeColor = System.Drawing.Color.Navy;
            this.lbMaPhieuNhap.Location = new System.Drawing.Point(18, 66);
            this.lbMaPhieuNhap.Name = "lbMaPhieuNhap";
            this.lbMaPhieuNhap.Size = new System.Drawing.Size(142, 22);
            this.lbMaPhieuNhap.TabIndex = 2;
            this.lbMaPhieuNhap.Text = "Mã Phiếu Nhập:";
            // 
            // lbNgayNhap
            // 
            this.lbNgayNhap.AutoSize = true;
            this.lbNgayNhap.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayNhap.ForeColor = System.Drawing.Color.Navy;
            this.lbNgayNhap.Location = new System.Drawing.Point(18, 132);
            this.lbNgayNhap.Name = "lbNgayNhap";
            this.lbNgayNhap.Size = new System.Drawing.Size(107, 22);
            this.lbNgayNhap.TabIndex = 2;
            this.lbNgayNhap.Text = "Ngày Nhập:";
            // 
            // gbPhieuNhap
            // 
            this.gbPhieuNhap.BackColor = System.Drawing.Color.Transparent;
            this.gbPhieuNhap.Controls.Add(this.txbTongTien);
            this.gbPhieuNhap.Controls.Add(this.label1);
            this.gbPhieuNhap.Controls.Add(this.dtp_NgayNhap);
            this.gbPhieuNhap.Controls.Add(this.btnXoa);
            this.gbPhieuNhap.Controls.Add(this.btnCapNhat);
            this.gbPhieuNhap.Controls.Add(this.lbMaPhieuNhap);
            this.gbPhieuNhap.Controls.Add(this.btnLuu);
            this.gbPhieuNhap.Controls.Add(this.btnThemMoi);
            this.gbPhieuNhap.Controls.Add(this.txbMaPhieuNhap);
            this.gbPhieuNhap.Controls.Add(this.lbNgayNhap);
            this.gbPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPhieuNhap.ForeColor = System.Drawing.Color.Chocolate;
            this.gbPhieuNhap.Location = new System.Drawing.Point(14, 112);
            this.gbPhieuNhap.Name = "gbPhieuNhap";
            this.gbPhieuNhap.Size = new System.Drawing.Size(509, 596);
            this.gbPhieuNhap.TabIndex = 48;
            this.gbPhieuNhap.TabStop = false;
            this.gbPhieuNhap.Text = "Thông Tin Phiếu Nhập";
            // 
            // txbTongTien
            // 
            this.txbTongTien.BackColor = System.Drawing.Color.LightGray;
            this.txbTongTien.Enabled = false;
            this.txbTongTien.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTongTien.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txbTongTien.Location = new System.Drawing.Point(177, 201);
            this.txbTongTien.Name = "txbTongTien";
            this.txbTongTien.Size = new System.Drawing.Size(296, 29);
            this.txbTongTien.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(18, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 45;
            this.label1.Text = "Tổng Tiền:";
            // 
            // dtp_NgayNhap
            // 
            this.dtp_NgayNhap.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dtp_NgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayNhap.Location = new System.Drawing.Point(177, 132);
            this.dtp_NgayNhap.Name = "dtp_NgayNhap";
            this.dtp_NgayNhap.Size = new System.Drawing.Size(296, 28);
            this.dtp_NgayNhap.TabIndex = 44;
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
            this.btnXoa.Location = new System.Drawing.Point(284, 387);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(191, 50);
            this.btnXoa.TabIndex = 2;
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
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(55, 387);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(191, 50);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Xem và Cập Nhật";
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
            this.btnLuu.Location = new System.Drawing.Point(284, 295);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(191, 50);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Nhập Sách";
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
            this.btnThemMoi.Location = new System.Drawing.Point(55, 295);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(191, 50);
            this.btnThemMoi.TabIndex = 2;
            this.btnThemMoi.Text = "Thêm Mới";
            this.btnThemMoi.TextColor = System.Drawing.Color.White;
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1260, 724);
            this.Controls.Add(this.gbPhieuNhap);
            this.Controls.Add(this.labelTieuDe);
            this.Controls.Add(this.labelDuLieuPhieuNhapSach);
            this.Controls.Add(this.dgvPhieuNhap);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Chocolate;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.gbPhieuNhap.ResumeLayout(false);
            this.gbPhieuNhap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.Label labelDuLieuPhieuNhapSach;
        private System.Windows.Forms.Label labelTieuDe;
        private System.Windows.Forms.TextBox txbMaPhieuNhap;
        private System.Windows.Forms.Label lbMaPhieuNhap;
        private System.Windows.Forms.Label lbNgayNhap;
        private ThayDoiQuyDinh.nButton btnXoa;
        private ThayDoiQuyDinh.nButton btnCapNhat;
        private ThayDoiQuyDinh.nButton btnThemMoi;
        private ThayDoiQuyDinh.nButton btnLuu;
        private System.Windows.Forms.GroupBox gbPhieuNhap;
        private System.Windows.Forms.DateTimePicker dtp_NgayNhap;
        private System.Windows.Forms.TextBox txbTongTien;
        private System.Windows.Forms.Label label1;
    }
}

