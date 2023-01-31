namespace DataValidation_Person_ConsoleApp;

public class Person
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; } = "";
    public string Gender { get; set; } = "";
    public byte Age { get; set; } = 0;
    public string Email { get; set; } = "";
}