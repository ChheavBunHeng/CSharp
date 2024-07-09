namespace Books_DataValidation_Classic.ConsoleApp;

public class Bookvalidator
{
    public static byte Minpage => 10;
    public static byte Maxpage => 2000;
    public static byte AuthorMaxLenght => 20;
    public static byte TitleLength => 30;

    public bool ValidateTitle(string? name, out ValidationResult? result)
    {
        string menber = nameof()
    }
}