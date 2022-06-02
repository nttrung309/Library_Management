
namespace formcuonsach
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
            this.gb_TTCuonSach = new System.Windows.Forms.GroupBox();
            this.txb_MaSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lb_TTCuonSach = new System.Windows.Forms.Label();
            this.lb_DSCuonSach = new System.Windows.Forms.Label();
            this.dgvTacGia = new System.Windows.Forms.DataGridView();
            this.dgv_DSCuonSach = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btthemmoi = new CustomButton.VBButton();
            this.BtLuu = new CustomButton.VBButton();
            this.Btcapnhat = new CustomButton.VBButton();
            this.Btxoa = new CustomButton.VBButton();
            this.txb_MaCuonSach = new System.Windows.Forms.TextBox();
            this.gb_TTCuonSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSCuonSach)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_TTCuonSach
            // 
            this.gb_TTCuonSach.Controls.Add(this.txb_MaCuonSach);
            this.gb_TTCuonSach.Controls.Add(this.Btxoa);
            this.gb_TTCuonSach.Controls.Add(this.Btcapnhat);
            this.gb_TTCuonSach.Controls.Add(this.BtLuu);
            this.gb_TTCuonSach.Controls.Add(this.Btthemmoi);
            this.gb_TTCuonSach.Controls.Add(this.txb_MaSach);
            this.gb_TTCuonSach.Controls.Add(this.label1);
            this.gb_TTCuonSach.Controls.Add(this.label24);
            this.gb_TTCuonSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_TTCuonSach.ForeColor = System.Drawing.Color.Chocolate;
            this.gb_TTCuonSach.Location = new System.Drawing.Point(13, 96);
            this.gb_TTCuonSach.Name = "gb_TTCuonSach";
            this.gb_TTCuonSach.Size = new System.Drawing.Size(509, 600);
            this.gb_TTCuonSach.TabIndex = 52;
            this.gb_TTCuonSach.TabStop = false;
            this.gb_TTCuonSach.Text = "Thông Tin Cuốn Sách";
            // 
            // txb_MaSach
            // 
            this.txb_MaSach.BackColor = System.Drawing.SystemColors.Control;
            this.txb_MaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_MaSach.Location = new System.Drawing.Point(177, 132);
            this.txb_MaSach.Name = "txb_MaSach";
            this.txb_MaSach.Size = new System.Drawing.Size(296, 34);
            this.txb_MaSach.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(18, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Cuốn Sách:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Navy;
            this.label24.Location = new System.Drawing.Point(18, 138);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(97, 25);
            this.label24.TabIndex = 2;
            this.label24.Text = "Mã Sách:";
            // 
            // lb_TTCuonSach
            // 
            this.lb_TTCuonSach.AutoSize = true;
            this.lb_TTCuonSach.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TTCuonSach.ForeColor = System.Drawing.Color.Navy;
            this.lb_TTCuonSach.Location = new System.Drawing.Point(431, 26);
            this.lb_TTCuonSach.Name = "lb_TTCuonSach";
            this.lb_TTCuonSach.Size = new System.Drawing.Size(398, 51);
            this.lb_TTCuonSach.TabIndex = 51;
            this.lb_TTCuonSach.Text = "Thông Tin Cuốn Sách";
            this.lb_TTCuonSach.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb_DSCuonSach
            // 
            this.lb_DSCuonSach.AutoSize = true;
            this.lb_DSCuonSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DSCuonSach.ForeColor = System.Drawing.Color.Chocolate;
            this.lb_DSCuonSach.Location = new System.Drawing.Point(697, 80);
            this.lb_DSCuonSach.Name = "lb_DSCuonSach";
            this.lb_DSCuonSach.Size = new System.Drawing.Size(421, 26);
            this.lb_DSCuonSach.TabIndex = 49;
            this.lb_DSCuonSach.Text = "Danh Sách Cuốn Sách Trong Thư Viện";
            this.lb_DSCuonSach.Click += new System.EventHandler(this.label9_Click);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTacGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTacGia.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTacGia.EnableHeadersVisualStyles = false;
            this.dgvTacGia.GridColor = System.Drawing.Color.Navy;
            this.dgvTacGia.Location = new System.Drawing.Point(528, 109);
            this.dgvTacGia.Name = "dgvTacGia";
            this.dgvTacGia.ReadOnly = true;
            this.dgvTacGia.RowHeadersVisible = false;
            this.dgvTacGia.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dgvTacGia.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTacGia.RowTemplate.Height = 24;
            this.dgvTacGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTacGia.Size = new System.Drawing.Size(719, 587);
            this.dgvTacGia.TabIndex = 50;
            // 
            // dgv_DSCuonSach
            // 
            this.dgv_DSCuonSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSCuonSach.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DSCuonSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_DSCuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSCuonSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DSCuonSach.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_DSCuonSach.EnableHeadersVisualStyles = false;
            this.dgv_DSCuonSach.GridColor = System.Drawing.Color.Navy;
            this.dgv_DSCuonSach.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_DSCuonSach.Location = new System.Drawing.Point(528, 109);
            this.dgv_DSCuonSach.Name = "dgv_DSCuonSach";
            this.dgv_DSCuonSach.RowHeadersVisible = false;
            this.dgv_DSCuonSach.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DSCuonSach.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_DSCuonSach.RowTemplate.Height = 24;
            this.dgv_DSCuonSach.ShowCellErrors = false;
            this.dgv_DSCuonSach.Size = new System.Drawing.Size(721, 587);
            this.dgv_DSCuonSach.TabIndex = 53;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Cuốn Sách";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã Sách";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tình Trạng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
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
            this.Btthemmoi.Location = new System.Drawing.Point(45, 339);
            this.Btthemmoi.Name = "Btthemmoi";
            this.Btthemmoi.Size = new System.Drawing.Size(175, 50);
            this.Btthemmoi.TabIndex = 5;
            this.Btthemmoi.Text = "Thêm mới";
            this.Btthemmoi.TextColor = System.Drawing.Color.White;
            this.Btthemmoi.UseVisualStyleBackColor = false;
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
            this.BtLuu.Location = new System.Drawing.Point(258, 339);
            this.BtLuu.Name = "BtLuu";
            this.BtLuu.Size = new System.Drawing.Size(175, 50);
            this.BtLuu.TabIndex = 6;
            this.BtLuu.Text = "Lưu";
            this.BtLuu.TextColor = System.Drawing.Color.White;
            this.BtLuu.UseVisualStyleBackColor = false;
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
            this.Btcapnhat.Location = new System.Drawing.Point(45, 434);
            this.Btcapnhat.Name = "Btcapnhat";
            this.Btcapnhat.Size = new System.Drawing.Size(175, 50);
            this.Btcapnhat.TabIndex = 7;
            this.Btcapnhat.Text = "Cập Nhật";
            this.Btcapnhat.TextColor = System.Drawing.Color.White;
            this.Btcapnhat.UseVisualStyleBackColor = false;
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
            this.Btxoa.Location = new System.Drawing.Point(258, 434);
            this.Btxoa.Name = "Btxoa";
            this.Btxoa.Size = new System.Drawing.Size(175, 50);
            this.Btxoa.TabIndex = 8;
            this.Btxoa.Text = "Xóa";
            this.Btxoa.TextColor = System.Drawing.Color.White;
            this.Btxoa.UseVisualStyleBackColor = false;
            // 
            // txb_MaCuonSach
            // 
            this.txb_MaCuonSach.BackColor = System.Drawing.SystemColors.Control;
            this.txb_MaCuonSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_MaCuonSach.Location = new System.Drawing.Point(177, 60);
            this.txb_MaCuonSach.Name = "txb_MaCuonSach";
            this.txb_MaCuonSach.Size = new System.Drawing.Size(296, 34);
            this.txb_MaCuonSach.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1260, 724);
            this.Controls.Add(this.dgv_DSCuonSach);
            this.Controls.Add(this.gb_TTCuonSach);
            this.Controls.Add(this.lb_TTCuonSach);
            this.Controls.Add(this.lb_DSCuonSach);
            this.Controls.Add(this.dgvTacGia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_TTCuonSach.ResumeLayout(false);
            this.gb_TTCuonSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSCuonSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_TTCuonSach;
        private System.Windows.Forms.TextBox txb_MaSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lb_TTCuonSach;
        private System.Windows.Forms.Label lb_DSCuonSach;
        private System.Windows.Forms.DataGridView dgvTacGia;
        private System.Windows.Forms.DataGridView dgv_DSCuonSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private CustomButton.VBButton Btxoa;
        private CustomButton.VBButton Btcapnhat;
        private CustomButton.VBButton BtLuu;
        private CustomButton.VBButton Btthemmoi;
        private System.Windows.Forms.TextBox txb_MaCuonSach;
    }
}

