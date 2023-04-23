using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO3
{
    internal class BD
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DNK6MCT\SQLEXPRESS;Initial Catalog=Captcha;Integrated Security=True");
        public void openConnection()
        {
            con.Open();
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
