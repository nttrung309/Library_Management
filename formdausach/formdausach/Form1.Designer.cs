
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_DSDauSach = new System.Windows.Forms.DataGridView();
            this.gb_TtDauSach = new System.Windows.Forms.GroupBox();
            this.txb_TenDauSach = new System.Windows.Forms.TextBox();
            this.lb_MaDauSach = new System.Windows.Forms.Label();
            this.lb_TenDauSach = new System.Windows.Forms.Label();
            this.lb_TTDauSach = new System.Windows.Forms.Label();
            this.lb_DSDauSach = new System.Windows.Forms.Label();
            this.dgvTacGia = new System.Windows.Forms.DataGridView();
            this.txb_TenTheLoai = new System.Windows.Forms.TextBox();
            this.lb_TenTheLoai = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txb_MaDauSach = new System.Windows.Forms.TextBox();
            this.Btxoa = new CustomButton.VBButton();
            this.Btcapnhat = new CustomButton.VBButton();
            this.BtLuu = new CustomButton.VBButton();
            this.Btthemmoi = new CustomButton.VBButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSDauSach)).BeginInit();
            this.gb_TtDauSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DSDauSach
            // 
            this.dgv_DSDauSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSDauSach.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DSDauSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DSDauSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSDauSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DSDauSach.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DSDauSach.EnableHeadersVisualStyles = false;
            this.dgv_DSDauSach.GridColor = System.Drawing.Color.Navy;
            this.dgv_DSDauSach.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_DSDauSach.Location = new System.Drawing.Point(527, 110);
            this.dgv_DSDauSach.Name = "dgv_DSDauSach";
            this.dgv_DSDauSach.RowHeadersVisible = false;
            this.dgv_DSDauSach.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DSDauSach.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_DSDauSach.RowTemplate.Height = 24;
            this.dgv_DSDauSach.ShowCellErrors = false;
            this.dgv_DSDauSach.Size = new System.Drawing.Size(721, 587);
            this.dgv_DSDauSach.TabIndex = 58;
            // 
            // gb_TtDauSach
            // 
            this.gb_TtDauSach.Controls.Add(this.Btxoa);
            this.gb_TtDauSach.Controls.Add(this.Btcapnhat);
            this.gb_TtDauSach.Controls.Add(this.BtLuu);
            this.gb_TtDauSach.Controls.Add(this.Btthemmoi);
            this.gb_TtDauSach.Controls.Add(this.txb_MaDauSach);
            this.gb_TtDauSach.Controls.Add(this.txb_TenTheLoai);
            this.gb_TtDauSach.Controls.Add(this.lb_TenTheLoai);
            this.gb_TtDauSach.Controls.Add(this.txb_TenDauSach);
            this.gb_TtDauSach.Controls.Add(this.lb_MaDauSach);
            this.gb_TtDauSach.Controls.Add(this.lb_TenDauSach);
            this.gb_TtDauSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_TtDauSach.ForeColor = System.Drawing.Color.Chocolate;
            this.gb_TtDauSach.Location = new System.Drawing.Point(12, 97);
            this.gb_TtDauSach.Name = "gb_TtDauSach";
            this.gb_TtDauSach.Size = new System.Drawing.Size(509, 600);
            this.gb_TtDauSach.TabIndex = 57;
            this.gb_TtDauSach.TabStop = false;
            this.gb_TtDauSach.Text = "Thông Tin Đầu Sách";
            // 
            // txb_TenDauSach
            // 
            this.txb_TenDauSach.BackColor = System.Drawing.SystemColors.Control;
            this.txb_TenDauSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_TenDauSach.Location = new System.Drawing.Point(177, 132);
            this.txb_TenDauSach.Name = "txb_TenDauSach";
            this.txb_TenDauSach.Size = new System.Drawing.Size(296, 34);
            this.txb_TenDauSach.TabIndex = 4;
            // 
            // lb_MaDauSach
            // 
            this.lb_MaDauSach.AutoSize = true;
            this.lb_MaDauSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaDauSach.ForeColor = System.Drawing.Color.Navy;
            this.lb_MaDauSach.Location = new System.Drawing.Point(18, 66);
            this.lb_MaDauSach.Name = "lb_MaDauSach";
            this.lb_MaDauSach.Size = new System.Drawing.Size(138, 25);
            this.lb_MaDauSach.TabIndex = 2;
            this.lb_MaDauSach.Text = "Mã Đầu Sách:";
            this.lb_MaDauSach.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_TenDauSach
            // 
            this.lb_TenDauSach.AutoSize = true;
            this.lb_TenDauSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenDauSach.ForeColor = System.Drawing.Color.Navy;
            this.lb_TenDauSach.Location = new System.Drawing.Point(18, 138);
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
            this.lb_TTDauSach.Location = new System.Drawing.Point(430, 27);
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
            this.lb_DSDauSach.Location = new System.Drawing.Point(696, 81);
            this.lb_DSDauSach.Name = "lb_DSDauSach";
            this.lb_DSDauSach.Size = new System.Drawing.Size(408, 26);
            this.lb_DSDauSach.TabIndex = 54;
            this.lb_DSDauSach.Text = "Danh Sách Đầu Sách Trong Thư Viện";
            // 
            // dgvTacGia
            // 
            this.dgvTacGia.AllowUserToAddRows = false;
            this.dgvTacGia.AllowUserToDeleteRows = false;
            this.dgvTacGia.AllowUserToResizeRows = false;
            this.dgvTacGia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTacGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTacGia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTacGia.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTacGia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTacGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTacGia.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTacGia.EnableHeadersVisualStyles = false;
            this.dgvTacGia.GridColor = System.Drawing.Color.Navy;
            this.dgvTacGia.Location = new System.Drawing.Point(527, 110);
            this.dgvTacGia.Name = "dgvTacGia";
            this.dgvTacGia.ReadOnly = true;
            this.dgvTacGia.RowHeadersVisible = false;
            this.dgvTacGia.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dgvTacGia.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTacGia.RowTemplate.Height = 24;
            this.dgvTacGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTacGia.Size = new System.Drawing.Size(719, 587);
            this.dgvTacGia.TabIndex = 55;
            // 
            // txb_TenTheLoai
            // 
            this.txb_TenTheLoai.BackColor = System.Drawing.SystemColors.Control;
            this.txb_TenTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_TenTheLoai.Location = new System.Drawing.Point(177, 202);
            this.txb_TenTheLoai.Name = "txb_TenTheLoai";
            this.txb_TenTheLoai.Size = new System.Drawing.Size(296, 34);
            this.txb_TenTheLoai.TabIndex = 6;
            // 
            // lb_TenTheLoai
            // 
            this.lb_TenTheLoai.AutoSize = true;
            this.lb_TenTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenTheLoai.ForeColor = System.Drawing.Color.Navy;
            this.lb_TenTheLoai.Location = new System.Drawing.Point(18, 208);
            this.lb_TenTheLoai.Name = "lb_TenTheLoai";
            this.lb_TenTheLoai.Size = new System.Drawing.Size(135, 25);
            this.lb_TenTheLoai.TabIndex = 5;
            this.lb_TenTheLoai.Text = "Tên Thể Loại:";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Đầu Sách";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Đầu Sách";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên Thể Loại";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // txb_MaDauSach
            // 
            this.txb_MaDauSach.BackColor = System.Drawing.SystemColors.Control;
            this.txb_MaDauSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_MaDauSach.Location = new System.Drawing.Point(177, 60);
            this.txb_MaDauSach.Name = "txb_MaDauSach";
            this.txb_MaDauSach.Size = new System.Drawing.Size(296, 34);
            this.txb_MaDauSach.TabIndex = 7;
            // 
            // Btxoa
            // 
            this.Btxoa.BackColor = System.Drawing.Color.LightCoral;
            this.Btxoa.BackgroundColor = System.Drawing.Color.LightCoral;
            this.Btxoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btxoa.BorderRadius = 20;
            this.Btxoa.BorderSize = 0;
            this.Btxoa.FlatAppearance.BorderSize = 0;
            this.Btxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btxoa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.Btxoa.ForeColor = System.Drawing.Color.White;
            this.Btxoa.Location = new System.Drawing.Point(280, 425);
            this.Btxoa.Name = "Btxoa";
            this.Btxoa.Size = new System.Drawing.Size(175, 50);
            this.Btxoa.TabIndex = 12;
            this.Btxoa.Text = "Xóa";
            this.Btxoa.TextColor = System.Drawing.Color.White;
            this.Btxoa.UseVisualStyleBackColor = false;
            // 
            // Btcapnhat
            // 
            this.Btcapnhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.Btcapnhat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.Btcapnhat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btcapnhat.BorderRadius = 20;
            this.Btcapnhat.BorderSize = 0;
            this.Btcapnhat.FlatAppearance.BorderSize = 0;
            this.Btcapnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btcapnhat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.Btcapnhat.ForeColor = System.Drawing.Color.White;
            this.Btcapnhat.Location = new System.Drawing.Point(67, 425);
            this.Btcapnhat.Name = "Btcapnhat";
            this.Btcapnhat.Size = new System.Drawing.Size(175, 50);
            this.Btcapnhat.TabIndex = 11;
            this.Btcapnhat.Text = "Cập Nhật";
            this.Btcapnhat.TextColor = System.Drawing.Color.White;
            this.Btcapnhat.UseVisualStyleBackColor = false;
            // 
            // BtLuu
            // 
            this.BtLuu.AccessibleName = "BtLuu";
            this.BtLuu.BackColor = System.Drawing.Color.Violet;
            this.BtLuu.BackgroundColor = System.Drawing.Color.Violet;
            this.BtLuu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtLuu.BorderRadius = 20;
            this.BtLuu.BorderSize = 0;
            this.BtLuu.FlatAppearance.BorderSize = 0;
            this.BtLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.BtLuu.ForeColor = System.Drawing.Color.White;
            this.BtLuu.Location = new System.Drawing.Point(280, 330);
            this.BtLuu.Name = "BtLuu";
            this.BtLuu.Size = new System.Drawing.Size(175, 50);
            this.BtLuu.TabIndex = 10;
            this.BtLuu.Text = "Lưu";
            this.BtLuu.TextColor = System.Drawing.Color.White;
            this.BtLuu.UseVisualStyleBackColor = false;
            // 
            // Btthemmoi
            // 
            this.Btthemmoi.AccessibleName = "BtThemmoi";
            this.Btthemmoi.BackColor = System.Drawing.Color.YellowGreen;
            this.Btthemmoi.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.Btthemmoi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btthemmoi.BorderRadius = 20;
            this.Btthemmoi.BorderSize = 0;
            this.Btthemmoi.FlatAppearance.BorderSize = 0;
            this.Btthemmoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btthemmoi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.Btthemmoi.ForeColor = System.Drawing.Color.White;
            this.Btthemmoi.Location = new System.Drawing.Point(67, 330);
            this.Btthemmoi.Name = "Btthemmoi";
            this.Btthemmoi.Size = new System.Drawing.Size(175, 50);
            this.Btthemmoi.TabIndex = 9;
            this.Btthemmoi.Text = "Thêm mới";
            this.Btthemmoi.TextColor = System.Drawing.Color.White;
            this.Btthemmoi.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1260, 724);
            this.Controls.Add(this.dgv_DSDauSach);
            this.Controls.Add(this.gb_TtDauSach);
            this.Controls.Add(this.lb_TTDauSach);
            this.Controls.Add(this.lb_DSDauSach);
            this.Controls.Add(this.dgvTacGia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSDauSach)).EndInit();
            this.gb_TtDauSach.ResumeLayout(false);
            this.gb_TtDauSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DSDauSach;
        private System.Windows.Forms.GroupBox gb_TtDauSach;
        private System.Windows.Forms.TextBox txb_TenDauSach;
        private System.Windows.Forms.Label lb_MaDauSach;
        private System.Windows.Forms.Label lb_TenDauSach;
        private System.Windows.Forms.Label lb_TTDauSach;
        private System.Windows.Forms.Label lb_DSDauSach;
        private System.Windows.Forms.DataGridView dgvTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox txb_TenTheLoai;
        private System.Windows.Forms.Label lb_TenTheLoai;
        private System.Windows.Forms.TextBox txb_MaDauSach;
        private CustomButton.VBButton Btxoa;
        private CustomButton.VBButton Btcapnhat;
        private CustomButton.VBButton BtLuu;
        private CustomButton.VBButton Btthemmoi;
    }
}

