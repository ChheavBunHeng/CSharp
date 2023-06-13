using System.Diagnostics.SymbolStore;
using System.Collections.Generic;
using System;

namespace D13M06Y2023E1
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<User> users = new List<User>();    
            
            System.Console.WriteLine("input Name:");
            string name = Console.ReadLine();
            System.Console.WriteLine("Input Email:");
            string email = Console.ReadLine();
            System.Console.WriteLine("Input Password:");
            string password = Console.ReadLine();
            while(true)
            {
                System.Console.WriteLine("1.Input Data\n2.Output Data\n3.Update\n4.Delete\n5.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());   
                switch(choice)
                {
                    case 1: 
                        User.Insert(users,new User(name,email,password));
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
                        User userToUpdate = users.Find(u => u.ID == userId);
                        if (userToUpdate != null)
                        {
                            User.Update(userToUpdate, updatedName, updatedEmail, updatedPassword);
                            System.Console.WriteLine("User updated successfully.");
                        }
                        else
                        {
                            System.Console.WriteLine("User not found.");
                        }
                        break;
                    case 4: 
                        System.Console.WriteLine("Enter the ID of the user to delete:");
                        Guid deleteUserGuid = Guid.Parse(Console.ReadLine());
                        User userToDelete = users.Find(u => u.ID == deleteUserGuid);
                        if (userToDelete != null)
                        {
                            User.Delete(users, userToDelete);
                            System.Console.WriteLine("User deleted successfully.");
                        }
                        else
                        {
                            System.Console.WriteLine("User not found.");
                        }
                        break;
                    default:
                        System.Console.WriteLine("There is an error in the input");
                        break;
                }
            }          
        }
    }
}
