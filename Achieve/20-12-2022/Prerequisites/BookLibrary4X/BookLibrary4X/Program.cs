using System.Reflection;

namespace BookLibrary4X;
using BookLibrary4X;

internal class Program
{
    static void Main(string[] args)
    {
        String DataFile = "data.txt";
        if (!File.Exists(DataFile))
        {
            Console.WriteLine($"the data file, {DataFile}, doesnt not exit");
            return;;
        }

        List<Book> books = new();
        var lines = File.ReadAllLines(DataFile);
        foreach (var line in lines)
        {
            var piece = line.Split(">");
            if(piece.Length<2) continue;
            var TypeText = piece[0];
            var data = piece[1];
            var instance = Assembly.GetExecutingAssembly().CreateInstance(TypeText, true);
            var newBook = instance as Book;
            if (newBook != null)
            {
                if()
            }
        }

    }
}