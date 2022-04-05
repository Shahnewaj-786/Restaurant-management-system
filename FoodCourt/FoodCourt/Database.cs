using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCourt
{
    class Database
    {
        public static SqlConnection ConnectDB()
        {
            string connString = "Server=ULLASH;Database=foodcourt;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}
