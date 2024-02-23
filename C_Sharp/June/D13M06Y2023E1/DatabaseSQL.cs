using System.Runtime.InteropServices.ComTypes;
using System.Data.Common;
using System.Data;
using Mysql.Data.MySqlClient;
using System;

namespace D13M06Y2023E1
{
    public class DatabaseSQL
    {
        string connectionString = "Server=localhost;Database=school;user=root;password=1234;";
        MySqlConnection connection = new MySqlConnection(connectionString);
        public void Connect()
        {
            connection.Open();
        }
        
    }
}
