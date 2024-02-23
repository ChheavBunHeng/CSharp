using System;
using MySql.Data.MySqlClient;

namespace D13M06Y2023
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string id, string name, string email, string password)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Email: {Email}");
        }
    }

    public class DatabaseHandler
    {
        private MySqlConnection _connection;

        public DatabaseHandler(string connectionString)
        {
            _connection = new MySqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            _connection.Open();
            if(_connection.State == System.Data.ConnectionState.Open)
            {
                Console.WriteLine("Connection open");
            }   
        }

        public void CloseConnection()
        {
            _connection.Close();
        }

        public void InsertUser(User user)
        {
            string query = "Insert into user(UserID,UserName,UserEmail,UserPassword) values(@id,@name,@email,@password)";
            MySqlCommand cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@id",user.Id); 
            cmd.Parameters.AddWithValue("@name",user.Name);
            cmd.Parameters.AddWithValue("@email",user.Email);
            cmd.Parameters.AddWithValue("@password",user.Password);
            cmd.ExecuteNonQuery();
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            string connectionString = "server = localhost;user = root;database = school;port = 3306;password = 1234";
            DatabaseHandler dbHandler = new DatabaseHandler(connectionString);
            dbHandler.OpenConnection();

            while(true)
            {
                int option;
                Console.WriteLine("1.Input\n2.Display");
                option = int.Parse(Console.ReadLine()); 
                if(option == 1)
                {
                    string id,name,email,password;
                    Console.WriteLine("Enter id");
                    id = Console.ReadLine();
                    Console.WriteLine("Enter name");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter email");
                    email = Console.ReadLine();
                    Console.WriteLine("Enter password");
                    password = Console.ReadLine();
                    User user = new User(id,name,email,password);
                    dbHandler.InsertUser(user);
                }
                else if(option == 2)
                {
                    // Retrieve all users from database and display them
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM user", dbHandler._connection);
                    using(var reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            User user = new User(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                            user.Display();
                        }
                    }
                }
            }

            dbHandler.CloseConnection();
        }
    }
}
