using System;
using Mysql.Data.MySqlClient;


namespace D06M01Y2023
{
    class Program
    {
        public static void Main(string[] args)
        {
            string connectionString = "server=localhost;user=root;database=school;port=3306;password=1234";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connection Successful");
            connection.Close();
            Console.ReadKey();
            
        }
    }
}