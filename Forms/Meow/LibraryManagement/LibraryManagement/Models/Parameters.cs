using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LibraryManagement.Models
{
    public class Parameters
    {
        public static int maxLendDay;
        public static int maxBorrowBook;
        public static long finePerDay;
        public Parameters()
        {
            
        }
        public static void LoadParam()
        {
            SqlConnection conn = new SqlConnection(DatabaseInfo.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(DatabaseInfo.parametersQueryCmd, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                maxLendDay = (int)reader.GetInt32(4);
                maxBorrowBook = (int)reader.GetInt32(5);
                finePerDay = (long)reader.GetSqlMoney(6);
            }
        }
    }
}
