
namespace FormNhapSach
{
    partial class FORMPHIEUNHAP
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vbButton1 = new FormNhapSach.VBButton();
            this.btnxoa = new FormNhapSach.nButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnluu = new FormNhapSach.nButton();
            this.Btncapnhat = new FormNhapSach.nButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Lbngaynhap = new System.Windows.Forms.Label();
            this.BtnThemmoi = new FormNhapSach.nButton();
            this.LbIDphieunhap = new System.Windows.Forms.Label();
            this.Lbthongtinphieunhapsach = new System.Windows.Forms.Label();
            this.Lbdulieuphieunhapsach = new System.Windows.Forms.Label();
            this.LbPhieuNhapSach = new System.Windows.Forms.Label();
            this.DgvIDPhieunhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvNgaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvTongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.vbButton1.SuspendLayout();
            this.SuspendLayout();
            // 
            // d
            // 
            this.d.HeaderText = "Mã Sách";
            this.d.MinimumWidth = 6;
            this.d.Name = "d";
            this.d.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Thể Loại";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("UTM Avo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgvIDPhieunhap,
            this.DgvNgaynhap,
            this.DgvTongtien});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Navy;
            this.dataGridView1.Location = new System.Drawing.Point(642, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(590, 497);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // vbButton1
            // 
            this.vbButton1.BackColor = System.Drawing.Color.Transparent;
            this.vbButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.vbButton1.BorderColor = System.Drawing.Color.Navy;
            this.vbButton1.BorderRadius = 0;
            this.vbButton1.BorderSize = 1;
            this.vbButton1.Controls.Add(this.btnxoa);
            this.vbButton1.Controls.Add(this.textBox2);
            this.vbButton1.Controls.Add(this.btnluu);
            this.vbButton1.Controls.Add(this.Btncapnhat);
            this.vbButton1.Controls.Add(this.dateTimePicker1);
            this.vbButton1.Controls.Add(this.Lbngaynhap);
            this.vbButton1.Controls.Add(this.BtnThemmoi);
            this.vbButton1.Controls.Add(this.LbIDphieunhap);
            this.vbButton1.Font = new System.Drawing.Font("UTM Avo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vbButton1.ForeColor = System.Drawing.Color.Navy;
            this.vbButton1.Location = new System.Drawing.Point(30, 181);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(554, 497);
            this.vbButton1.TabIndex = 35;
            this.vbButton1.TextColor = System.Drawing.Color.Navy;
            this.vbButton1.Paint += new System.Windows.Forms.PaintEventHandler(this.vbButton1_Paint);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.LightCoral;
            this.btnxoa.BackgroundColor = System.Drawing.Color.LightCoral;
            this.btnxoa.BorderColor = System.Drawing.Color.Navy;
            this.btnxoa.BorderRadius = 20;
            this.btnxoa.BorderSize = 0;
            this.btnxoa.FlatAppearance.BorderSize = 0;
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnxoa.ForeColor = System.Drawing.Color.White;
            this.btnxoa.Location = new System.Drawing.Point(297, 391);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(141, 49);
            this.btnxoa.TabIndex = 55;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextColor = System.Drawing.Color.White;
            this.btnxoa.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.Location = new System.Drawing.Point(207, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(281, 32);
            this.textBox2.TabIndex = 45;
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.Color.Violet;
            this.btnluu.BackgroundColor = System.Drawing.Color.Violet;
            this.btnluu.BorderColor = System.Drawing.Color.Navy;
            this.btnluu.BorderRadius = 20;
            this.btnluu.BorderSize = 0;
            this.btnluu.FlatAppearance.BorderSize = 0;
            this.btnluu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnluu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnluu.ForeColor = System.Drawing.Color.White;
            this.btnluu.Location = new System.Drawing.Point(83, 391);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(141, 49);
            this.btnluu.TabIndex = 53;
            this.btnluu.Text = "Lưu";
            this.btnluu.TextColor = System.Drawing.Color.White;
            this.btnluu.UseVisualStyleBackColor = false;
            // 
            // Btncapnhat
            // 
            this.Btncapnhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.Btncapnhat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.Btncapnhat.BorderColor = System.Drawing.Color.Navy;
            this.Btncapnhat.BorderRadius = 20;
            this.Btncapnhat.BorderSize = 0;
            this.Btncapnhat.FlatAppearance.BorderSize = 0;
            this.Btncapnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btncapnhat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btncapnhat.ForeColor = System.Drawing.Color.White;
            this.Btncapnhat.Location = new System.Drawing.Point(297, 291);
            this.Btncapnhat.Name = "Btncapnhat";
            this.Btncapnhat.Size = new System.Drawing.Size(141, 49);
            this.Btncapnhat.TabIndex = 54;
            this.Btncapnhat.Text = "Cập Nhật";
            this.Btncapnhat.TextColor = System.Drawing.Color.White;
            this.Btncapnhat.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dateTimePicker1.Location = new System.Drawing.Point(207, 175);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(281, 32);
            this.dateTimePicker1.TabIndex = 44;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Lbngaynhap
            // 
            this.Lbngaynhap.AutoSize = true;
            this.Lbngaynhap.BackColor = System.Drawing.Color.Transparent;
            this.Lbngaynhap.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbngaynhap.Location = new System.Drawing.Point(38, 175);
            this.Lbngaynhap.Name = "Lbngaynhap";
            this.Lbngaynhap.Size = new System.Drawing.Size(135, 29);
            this.Lbngaynhap.TabIndex = 35;
            this.Lbngaynhap.Text = "Ngày Nhập:";
            // 
            // BtnThemmoi
            // 
            this.BtnThemmoi.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnThemmoi.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.BtnThemmoi.BorderColor = System.Drawing.Color.Navy;
            this.BtnThemmoi.BorderRadius = 20;
            this.BtnThemmoi.BorderSize = 0;
            this.BtnThemmoi.FlatAppearance.BorderSize = 0;
            this.BtnThemmoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnThemmoi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnThemmoi.ForeColor = System.Drawing.Color.White;
            this.BtnThemmoi.Location = new System.Drawing.Point(83, 291);
            this.BtnThemmoi.Name = "BtnThemmoi";
            this.BtnThemmoi.Size = new System.Drawing.Size(141, 49);
            this.BtnThemmoi.TabIndex = 51;
            this.BtnThemmoi.Text = "Thêm Mới";
            this.BtnThemmoi.TextColor = System.Drawing.Color.White;
            this.BtnThemmoi.UseVisualStyleBackColor = false;
            this.BtnThemmoi.Click += new System.EventHandler(this.nButton2_Click);
            // 
            // LbIDphieunhap
            // 
            this.LbIDphieunhap.AutoSize = true;
            this.LbIDphieunhap.BackColor = System.Drawing.Color.Transparent;
            this.LbIDphieunhap.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbIDphieunhap.ForeColor = System.Drawing.Color.Navy;
            this.LbIDphieunhap.Location = new System.Drawing.Point(34, 83);
            this.LbIDphieunhap.Name = "LbIDphieunhap";
            this.LbIDphieunhap.Size = new System.Drawing.Size(166, 29);
            this.LbIDphieunhap.TabIndex = 27;
            this.LbIDphieunhap.Text = "ID Phiếu Nhập:";
            // 
            // Lbthongtinphieunhapsach
            // 
            this.Lbthongtinphieunhapsach.AutoSize = true;
            this.Lbthongtinphieunhapsach.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbthongtinphieunhapsach.ForeColor = System.Drawing.Color.Chocolate;
            this.Lbthongtinphieunhapsach.Location = new System.Drawing.Point(125, 127);
            this.Lbthongtinphieunhapsach.Name = "Lbthongtinphieunhapsach";
            this.Lbthongtinphieunhapsach.Size = new System.Drawing.Size(366, 38);
            this.Lbthongtinphieunhapsach.TabIndex = 45;
            this.Lbthongtinphieunhapsach.Text = "Thông Tin Phiếu Nhập Sách";
            this.Lbthongtinphieunhapsach.Click += new System.EventHandler(this.label4_Click);
            // 
            // Lbdulieuphieunhapsach
            // 
            this.Lbdulieuphieunhapsach.AutoSize = true;
            this.Lbdulieuphieunhapsach.BackColor = System.Drawing.Color.Transparent;
            this.Lbdulieuphieunhapsach.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbdulieuphieunhapsach.ForeColor = System.Drawing.Color.Chocolate;
            this.Lbdulieuphieunhapsach.Location = new System.Drawing.Point(766, 127);
            this.Lbdulieuphieunhapsach.Name = "Lbdulieuphieunhapsach";
            this.Lbdulieuphieunhapsach.Size = new System.Drawing.Size(336, 38);
            this.Lbdulieuphieunhapsach.TabIndex = 46;
            this.Lbdulieuphieunhapsach.Text = "Dữ Liệu Phiếu Nhập Sách";
            // 
            // LbPhieuNhapSach
            // 
            this.LbPhieuNhapSach.AutoSize = true;
            this.LbPhieuNhapSach.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbPhieuNhapSach.ForeColor = System.Drawing.Color.Navy;
            this.LbPhieuNhapSach.Location = new System.Drawing.Point(478, 29);
            this.LbPhieuNhapSach.Name = "LbPhieuNhapSach";
            this.LbPhieuNhapSach.Size = new System.Drawing.Size(287, 46);
            this.LbPhieuNhapSach.TabIndex = 47;
            this.LbPhieuNhapSach.Text = "Phiếu Nhập Sách";
            // 
            // DgvIDPhieunhap
            // 
            this.DgvIDPhieunhap.HeaderText = "ID Phiếu Nhập";
            this.DgvIDPhieunhap.MinimumWidth = 6;
            this.DgvIDPhieunhap.Name = "DgvIDPhieunhap";
            // 
            // DgvNgaynhap
            // 
            this.DgvNgaynhap.HeaderText = "Ngày Nhập";
            this.DgvNgaynhap.MinimumWidth = 6;
            this.DgvNgaynhap.Name = "DgvNgaynhap";
            // 
            // DgvTongtien
            // 
            this.DgvTongtien.HeaderText = "Tổng Tiền";
            this.DgvTongtien.MinimumWidth = 6;
            this.DgvTongtien.Name = "DgvTongtien";
            // 
            // FORMPHIEUNHAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1260, 724);
            this.Controls.Add(this.LbPhieuNhapSach);
            this.Controls.Add(this.Lbdulieuphieunhapsach);
            this.Controls.Add(this.Lbthongtinphieunhapsach);
            this.Controls.Add(this.vbButton1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FORMPHIEUNHAP";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.vbButton1.ResumeLayout(false);
            this.vbButton1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn d;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private VBButton vbButton1;
        private System.Windows.Forms.Label Lbthongtinphieunhapsach;
        private System.Windows.Forms.Label LbIDphieunhap;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Lbngaynhap;
        private System.Windows.Forms.Label Lbdulieuphieunhapsach;
        private nButton BtnThemmoi;
        private System.Windows.Forms.TextBox textBox2;
        private nButton btnluu;
        private nButton Btncapnhat;
        private nButton btnxoa;
        private System.Windows.Forms.Label LbPhieuNhapSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvIDPhieunhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvNgaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvTongtien;
    }
}

