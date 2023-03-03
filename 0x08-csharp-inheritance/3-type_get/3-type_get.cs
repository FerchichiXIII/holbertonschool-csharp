using System;
using System.Reflection;
using System.Collections.Generic;

class Obj
{
    /// <summary>prints the names of the available properties and methods of an object.</summary>
    public static void Print(object myObj)
    {
        Type objType = myObj.GetType();
    

    PropertyInfo[] properties = objType.GetProperties();
    Console.WriteLine($"{objType.Name} Properties:");
    foreach (PropertyInfo prop in properties)
    {
        Console.WriteLine(prop.Name);
    }
    

    MethodInfo[] methods = objType.GetMethods();
    Console.WriteLine($"{objType.Name} Methods:");
    foreach (MethodInfo method in methods)
    {
        Console.WriteLine(method.Name);
    }        
    }
}
