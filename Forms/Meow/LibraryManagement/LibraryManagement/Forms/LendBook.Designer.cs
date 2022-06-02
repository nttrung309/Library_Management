namespace DemoDesign
{
    partial class LendBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.border = new System.Windows.Forms.PictureBox();
            this.txbFindBook = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbReaderCode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.borrowDate = new System.Windows.Forms.DateTimePicker();
            this.returnDate = new System.Windows.Forms.DateTimePicker();
            this.dtgvBookChosen = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbAmount = new System.Windows.Forms.Label();
            this.dtgvStock = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUnchooseBook = new LibraryManagement.nButton();
            this.btnChooseBook = new LibraryManagement.nButton();
            this.btnCancel = new LibraryManagement.nButton();
            this.btnLend = new LibraryManagement.nButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txbReaderName = new System.Windows.Forms.TextBox();
            this.lbWCode = new System.Windows.Forms.Label();
            this.lbWName = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tlTip = new System.Windows.Forms.ToolTip(this.components);
            this.tgBtnAllowMax = new CustomControls.RJControls.ToggleButton();
            this.tgBtnAskBeforePrint = new CustomControls.RJControls.ToggleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnViewBorrowSlip = new LibraryManagement.nButton();
            this.lbMaxBorrow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.border)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBookChosen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(21, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cho Mượn Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(85, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã độc giả:";
            // 
            // border
            // 
            this.border.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.border.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.border.Location = new System.Drawing.Point(28, 87);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(1206, 176);
            this.border.TabIndex = 0;
            this.border.TabStop = false;
            // 
            // txbFindBook
            // 
            this.txbFindBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFindBook.Location = new System.Drawing.Point(133, 305);
            this.txbFindBook.Name = "txbFindBook";
            this.txbFindBook.Size = new System.Drawing.Size(259, 26);
            this.txbFindBook.TabIndex = 7;
            this.tlTip.SetToolTip(this.txbFindBook, "Nhập mã sách/tên sách/thể loại/tác giả để tìm sách");
            this.txbFindBook.TextChanged += new System.EventHandler(this.txbFindBook_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Chocolate;
            this.label3.Location = new System.Drawing.Point(37, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tìm sách:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(221, 672);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sách trong kho";
            // 
            // cbbReaderCode
            // 
            this.cbbReaderCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbReaderCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbReaderCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbbReaderCode.FormattingEnabled = true;
            this.cbbReaderCode.Location = new System.Drawing.Point(212, 132);
            this.cbbReaderCode.Name = "cbbReaderCode";
            this.cbbReaderCode.Size = new System.Drawing.Size(168, 28);
            this.cbbReaderCode.TabIndex = 0;
            this.cbbReaderCode.SelectedIndexChanged += new System.EventHandler(this.cbbReaderCode_SelectedIndexChanged);
            this.cbbReaderCode.TextChanged += new System.EventHandler(this.cbbReaderCode_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(85, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tên độc giả:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Chocolate;
            this.label7.Location = new System.Drawing.Point(59, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nhập thông tin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(568, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ngày mượn:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(568, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ngày trả:";
            // 
            // borrowDate
            // 
            this.borrowDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowDate.CustomFormat = "dd/MM/yyyy";
            this.borrowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.borrowDate.Location = new System.Drawing.Point(700, 130);
            this.borrowDate.Name = "borrowDate";
            this.borrowDate.Size = new System.Drawing.Size(152, 26);
            this.borrowDate.TabIndex = 2;
            this.borrowDate.ValueChanged += new System.EventHandler(this.borrowDate_ValueChanged);
            // 
            // returnDate
            // 
            this.returnDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDate.CustomFormat = "dd/MM/yyyy";
            this.returnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.returnDate.Location = new System.Drawing.Point(700, 185);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(152, 26);
            this.returnDate.TabIndex = 19;
            this.returnDate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.returnDay_MouseDown);
            // 
            // dtgvBookChosen
            // 
            this.dtgvBookChosen.AllowUserToAddRows = false;
            this.dtgvBookChosen.AllowUserToDeleteRows = false;
            this.dtgvBookChosen.AllowUserToResizeRows = false;
            this.dtgvBookChosen.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBookChosen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvBookChosen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBookChosen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dtgvBookChosen.EnableHeadersVisualStyles = false;
            this.dtgvBookChosen.Location = new System.Drawing.Point(689, 352);
            this.dtgvBookChosen.MultiSelect = false;
            this.dtgvBookChosen.Name = "dtgvBookChosen";
            this.dtgvBookChosen.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBookChosen.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvBookChosen.RowHeadersVisible = false;
            this.dtgvBookChosen.RowHeadersWidth = 40;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvBookChosen.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvBookChosen.RowTemplate.Height = 26;
            this.dtgvBookChosen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvBookChosen.Size = new System.Drawing.Size(559, 308);
            this.dtgvBookChosen.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "stt";
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "code";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã sách";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 99;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên sách";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 180;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "category";
            this.dataGridViewTextBoxColumn4.HeaderText = "Thể loại";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "author";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tác giả";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 112;
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.ForeColor = System.Drawing.Color.Navy;
            this.lbAmount.Location = new System.Drawing.Point(991, 161);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(145, 29);
            this.lbAmount.TabIndex = 21;
            this.lbAmount.Text = "Số lượng: 5";
            // 
            // dtgvStock
            // 
            this.dtgvStock.AllowUserToAddRows = false;
            this.dtgvStock.AllowUserToDeleteRows = false;
            this.dtgvStock.AllowUserToOrderColumns = true;
            this.dtgvStock.AllowUserToResizeRows = false;
            this.dtgvStock.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dtgvStock.EnableHeadersVisualStyles = false;
            this.dtgvStock.Location = new System.Drawing.Point(19, 352);
            this.dtgvStock.MultiSelect = false;
            this.dtgvStock.Name = "dtgvStock";
            this.dtgvStock.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvStock.RowHeadersVisible = false;
            this.dtgvStock.RowHeadersWidth = 40;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvStock.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvStock.RowTemplate.Height = 26;
            this.dtgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvStock.Size = new System.Drawing.Size(559, 308);
            this.dtgvStock.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "stt";
            this.dataGridViewTextBoxColumn6.HeaderText = "STT";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 40;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "code";
            this.dataGridViewTextBoxColumn7.HeaderText = "Mã sách";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 99;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn8.HeaderText = "Tên sách";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 180;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "category";
            this.dataGridViewTextBoxColumn9.HeaderText = "Thể loại";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "author";
            this.dataGridViewTextBoxColumn10.HeaderText = "Tác giả";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 112;
            // 
            // btnUnchooseBook
            // 
            this.btnUnchooseBook.BackColor = System.Drawing.Color.LightCoral;
            this.btnUnchooseBook.BackgroundColor = System.Drawing.Color.LightCoral;
            this.btnUnchooseBook.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUnchooseBook.BorderRadius = 20;
            this.btnUnchooseBook.BorderSize = 0;
            this.btnUnchooseBook.FlatAppearance.BorderSize = 0;
            this.btnUnchooseBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnchooseBook.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnUnchooseBook.ForeColor = System.Drawing.Color.White;
            this.btnUnchooseBook.Location = new System.Drawing.Point(594, 518);
            this.btnUnchooseBook.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnchooseBook.Name = "btnUnchooseBook";
            this.btnUnchooseBook.Size = new System.Drawing.Size(80, 42);
            this.btnUnchooseBook.TabIndex = 25;
            this.btnUnchooseBook.Text = "<- Bỏ";
            this.btnUnchooseBook.TextColor = System.Drawing.Color.White;
            this.btnUnchooseBook.UseVisualStyleBackColor = false;
            this.btnUnchooseBook.Click += new System.EventHandler(this.btnUnchooseBook_Click);
            // 
            // btnChooseBook
            // 
            this.btnChooseBook.BackColor = System.Drawing.Color.YellowGreen;
            this.btnChooseBook.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.btnChooseBook.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnChooseBook.BorderRadius = 20;
            this.btnChooseBook.BorderSize = 0;
            this.btnChooseBook.FlatAppearance.BorderSize = 0;
            this.btnChooseBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseBook.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnChooseBook.ForeColor = System.Drawing.Color.White;
            this.btnChooseBook.Location = new System.Drawing.Point(594, 466);
            this.btnChooseBook.Margin = new System.Windows.Forms.Padding(2);
            this.btnChooseBook.Name = "btnChooseBook";
            this.btnChooseBook.Size = new System.Drawing.Size(80, 42);
            this.btnChooseBook.TabIndex = 24;
            this.btnChooseBook.Text = "Thêm ->";
            this.btnChooseBook.TextColor = System.Drawing.Color.White;
            this.btnChooseBook.UseVisualStyleBackColor = false;
            this.btnChooseBook.Click += new System.EventHandler(this.btnChooseBook_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.BackgroundColor = System.Drawing.Color.LightCoral;
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 20;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1113, 27);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 38);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cập nhật";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLend
            // 
            this.btnLend.BackColor = System.Drawing.Color.YellowGreen;
            this.btnLend.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.btnLend.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLend.BorderRadius = 20;
            this.btnLend.BorderSize = 0;
            this.btnLend.FlatAppearance.BorderSize = 0;
            this.btnLend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLend.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnLend.ForeColor = System.Drawing.Color.White;
            this.btnLend.Location = new System.Drawing.Point(996, 27);
            this.btnLend.Margin = new System.Windows.Forms.Padding(2);
            this.btnLend.Name = "btnLend";
            this.btnLend.Size = new System.Drawing.Size(112, 38);
            this.btnLend.TabIndex = 22;
            this.btnLend.Text = "Cho Mượn";
            this.btnLend.TextColor = System.Drawing.Color.White;
            this.btnLend.UseVisualStyleBackColor = false;
            this.btnLend.Click += new System.EventHandler(this.btnLend_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(908, 672);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 23);
            this.label10.TabIndex = 27;
            this.label10.Text = "Sách đã chọn";
            // 
            // txbReaderName
            // 
            this.txbReaderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbReaderName.Location = new System.Drawing.Point(212, 187);
            this.txbReaderName.Name = "txbReaderName";
            this.txbReaderName.Size = new System.Drawing.Size(233, 26);
            this.txbReaderName.TabIndex = 28;
            this.txbReaderName.TextChanged += new System.EventHandler(this.txbReaderName_TextChanged);
            this.txbReaderName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txbReaderName_MouseDown);
            // 
            // lbWCode
            // 
            this.lbWCode.AutoSize = true;
            this.lbWCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbWCode.Location = new System.Drawing.Point(211, 161);
            this.lbWCode.Name = "lbWCode";
            this.lbWCode.Size = new System.Drawing.Size(141, 16);
            this.lbWCode.TabIndex = 29;
            this.lbWCode.Text = "Không tìm thấy độc giả";
            this.lbWCode.Visible = false;
            // 
            // lbWName
            // 
            this.lbWName.AutoSize = true;
            this.lbWName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbWName.Location = new System.Drawing.Point(211, 216);
            this.lbWName.Name = "lbWName";
            this.lbWName.Size = new System.Drawing.Size(141, 16);
            this.lbWName.TabIndex = 30;
            this.lbWName.Text = "Không tìm thấy độc giả";
            this.lbWName.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(392, 311);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(31, 16);
            this.linkLabel1.TabIndex = 31;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Xóa";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // tlTip
            // 
            this.tlTip.AutoPopDelay = 5000;
            this.tlTip.InitialDelay = 100;
            this.tlTip.ReshowDelay = 100;
            // 
            // tgBtnAllowMax
            // 
            this.tgBtnAllowMax.AutoSize = true;
            this.tgBtnAllowMax.Checked = true;
            this.tgBtnAllowMax.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tgBtnAllowMax.Location = new System.Drawing.Point(1168, 277);
            this.tgBtnAllowMax.MinimumSize = new System.Drawing.Size(45, 22);
            this.tgBtnAllowMax.Name = "tgBtnAllowMax";
            this.tgBtnAllowMax.OffBackColor = System.Drawing.Color.Gray;
            this.tgBtnAllowMax.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tgBtnAllowMax.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tgBtnAllowMax.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tgBtnAllowMax.Size = new System.Drawing.Size(45, 22);
            this.tgBtnAllowMax.TabIndex = 32;
            this.tgBtnAllowMax.UseVisualStyleBackColor = true;
            this.tgBtnAllowMax.CheckedChanged += new System.EventHandler(this.tgBtnAllowMax_CheckedChanged);
            // 
            // tgBtnAskBeforePrint
            // 
            this.tgBtnAskBeforePrint.AutoSize = true;
            this.tgBtnAskBeforePrint.Checked = true;
            this.tgBtnAskBeforePrint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tgBtnAskBeforePrint.Location = new System.Drawing.Point(1168, 310);
            this.tgBtnAskBeforePrint.MinimumSize = new System.Drawing.Size(45, 22);
            this.tgBtnAskBeforePrint.Name = "tgBtnAskBeforePrint";
            this.tgBtnAskBeforePrint.OffBackColor = System.Drawing.Color.Gray;
            this.tgBtnAskBeforePrint.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tgBtnAskBeforePrint.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tgBtnAskBeforePrint.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tgBtnAskBeforePrint.Size = new System.Drawing.Size(45, 22);
            this.tgBtnAskBeforePrint.TabIndex = 33;
            this.tgBtnAskBeforePrint.UseVisualStyleBackColor = true;
            this.tgBtnAskBeforePrint.CheckedChanged += new System.EventHandler(this.tgBtnAskBeforePrint_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(899, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Áp dụng số sách tối đa có thể mượn";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(1052, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 20);
            this.label11.TabIndex = 35;
            this.label11.Text = "In phiếu mượn";
            // 
            // btnViewBorrowSlip
            // 
            this.btnViewBorrowSlip.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnViewBorrowSlip.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.btnViewBorrowSlip.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnViewBorrowSlip.BorderRadius = 20;
            this.btnViewBorrowSlip.BorderSize = 0;
            this.btnViewBorrowSlip.FlatAppearance.BorderSize = 0;
            this.btnViewBorrowSlip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBorrowSlip.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewBorrowSlip.ForeColor = System.Drawing.Color.White;
            this.btnViewBorrowSlip.Location = new System.Drawing.Point(845, 27);
            this.btnViewBorrowSlip.Name = "btnViewBorrowSlip";
            this.btnViewBorrowSlip.Size = new System.Drawing.Size(146, 38);
            this.btnViewBorrowSlip.TabIndex = 60;
            this.btnViewBorrowSlip.Text = "Xem phiếu mượn";
            this.btnViewBorrowSlip.TextColor = System.Drawing.Color.White;
            this.btnViewBorrowSlip.UseVisualStyleBackColor = false;
            this.btnViewBorrowSlip.Click += new System.EventHandler(this.btnViewBorrowSlip_Click);
            // 
            // lbMaxBorrow
            // 
            this.lbMaxBorrow.AutoSize = true;
            this.lbMaxBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaxBorrow.ForeColor = System.Drawing.Color.Navy;
            this.lbMaxBorrow.Location = new System.Drawing.Point(698, 314);
            this.lbMaxBorrow.Name = "lbMaxBorrow";
            this.lbMaxBorrow.Size = new System.Drawing.Size(279, 24);
            this.lbMaxBorrow.TabIndex = 61;
            this.lbMaxBorrow.Text = "Số sách được mượn tối đa: 5\r\n";
            // 
            // LendBook
            // 
            this.AcceptButton = this.btnLend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1260, 724);
            this.Controls.Add(this.lbMaxBorrow);
            this.Controls.Add(this.btnViewBorrowSlip);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tgBtnAskBeforePrint);
            this.Controls.Add(this.tgBtnAllowMax);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbWName);
            this.Controls.Add(this.lbWCode);
            this.Controls.Add(this.txbReaderName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtgvStock);
            this.Controls.Add(this.btnUnchooseBook);
            this.Controls.Add(this.btnChooseBook);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLend);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.dtgvBookChosen);
            this.Controls.Add(this.returnDate);
            this.Controls.Add(this.borrowDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbReaderCode);
            this.Controls.Add(this.txbFindBook);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.border);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LendBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LendBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.border)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBookChosen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox border;
        private System.Windows.Forms.TextBox txbFindBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbReaderCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker borrowDate;
        private System.Windows.Forms.DateTimePicker returnDate;
        private System.Windows.Forms.DataGridView dtgvBookChosen;
        private System.Windows.Forms.Label lbAmount;
        private LibraryManagement.nButton btnLend;
        private LibraryManagement.nButton btnCancel;
        private LibraryManagement.nButton btnChooseBook;
        private LibraryManagement.nButton btnUnchooseBook;
        private System.Windows.Forms.DataGridView dtgvStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbReaderName;
        private System.Windows.Forms.Label lbWCode;
        private System.Windows.Forms.Label lbWName;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolTip tlTip;
        private CustomControls.RJControls.ToggleButton tgBtnAllowMax;
        private CustomControls.RJControls.ToggleButton tgBtnAskBeforePrint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private LibraryManagement.nButton btnViewBorrowSlip;
        private System.Windows.Forms.Label lbMaxBorrow;
    }
}

