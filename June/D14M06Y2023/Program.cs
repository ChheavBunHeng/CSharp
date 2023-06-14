using System;
using MySql.Data.MySqlClient;

namespace D14M06Y2023
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "server=localhost;user=root;password=1234;database=school";
            MySqlConnection connection = new MySqlConnection(connectionString);
            
            try
            {
                connection.Open();
                
                string query = "SELECT * FROM user";
                MySqlCommand command = new MySqlCommand(query, connection); 
                MySqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader[i] + "\n");
                    }
                    Console.WriteLine();
                }
                
                reader.Close();
            }   
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
