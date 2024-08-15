using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    public class User
    {
        public int ID;
        public string Name;
    }
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello world");
            User user = new();
            user.ID = int.Parse(Console.ReadLine());
            user.Name = Console.ReadLine();
            Console.WriteLine(user.ID);
            
            Console.WriteLine(user.Name);

        }
    }
}