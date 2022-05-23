using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class BorrowSlip
    {
        public string slipCode;
        public string code;
        public string name;
        public string email;
        public string borrowDate;
        public string returnDate;
        public string amount;
        public List<Book> chosenBooks;

        public BorrowSlip()
        {
            slipCode = "";
            code = "";
            name = "";
            email = "";
            borrowDate = "";
            returnDate = "";
            amount = "";
            chosenBooks = new List<Book>();
        }
        public BorrowSlip(string slipCode, string code, string name,string email, string borrowDate, string returnDate, string amount, List<Book> selectedBooks)
        {
            this.slipCode = slipCode;
            this.code = code;
            this.name = name;
            this.email = email;
            this.borrowDate = borrowDate;
            this.returnDate = returnDate;
            this.amount = amount;
            chosenBooks = new List<Book>();

            foreach (Book book in selectedBooks)
            {
                Book copy = new Book(book);
                chosenBooks.Add(copy);
            }
        }
    }
}
