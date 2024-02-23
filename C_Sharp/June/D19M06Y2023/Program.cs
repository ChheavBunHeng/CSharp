using System.Collections.Generic;
using System;

namespace D19M06Y2023
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<User> users = new();
            System.Console.WriteLine("Input Name:");
            string name = Console.ReadLine();
            System.Console.WriteLine("Input Email:");
            string email = Console.ReadLine();
            System.Console.WriteLine("Input Password:");
            string Passowrd =Console.ReadLine();
            while(true)
            {
                System.Console.WriteLine("1.Input Data\n2.Output Data\n3.Update\n4.Delete\n5.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());   
                switch(choice)
                {
                    case 1:
                        User.Insert(users,new User(name,email,Passowrd));
                        break;
                    case 2:
                        User.DisplayAll(users);
                        break;
                    case 3:
                        System.Console.WriteLine("Enter the ID of the user to update:");
                        Guid userId = Guid.Parse(Console.ReadLine());
                        System.Console.WriteLine("Enter the user's new name (or press Enter to keep current):");
                        string updatedName = Console.ReadLine();
                        System.Console.WriteLine("Enter the user's new email address (or press Enter to keep current):");
                        string updatedEmail = Console.ReadLine();
                        System.Console.WriteLine("Enter the user's new password (or press Enter to keep current):");
                        string updatedPassword = Console.ReadLine();
                        User UserToUpdate = users.Find(u => u.ID == userId);
                        if(UserToUpdate != null)
                        {
                            User.Update(userToUpdate, updatedName, updatedEmail, updatedPassword);
                            System.Console.WriteLine("User updated successfully.");
                        }
                        else
                        {
                            System.Console.WriteLine("User no found.");
                        }
                        break;
                    case 4:
                }
            }
        }
    }
}