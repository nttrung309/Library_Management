﻿using System;
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
    public partial class RecvBook : Form
    {
        public RecvBook()
        {
            InitializeComponent();
        }

        private void RecvBook_Load(object sender, EventArgs e)
        {
            LoadReaders();
        }

        private void LoadReaders()
        {
            throw new NotImplementedException();
        }
    }
}
