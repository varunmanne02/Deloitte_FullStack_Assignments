using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connStr = "Server=USHYDVAMANNE01\\SQLSERVER2022; Database=Sept2024Db; Integrated Security=true";

            string cmdText = "SELECT * FROM PROD";

            SqlDataAdapter adapter = new SqlDataAdapter(cmdText, connStr);
            DataSet ds = new DataSet();

            adapter.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine("{0},{1},{2}", row["PRODID"].ToString(), row["PNAME"].ToString(), row["PRICE"].ToString(), row["QUANTITY"].ToString(), row["CATEGORY"].ToString());
            }

            Console.ReadLine();
        }
    }
}
