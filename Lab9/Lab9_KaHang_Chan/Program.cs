using System;
using System.Data.SqlClient;

namespace Lab9 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Connect();
            Console.ReadKey();
            Update();
            Console.ReadKey();
            Delete();            
        }

        static void Connect()
        {
            string constr;
            SqlConnection conn;
            constr = @"Data Source=DESKTOP-J8N4H7L;Initial Catalog=MMABooks;Integrated Security=True";
            conn = new SqlConnection(constr);
            conn.Open();
            Console.WriteLine("Connection Open!");
            conn.Close();
        }

        static void Update()
        {
            string constr;
            SqlConnection conn;
            constr = @"Data Source=DESKTOP-J8N4H7L;Initial Catalog=MMABooks;Integrated Security=True";
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd;
            string sql, output = "";
            sql = "UPDATE Customers SET Name = 'Ka' WHERE CustomerID = 1";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteReader();
            Console.WriteLine("Update Successful");
            cmd.Dispose();
            conn.Close();
        }

        static void Delete()
        {
            string constr;
            SqlConnection conn;
            constr = @"Data Source=DESKTOP-J8N4H7L;Initial Catalog=MMABooks;Integrated Security=True";
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd;
            string sql, output = "";
            sql = "DELETE FROM Customers WHERE CustomerID = 1";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteReader();
            Console.WriteLine("Delete Successful");
            cmd.Dispose();
            conn.Close();
        }
    }
}