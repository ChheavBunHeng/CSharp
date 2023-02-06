using ShapeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Demo;

public class Triangle:Shape
{
    public static new string Separator { get; set; } = "/";
    protected double a;
    protected double b;
    protected double c;
    public double Side1 { get => a; set { a = value; Notify(); } }
    public double Side2 { get => b; set { b = value; Notify(); } }
    public double Side3 { get => c; set { c = value; Notify(); } }

    #region overridings
    public override bool SetData(string data)
    {
        var arr = data.Split(Rectangle.Separator);
        if (!double.TryParse(arr[0], out var a)) return false;
        if (!double.TryParse(arr[1], out var b)) return false;
        if (!double.TryParse(arr[2], out var c)) return false;
        this.a = a;
        this.b = b;
        this.c = c;
        Notify();
        return true;
    }
 
    public override string Info => $"side1:{a:n2}, side2:{b:n2}, side3:{c:n2}";

    public override double Area
    {
        get
        {
            double per = (a + b + c) / 2.0;
            return Math.Sqrt(per * (per - a) * (per - b) * (per - c));
        }
    }
    #endregion
}
