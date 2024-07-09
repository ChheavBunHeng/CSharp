using System.Reflection.Metadata;
using System;

namespace D7M6Y2023
{
    public class User
    {
        public string Email{get;set;}
        public string Password{get;set;}
        static void Login()
        {
            System.Console.WriteLine("Email:");
            string email = Console.ReadLine();
            System.Console.WriteLine("Password:");
            string password = Console.ReadLine();
        }
    }
}
