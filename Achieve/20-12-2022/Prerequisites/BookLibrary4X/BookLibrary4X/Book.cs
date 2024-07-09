namespace BookLibrary4X;

public class Book
{
    public static string Separator { get; set; } = "/";
    public long Code { get; set; } = 0;

    public string Title { get; set; } = "";

    public int Pages { get; set; } = 0;

    public string Author { get; set; } = "";
    
    public object? Tag { get; set; } = null;
    
    public virtual bool SetData(string data)
    {
        var arr = data.Split(Separator);
        if (arr.Length < 4) return false;
        if (long.TryParse(arr[0], out var code) == false) return false;
        var title = arr[1].Trim();
        if (int.TryParse(arr[2], out var pages) == false) return false;
        var author = arr[3].Trim();

        Code = code;
        Title = title;
        Pages = pages;
        Author = author;
        return true;
    }

    public override string ToString()
    {
        return $"code:{Code,6}, title:{Title,-30}, pages: {Pages,5}, author:{Author,-20}";
    }
}
