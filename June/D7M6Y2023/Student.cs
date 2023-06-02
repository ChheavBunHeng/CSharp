using System;

namespace D7M6Y2023
{
    public class Student
    {
        public int ID {get;set;}
        public string Name {get;set;}
        public Student(int ID,string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
        public void StudentList()
        {
            System.Console.WriteLine($"Student Name{Name}, ID{ID}");
        }
    }
   
}
