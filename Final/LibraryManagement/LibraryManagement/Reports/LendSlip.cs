using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagement.Models;

namespace LibraryManagement.Reports
{
    public partial class LendSlip : Form
    {
        public LendSlip()
        {
            InitializeComponent();
        }
        public void SetData(BorrowSlip borrowSlip)
        {
            lbSlipCode.Text = borrowSlip.slipCode;
            lbReaderCode.Text = borrowSlip.code;
            lbReaderName.Text = borrowSlip.name;
            lbBorrowDate.Text = FormatDate(borrowSlip.borrowDate);
            lbReturnDate.Text = FormatDate(borrowSlip.returnDate);
            lbAmount.Text = borrowSlip.amount;
        }
        private string FormatDate(string date)
        {
            string day = date.Substring(8, 2);
            string month = date.Substring(5, 2);
            string year = date.Substring(0, 4);
            return $"{day}/{month}/{year}";
        }
    }
}
