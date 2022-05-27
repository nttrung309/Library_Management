
namespace FormChiTietTacGia
{
    partial class ChiTietTacGia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvChiTietTacGia = new System.Windows.Forms.DataGridView();
            this.lbTieuDe1 = new System.Windows.Forms.Label();
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.lbTenSach = new System.Windows.Forms.Label();
            this.gbCTTG = new System.Windows.Forms.GroupBox();
            this.cbTenTacGia = new System.Windows.Forms.ComboBox();
            this.cbTenSach = new System.Windows.Forms.ComboBox();
            this.lbTenTacGia = new System.Windows.Forms.Label();
            this.errTenDS = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTenTG = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnXoa = new ThayDoiQuyDinh.nButton();
            this.btnCapNhat = new ThayDoiQuyDinh.nButton();
            this.btnLuu = new ThayDoiQuyDinh.nButton();
            this.btnThemMoi = new ThayDoiQuyDinh.nButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietTacGia)).BeginInit();
            this.gbCTTG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errTenDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenTG)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChiTietTacGia
            // 
            this.dgvChiTietTacGia.AllowUserToAddRows = false;
            this.dgvChiTietTacGia.AllowUserToDeleteRows = false;
            this.dgvChiTietTacGia.AllowUserToResizeRows = false;
            this.dgvChiTietTacGia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiTietTacGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietTacGia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvChiTietTacGia.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvChiTietTacGia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietTacGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvChiTietTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiTietTacGia.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvChiTietTacGia.EnableHeadersVisualStyles = false;
            this.dgvChiTietTacGia.GridColor = System.Drawing.Color.Navy;
            this.dgvChiTietTacGia.Location = new System.Drawing.Point(529, 123);
            this.dgvChiTietTacGia.Name = "dgvChiTietTacGia";
            this.dgvChiTietTacGia.ReadOnly = true;
            this.dgvChiTietTacGia.RowHeadersVisible = false;
            this.dgvChiTietTacGia.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dgvChiTietTacGia.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvChiTietTacGia.RowTemplate.Height = 24;
            this.dgvChiTietTacGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietTacGia.Size = new System.Drawing.Size(719, 589);
            this.dgvChiTietTacGia.TabIndex = 6;
            this.dgvChiTietTacGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietTacGia_CellClick);
            // 
            // lbTieuDe1
            // 
            this.lbTieuDe1.AutoSize = true;
            this.lbTieuDe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe1.ForeColor = System.Drawing.Color.Chocolate;
            this.lbTieuDe1.Location = new System.Drawing.Point(707, 90);
            this.lbTieuDe1.Name = "lbTieuDe1";
            this.lbTieuDe1.Size = new System.Drawing.Size(272, 26);
            this.lbTieuDe1.TabIndex = 4;
            this.lbTieuDe1.Text = "Dữ Liệu Chi Tiết Tác Giả";
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.ForeColor = System.Drawing.Color.Navy;
            this.lbTieuDe.Location = new System.Drawing.Point(492, 45);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(244, 36);
            this.lbTieuDe.TabIndex = 7;
            this.lbTieuDe.Text = "Chi Tiết Tác Giả";
            // 
            // lbTenSach
            // 
            this.lbTenSach.AutoSize = true;
            this.lbTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSach.ForeColor = System.Drawing.Color.Navy;
            this.lbTenSach.Location = new System.Drawing.Point(21, 65);
            this.lbTenSach.Name = "lbTenSach";
            this.lbTenSach.Size = new System.Drawing.Size(122, 29);
            this.lbTenSach.TabIndex = 2;
            this.lbTenSach.Text = "Tên Sách:";
            // 
            // gbCTTG
            // 
            this.gbCTTG.Controls.Add(this.cbTenTacGia);
            this.gbCTTG.Controls.Add(this.cbTenSach);
            this.gbCTTG.Controls.Add(this.btnXoa);
            this.gbCTTG.Controls.Add(this.btnCapNhat);
            this.gbCTTG.Controls.Add(this.btnLuu);
            this.gbCTTG.Controls.Add(this.btnThemMoi);
            this.gbCTTG.Controls.Add(this.lbTenTacGia);
            this.gbCTTG.Controls.Add(this.lbTenSach);
            this.gbCTTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCTTG.ForeColor = System.Drawing.Color.Chocolate;
            this.gbCTTG.Location = new System.Drawing.Point(13, 116);
            this.gbCTTG.Name = "gbCTTG";
            this.gbCTTG.Size = new System.Drawing.Size(509, 596);
            this.gbCTTG.TabIndex = 48;
            this.gbCTTG.TabStop = false;
            this.gbCTTG.Text = "Thông Tin Chi Tiết Tác Giả";
            // 
            // cbTenTacGia
            // 
            this.cbTenTacGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenTacGia.FormattingEnabled = true;
            this.cbTenTacGia.Location = new System.Drawing.Point(169, 144);
            this.cbTenTacGia.Name = "cbTenTacGia";
            this.cbTenTacGia.Size = new System.Drawing.Size(296, 37);
            this.cbTenTacGia.TabIndex = 4;
            // 
            // cbTenSach
            // 
            this.cbTenSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenSach.FormattingEnabled = true;
            this.cbTenSach.Location = new System.Drawing.Point(169, 62);
            this.cbTenSach.Name = "cbTenSach";
            this.cbTenSach.Size = new System.Drawing.Size(296, 37);
            this.cbTenSach.TabIndex = 4;
            // 
            // lbTenTacGia
            // 
            this.lbTenTacGia.AutoSize = true;
            this.lbTenTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTacGia.ForeColor = System.Drawing.Color.Navy;
            this.lbTenTacGia.Location = new System.Drawing.Point(21, 147);
            this.lbTenTacGia.Name = "lbTenTacGia";
            this.lbTenTacGia.Size = new System.Drawing.Size(152, 29);
            this.lbTenTacGia.TabIndex = 2;
            this.lbTenTacGia.Text = "Tên Tác Giả:";
            // 
            // errTenDS
            // 
            this.errTenDS.ContainerControl = this;
            // 
            // errTenTG
            // 
            this.errTenTG.ContainerControl = this;
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
            this.btnXoa.Location = new System.Drawing.Point(290, 320);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(175, 50);
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
            this.btnCapNhat.Location = new System.Drawing.Point(61, 320);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(175, 50);
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
            this.btnLuu.Location = new System.Drawing.Point(290, 228);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(175, 50);
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
            this.btnThemMoi.Location = new System.Drawing.Point(61, 228);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(175, 50);
            this.btnThemMoi.TabIndex = 2;
            this.btnThemMoi.Text = "Thêm Mới";
            this.btnThemMoi.TextColor = System.Drawing.Color.White;
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // ChiTietTacGia
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1260, 724);
            this.Controls.Add(this.gbCTTG);
            this.Controls.Add(this.lbTieuDe);
            this.Controls.Add(this.lbTieuDe1);
            this.Controls.Add(this.dgvChiTietTacGia);
            this.ForeColor = System.Drawing.Color.Chocolate;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChiTietTacGia";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ChiTietTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietTacGia)).EndInit();
            this.gbCTTG.ResumeLayout(false);
            this.gbCTTG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errTenDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenTG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvChiTietTacGia;
        private System.Windows.Forms.Label lbTieuDe1;
        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.Label lbTenSach;
        private ThayDoiQuyDinh.nButton btnXoa;
        private ThayDoiQuyDinh.nButton btnCapNhat;
        private ThayDoiQuyDinh.nButton btnThemMoi;
        private ThayDoiQuyDinh.nButton btnLuu;
        private System.Windows.Forms.GroupBox gbCTTG;
        private System.Windows.Forms.ErrorProvider errTenDS;
        private System.Windows.Forms.Label lbTenTacGia;
        private System.Windows.Forms.ComboBox cbTenTacGia;
        private System.Windows.Forms.ComboBox cbTenSach;
        private System.Windows.Forms.ErrorProvider errTenTG;
    }
}

