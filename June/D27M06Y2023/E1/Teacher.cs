using System.Diagnostics.SymbolStore;
using System.Security.Cryptography.X509Certificates;
using System;

namespace E1
{
    public class Teacher
    {
        List<Teacher> Teacher = new();
        static public Guid ID = Guid.NewGuid();
        static public String Name{get;set;}   
        static public String Status{get;set;}
        public Teacher(string name, string status)
        {
            this.Name = name;   
            this.Status = status;   
        }
        public void Insert()    
        {
            System.Console.WriteLine("Insert Teacher Name:");
            Name = Console.ReadLine();
            System.Console.WriteLine("Insert Teacher Status:");
            Status = Console.ReadLine(); 
            Teacher teacher = new(Name,Status); 
            Teacher.Add(teacher);

        }
        public void Display()
        {
            foreach(Teacher teacher in teachers)
            {
                System.Console.WriteLine($"ID:{teacher.ID} Name:{teacher.Name} Status:{teacher.Status}");
            }
        }

    }   
}
