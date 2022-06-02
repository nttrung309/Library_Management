using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class ReportLate
    {
        public int stt { get; set; }

        public string bookCode { get; set; }
        public string bookName { get; set; }
        public string borrowDate { get; set; }
        public int lateReturnDays { get; set; }

        public ReportLate() { }

        public ReportLate(string bookCode, string bookName, string borrowDate)
        {
            this.bookCode = bookCode;
            this.bookName = bookName;
            this.borrowDate = borrowDate;
        }
    }
}
