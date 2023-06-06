using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace EnrollLibrary
{
    public static class IDataRecordExtension
    { 
        public static Student ToStudent(this IDataRecord record)
        {
            int index = record.GetOrdinal("id");
            string id = record.GetString(index);

            index = record.GetOrdinal("firstname");
            string? firstname = null;
            if (!record.IsDBNull(index)) firstname = record.GetString(index);

            index = record.GetOrdinal("lastname");
            string? lastname = null;
            if (!record.IsDBNull(index)) lastname = record.GetString(index);

            index = record.GetOrdinal("gender");
            Genders? gender = null;
            if (!record.IsDBNull(index)) gender = (Genders)record.GetInt32(index);

            index = record.GetOrdinal("age");
            byte? age = null;
            if (!record.IsDBNull(index)) age = record.GetByte(index);
            return new Student()
            {
                Id = id,
                FirstName = firstname,
                LastName = lastname,
                Gender = gender,
                Age = age
            };
        }
    }
}