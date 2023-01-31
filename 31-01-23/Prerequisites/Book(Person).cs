    

namespace Books_DataValidation_Classic.Library;

public class Book
{
    public long Number { get; init; }
    public string Title { get; set; } = "";
    public int Pages { get; set; } = 0;
    public string? Author { get; set; } = null;

}