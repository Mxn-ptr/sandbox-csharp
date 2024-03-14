using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index < 0 || index > myList.Count - 1)
            Console.WriteLine("Index is out of range");
        else
        {
            int itemToRemoved = myList[index];
            myList.Remove(itemToRemoved);
        }
        return myList;
    }
}
