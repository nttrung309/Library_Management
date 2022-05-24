using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class ReturnSlip
    {
        public string borrowSlipCode;
        public string readerCode;
        public string readerName;
        public string returnDate;
        public string lateReturnDays;
        public string fineThisPeriod;
        public string totalFine;
    }
}
