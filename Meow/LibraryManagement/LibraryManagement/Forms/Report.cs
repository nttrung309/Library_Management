using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDesign
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label4.Text = "Báo Cáo Tháng " + dateTimePicker1.Value.Month.ToString();
        }
    }
}
