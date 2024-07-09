public class Person
{
    #region static members
    public static string Separator { get; set; } = "/";
    public static (int, string, string, Gender, byte)? GetFieldData(string data)
    {
        string[] arr = data.Split(Person.Separator);
        if (arr.Length < 5) return null;
        if (int.TryParse(arr[0], out var code) == false) return null;
        var first = arr[1].Trim();
        var last = arr[2].Trim();
        if (Enum.TryParse<Gender>(Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(arr[3]), out var gender)==false) return null;; ;
        if (Enum.IsDefined<Gender>(gender) == false) return null;
        if (byte.TryParse(arr[4], out var age) == false) return null;
        return (code, first, last, gender, age);
    }
    public static Person? Create(string data)
    {
        (int code, string first, string last, Gender gender, byte age)? fieldData = Person.GetFieldData(data);
        if (fieldData == null) return null;
        return new Person()
        {
            Code = (int)fieldData?.code!,
            FirstName = fieldData?.first!,
            LastName = fieldData?.last!,
            Gender = (Gender)fieldData?.gender!,
            Age = (byte)fieldData?.age!
        };
    }
    #endregion

    #region instance fields
    protected int code;
    protected string fname="";
    protected string lname="";
    protected Gender gender = Gender.Unknown;
    protected Byte age;
    #endregion


    #region instance methods
    protected virtual void Notify()
    {

    }
    public void SetData(int code, string first, string last, Gender gender, byte age)
    {
        this.code = code;
        this.fname = first;
        this.LastName = last;
        this.gender = gender;
        this.age = age;
        Notify();
    }
    #endregion

    #region instance properties
    public int Code
    {
        get => code;
        set
        {
            code = value;
            Notify();
        }
    }
    public string FirstName
    {
        get => fname;
        set
        {
            fname = value;
            Notify();
        }
    }
    public string LastName
    {
        get => lname;
        set
        {
            lname = value;
            Notify();
        }
    }
    public Gender Gender
    {
        get => gender;
        set
        {
            gender = value;
            Notify();
        }
    }
    public byte Age
    {
        get => age;
        set
        {
            age = value;
            Notify();
        }
    }
    public string FullName { get => $"{FirstName} {LastName}"; }
    public string Info { get => $"{Code}>{FullName}, {Gender}, {Age}"; }
    public string Data
    {
        set
        {
            (int code, string first, string last, Gender gender, byte age)? fieldData = Person.GetFieldData(value);
            if (fieldData == null) return;
            code = (int)fieldData?.code!;
            fname = fieldData?.first!;
            lname = fieldData?.last!;
            gender = (Gender)fieldData?.gender!;
            age = (byte)fieldData?.age!;
            Notify();
        }
    }
    #endregion
}