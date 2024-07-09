namespace BankAccounts.Library;

public class BankAccountException: Exception
{
    private string _message="";
    public BankAccountException() { }
    public BankAccountException(string message)
    {
        _message = message;
    }
    public override string Message
    {
        get
        {
            string result = _message;
            if (Data.Count> 0)
            {
                var extra = Data.Keys.Cast<string>()
                         .Select(key => $"[{key}:{Data[key]}]")
                         .Aggregate((a, b) => a + ", " + b);
                if (extra!=null) result += $"> {extra}";
            }
            return result;
        }
    }
}
