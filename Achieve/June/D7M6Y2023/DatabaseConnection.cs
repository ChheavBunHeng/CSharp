using System.Data;
using System.Runtime.InteropServices.ComTypes;
using System;
using MySql.Data.MySqlClient;
namespace D7M6Y2023
{
    public class DatabaseConnection
    {
        string connectionstring = "server = localhost; database = school; user = root; password = 1234";
        MySqlConnection connection = new MySqlConnection(connectionstring);
        public void OpenConnection()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
                System.Console.WriteLine("Successfully");
            }
        }

    }
}
