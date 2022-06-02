using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class ReturnBook
    {
        public string borrowSlipCode;
        public string specBookCode;
        public string detailSlipCode;
        public int stt { get; set; }
        public string bookCode { get; set; }
        public string bookName { get; set; }
        public string borrowDate { get; set; }
        public string borrowedDays { get; set; }
        public long fine { get; set; }
        public int lateReturnDays;

        public ReturnBook() { }
        public ReturnBook(int stt, string bookCode, string bookName, string borrowDate, string borrowedDays, long fine)
        {
            this.stt = stt;
            this.bookCode = bookCode;
            this.bookName = bookName;
            this.borrowDate = borrowDate;
            this.borrowedDays = borrowedDays;
            this.fine = fine;
        }
        public ReturnBook(ReturnBook returnBook)
        {
            this.bookCode = returnBook.bookCode;
            this.bookName = returnBook.bookName;
            this.borrowDate = returnBook.borrowDate;
            this.borrowedDays = returnBook.borrowedDays;
            this.fine = returnBook.fine;
            this.stt = returnBook.stt;
            this.specBookCode = returnBook.specBookCode;
            this.detailSlipCode = returnBook.detailSlipCode;
        }
    }
}
