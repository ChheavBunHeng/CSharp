namespace ShapeLibrary;

public abstract class shape
{
    public static string Separator { get; set; } = "/";
    public event EventHandler? DataModified;

    protected void notify()
    {
        DataModified?.Invoke(this,EventArgs.Empty);
    }
    public object? Tag { get; set; }
    public sealed override string ToString() => this.Info; /*Polymorphism */ 
    public string Type { get => this.GetType().Name; }

    public abstract bool SetData(string data);
    public abstract double Area { get; }
    public abstract string Info { get; }
}

