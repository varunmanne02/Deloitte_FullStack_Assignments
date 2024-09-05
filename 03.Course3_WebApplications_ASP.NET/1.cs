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

            SqlConnection conn = new SqlConnection(connStr);
            // conn.ConnectionString = connStr;

            string cmdText = "INSERT INTO PROD VALUES(12908,'DESK',3000,3,'FURNITURE')";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            conn.Open();
            Console.WriteLine("Connected to Database successfully");

            int n = cmd.ExecuteNonQuery();  // For DML:  Insert, update, delete

            Console.WriteLine("No. of rows affected :" + n);
            conn.Close();

            Console.ReadLine();
        }
    }
}
