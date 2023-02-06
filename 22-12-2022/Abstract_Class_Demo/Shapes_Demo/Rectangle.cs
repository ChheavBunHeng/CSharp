using ShapeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Demo;

public class Rectangle:Shape
{
    public static new string Separator { get; set; } = "/";
    protected double wd;
    protected double ln;
    public double Width { get => wd; set { wd = value; Notify(); } }
    public double Length { get => ln; set { ln = value; Notify(); } }

    #region overridings
    public override bool SetData(string data)
    {
        var arr = data.Split(Rectangle.Separator);
        if (!double.TryParse(arr[0], out var wd)) return false;
        if (!double.TryParse(arr[1], out var ln)) return false;
        this.wd = wd;
        this.ln = ln;
        Notify();
        return true;
    }

    public override string Info => $"width:{wd:n2}, length:{ln:n2}";

    public override double Area => wd * ln;
    #endregion

}
