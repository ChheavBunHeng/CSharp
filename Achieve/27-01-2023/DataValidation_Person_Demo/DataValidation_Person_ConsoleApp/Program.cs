using System.Reflection;
using System.Xml.Linq;

namespace DataValidation_Person_ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Data Validation!");
        ValidationException.MessageSeparator = ", ";
        //PersonRequest request = new() { Name = "Heng LongDaraSovannTepy", Age = 23, Gender = "female", Email = "abc@gmail.com" };
        //try
        //{
        //    Person person = request.ToPerson();
        //    Console.WriteLine("Accepted");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine($"Rejected > {ex.Message}");
        //}

        PersonRequest[] requests = new PersonRequest[]
           {
                new(),
                new(){Name="", Age=223, Gender="F", Email="abc.gmail.com"},
                new(){Name="Heng Long", Age=223, Gender="f", Email="abc.gmail.com"},
                new(){Name="Heng Long", Age=23, Gender="f", Email="abc.gmail.com"},
                new(){Name="Heng Long", Age=23, Gender="female", Email="abc.gmail.com"},
                new(){Name="Heng Long", Age=23, Gender="male", Email="abc@gmail.com"}
           };

        List<Person> people = new();
        for (int index = 0; index < requests.Length; index++)
        {
            Console.Write($"\nRequest {index + 1} was ");
            try
            {
                people.Add(requests[index].ToPerson());
                ViewSuccessText("accepted", true);
            }
            catch (Exception ex)
            {
                ViewFailText($"rejected", true);
                Console.WriteLine($"[{ex.Message}]");
            }
        }

        Console.WriteLine($"\nThere are {people.Count} person(s) accepted to process...");
    }
    static void ViewSuccessText(string text, bool isNewLine = false)
    {
        ConsoleColor temp = Console.BackgroundColor;
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Write(text);
        Console.BackgroundColor = temp;
        if (isNewLine) Console.WriteLine();
    }
    static void ViewFailText(string text, bool isNewLine = false)
    {
        ConsoleColor temp = Console.BackgroundColor;
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write(text);
        Console.BackgroundColor = temp;
        if (isNewLine) Console.WriteLine();
    }
}
