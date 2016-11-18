using System;
using System.Data.SqlClient;

namespace DatabaseTest
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection
                (@"Data Source = ealdb1.eal.local;
                 Database = EJL87_DB;
                 User ID = ejl87_usr;
                 Password = Baz1nga87"
                );
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID, FirstName, LastName   FROM [EJL87_DB].[db_owner].[Getting Real]", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("{0}. {1} {2} ", reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
            }
            reader.Close();
            conn.Close();
            Console.ReadKey();


        }
    }
}
