using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.IO;


namespace Gara_Data
{
    public class Connections
    {
        public static SqlConnection connection= null;
        public static String strConStr = @"Data Source=DESKTOP-52G2SMH\RAZORDSQL;Initial Catalog=QUANLYGARAOTO;User ID=admin;Password=admin";
        public Connections() 
        {
            if (connection == null) 
            { 

                connection = new SqlConnection(strConStr);
 
            }
            if (connection.State != ConnectionState.Open) { connection.Open(); }
        }
        public SqlConnection GetConnection()
        {
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    return connection;
                }
                else
                    return connection;
            }
        }
    }
}
