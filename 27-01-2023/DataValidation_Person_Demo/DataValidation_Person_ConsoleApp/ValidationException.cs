namespace DataValidation_Person_ConsoleApp;

public class ValidationException: Exception
{
    public static string MessageSeparator { get; set; } = "\n";

    private List<ValidationResult> results = new List<ValidationResult>();
    public ValidationException(List<ValidationResult> results)
    {
        this.results = results;
    }
    public List<ValidationResult> Results => results;
    public override string Message => string.Join(MessageSeparator, results.Select(r => r.ErrorMessage));
}