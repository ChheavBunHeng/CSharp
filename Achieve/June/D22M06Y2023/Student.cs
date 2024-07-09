using System;
namespace D22M06Y2023
{
    public class Student
    {
        public Guid ID{get;set;}
        public String Name{get;set;}
        public String Email{get;set;}
        public Student(String name,String email)
        {
            this.ID = new Guid();
            this.Name = name;
            this.Email = email;
        }

        public void Display()
        {
            System.Console.WriteLine($"ID{this.ID} Name{this.Name} Email{this.Name}");
            
        }
    }
}