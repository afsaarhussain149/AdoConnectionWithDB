using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdoConnectionWithDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // cs is variable and declaring database connection
            string cs = "Server=localhost;Port=5432;Database=ado_dbms;UserId=postgres;Password=1234";
            NpgsqlConnection conn = new NpgsqlConnection(cs);

            try
            {
                conn.Open();

                if (conn.State == ConnectionState.Open)
                {
                    Console.WriteLine("Connection is Successfull...!");
                }

            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            Console.ReadLine();
        }

        
    }
}
