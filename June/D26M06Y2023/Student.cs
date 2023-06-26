using System.Reflection.Metadata;
using System.Collections.Generic;
using System;

namespace D26M06Y2023
{
    public class Student
    {
        public Guid ID = Guid.NewGuid();
        
        public string Name { get; set;}
        public string Email { get; set;}

        public Student(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }
        public void Display()
        {
            System.Console.WriteLine($"ID{this.ID} Name{this.Name} Email{this.Email}");
        }
        public static void DisplayAll(List<Student> students)
        {
            foreach(Student student in students)    
            {
                student.Display();
            }
        }
        public static void Insert(List<Student> students, Student student)
        {
            students.Add(student);
        }
        public static void Delete(List<Student> students, Student student)
        
    }


}
