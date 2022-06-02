using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class Reader
    {
        public string code { get; set; }
        public string name { get; set; }
        public DateTime dateExpried { get; set; }
        public string email;

        public Reader(string code, string name, DateTime dateExpried, string email)
        {
            this.code = code;
            this.name = name;
            this.dateExpried = dateExpried;
            this.email = email;
        }
    }
}
