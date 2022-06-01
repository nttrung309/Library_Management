
namespace LibraryManagement
{
    partial class fHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHome));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlSlideMenu = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnFine = new System.Windows.Forms.Button();
            this.btnRecvBook = new System.Windows.Forms.Button();
            this.btnLendBook = new System.Windows.Forms.Button();
            this.btnAddNewBook = new System.Windows.Forms.Button();
            this.btnAddReader = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lbClock = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.nButton1 = new LibraryManagement.nButton();
            this.pnlTop.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(84)))), ((int)(((byte)(131)))));
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1415, 25);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(84)))), ((int)(((byte)(131)))));
            this.btnMinimize.BackgroundImage = global::LibraryManagement.Properties.Resources.minimize_btn;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.Location = new System.Drawing.Point(1357, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 20);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(84)))), ((int)(((byte)(131)))));
            this.btnClose.BackgroundImage = global::LibraryManagement.Properties.Resources.close_btn;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1387, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 20);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(135)))), ((int)(((byte)(176)))));
            this.pnlMenu.Controls.Add(this.pnlSlideMenu);
            this.pnlMenu.Controls.Add(this.btnSearch);
            this.pnlMenu.Controls.Add(this.btnReport);
            this.pnlMenu.Controls.Add(this.btnFine);
            this.pnlMenu.Controls.Add(this.btnRecvBook);
            this.pnlMenu.Controls.Add(this.btnLendBook);
            this.pnlMenu.Controls.Add(this.btnAddNewBook);
            this.pnlMenu.Controls.Add(this.btnAddReader);
            this.pnlMenu.Controls.Add(this.btnSetting);
            this.pnlMenu.Controls.Add(this.lbTitle);
            this.pnlMenu.Controls.Add(this.picLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 25);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(155, 771);
            this.pnlMenu.TabIndex = 1;
            // 
            // pnlSlideMenu
            // 
            this.pnlSlideMenu.BackColor = System.Drawing.Color.White;
            this.pnlSlideMenu.Location = new System.Drawing.Point(0, 242);
            this.pnlSlideMenu.Name = "pnlSlideMenu";
            this.pnlSlideMenu.Size = new System.Drawing.Size(4, 50);
            this.pnlSlideMenu.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSearch.Image = global::LibraryManagement.Properties.Resources.menu_btnSearch;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(0, 342);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(162, 50);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Tra cứu sách";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(0, 542);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(155, 50);
            this.btnReport.TabIndex = 14;
            this.btnReport.Text = "Lập báo cáo";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnFine
            // 
            this.btnFine.FlatAppearance.BorderSize = 0;
            this.btnFine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFine.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnFine.Image = ((System.Drawing.Image)(resources.GetObject("btnFine.Image")));
            this.btnFine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFine.Location = new System.Drawing.Point(0, 492);
            this.btnFine.Name = "btnFine";
            this.btnFine.Size = new System.Drawing.Size(155, 50);
            this.btnFine.TabIndex = 13;
            this.btnFine.Text = "Lập phiếu thu tiền phạt";
            this.btnFine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFine.UseVisualStyleBackColor = true;
            // 
            // btnRecvBook
            // 
            this.btnRecvBook.FlatAppearance.BorderSize = 0;
            this.btnRecvBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecvBook.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnRecvBook.Image = ((System.Drawing.Image)(resources.GetObject("btnRecvBook.Image")));
            this.btnRecvBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecvBook.Location = new System.Drawing.Point(0, 442);
            this.btnRecvBook.Name = "btnRecvBook";
            this.btnRecvBook.Size = new System.Drawing.Size(155, 50);
            this.btnRecvBook.TabIndex = 12;
            this.btnRecvBook.Text = "Nhận trả sách";
            this.btnRecvBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecvBook.UseVisualStyleBackColor = true;
            // 
            // btnLendBook
            // 
            this.btnLendBook.FlatAppearance.BorderSize = 0;
            this.btnLendBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLendBook.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnLendBook.Image = ((System.Drawing.Image)(resources.GetObject("btnLendBook.Image")));
            this.btnLendBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLendBook.Location = new System.Drawing.Point(0, 392);
            this.btnLendBook.Name = "btnLendBook";
            this.btnLendBook.Size = new System.Drawing.Size(162, 50);
            this.btnLendBook.TabIndex = 11;
            this.btnLendBook.Text = "Cho mượn sách";
            this.btnLendBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLendBook.UseVisualStyleBackColor = true;
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.FlatAppearance.BorderSize = 0;
            this.btnAddNewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewBook.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAddNewBook.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewBook.Image")));
            this.btnAddNewBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewBook.Location = new System.Drawing.Point(0, 292);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(155, 50);
            this.btnAddNewBook.TabIndex = 10;
            this.btnAddNewBook.Text = "Tiếp nhận\r\nsách mới";
            this.btnAddNewBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewBook.UseVisualStyleBackColor = true;
            // 
            // btnAddReader
            // 
            this.btnAddReader.FlatAppearance.BorderSize = 0;
            this.btnAddReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReader.Image = ((System.Drawing.Image)(resources.GetObject("btnAddReader.Image")));
            this.btnAddReader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddReader.Location = new System.Drawing.Point(0, 242);
            this.btnAddReader.Name = "btnAddReader";
            this.btnAddReader.Size = new System.Drawing.Size(162, 50);
            this.btnAddReader.TabIndex = 9;
            this.btnAddReader.Text = "Lập thẻ độc giả";
            this.btnAddReader.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddReader.UseVisualStyleBackColor = true;
            // 
            // btnSetting
            // 
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 721);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(155, 50);
            this.btnSetting.TabIndex = 8;
            this.btnSetting.Text = "Cài đặt";
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(7, 138);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(141, 25);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Quản Lý Thư Viện";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(30, 54);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(94, 91);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.pnlUser.Controls.Add(this.lbClock);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUser.Location = new System.Drawing.Point(155, 25);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(1260, 47);
            this.pnlUser.TabIndex = 2;
            // 
            // lbClock
            // 
            this.lbClock.AutoSize = true;
            this.lbClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClock.Location = new System.Drawing.Point(16, 14);
            this.lbClock.Name = "lbClock";
            this.lbClock.Size = new System.Drawing.Size(51, 20);
            this.lbClock.TabIndex = 4;
            this.lbClock.Text = "label1";
            // 
            // clock
            // 
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // nButton1
            // 
            this.nButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.nButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.nButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.nButton1.BorderRadius = 20;
            this.nButton1.BorderSize = 0;
            this.nButton1.FlatAppearance.BorderSize = 0;
            this.nButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nButton1.ForeColor = System.Drawing.Color.White;
            this.nButton1.Location = new System.Drawing.Point(609, 197);
            this.nButton1.Name = "nButton1";
            this.nButton1.Size = new System.Drawing.Size(49, 51);
            this.nButton1.TabIndex = 3;
            this.nButton1.Text = "nButton1";
            this.nButton1.TextColor = System.Drawing.Color.White;
            this.nButton1.UseVisualStyleBackColor = false;
            // 
            // fHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1415, 796);
            this.ControlBox = false;
            this.Controls.Add(this.nButton1);
            this.Controls.Add(this.pnlUser);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.fHome_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnlSlideMenu;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnAddNewBook;
        private System.Windows.Forms.Button btnAddReader;
        private System.Windows.Forms.Button btnLendBook;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnFine;
        private System.Windows.Forms.Button btnRecvBook;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbClock;
        private nButton nButton1;
        private System.Windows.Forms.Timer clock;
    }
}

