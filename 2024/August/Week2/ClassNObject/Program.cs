using System;
using System.Collections.Generic;

namespace ClassNObject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            // Generate and display random users
            List<User> users = GenerateRandomUsers(5);
            foreach (var user in users)
            {
                Console.WriteLine($"User ID: {user.Id}, Salary: {user.Salary:F2}");
            }
        }

        static void Callfunction()
        {
            // Accessing the static property directly through the class name
            string name = Student.Name;
        }

        static List<User> GenerateRandomUsers(int count)
        {
            Random random = new Random();
            List<User> users = new List<User>();

            for (int i = 0; i < count; i++)
            {
                users.Add(new User
                {
                    Id = i + 1,
                    Salary = (float)(random.NextDouble() * 100000)
                });
            }

            return users;
        }
    }

    public class Student
    {
        public static string Name { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public float Salary { get; set; }
    }
}
