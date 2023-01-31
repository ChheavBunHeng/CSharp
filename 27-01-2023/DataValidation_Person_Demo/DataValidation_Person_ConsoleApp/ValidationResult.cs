namespace DataValidation_Person_ConsoleApp;

public class ValidationResult
{
    private List<string> memberNames = new();
    public ValidationResult(string message, params string[] members)
    {
        memberNames.AddRange(members);
        ErrorMessage = message;
    }
    public string ErrorMessage { get; init; }
    public List<string> MemberNames => memberNames;
}