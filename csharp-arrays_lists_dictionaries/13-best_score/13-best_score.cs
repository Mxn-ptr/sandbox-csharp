using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int max = -1;
        string key = "None";
        foreach (var kvp in myList)
        {
            if (kvp.Value > max) {
                max = kvp.Value;
                key = kvp.Key;
            }
        }
        return key;
    }
}
