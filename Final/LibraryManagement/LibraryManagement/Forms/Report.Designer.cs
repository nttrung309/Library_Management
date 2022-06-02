namespace DemoDesign
{
    partial class Report
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbTotalBorrowTitle = new System.Windows.Forms.Label();
            this.lbTitleName = new System.Windows.Forms.Label();
            this.lbTotalBorrow = new System.Windows.Forms.Label();
            this.cbbReportType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExport = new LibraryManagement.nButton();
            this.lbInform = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            this.dtgv.AllowUserToResizeRows = false;
            this.dtgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.kind,
            this.lendCount,
            this.rate});
            this.dtgv.EnableHeadersVisualStyles = false;
            this.dtgv.Location = new System.Drawing.Point(39, 236);
            this.dtgv.MultiSelect = false;
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.RowHeadersWidth = 40;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgv.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgv.RowTemplate.Height = 32;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(1187, 417);
            this.dtgv.TabIndex = 58;
            // 
            // col1
            // 
            this.col1.DataPropertyName = "stt";
            this.col1.HeaderText = "STT";
            this.col1.Name = "col1";
            this.col1.ReadOnly = true;
            this.col1.Width = 80;
            // 
            // kind
            // 
            this.kind.HeaderText = "Tên thể loại";
            this.kind.Name = "kind";
            this.kind.ReadOnly = true;
            this.kind.Width = 650;
            // 
            // lendCount
            // 
            this.lendCount.HeaderText = "Số lượt mượn";
            this.lendCount.Name = "lendCount";
            this.lendCount.ReadOnly = true;
            this.lendCount.Width = 224;
            // 
            // rate
            // 
            this.rate.HeaderText = "Tỷ lệ";
            this.rate.Name = "rate";
            this.rate.ReadOnly = true;
            this.rate.Width = 230;
            // 
            // dtp
            // 
            this.dtp.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.CustomFormat = "MM/yyyy";
            this.dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.Location = new System.Drawing.Point(185, 134);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(141, 31);
            this.dtp.TabIndex = 57;
            this.dtp.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 52;
            this.label2.Text = "Thời gian:";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.lbTitle.ForeColor = System.Drawing.Color.Navy;
            this.lbTitle.Location = new System.Drawing.Point(495, 24);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(274, 41);
            this.lbTitle.TabIndex = 49;
            this.lbTitle.Text = "Báo Cáo Thống Kê\r\n";
            // 
            // lbTotalBorrowTitle
            // 
            this.lbTotalBorrowTitle.AutoSize = true;
            this.lbTotalBorrowTitle.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalBorrowTitle.ForeColor = System.Drawing.Color.Indigo;
            this.lbTotalBorrowTitle.Location = new System.Drawing.Point(869, 672);
            this.lbTotalBorrowTitle.Name = "lbTotalBorrowTitle";
            this.lbTotalBorrowTitle.Size = new System.Drawing.Size(282, 33);
            this.lbTotalBorrowTitle.TabIndex = 59;
            this.lbTotalBorrowTitle.Text = "Tổng số lượt mượn:";
            // 
            // lbTitleName
            // 
            this.lbTitleName.AutoSize = true;
            this.lbTitleName.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold);
            this.lbTitleName.ForeColor = System.Drawing.Color.Gold;
            this.lbTitleName.Location = new System.Drawing.Point(285, 184);
            this.lbTitleName.Name = "lbTitleName";
            this.lbTitleName.Size = new System.Drawing.Size(670, 35);
            this.lbTitleName.TabIndex = 60;
            this.lbTitleName.Text = "Tình Hình Mượn Sách Theo Thể Loại Tháng 6";
            // 
            // lbTotalBorrow
            // 
            this.lbTotalBorrow.AutoSize = true;
            this.lbTotalBorrow.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalBorrow.ForeColor = System.Drawing.Color.Indigo;
            this.lbTotalBorrow.Location = new System.Drawing.Point(1140, 672);
            this.lbTotalBorrow.Name = "lbTotalBorrow";
            this.lbTotalBorrow.Size = new System.Drawing.Size(49, 33);
            this.lbTotalBorrow.TabIndex = 61;
            this.lbTotalBorrow.Text = "12";
            // 
            // cbbReportType
            // 
            this.cbbReportType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbbReportType.FormattingEnabled = true;
            this.cbbReportType.Items.AddRange(new object[] {
            "Tình Hình Mượn Sách Theo Thể Loại",
            "Sách Trả Trễ"});
            this.cbbReportType.Location = new System.Drawing.Point(185, 84);
            this.cbbReportType.Name = "cbbReportType";
            this.cbbReportType.Size = new System.Drawing.Size(286, 28);
            this.cbbReportType.TabIndex = 62;
            this.cbbReportType.SelectedIndexChanged += new System.EventHandler(this.cbbReportType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 29);
            this.label6.TabIndex = 63;
            this.label6.Text = "Loại báo cáo:\r\n";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.CadetBlue;
            this.btnExport.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.btnExport.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExport.BorderRadius = 20;
            this.btnExport.BorderSize = 0;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(1067, 48);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(134, 49);
            this.btnExport.TabIndex = 64;
            this.btnExport.Text = "Xuất báo cáo";
            this.btnExport.TextColor = System.Drawing.Color.White;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lbInform
            // 
            this.lbInform.AutoSize = true;
            this.lbInform.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInform.Location = new System.Drawing.Point(560, 424);
            this.lbInform.Name = "lbInform";
            this.lbInform.Size = new System.Drawing.Size(177, 42);
            this.lbInform.TabIndex = 65;
            this.lbInform.Text = "Không có";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1260, 724);
            this.Controls.Add(this.lbInform);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.cbbReportType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbTotalBorrow);
            this.Controls.Add(this.lbTitleName);
            this.Controls.Add(this.lbTotalBorrowTitle);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbTotalBorrowTitle;
        private System.Windows.Forms.Label lbTitleName;
        private System.Windows.Forms.Label lbTotalBorrow;
        private System.Windows.Forms.ComboBox cbbReportType;
        private System.Windows.Forms.Label label6;
        private LibraryManagement.nButton btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kind;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate;
        private System.Windows.Forms.Label lbInform;
    }
}