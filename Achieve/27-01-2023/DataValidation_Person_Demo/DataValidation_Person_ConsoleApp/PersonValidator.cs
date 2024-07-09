namespace DataValidation_Person_ConsoleApp;

public class PersonValidator
{
    public static string[] Genders { get; protected set; } = new string[] { "female", "male" };
    public static byte MinAge => 0;
    public static byte MaxAge => 125;
    public static int NameMaxLength = 20;
    public bool Validate(PersonRequest request, out List<ValidationResult?> results)
    {
        results = new List<ValidationResult?>();
        if (ValidateName(request.Name, out var nameResult) == false)
        {
            results.Add(nameResult);
        }
        if (ValidateGender(request.Gender, out var genderResult) == false)
        {
            results.Add(genderResult);
        }
        if (ValidateAge(request.Age, out var ageResult) == false)
        {
            results.Add(ageResult);
        }
        if (ValidateEmail(request.Email, out var emailResult) == false)
        {
            results.Add(emailResult);
        }
        return results.Count == 0;
    }
    //ValidateData
    public bool ValidateName(string? name, out ValidationResult? result)
    {
        string member = nameof(Person.Name);
        if (string.IsNullOrEmpty(name?.Trim()))
        {
            result = new ValidationResult($"{member} is required", member);
            return false;
        }
        if (name?.Trim().Length > NameMaxLength)
        {
            result = new ValidationResult($"{member} has maximum length of {NameMaxLength}", member);
            return false;
        }
        result = null;
        return true;

    }
    public bool ValidateGender(string? gender, out ValidationResult? result)
    {
        string member = nameof(Person.Gender);
        if (string.IsNullOrEmpty(gender?.Trim()))
        {
            result = new ValidationResult($"{member} is required", member);
            return false;
        }

        if (!Genders.Contains(gender))
        {
            string text = $"{"{"}{Genders.Aggregate((a,b)=>a + ", " + b)}{"}"}";
            result = new ValidationResult($"{member} must be in {text}", member);
            return false;
        }
        result = null;
        return true;

    }
    public bool ValidateAge(int? age, out ValidationResult? result)
    {
        string member = nameof(Person.Age);
        if (age == null)
        {
            result = new ValidationResult($"{member} is required", member);
            return false;
        }
        if (age<MinAge || age>MaxAge)
        {
            string text = $"[{MinAge}, {MaxAge}]";
            result = new ValidationResult($"{member} must be in {text}", member);
            return false;
        }
        result = null;
        return true;

    }
    public bool ValidateEmail(string? email, out ValidationResult? result)
    {
        string member = nameof(Person.Email);
        if (string.IsNullOrEmpty(email?.Trim()))
        {
            result = new ValidationResult($"{member} is required", member);
            return false;
        }
        if (!email.Contains('@'))
        {
            result = new ValidationResult($"{member} is not valid email address", member);
            return false;
        }
        result = null;
        return true;

    }
}
