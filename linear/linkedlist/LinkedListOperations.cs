using System;
using System.Collections.Generic;

public static class LinkedListOperations
{
    public static void AddFirst<T>(LinkedList<T> list, T item) => list.AddFirst(item);
    public static void AddLast<T>(LinkedList<T> list, T item) => list.AddLast(item);
    public static void Remove<T>(LinkedList<T> list, T item) => list.Remove(item);
    public static void PrintLinkedList<T>(LinkedList<T> list)
    {
        Console.WriteLine("LinkedList elements:");
        foreach (var item in list)
            Console.Write(item + " ");
        Console.WriteLine();
    }

    public static bool FindElement<T>(LinkedList<T> list, T element)
    {
        if (list == null) throw new ArgumentNullException(nameof(list));
        return list.Contains(element);
    }

    public static void Reverse<T>(LinkedList<T> list)
    {
        if (list == null) throw new ArgumentNullException(nameof(list));
        var arr = new List<T>(list);
        list.Clear();
        for (int i = arr.Count - 1; i >= 0; i--)
            list.AddLast(arr[i]);
    }
}
