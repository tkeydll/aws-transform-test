using System;
using Oracle.ManagedDataAccess.Client;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Framework version: " + Environment.Version);

            using (var conn = new OracleConnection("User Id=hr;Password=hr;Data Source=localhost:1521/orclpdb1.localdomain"))
            {
                Console.WriteLine(conn.ToString());
                Console.WriteLine(conn.ConnectionString);
            }

            Console.WriteLine("Press any key.");
            Console.ReadLine();
        }
    }
}
