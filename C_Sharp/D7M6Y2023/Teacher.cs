using System;

namespace D7M6Y2023
{
    public class Teacher
    {
        public int ID{get;set;}
        public string Name{get;set;}
        public float Salary{get;set;}
        public Teacher(int id,string name,float salary)
        {
            ID = id;
            Name = name;
            Salary = salary;
        }
        public void ShowInfo()
        {
            System.Console.WriteLine($"ID:{ID} Name:{Name} Salary:{Salary}");
        }

    }

}
