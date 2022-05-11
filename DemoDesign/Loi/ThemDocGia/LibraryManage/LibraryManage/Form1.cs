using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show(this.Width.ToString() + this.Height.ToString());
            foreach (DataGridViewColumn col in dgvDSDocGia.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            dgvDSDocGia.EnableHeadersVisualStyles = false;
        }

        private void dateTimePicker1_DropDown(object sender, EventArgs e)
        {
            /* System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("vi-VN");
             System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
             System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;*/
            
        }

        private void lbHoTen_Click(object sender, EventArgs e)
        {

        }

        private void gbDocGia_Enter(object sender, EventArgs e)
        {

        }

        private void lbNgLapThe_Click(object sender, EventArgs e)
        {

        }
    }
}
