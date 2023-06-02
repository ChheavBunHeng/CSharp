using System.Security.Principal;
using System;
using System.Collections.Generic;
using D7M6Y2023;
using MySql.Data.MySqlClient;

class Program
{
    static void Main()
    {
        Student Jim = new Student(123,"Duck");
        Jim.StudentList();
        Teacher John = new Teacher(456,"smith",250);
        John.ShowInfo();
        DatabaseConnection DBconnection = new DatabaseConnection();
        DBconnection.OpenConnection();
        
    }
}

