

namespace Books_DataValidation_Classic.Library;

public class ValidationException : Exception
{
    public static string MessageSeparator { get; set; } = ", ";

    private List<ValidationResult> results = new List<ValidationResult>();
    public ValidationException(List<ValidationResult> results)
    {
        if (results != null) this.results = results;
    }
    public List<ValidationResult> Results => results;
    public override string Message => 
        string.Join(MessageSeparator, results.Select(r => r.ErrorMessage));
}
