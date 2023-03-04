using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int count = 0;
        foreach (KeyValuePair<string, string> kvp in myDict)
        {
            count++;
        }
        return count;
    }
}