using System.Security;
using System;

namespace D13M06Y2023
{
    public class User
    {
        public string Id{get;set;}
        public string Name{get;set;}
        public string Email{get;set;}
        public string Password{get;set;}
        public User(string id,string name,string email,string password)
        {
            this.Id=id;
            this.Name=name;
            this.Email=email;
            this.Password=password;
        }
        public void Display()
        {
            System.Console.WriteLine($"ID: {Id}, Name: {Name}, Email: {Email}, Password: {Password}");

        }
        
    }
}
