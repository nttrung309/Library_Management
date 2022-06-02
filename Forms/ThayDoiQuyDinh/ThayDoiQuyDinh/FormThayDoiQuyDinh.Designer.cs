
namespace ThayDoiQuyDinh
{
    partial class FormThayDoiQuyDinh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbThoiHanThe = new System.Windows.Forms.Label();
            this.txbThoiHanThe = new System.Windows.Forms.TextBox();
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.gbThayDoiQuyDinh = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbMucThuTienPhat = new System.Windows.Forms.TextBox();
            this.lbMucThuTienPhat = new System.Windows.Forms.Label();
            this.txbSoSachMuonMax = new System.Windows.Forms.TextBox();
            this.lbSoSachMuonToiDa = new System.Windows.Forms.Label();
            this.txbTuoiToiThieu = new System.Windows.Forms.TextBox();
            this.lbThoiGianLuuHanh = new System.Windows.Forms.Label();
            this.txbSoNgayMuonMax = new System.Windows.Forms.TextBox();
            this.lbSoNgayMuonMax = new System.Windows.Forms.Label();
            this.txbTuoiToiDa = new System.Windows.Forms.TextBox();
            this.lbTuoiToiDa = new System.Windows.Forms.Label();
            this.txbThoiGianLuuHanh = new System.Windows.Forms.TextBox();
            this.lbTuoiToiThieu = new System.Windows.Forms.Label();
            this.gbQuyDinhHienHanh = new System.Windows.Forms.DataGridView();
            this.lbTieuDe1 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lbTien = new System.Windows.Forms.Label();
            this.lbSachMax = new System.Windows.Forms.Label();
            this.lbNgayMax = new System.Windows.Forms.Label();
            this.lbTuoiMin = new System.Windows.Forms.Label();
            this.lbTuoiMax = new System.Windows.Forms.Label();
            this.lbLuuHanh = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbthoihan = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCapNhat = new ThayDoiQuyDinh.nButton();
            this.gbThayDoiQuyDinh.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbQuyDinhHienHanh)).BeginInit();
            this.SuspendLayout();
            // 
            // lbThoiHanThe
            // 
            this.lbThoiHanThe.AutoSize = true;
            this.lbThoiHanThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoiHanThe.ForeColor = System.Drawing.Color.Navy;
            this.lbThoiHanThe.Location = new System.Drawing.Point(-4, 13);
            this.lbThoiHanThe.Name = "lbThoiHanThe";
            this.lbThoiHanThe.Size = new System.Drawing.Size(251, 29);
            this.lbThoiHanThe.TabIndex = 0;
            this.lbThoiHanThe.Text = "Thời Hạn Thẻ (Tháng)";
            // 
            // txbThoiHanThe
            // 
            this.txbThoiHanThe.BackColor = System.Drawing.SystemColors.Control;
            this.txbThoiHanThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbThoiHanThe.Location = new System.Drawing.Point(11, 51);
            this.txbThoiHanThe.MaxLength = 4;
            this.txbThoiHanThe.Name = "txbThoiHanThe";
            this.txbThoiHanThe.Size = new System.Drawing.Size(185, 38);
            this.txbThoiHanThe.TabIndex = 1;
            this.txbThoiHanThe.TextChanged += new System.EventHandler(this.txbThoiHanThe_TextChanged);
            this.txbThoiHanThe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.ForeColor = System.Drawing.Color.Navy;
            this.lbTieuDe.Location = new System.Drawing.Point(477, 9);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(283, 36);
            this.lbTieuDe.TabIndex = 0;
            this.lbTieuDe.Text = "Thay Đổi Quy Định";
            // 
            // gbThayDoiQuyDinh
            // 
            this.gbThayDoiQuyDinh.BackColor = System.Drawing.Color.Transparent;
            this.gbThayDoiQuyDinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gbThayDoiQuyDinh.Controls.Add(this.panel4);
            this.gbThayDoiQuyDinh.Controls.Add(this.btnCapNhat);
            this.gbThayDoiQuyDinh.Location = new System.Drawing.Point(736, 122);
            this.gbThayDoiQuyDinh.Name = "gbThayDoiQuyDinh";
            this.gbThayDoiQuyDinh.Size = new System.Drawing.Size(512, 589);
            this.gbThayDoiQuyDinh.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbThoiHanThe);
            this.panel4.Controls.Add(this.txbMucThuTienPhat);
            this.panel4.Controls.Add(this.lbMucThuTienPhat);
            this.panel4.Controls.Add(this.txbSoSachMuonMax);
            this.panel4.Controls.Add(this.lbSoSachMuonToiDa);
            this.panel4.Controls.Add(this.txbTuoiToiThieu);
            this.panel4.Controls.Add(this.lbThoiGianLuuHanh);
            this.panel4.Controls.Add(this.txbSoNgayMuonMax);
            this.panel4.Controls.Add(this.lbSoNgayMuonMax);
            this.panel4.Controls.Add(this.txbTuoiToiDa);
            this.panel4.Controls.Add(this.lbTuoiToiDa);
            this.panel4.Controls.Add(this.txbThoiGianLuuHanh);
            this.panel4.Controls.Add(this.lbTuoiToiThieu);
            this.panel4.Controls.Add(this.txbThoiHanThe);
            this.panel4.Location = new System.Drawing.Point(29, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(462, 466);
            this.panel4.TabIndex = 5;
            // 
            // txbMucThuTienPhat
            // 
            this.txbMucThuTienPhat.BackColor = System.Drawing.SystemColors.Control;
            this.txbMucThuTienPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMucThuTienPhat.Location = new System.Drawing.Point(145, 425);
            this.txbMucThuTienPhat.Name = "txbMucThuTienPhat";
            this.txbMucThuTienPhat.Size = new System.Drawing.Size(185, 38);
            this.txbMucThuTienPhat.TabIndex = 7;
            this.txbMucThuTienPhat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // lbMucThuTienPhat
            // 
            this.lbMucThuTienPhat.AutoSize = true;
            this.lbMucThuTienPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMucThuTienPhat.ForeColor = System.Drawing.Color.Navy;
            this.lbMucThuTienPhat.Location = new System.Drawing.Point(125, 393);
            this.lbMucThuTienPhat.Name = "lbMucThuTienPhat";
            this.lbMucThuTienPhat.Size = new System.Drawing.Size(295, 29);
            this.lbMucThuTienPhat.TabIndex = 0;
            this.lbMucThuTienPhat.Text = "Mức Thu Tiền Phạt (Đồng)";
            // 
            // txbSoSachMuonMax
            // 
            this.txbSoSachMuonMax.BackColor = System.Drawing.SystemColors.Control;
            this.txbSoSachMuonMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSoSachMuonMax.Location = new System.Drawing.Point(250, 304);
            this.txbSoSachMuonMax.Name = "txbSoSachMuonMax";
            this.txbSoSachMuonMax.Size = new System.Drawing.Size(185, 38);
            this.txbSoSachMuonMax.TabIndex = 6;
            this.txbSoSachMuonMax.TextChanged += new System.EventHandler(this.txbSoSachMuonMax_TextChanged);
            this.txbSoSachMuonMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // lbSoSachMuonToiDa
            // 
            this.lbSoSachMuonToiDa.AutoSize = true;
            this.lbSoSachMuonToiDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoSachMuonToiDa.ForeColor = System.Drawing.Color.Navy;
            this.lbSoSachMuonToiDa.Location = new System.Drawing.Point(245, 265);
            this.lbSoSachMuonToiDa.Name = "lbSoSachMuonToiDa";
            this.lbSoSachMuonToiDa.Size = new System.Drawing.Size(247, 29);
            this.lbSoSachMuonToiDa.TabIndex = 0;
            this.lbSoSachMuonToiDa.Text = "Số Sách Mượn Tối Đa";
            // 
            // txbTuoiToiThieu
            // 
            this.txbTuoiToiThieu.BackColor = System.Drawing.SystemColors.Control;
            this.txbTuoiToiThieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTuoiToiThieu.Location = new System.Drawing.Point(250, 168);
            this.txbTuoiToiThieu.Name = "txbTuoiToiThieu";
            this.txbTuoiToiThieu.Size = new System.Drawing.Size(185, 38);
            this.txbTuoiToiThieu.TabIndex = 4;
            this.txbTuoiToiThieu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // lbThoiGianLuuHanh
            // 
            this.lbThoiGianLuuHanh.AutoSize = true;
            this.lbThoiGianLuuHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoiGianLuuHanh.ForeColor = System.Drawing.Color.Navy;
            this.lbThoiGianLuuHanh.Location = new System.Drawing.Point(219, 12);
            this.lbThoiGianLuuHanh.Name = "lbThoiGianLuuHanh";
            this.lbThoiGianLuuHanh.Size = new System.Drawing.Size(298, 29);
            this.lbThoiGianLuuHanh.TabIndex = 0;
            this.lbThoiGianLuuHanh.Text = "Thời Gian Lưu Hành (Năm)";
            // 
            // txbSoNgayMuonMax
            // 
            this.txbSoNgayMuonMax.BackColor = System.Drawing.SystemColors.Control;
            this.txbSoNgayMuonMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSoNgayMuonMax.Location = new System.Drawing.Point(11, 304);
            this.txbSoNgayMuonMax.Name = "txbSoNgayMuonMax";
            this.txbSoNgayMuonMax.Size = new System.Drawing.Size(185, 38);
            this.txbSoNgayMuonMax.TabIndex = 5;
            this.txbSoNgayMuonMax.TextChanged += new System.EventHandler(this.txbSoNgayMuonMax_TextChanged);
            this.txbSoNgayMuonMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // lbSoNgayMuonMax
            // 
            this.lbSoNgayMuonMax.AutoSize = true;
            this.lbSoNgayMuonMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoNgayMuonMax.ForeColor = System.Drawing.Color.Navy;
            this.lbSoNgayMuonMax.Location = new System.Drawing.Point(3, 265);
            this.lbSoNgayMuonMax.Name = "lbSoNgayMuonMax";
            this.lbSoNgayMuonMax.Size = new System.Drawing.Size(249, 29);
            this.lbSoNgayMuonMax.TabIndex = 0;
            this.lbSoNgayMuonMax.Text = "Số Ngày Mượn Tối Đa";
            // 
            // txbTuoiToiDa
            // 
            this.txbTuoiToiDa.BackColor = System.Drawing.SystemColors.Control;
            this.txbTuoiToiDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTuoiToiDa.Location = new System.Drawing.Point(11, 168);
            this.txbTuoiToiDa.Name = "txbTuoiToiDa";
            this.txbTuoiToiDa.Size = new System.Drawing.Size(185, 38);
            this.txbTuoiToiDa.TabIndex = 3;
            this.txbTuoiToiDa.TextChanged += new System.EventHandler(this.txbTuoiToiDa_TextChanged);
            this.txbTuoiToiDa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // lbTuoiToiDa
            // 
            this.lbTuoiToiDa.AutoSize = true;
            this.lbTuoiToiDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTuoiToiDa.ForeColor = System.Drawing.Color.Navy;
            this.lbTuoiToiDa.Location = new System.Drawing.Point(41, 130);
            this.lbTuoiToiDa.Name = "lbTuoiToiDa";
            this.lbTuoiToiDa.Size = new System.Drawing.Size(161, 32);
            this.lbTuoiToiDa.TabIndex = 0;
            this.lbTuoiToiDa.Text = "Tuổi Tối Đa";
            // 
            // txbThoiGianLuuHanh
            // 
            this.txbThoiGianLuuHanh.BackColor = System.Drawing.SystemColors.Control;
            this.txbThoiGianLuuHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbThoiGianLuuHanh.Location = new System.Drawing.Point(250, 50);
            this.txbThoiGianLuuHanh.Name = "txbThoiGianLuuHanh";
            this.txbThoiGianLuuHanh.Size = new System.Drawing.Size(185, 38);
            this.txbThoiGianLuuHanh.TabIndex = 2;
            this.txbThoiGianLuuHanh.TextChanged += new System.EventHandler(this.txbThoiGianLuuHanh_TextChanged);
            this.txbThoiGianLuuHanh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // lbTuoiToiThieu
            // 
            this.lbTuoiToiThieu.AutoSize = true;
            this.lbTuoiToiThieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTuoiToiThieu.ForeColor = System.Drawing.Color.Navy;
            this.lbTuoiToiThieu.Location = new System.Drawing.Point(270, 130);
            this.lbTuoiToiThieu.Name = "lbTuoiToiThieu";
            this.lbTuoiToiThieu.Size = new System.Drawing.Size(197, 32);
            this.lbTuoiToiThieu.TabIndex = 0;
            this.lbTuoiToiThieu.Text = "Tuổi Tối Thiểu";
            // 
            // gbQuyDinhHienHanh
            // 
            this.gbQuyDinhHienHanh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbQuyDinhHienHanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gbQuyDinhHienHanh.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gbQuyDinhHienHanh.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbQuyDinhHienHanh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gbQuyDinhHienHanh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.gbQuyDinhHienHanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gbQuyDinhHienHanh.EnableHeadersVisualStyles = false;
            this.gbQuyDinhHienHanh.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbQuyDinhHienHanh.Location = new System.Drawing.Point(12, 122);
            this.gbQuyDinhHienHanh.Name = "gbQuyDinhHienHanh";
            this.gbQuyDinhHienHanh.RowHeadersVisible = false;
            this.gbQuyDinhHienHanh.RowHeadersWidth = 51;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.gbQuyDinhHienHanh.RowsDefaultCellStyle = dataGridViewCellStyle22;
            this.gbQuyDinhHienHanh.RowTemplate.Height = 24;
            this.gbQuyDinhHienHanh.Size = new System.Drawing.Size(708, 589);
            this.gbQuyDinhHienHanh.TabIndex = 4;
            // 
            // lbTieuDe1
            // 
            this.lbTieuDe1.AutoSize = true;
            this.lbTieuDe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe1.ForeColor = System.Drawing.Color.Chocolate;
            this.lbTieuDe1.Location = new System.Drawing.Point(220, 78);
            this.lbTieuDe1.Name = "lbTieuDe1";
            this.lbTieuDe1.Size = new System.Drawing.Size(300, 32);
            this.lbTieuDe1.TabIndex = 0;
            this.lbTieuDe1.Text = "Quy Định Hiện Hành ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Chocolate;
            this.label24.Location = new System.Drawing.Point(761, 107);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(270, 32);
            this.label24.TabIndex = 0;
            this.label24.Text = "Thay Đổi Quy Định";
            // 
            // lbTien
            // 
            this.lbTien.AutoSize = true;
            this.lbTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTien.ForeColor = System.Drawing.Color.Crimson;
            this.lbTien.Location = new System.Drawing.Point(404, 577);
            this.lbTien.Name = "lbTien";
            this.lbTien.Size = new System.Drawing.Size(135, 29);
            this.lbTien.TabIndex = 19;
            this.lbTien.Text = "1000 đồng";
            // 
            // lbSachMax
            // 
            this.lbSachMax.AutoSize = true;
            this.lbSachMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSachMax.ForeColor = System.Drawing.Color.Crimson;
            this.lbSachMax.Location = new System.Drawing.Point(501, 502);
            this.lbSachMax.Name = "lbSachMax";
            this.lbSachMax.Size = new System.Drawing.Size(90, 29);
            this.lbSachMax.TabIndex = 20;
            this.lbSachMax.Text = "4 cuốn";
            // 
            // lbNgayMax
            // 
            this.lbNgayMax.AutoSize = true;
            this.lbNgayMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayMax.ForeColor = System.Drawing.Color.Crimson;
            this.lbNgayMax.Location = new System.Drawing.Point(478, 436);
            this.lbNgayMax.Name = "lbNgayMax";
            this.lbNgayMax.Size = new System.Drawing.Size(89, 29);
            this.lbNgayMax.TabIndex = 21;
            this.lbNgayMax.Text = "5 ngày";
            // 
            // lbTuoiMin
            // 
            this.lbTuoiMin.AutoSize = true;
            this.lbTuoiMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTuoiMin.ForeColor = System.Drawing.Color.Crimson;
            this.lbTuoiMin.Location = new System.Drawing.Point(542, 372);
            this.lbTuoiMin.Name = "lbTuoiMin";
            this.lbTuoiMin.Size = new System.Drawing.Size(91, 29);
            this.lbTuoiMin.TabIndex = 22;
            this.lbTuoiMin.Text = "18 tuổi";
            // 
            // lbTuoiMax
            // 
            this.lbTuoiMax.AutoSize = true;
            this.lbTuoiMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTuoiMax.ForeColor = System.Drawing.Color.Crimson;
            this.lbTuoiMax.Location = new System.Drawing.Point(527, 311);
            this.lbTuoiMax.Name = "lbTuoiMax";
            this.lbTuoiMax.Size = new System.Drawing.Size(91, 29);
            this.lbTuoiMax.TabIndex = 23;
            this.lbTuoiMax.Text = "55 tuổi";
            // 
            // lbLuuHanh
            // 
            this.lbLuuHanh.AutoSize = true;
            this.lbLuuHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLuuHanh.ForeColor = System.Drawing.Color.Crimson;
            this.lbLuuHanh.Location = new System.Drawing.Point(578, 242);
            this.lbLuuHanh.Name = "lbLuuHanh";
            this.lbLuuHanh.Size = new System.Drawing.Size(83, 29);
            this.lbLuuHanh.TabIndex = 24;
            this.lbLuuHanh.Text = "5 năm";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Navy;
            this.label16.Location = new System.Drawing.Point(49, 577);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(440, 29);
            this.label16.TabIndex = 25;
            this.label16.Text = "7.Mức tiền phạt cho mỗi cuốn sách là";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Navy;
            this.label15.Location = new System.Drawing.Point(48, 502);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(557, 29);
            this.label15.TabIndex = 26;
            this.label15.Text = "6.Số Sách được mượn tối đa của một độc giả là";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(48, 436);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(521, 29);
            this.label14.TabIndex = 27;
            this.label14.Text = "5.Số ngày mượn tối đa của một cuốn sách là";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(43, 372);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(618, 29);
            this.label13.TabIndex = 28;
            this.label13.Text = "4.Tuổi tối thiểu của độc giả được phép mượn sách là";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(43, 311);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(590, 29);
            this.label12.TabIndex = 29;
            this.label12.Text = "3.Tuổi tối đa của độc giả được phép mượn sách là";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(43, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(666, 29);
            this.label11.TabIndex = 30;
            this.label11.Text = "2.Chỉ nhận sách có thời gian lưu hành bé hơn hoặc bằng ";
            // 
            // lbthoihan
            // 
            this.lbthoihan.AutoSize = true;
            this.lbthoihan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbthoihan.ForeColor = System.Drawing.Color.Crimson;
            this.lbthoihan.Location = new System.Drawing.Point(379, 183);
            this.lbthoihan.Name = "lbthoihan";
            this.lbthoihan.Size = new System.Drawing.Size(98, 29);
            this.lbthoihan.TabIndex = 31;
            this.lbthoihan.Text = "7 tháng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(43, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(421, 29);
            this.label10.TabIndex = 32;
            this.label10.Text = "1.Thời hạn giá trị của thẻ độc giả là";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCapNhat.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.btnCapNhat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCapNhat.BorderRadius = 20;
            this.btnCapNhat.BorderSize = 0;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(184, 531);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(155, 42);
            this.btnCapNhat.TabIndex = 8;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.TextColor = System.Drawing.Color.White;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.nButton1_Click);
            // 
            // FormThayDoiQuyDinh
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1260, 724);
            this.Controls.Add(this.lbTien);
            this.Controls.Add(this.lbSachMax);
            this.Controls.Add(this.lbNgayMax);
            this.Controls.Add(this.lbTuoiMin);
            this.Controls.Add(this.lbTuoiMax);
            this.Controls.Add(this.lbLuuHanh);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbthoihan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.lbTieuDe1);
            this.Controls.Add(this.gbQuyDinhHienHanh);
            this.Controls.Add(this.gbThayDoiQuyDinh);
            this.Controls.Add(this.lbTieuDe);
            this.ForeColor = System.Drawing.Color.Chocolate;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThayDoiQuyDinh";
            this.Text = "0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbThayDoiQuyDinh.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbQuyDinhHienHanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbThoiHanThe;
        private System.Windows.Forms.TextBox txbThoiHanThe;
        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.Panel gbThayDoiQuyDinh;
        private System.Windows.Forms.DataGridView gbQuyDinhHienHanh;
        private System.Windows.Forms.TextBox txbMucThuTienPhat;
        private System.Windows.Forms.Label lbMucThuTienPhat;
        private System.Windows.Forms.TextBox txbSoSachMuonMax;
        private System.Windows.Forms.Label lbSoSachMuonToiDa;
        private System.Windows.Forms.TextBox txbTuoiToiThieu;
        private System.Windows.Forms.Label lbThoiGianLuuHanh;
        private System.Windows.Forms.TextBox txbSoNgayMuonMax;
        private System.Windows.Forms.Label lbSoNgayMuonMax;
        private System.Windows.Forms.TextBox txbTuoiToiDa;
        private System.Windows.Forms.Label lbTuoiToiDa;
        private System.Windows.Forms.TextBox txbThoiGianLuuHanh;
        private System.Windows.Forms.Label lbTuoiToiThieu;
        private System.Windows.Forms.Label lbTieuDe1;
        private nButton btnCapNhat;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lbTien;
        private System.Windows.Forms.Label lbSachMax;
        private System.Windows.Forms.Label lbNgayMax;
        private System.Windows.Forms.Label lbTuoiMin;
        private System.Windows.Forms.Label lbTuoiMax;
        private System.Windows.Forms.Label lbLuuHanh;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbthoihan;
        private System.Windows.Forms.Label label10;
    }
}

