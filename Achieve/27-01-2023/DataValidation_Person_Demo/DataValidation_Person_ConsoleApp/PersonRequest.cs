namespace DataValidation_Person_ConsoleApp;

public class PersonRequest
{
    public string? Name { get; set; }
    public string? Gender { get; set; }
    public byte? Age { get; set; }
    public string? Email { get; set; }

    public Person ToPerson()
    {
        var validator = new PersonValidator();
        if (validator.Validate(this, out var results) == false)
        {
            throw new ValidationException(results!);
        }
        return new Person()
        {
            Id = Guid.NewGuid().ToString(),
            Name = this.Name!,
            Gender = this.Gender!,
            Age = this.Age!.Value,
            Email = this.Email!,
        };
    }
}
