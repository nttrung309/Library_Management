
namespace PhieuThuTien
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nButton4 = new PhieuThuTien.nButton();
            this.nButton1 = new PhieuThuTien.nButton();
            this.nButton2 = new PhieuThuTien.nButton();
            this.nButton3 = new PhieuThuTien.nButton();
            this.vbButton1 = new PhieuThuTien.VBButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Navy;
            this.dataGridView1.Location = new System.Drawing.Point(33, 364);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1215, 304);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(70, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 29);
            this.label4.TabIndex = 45;
            this.label4.Text = "Thông Tin Phiếu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(44, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(379, 51);
            this.label8.TabIndex = 33;
            this.label8.Text = "Phiếu Thu Tiền Phạt";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Chocolate;
            this.label10.Location = new System.Drawing.Point(428, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(455, 41);
            this.label10.TabIndex = 46;
            this.label10.Text = "Danh Sách Phiếu Thu Tiền Phạt";
            // 
            // nButton4
            // 
            this.nButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.nButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.nButton4.BorderColor = System.Drawing.Color.Navy;
            this.nButton4.BorderRadius = 20;
            this.nButton4.BorderSize = 0;
            this.nButton4.FlatAppearance.BorderSize = 0;
            this.nButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.nButton4.ForeColor = System.Drawing.Color.White;
            this.nButton4.Location = new System.Drawing.Point(989, 50);
            this.nButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nButton4.Name = "nButton4";
            this.nButton4.Size = new System.Drawing.Size(114, 42);
            this.nButton4.TabIndex = 52;
            this.nButton4.Text = "Cập Nhật";
            this.nButton4.TextColor = System.Drawing.Color.White;
            this.nButton4.UseVisualStyleBackColor = false;
            this.nButton4.Click += new System.EventHandler(this.nButton4_Click);
            // 
            // nButton1
            // 
            this.nButton1.BackColor = System.Drawing.Color.Violet;
            this.nButton1.BackgroundColor = System.Drawing.Color.Violet;
            this.nButton1.BorderColor = System.Drawing.Color.Navy;
            this.nButton1.BorderRadius = 20;
            this.nButton1.BorderSize = 0;
            this.nButton1.FlatAppearance.BorderSize = 0;
            this.nButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.nButton1.ForeColor = System.Drawing.Color.White;
            this.nButton1.Location = new System.Drawing.Point(859, 50);
            this.nButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nButton1.Name = "nButton1";
            this.nButton1.Size = new System.Drawing.Size(122, 42);
            this.nButton1.TabIndex = 51;
            this.nButton1.Text = "Lưu";
            this.nButton1.TextColor = System.Drawing.Color.White;
            this.nButton1.UseVisualStyleBackColor = false;
            this.nButton1.Click += new System.EventHandler(this.nButton1_Click);
            // 
            // nButton2
            // 
            this.nButton2.BackColor = System.Drawing.Color.YellowGreen;
            this.nButton2.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.nButton2.BorderColor = System.Drawing.Color.Navy;
            this.nButton2.BorderRadius = 20;
            this.nButton2.BorderSize = 0;
            this.nButton2.FlatAppearance.BorderSize = 0;
            this.nButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.nButton2.ForeColor = System.Drawing.Color.White;
            this.nButton2.Location = new System.Drawing.Point(729, 50);
            this.nButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nButton2.Name = "nButton2";
            this.nButton2.Size = new System.Drawing.Size(122, 42);
            this.nButton2.TabIndex = 51;
            this.nButton2.Text = "Thêm";
            this.nButton2.TextColor = System.Drawing.Color.White;
            this.nButton2.UseVisualStyleBackColor = false;
            this.nButton2.Click += new System.EventHandler(this.nButton2_Click);
            // 
            // nButton3
            // 
            this.nButton3.BackColor = System.Drawing.Color.LightCoral;
            this.nButton3.BackgroundColor = System.Drawing.Color.LightCoral;
            this.nButton3.BorderColor = System.Drawing.Color.Navy;
            this.nButton3.BorderRadius = 20;
            this.nButton3.BorderSize = 0;
            this.nButton3.FlatAppearance.BorderSize = 0;
            this.nButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.nButton3.ForeColor = System.Drawing.Color.White;
            this.nButton3.Location = new System.Drawing.Point(1110, 50);
            this.nButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nButton3.Name = "nButton3";
            this.nButton3.Size = new System.Drawing.Size(117, 42);
            this.nButton3.TabIndex = 50;
            this.nButton3.Text = "in";
            this.nButton3.TextColor = System.Drawing.Color.White;
            this.nButton3.UseVisualStyleBackColor = false;
            this.nButton3.Click += new System.EventHandler(this.nButton3_Click);
            // 
            // vbButton1
            // 
            this.vbButton1.BackColor = System.Drawing.Color.Transparent;
            this.vbButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.vbButton1.BorderColor = System.Drawing.Color.Navy;
            this.vbButton1.BorderRadius = 0;
            this.vbButton1.BorderSize = 1;
            this.vbButton1.Controls.Add(this.textBox4);
            this.vbButton1.Controls.Add(this.label9);
            this.vbButton1.Controls.Add(this.textBox3);
            this.vbButton1.Controls.Add(this.label3);
            this.vbButton1.Controls.Add(this.dateTimePicker1);
            this.vbButton1.Controls.Add(this.comboBox3);
            this.vbButton1.Controls.Add(this.textBox5);
            this.vbButton1.Controls.Add(this.label7);
            this.vbButton1.Controls.Add(this.label6);
            this.vbButton1.Controls.Add(this.label5);
            this.vbButton1.Controls.Add(this.textBox2);
            this.vbButton1.Controls.Add(this.label2);
            this.vbButton1.Controls.Add(this.textBox1);
            this.vbButton1.Controls.Add(this.label1);
            this.vbButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.vbButton1.ForeColor = System.Drawing.Color.Navy;
            this.vbButton1.Location = new System.Drawing.Point(34, 106);
            this.vbButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(1191, 201);
            this.vbButton1.TabIndex = 35;
            this.vbButton1.TextColor = System.Drawing.Color.Navy;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.Location = new System.Drawing.Point(497, 162);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(227, 28);
            this.textBox4.TabIndex = 46;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(397, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 24);
            this.label9.TabIndex = 45;
            this.label9.Text = "Họ Tên:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.Location = new System.Drawing.Point(867, 110);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(221, 28);
            this.textBox3.TabIndex = 46;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(791, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 45;
            this.label3.Text = "Còn Lại:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(867, 53);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(221, 28);
            this.dateTimePicker1.TabIndex = 44;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(497, 50);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(227, 30);
            this.comboBox3.TabIndex = 43;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.Location = new System.Drawing.Point(497, 111);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(227, 28);
            this.textBox5.TabIndex = 36;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(791, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 24);
            this.label7.TabIndex = 35;
            this.label7.Text = "Ngày Thu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(397, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 24);
            this.label6.TabIndex = 34;
            this.label6.Text = "Tổng Nợ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(397, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 33;
            this.label5.Text = "Mã Độc Giả:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.Location = new System.Drawing.Point(147, 110);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(214, 28);
            this.textBox2.TabIndex = 32;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(34, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "Số Tiền Thu:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(147, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 28);
            this.textBox1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(34, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mã Phiếu Thu:";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1260, 724);
            this.Controls.Add(this.nButton4);
            this.Controls.Add(this.nButton1);
            this.Controls.Add(this.nButton2);
            this.Controls.Add(this.nButton3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.vbButton1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private nButton nButton3;
        private nButton nButton2;
        private nButton nButton4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private nButton nButton1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
    }
}
