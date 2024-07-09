using System.ComponentModel;
using System.Reflection;

namespace ShapeLibrary;

public static class AssemblyExtension
{
    public static object? CreateObject(this Assembly assembly, string typeName,  bool isIncludeRef=false)
    {
        var type = assembly.GetTypes().FirstOrDefault(e => e.Name == typeName);
        object? instance = null;
        if (type != null)
        {
            instance = Activator.CreateInstance(type);
        }
        if (instance == null && isIncludeRef)
        {
            foreach (var assName in assembly.GetReferencedAssemblies())
            {
                var ass = Assembly.Load(assName);
                if (ass == null) continue;
                instance = CreateObject(ass, typeName, false);
                if (instance != null) break;
            }
        }
        
        return instance;
    }
}
