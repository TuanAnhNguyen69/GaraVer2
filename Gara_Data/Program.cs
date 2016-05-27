using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace Gara_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting Connection ...");
            Connections a = new Connections();
            SqlConnection conn = a.GetConnection();
                Console.WriteLine("Openning Connection ...");
                if (conn.State == System.Data.ConnectionState.Open)
                    Console.WriteLine("Connection open!");
    
                conn.Close();
                if (conn.State == System.Data.ConnectionState.Closed)
                    Console.WriteLine("Connection close!");
                conn.Open();
                if (conn.State == System.Data.ConnectionState.Open)
                Console.WriteLine("Connection open!");
    

            Console.Read();
        }
    }
}
