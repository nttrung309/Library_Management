using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class DetailBorrowSlip
    {
        public int stt { get; set; }
        public string specSlipCode { get; set; }
        public string slipCode;
        public string bookCode { get; set; }
        public string status { get; set; }

        public DetailBorrowSlip() { }
        public DetailBorrowSlip(string specSlipCode, string slipCode, string bookCode, string status)
        {
            this.specSlipCode = specSlipCode;
            this.slipCode = slipCode;
            this.bookCode = bookCode;
            this.status = status;
        }
    }
}
