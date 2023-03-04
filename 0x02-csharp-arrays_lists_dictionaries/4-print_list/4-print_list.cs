using System;
using System.Collections.Generic;

public class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        List<int> list = new List<int>();
        for (int i = 0; i < size; i++)
        {
            Console.Write("{0}{1}",i , i != size-1 ? " ":"");
            list.Add(i);
        }
        Console.WriteLine();

        return list;
    }
}
