using BookLibrary4X;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Books_Extension;

public class Manager
{
    private List<BookX> books = new();
    public int? Load(string filename)
    {
        if (!File.Exists(filename)) return null;
        int n = 0;
        foreach(var line in File.ReadAllLines(filename))
        {
            var newBook = new BookX();
            if (newBook.SetData(line))
            {
                books.Add(newBook);
                n++;
            }
        }
        return n;
    }
    public BookX[] Books => books.ToArray();

    public List<BookX> Filter(Func<BookX, bool> filter) { return books.Where(filter).ToList(); }

}
public class BookX:Book
{
    public int YearPublished { get; set; } = 0;

    public override bool SetData(string data)
    {
        var arr = data.Split(BookX.Separator);
        if (arr==null || arr.Length < 5) return false;
        if (int.TryParse(arr[4], out int year) == false) return false;
        if (base.SetData(data) == true)
        {
            YearPublished = year;
            return true;
        }
        return false;
    }
    public override string ToString()
    {
        return $"{base.ToString()}, year pub.:{YearPublished}";
    }
}
