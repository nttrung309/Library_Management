
namespace FormLoaiDocGia
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
            this.dgvLoaiDocGia = new System.Windows.Forms.DataGridView();
            this.lbtieude1 = new System.Windows.Forms.Label();
            this.lbtieude = new System.Windows.Forms.Label();
            this.txbTenLoaiDocGia = new System.Windows.Forms.TextBox();
            this.txbMaLoaiDocGia = new System.Windows.Forms.TextBox();
            this.lbMaLoaiDocGia = new System.Windows.Forms.Label();
            this.lbTenLoaiDocGia = new System.Windows.Forms.Label();
            this.gbThongTinLoaiDocGia = new System.Windows.Forms.GroupBox();
            this.errTenLDG = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnXoa = new ThayDoiQuyDinh.nButton();
            this.btnCapNhat = new ThayDoiQuyDinh.nButton();
            this.btnLuu = new ThayDoiQuyDinh.nButton();
            this.btnThemMoi = new ThayDoiQuyDinh.nButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDocGia)).BeginInit();
            this.gbThongTinLoaiDocGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errTenLDG)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoaiDocGia
            // 
            this.dgvLoaiDocGia.AllowUserToAddRows = false;
            this.dgvLoaiDocGia.AllowUserToDeleteRows = false;
            this.dgvLoaiDocGia.AllowUserToResizeRows = false;
            this.dgvLoaiDocGia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLoaiDocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiDocGia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLoaiDocGia.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvLoaiDocGia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiDocGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoaiDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoaiDocGia.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLoaiDocGia.EnableHeadersVisualStyles = false;
            this.dgvLoaiDocGia.GridColor = System.Drawing.Color.Navy;
            this.dgvLoaiDocGia.Location = new System.Drawing.Point(529, 123);
            this.dgvLoaiDocGia.Name = "dgvLoaiDocGia";
            this.dgvLoaiDocGia.ReadOnly = true;
            this.dgvLoaiDocGia.RowHeadersVisible = false;
            this.dgvLoaiDocGia.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dgvLoaiDocGia.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLoaiDocGia.RowTemplate.Height = 24;
            this.dgvLoaiDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiDocGia.Size = new System.Drawing.Size(719, 589);
            this.dgvLoaiDocGia.TabIndex = 6;
            this.dgvLoaiDocGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiDocGia_CellClick);
            // 
            // lbtieude1
            // 
            this.lbtieude1.AutoSize = true;
            this.lbtieude1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtieude1.ForeColor = System.Drawing.Color.Chocolate;
            this.lbtieude1.Location = new System.Drawing.Point(707, 90);
            this.lbtieude1.Name = "lbtieude1";
            this.lbtieude1.Size = new System.Drawing.Size(323, 26);
            this.lbtieude1.TabIndex = 4;
            this.lbtieude1.Text = "Danh Sách Các Loại Độc Giả";
            // 
            // lbtieude
            // 
            this.lbtieude.AutoSize = true;
            this.lbtieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtieude.ForeColor = System.Drawing.Color.Navy;
            this.lbtieude.Location = new System.Drawing.Point(450, 38);
            this.lbtieude.Name = "lbtieude";
            this.lbtieude.Size = new System.Drawing.Size(353, 36);
            this.lbtieude.TabIndex = 7;
            this.lbtieude.Text = "Thông Tin Loại Độc Giả";
            // 
            // txbTenLoaiDocGia
            // 
            this.txbTenLoaiDocGia.BackColor = System.Drawing.SystemColors.Control;
            this.txbTenLoaiDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenLoaiDocGia.Location = new System.Drawing.Point(177, 132);
            this.txbTenLoaiDocGia.Name = "txbTenLoaiDocGia";
            this.txbTenLoaiDocGia.Size = new System.Drawing.Size(296, 34);
            this.txbTenLoaiDocGia.TabIndex = 4;
            // 
            // txbMaLoaiDocGia
            // 
            this.txbMaLoaiDocGia.BackColor = System.Drawing.Color.LightGray;
            this.txbMaLoaiDocGia.Enabled = false;
            this.txbMaLoaiDocGia.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaLoaiDocGia.Location = new System.Drawing.Point(177, 63);
            this.txbMaLoaiDocGia.Name = "txbMaLoaiDocGia";
            this.txbMaLoaiDocGia.Size = new System.Drawing.Size(296, 34);
            this.txbMaLoaiDocGia.TabIndex = 3;
            // 
            // lbMaLoaiDocGia
            // 
            this.lbMaLoaiDocGia.AutoSize = true;
            this.lbMaLoaiDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLoaiDocGia.ForeColor = System.Drawing.Color.Navy;
            this.lbMaLoaiDocGia.Location = new System.Drawing.Point(18, 66);
            this.lbMaLoaiDocGia.Name = "lbMaLoaiDocGia";
            this.lbMaLoaiDocGia.Size = new System.Drawing.Size(163, 25);
            this.lbMaLoaiDocGia.TabIndex = 2;
            this.lbMaLoaiDocGia.Text = "Mã Loại Độc Giả:";
            // 
            // lbTenLoaiDocGia
            // 
            this.lbTenLoaiDocGia.AutoSize = true;
            this.lbTenLoaiDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenLoaiDocGia.ForeColor = System.Drawing.Color.Navy;
            this.lbTenLoaiDocGia.Location = new System.Drawing.Point(18, 132);
            this.lbTenLoaiDocGia.Name = "lbTenLoaiDocGia";
            this.lbTenLoaiDocGia.Size = new System.Drawing.Size(170, 25);
            this.lbTenLoaiDocGia.TabIndex = 2;
            this.lbTenLoaiDocGia.Text = "Tên Loại Độc Giả:";
            // 
            // gbThongTinLoaiDocGia
            // 
            this.gbThongTinLoaiDocGia.Controls.Add(this.btnXoa);
            this.gbThongTinLoaiDocGia.Controls.Add(this.txbTenLoaiDocGia);
            this.gbThongTinLoaiDocGia.Controls.Add(this.btnCapNhat);
            this.gbThongTinLoaiDocGia.Controls.Add(this.lbMaLoaiDocGia);
            this.gbThongTinLoaiDocGia.Controls.Add(this.btnLuu);
            this.gbThongTinLoaiDocGia.Controls.Add(this.btnThemMoi);
            this.gbThongTinLoaiDocGia.Controls.Add(this.txbMaLoaiDocGia);
            this.gbThongTinLoaiDocGia.Controls.Add(this.lbTenLoaiDocGia);
            this.gbThongTinLoaiDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTinLoaiDocGia.ForeColor = System.Drawing.Color.Chocolate;
            this.gbThongTinLoaiDocGia.Location = new System.Drawing.Point(13, 116);
            this.gbThongTinLoaiDocGia.Name = "gbThongTinLoaiDocGia";
            this.gbThongTinLoaiDocGia.Size = new System.Drawing.Size(509, 596);
            this.gbThongTinLoaiDocGia.TabIndex = 48;
            this.gbThongTinLoaiDocGia.TabStop = false;
            this.gbThongTinLoaiDocGia.Text = "Thông Tin Loại Độc Giả";
            // 
            // errTenLDG
            // 
            this.errTenLDG.ContainerControl = this;
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
            this.btnXoa.Location = new System.Drawing.Point(277, 352);
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
            this.btnCapNhat.Location = new System.Drawing.Point(48, 352);
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
            this.btnLuu.Location = new System.Drawing.Point(277, 260);
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
            this.btnThemMoi.Location = new System.Drawing.Point(48, 260);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(175, 50);
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
            this.Controls.Add(this.gbThongTinLoaiDocGia);
            this.Controls.Add(this.lbtieude);
            this.Controls.Add(this.lbtieude1);
            this.Controls.Add(this.dgvLoaiDocGia);
            this.ForeColor = System.Drawing.Color.Chocolate;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDocGia)).EndInit();
            this.gbThongTinLoaiDocGia.ResumeLayout(false);
            this.gbThongTinLoaiDocGia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errTenLDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvLoaiDocGia;
        private System.Windows.Forms.Label lbtieude1;
        private System.Windows.Forms.Label lbtieude;
        private System.Windows.Forms.TextBox txbMaLoaiDocGia;
        private System.Windows.Forms.Label lbMaLoaiDocGia;
        private System.Windows.Forms.Label lbTenLoaiDocGia;
        private ThayDoiQuyDinh.nButton btnXoa;
        private ThayDoiQuyDinh.nButton btnCapNhat;
        private ThayDoiQuyDinh.nButton btnThemMoi;
        private ThayDoiQuyDinh.nButton btnLuu;
        private System.Windows.Forms.TextBox txbTenLoaiDocGia;
        private System.Windows.Forms.GroupBox gbThongTinLoaiDocGia;
        private System.Windows.Forms.ErrorProvider errTenLDG;
    }
}

