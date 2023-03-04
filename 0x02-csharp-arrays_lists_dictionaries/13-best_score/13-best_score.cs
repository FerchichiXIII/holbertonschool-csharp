using System;
using System.Collections.Generic;

public class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string bestStudent = "None";
        int bestScore = int.MinValue;

        foreach (KeyValuePair<string, int> pair in myList)
        {
            if (pair.Value > bestScore)
            {
                bestScore = pair.Value;
                bestStudent = pair.Key;
            }
        }

        return bestStudent;
    }
}
