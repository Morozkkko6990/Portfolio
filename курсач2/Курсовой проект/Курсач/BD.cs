using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач
{
    internal class BD
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DNK6MCT\SQLEXPRESS;Initial Catalog=Kursovaya;Integrated Security=True");
        public void openConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void closeConection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return con;
        }
    }
}
