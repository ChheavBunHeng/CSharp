using System.Reflection;

namespace ShapeLibrary;

public delegate void ShapeEventHandler(object sender, Shape sh);
public class ShapeManager
{
    public static Shape? CreateShape(string typeName, string data)
    {
        var instance = Assembly.GetEntryAssembly()?.CreateObject(typeName, true);
        if (instance is Shape sh)
        {
            if (sh.SetData(data) /*polymorphism*/ == true)
            {
                return sh;
            }
        }
        return null;
    }

    private List<Shape> shapes = new();

    public event ShapeEventHandler? ShapeAdded;
    public event ShapeEventHandler? ShapeRemoved;
    public event ShapeEventHandler? ShapeDataModified;   
    public List<Shape> Shapes => new List<Shape>(shapes);

    public double TotalArea => shapes.Sum(e => e.Area/*polymorphism*/ );
    public ShapeManager Add(Shape shape)
    {
        shapes.Add(shape);
        ShapeAdded?.Invoke(this, shape);
        shape.DataModified += OnShapeDataModified; 
        return this;
    }

    public ShapeManager Add(string typeName, string data)
    {
        var sh = ShapeManager.CreateShape(typeName, data);
        if (sh != null) Add(sh);
        return this;
    }
    public ShapeManager Remove(Shape sh)
    {
        var result = shapes.Remove(sh);
        if (result == true)
        {
            ShapeRemoved?.Invoke(this, sh);
            sh.DataModified -= OnShapeDataModified;
        }
        return this;
    }
    public List<Shape> GetShapesFor(Type type) => shapes.Where(e => e.GetType()==type).ToList();

    private void OnShapeDataModified(object? sender, EventArgs e)
    {
        if (sender is Shape sh) ShapeDataModified?.Invoke(this, sh);
    }




}