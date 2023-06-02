using System;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
namespace D6M1Y2023
{
    class Program
    {
        public static void Main(string[] args)
        {
            string connectionString = "server=localhost;user=root;database=accountnika;port=3306;password=1234";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connection Successful");
            connection.Close();
            Console.ReadKey();

            var person = new { Name = "John", Age = 21 };
            string json = JsonConvert.SerializeObject(person);
            Console.WriteLine(json);           
        }
    }
}