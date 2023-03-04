using System;
using System.Collections.Generic;

public class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index < 0 || index >= myList.Count)
        {
            Console.WriteLine("Index is out of range");
            return myList;
        }

        List<int> result = new List<int>(myList.Count - 1);
        for (int i = 0; i < myList.Count; i++)
        {
            if (i != index)
            {
                result.Add(myList[i]);
            }
        }
        return result;
    }
}
