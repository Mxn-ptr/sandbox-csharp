using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> div = new List<bool>();
        foreach (int element in myList)
        {
            if (element % 2 == 0)
                div.Add(true);
            else
                div.Add(false);
        }
        return div;
    }
}
