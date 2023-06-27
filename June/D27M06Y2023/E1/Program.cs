using System.Collections.Generic;
using System;

namespace E1
{
    static class Program{
        public static void Main(string[] args)
        {
            List<Teacher> Teacher = new List<Teacher>();    
            List<Student> Student = new List<Student>();
            Console.WriteLine("1.Insert\n2.Update\3.Delete\4.Display");
            int option = int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                Teacher.Add();
                break;
                case 2:
                Teacher.Display();
                break;
                default:
                System.Console.WriteLine("Erorr");
                break;
            }     
        }
    }
}