using System.Collections.Generic;
using System;

namespace D13M06Y2023E1
{
    public class User
    {
        public Guid ID{get;set;}
        public String Name{get;set;}
        public String Email{get;set;}
        public String Password{get;set;} 
        public User(string name,string email,string password)
        {
            this.ID = Guid.NewGuid();
            this.Name = name;
            this.Email = email;
            this.Password = password;
        }
        public void Display()
        {
            System.Console.WriteLine($"ID{this.ID} Name{this.Name} Email{this.Email} Password{this.Password}");
        }
        public static void DisplayAll(List<User> users)
        {
            foreach(User user in users)
            {
                user.Display();
            }
        }
        public static void Insert(List<User> users, User user)
        {
            users.Add(user);
        }
        public static void Delete(List<User> users, User user)
        {
            users.Remove(user);
        }
        public static void Update(User user, string name = null, string email = null, string password = null)
        {
            if(name != null) user.Name = name;
            if(email != null) user.Email = email;
            if(password != null)user.Password = password;
        }
    }
}
