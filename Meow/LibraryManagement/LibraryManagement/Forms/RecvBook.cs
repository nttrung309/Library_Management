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
            SqlConnection conn = new SqlConnection(DatabaseInfo.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(DatabaseInfo.borrowSlipQuery, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    
                }
            }
            conn.Close();
        }
    }
}
