// See https://aka.ms/new-console-template for more information
using ShapeLibrary;
using Shapes_Demo;

Console.WriteLine("Hello, Shapes");

string datafile = "data.txt";
if (!File.Exists(datafile))
{
    Console.WriteLine($"The data file, {datafile}, does not exist");
    return;
}
ShapeManager mgr = new ShapeManager();
mgr.ShapeAdded += (sender, sh) => { Console.WriteLine($">>Added {sh.GetType().Name,-10}=> {sh}"); };
mgr.ShapeRemoved += (sender, sh) => {Console.WriteLine($">>Removed {sh.GetType().Name,-10}=> {sh}");};
mgr.ShapeDataModified += (sender, sh) => { Console.WriteLine($">>Modified{sh.GetType().Name,-10}=> {sh}"); };

Console.WriteLine(";\nLoading shapes from data file...");
foreach(var line in File.ReadLines(datafile))
{
    var arr = line.Split(":");
    mgr.Add(arr[0], arr[1]); 
}

Console.WriteLine("\nAll shapes");
foreach(var sh in mgr.Shapes)
{
    Console.WriteLine($"{sh.GetType().Name,-10}=> area:{sh.Area,10:n2}, {sh}");
}
Console.WriteLine($"Area Total: {mgr.TotalArea:n2}");

double total = 0.0;
Console.WriteLine("\nAll rectangles");
total = 0.0;
foreach (var sh in mgr.GetShapesFor(typeof(Rectangle)))
{
    Console.WriteLine($"area:{sh.Area,10:n2}, {sh}");
    total += sh.Area;
}
Console.WriteLine($"Area Total: {total:n2}");


Console.WriteLine("\nAll triangles");
total = 0.0;
foreach (var sh in mgr.GetShapesFor(typeof(Triangle)))
{
    Console.WriteLine($"area:{sh.Area,10:n2}, {sh}");
    total += sh.Area;
}
Console.WriteLine($"Area Total: {total:n2}");

Console.WriteLine("\nRemove shapes with area > 30 ...");
var removes = mgr.Shapes.Where(e => e.Area > 30);//polymorphism
foreach(var remove in removes)
{
    mgr.Remove(remove);
}

Console.WriteLine("\nRemaining shapes");
foreach (var sh in mgr.Shapes)
{
    Console.WriteLine($"{sh.GetType().Name,-10}=> area:{sh.Area,10:n2}, {sh}");
}
Console.WriteLine($"Area Total: {mgr.TotalArea:n2}");