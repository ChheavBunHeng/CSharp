namespace Books_DataValidation_Classic.ConsoleApp;

public class BookCreateRequest
{
    public long? Number { get; set; } = null;
    public string? Title { get; set; } = null;
    public int? Pages { get; set; } = null;
    public string? Author { get; set; } = null;

    public static string DataSeparator { get; set; } = "/";
    public static BookCreateRequest Create(string data)
    {
        var arr = data.Split(DataSeparator);
        BookCreateRequest request= new BookCreateRequest();
        try { if (long.TryParse(arr[0], out var no)) request.Number=no; } catch (Exception) { }
        try { request.Title = arr[1].Trim(); }catch(Exception) { }
        try { if (int.TryParse(arr[2], out var pages)) request.Pages = pages; } catch(Exception) { }
        try { request.Author = arr[3].Trim(); }catch(Exception) { }
        return request;
    }
}
