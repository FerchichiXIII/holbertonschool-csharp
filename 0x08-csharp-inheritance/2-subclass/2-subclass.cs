using System;


class Obj
{
    /// <summary>returns True if the object is an instance of a class that inherits from the specified class</summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
