using System;
using System.Collections.Generic;

public static class ListOperations
{
    // Print all elements of a list (int)
    public static void PrintList(List<int> list)
    {
        Console.WriteLine("List elements:");
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    // Print all elements of a list (string)
    public static void PrintList(List<string> list)
    {
        Console.WriteLine("List elements:");
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    // Insert element at index
    public static void InsertElement<T>(List<T> list, T element, int index)
    {
        list.Insert(index, element);
    }

    // Remove element at index
    public static void RemoveElement<T>(List<T> list, int index)
    {
        list.RemoveAt(index);
    }

    // Insert element in the middle
    public static void InsertInMiddle<T>(List<T> list, T element)
    {
        int mid = list.Count / 2;
        list.Insert(mid, element);
    }
}
