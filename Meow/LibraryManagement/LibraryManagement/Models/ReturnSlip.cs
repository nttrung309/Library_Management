using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Models;

namespace LibraryManagement.Models
{
    public class ReturnSlip
    {
        public string borrowSlipCode;
        public string readerCode;
        public string readerName;
        public string returnDate;
        public int lateReturnDays;
        public long fineThisPeriod;
        public string totalFine;
        public List<Book> borrowedBooks;

        public ReturnSlip() { borrowedBooks = new List<Book>(); }

        public ReturnSlip(string borrowSlipCode, string readerCode, string readerName, string returnDate, string totalFine)
        {
            this.borrowSlipCode = borrowSlipCode;
            this.readerCode = readerCode;
            this.readerName = readerName;
            this.returnDate = returnDate;
            this.totalFine = totalFine;

            borrowedBooks = new List<Book>();
        }
    }
}
