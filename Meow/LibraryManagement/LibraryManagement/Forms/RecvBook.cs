using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibraryManagement.Forms;
using LibraryManagement.Models;

namespace DemoDesign
{
    public partial class RecvBook : Form
    {
        public List<ReturnSlip> returnSlip;

        public RecvBook()
        {
            InitializeComponent();
        }

        private void RecvBook_Load(object sender, EventArgs e)
        {
            LoadBorrowSlip();
        }

        private void LoadBorrowSlip()
        {
            returnSlip = new List<ReturnSlip>();

            SqlConnection conn = new SqlConnection(DatabaseInfo.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(DatabaseInfo.borrowSlipQuery, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    DateTime dt = reader.GetDateTime(3);
                    string returnDate = dt.ToString("dd/MM/yyyy");
                    ReturnSlip slip = new ReturnSlip(reader.GetString(0), reader.GetString(1), reader.GetString(2), returnDate, reader.GetSqlMoney(4).Value.ToString());
                    slip.lateReturnDays = DateTime.Now.Subtract(dt).Days;
                    slip.fineThisPeriod = CalFineThisPeriod(slip.lateReturnDays);
                }
            }
            cmd.CommandText = DatabaseInfo.borrowedBooksQuery;

            conn.Close();
        }

        private long CalFineThisPeriod(int lateReturnDays)
        {
            Parameters.LoadParam();
            long fine = Parameters.finePerDay * lateReturnDays;
            return fine;
        }
    }
}
