namespace EnrollLibrary
{
    public class Student
    {
        public string Id { get; set; } = "";
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Genders? Gender { get; set; }
        public byte? Age { get; set; }
    }
}