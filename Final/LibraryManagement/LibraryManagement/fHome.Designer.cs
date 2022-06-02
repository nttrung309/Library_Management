
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
            this.btnChangeRule = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAddNewBook = new System.Windows.Forms.Button();
            this.btnAddReader = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lbClock = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.menuReader = new CustomControls.RJControls.RJDropdownMenu(this.components);
            this.thẻĐộcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiĐộcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBook = new CustomControls.RJControls.RJDropdownMenu(this.components);
            this.đầuSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuNhậpSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLendReturn = new CustomControls.RJControls.RJDropdownMenu(this.components);
            this.mượnSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trảSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTop.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlUser.SuspendLayout();
            this.menuReader.SuspendLayout();
            this.menuBook.SuspendLayout();
            this.menuLendReturn.SuspendLayout();
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
            this.pnlMenu.Controls.Add(this.btnChangeRule);
            this.pnlMenu.Controls.Add(this.btnFind);
            this.pnlMenu.Controls.Add(this.btnAddNewBook);
            this.pnlMenu.Controls.Add(this.btnAddReader);
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
            this.pnlSlideMenu.Location = new System.Drawing.Point(0, 257);
            this.pnlSlideMenu.Name = "pnlSlideMenu";
            this.pnlSlideMenu.Size = new System.Drawing.Size(4, 50);
            this.pnlSlideMenu.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Image = global::LibraryManagement.Properties.Resources.menu_btnSearch;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(0, 357);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(162, 50);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Quản lí mượn trả";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReport
            // 
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(0, 457);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(155, 50);
            this.btnReport.TabIndex = 14;
            this.btnReport.Text = "Lập báo cáo";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnChangeRule
            // 
            this.btnChangeRule.FlatAppearance.BorderSize = 0;
            this.btnChangeRule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeRule.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnChangeRule.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeRule.Image")));
            this.btnChangeRule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeRule.Location = new System.Drawing.Point(0, 507);
            this.btnChangeRule.Name = "btnChangeRule";
            this.btnChangeRule.Size = new System.Drawing.Size(155, 50);
            this.btnChangeRule.TabIndex = 13;
            this.btnChangeRule.Text = "Thay đổi quy định";
            this.btnChangeRule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangeRule.UseVisualStyleBackColor = true;
            this.btnChangeRule.Click += new System.EventHandler(this.btnChangeRule_Click);
            // 
            // btnFind
            // 
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(0, 407);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(162, 50);
            this.btnFind.TabIndex = 11;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.FlatAppearance.BorderSize = 0;
            this.btnAddNewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewBook.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAddNewBook.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewBook.Image")));
            this.btnAddNewBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewBook.Location = new System.Drawing.Point(0, 307);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(155, 50);
            this.btnAddNewBook.TabIndex = 10;
            this.btnAddNewBook.Text = "Quản lý sách";
            this.btnAddNewBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewBook.UseVisualStyleBackColor = true;
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNewBook_Click);
            // 
            // btnAddReader
            // 
            this.btnAddReader.FlatAppearance.BorderSize = 0;
            this.btnAddReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReader.Image = ((System.Drawing.Image)(resources.GetObject("btnAddReader.Image")));
            this.btnAddReader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddReader.Location = new System.Drawing.Point(0, 257);
            this.btnAddReader.Name = "btnAddReader";
            this.btnAddReader.Size = new System.Drawing.Size(162, 50);
            this.btnAddReader.TabIndex = 9;
            this.btnAddReader.Text = "Quản lý độc giả";
            this.btnAddReader.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddReader.UseVisualStyleBackColor = true;
            this.btnAddReader.Click += new System.EventHandler(this.btnAddReader_Click);
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
            // menuReader
            // 
            this.menuReader.IsMainMenu = false;
            this.menuReader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thẻĐộcGiảToolStripMenuItem,
            this.loạiĐộcGiảToolStripMenuItem,
            this.phiếuToolStripMenuItem});
            this.menuReader.MenuItemHeight = 25;
            this.menuReader.MenuItemTextColor = System.Drawing.Color.Empty;
            this.menuReader.Name = "menuReader";
            this.menuReader.PrimaryColor = System.Drawing.Color.Empty;
            this.menuReader.Size = new System.Drawing.Size(181, 92);
            // 
            // thẻĐộcGiảToolStripMenuItem
            // 
            this.thẻĐộcGiảToolStripMenuItem.Name = "thẻĐộcGiảToolStripMenuItem";
            this.thẻĐộcGiảToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thẻĐộcGiảToolStripMenuItem.Text = "Thẻ độc giả";
            this.thẻĐộcGiảToolStripMenuItem.Click += new System.EventHandler(this.thẻĐộcGiảToolStripMenuItem_Click);
            // 
            // loạiĐộcGiảToolStripMenuItem
            // 
            this.loạiĐộcGiảToolStripMenuItem.Name = "loạiĐộcGiảToolStripMenuItem";
            this.loạiĐộcGiảToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loạiĐộcGiảToolStripMenuItem.Text = "Loại độc giả";
            this.loạiĐộcGiảToolStripMenuItem.Click += new System.EventHandler(this.loạiĐộcGiảToolStripMenuItem_Click);
            // 
            // phiếuToolStripMenuItem
            // 
            this.phiếuToolStripMenuItem.Name = "phiếuToolStripMenuItem";
            this.phiếuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.phiếuToolStripMenuItem.Text = "Phiếu thu tiền";
            this.phiếuToolStripMenuItem.Click += new System.EventHandler(this.phiếuToolStripMenuItem_Click);
            // 
            // menuBook
            // 
            this.menuBook.IsMainMenu = false;
            this.menuBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đầuSáchToolStripMenuItem,
            this.tácGiảToolStripMenuItem,
            this.sáchToolStripMenuItem,
            this.phiếuNhậpSáchToolStripMenuItem,
            this.loạiSáchToolStripMenuItem});
            this.menuBook.MenuItemHeight = 25;
            this.menuBook.MenuItemTextColor = System.Drawing.Color.Empty;
            this.menuBook.Name = "menuBook";
            this.menuBook.PrimaryColor = System.Drawing.Color.Empty;
            this.menuBook.Size = new System.Drawing.Size(162, 114);
            // 
            // đầuSáchToolStripMenuItem
            // 
            this.đầuSáchToolStripMenuItem.Name = "đầuSáchToolStripMenuItem";
            this.đầuSáchToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.đầuSáchToolStripMenuItem.Text = "Đầu sách";
            this.đầuSáchToolStripMenuItem.Click += new System.EventHandler(this.đầuSáchToolStripMenuItem_Click);
            // 
            // tácGiảToolStripMenuItem
            // 
            this.tácGiảToolStripMenuItem.Name = "tácGiảToolStripMenuItem";
            this.tácGiảToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.tácGiảToolStripMenuItem.Text = "Tác giả";
            this.tácGiảToolStripMenuItem.Click += new System.EventHandler(this.tácGiảToolStripMenuItem_Click);
            // 
            // sáchToolStripMenuItem
            // 
            this.sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            this.sáchToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.sáchToolStripMenuItem.Text = "Sách";
            this.sáchToolStripMenuItem.Click += new System.EventHandler(this.sáchToolStripMenuItem_Click);
            // 
            // phiếuNhậpSáchToolStripMenuItem
            // 
            this.phiếuNhậpSáchToolStripMenuItem.Name = "phiếuNhậpSáchToolStripMenuItem";
            this.phiếuNhậpSáchToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.phiếuNhậpSáchToolStripMenuItem.Text = "Phiếu nhập sách";
            this.phiếuNhậpSáchToolStripMenuItem.Click += new System.EventHandler(this.phiếuNhậpSáchToolStripMenuItem_Click);
            // 
            // loạiSáchToolStripMenuItem
            // 
            this.loạiSáchToolStripMenuItem.Name = "loạiSáchToolStripMenuItem";
            this.loạiSáchToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.loạiSáchToolStripMenuItem.Text = "Loại Sách";
            this.loạiSáchToolStripMenuItem.Click += new System.EventHandler(this.loạiSáchToolStripMenuItem_Click);
            // 
            // menuLendReturn
            // 
            this.menuLendReturn.IsMainMenu = false;
            this.menuLendReturn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mượnSáchToolStripMenuItem,
            this.trảSáchToolStripMenuItem});
            this.menuLendReturn.MenuItemHeight = 25;
            this.menuLendReturn.MenuItemTextColor = System.Drawing.Color.Empty;
            this.menuLendReturn.Name = "menuLendReturn";
            this.menuLendReturn.PrimaryColor = System.Drawing.Color.Empty;
            this.menuLendReturn.Size = new System.Drawing.Size(134, 48);
            // 
            // mượnSáchToolStripMenuItem
            // 
            this.mượnSáchToolStripMenuItem.Name = "mượnSáchToolStripMenuItem";
            this.mượnSáchToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.mượnSáchToolStripMenuItem.Text = "Mượn sách";
            this.mượnSáchToolStripMenuItem.Click += new System.EventHandler(this.mượnSáchToolStripMenuItem_Click);
            // 
            // trảSáchToolStripMenuItem
            // 
            this.trảSáchToolStripMenuItem.Name = "trảSáchToolStripMenuItem";
            this.trảSáchToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.trảSáchToolStripMenuItem.Text = "Trả sách";
            this.trảSáchToolStripMenuItem.Click += new System.EventHandler(this.trảSáchToolStripMenuItem_Click);
            // 
            // fHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1415, 796);
            this.ControlBox = false;
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
            this.menuReader.ResumeLayout(false);
            this.menuBook.ResumeLayout(false);
            this.menuLendReturn.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnAddNewBook;
        private System.Windows.Forms.Button btnAddReader;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnChangeRule;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbClock;
        private System.Windows.Forms.Timer clock;
        private CustomControls.RJControls.RJDropdownMenu menuReader;
        private CustomControls.RJControls.RJDropdownMenu menuBook;
        private CustomControls.RJControls.RJDropdownMenu menuLendReturn;
        private System.Windows.Forms.ToolStripMenuItem thẻĐộcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loạiĐộcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đầuSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuNhậpSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loạiSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mượnSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trảSáchToolStripMenuItem;
    }
}

