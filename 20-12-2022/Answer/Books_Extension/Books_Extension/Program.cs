using System.Runtime.InteropServices;
using System.Security.Authentication.ExtendedProtection;
using Books_Extension;

string FileName = "data1.txt";
if (!File.Exists(FileName))
{
    Console.WriteLine($"The Data file,{FileName},does not exit");
}
List<BookX> books = new();
foreach (var line in File.ReadAllLines(FileName))
{
    var newbook = new BookX();
    if(newbook.SetData(line)) books.Add(newbook);
}

Console.WriteLine("\n>>All extend book");
foreach(var bk in books) Console.WriteLine(bk);
Console.WriteLine("\n>>Extended books(page>=500");
foreach(var bk in books.Where(e=>e.Pages>=500)); 
Console.WriteLine("\n>>Extended books(title patterned *C#* & published in year 2022)");
foreach(var bk in books.Where(e => e.Title.Contains("c#") && e.YearPublished == 2022));