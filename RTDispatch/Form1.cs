using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTDispatch
{
    public partial class Form1 : Form
    {
        public Form1()                                       
        {
            InitializeComponent();

            //Connect to databases

            //connection string
            string connection_string = "Server = tcp:wolfden.database.windows.net,1433; Initial Catalog = RTDispatch; Persist Security Info = False; User ID = john; Password ={ your_password}; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30";
            string query_string = "SELECT * FROM dbo.RTcustomers";

            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                using (SqlCommand command = new SqlCommand(query_string, connection))
                {
                    DataTable customerTable = new DataTable("AllCustomers");

                }
            }

            //Connect to customer database

            //connect to operations database

            //connect to 
        }
    }
}
