using System;
using System.Collections.Generic;

public static class ListOperations
{
    // Generic print with null-check
    public static void PrintList<T>(List<T> list)
    {
        if (list == null) throw new ArgumentNullException(nameof(list));
        Console.WriteLine("List elements:");
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    // Insert element at index with validation
    public static void InsertElement<T>(List<T> list, T element, int index)
    {
        if (list == null) throw new ArgumentNullException(nameof(list));
        if (index < 0 || index > list.Count) throw new ArgumentOutOfRangeException(nameof(index));
        list.Insert(index, element);
    }

    // Remove element at index with validation
    public static void RemoveElement<T>(List<T> list, int index)
    {
        if (list == null) throw new ArgumentNullException(nameof(list));
        if (index < 0 || index >= list.Count) throw new ArgumentOutOfRangeException(nameof(index));
        list.RemoveAt(index);
    }

    // Insert element in the middle
    public static void InsertInMiddle<T>(List<T> list, T element)
    {
        if (list == null) throw new ArgumentNullException(nameof(list));
        int mid = list.Count / 2;
        list.Insert(mid, element);
    }

    public static int FindElement<T>(List<T> list, T element)
    {
        if (list == null) throw new ArgumentNullException(nameof(list));
        return list.IndexOf(element);
    }

    public static void Reverse<T>(List<T> list)
    {
        if (list == null) throw new ArgumentNullException(nameof(list));
        list.Reverse();
    }
}
