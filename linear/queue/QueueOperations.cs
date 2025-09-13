using System;
using System.Collections.Generic;

public static class QueueOperations
{
    public static void Enqueue<T>(Queue<T> queue, T item)
    {
        if (queue == null) throw new ArgumentNullException(nameof(queue));
        queue.Enqueue(item);
    }

    public static T Dequeue<T>(Queue<T> queue)
    {
        if (queue == null) throw new ArgumentNullException(nameof(queue));
        if (queue.Count == 0) throw new InvalidOperationException("Queue is empty.");
        return queue.Dequeue();
    }

    public static T Peek<T>(Queue<T> queue)
    {
        if (queue == null) throw new ArgumentNullException(nameof(queue));
        if (queue.Count == 0) throw new InvalidOperationException("Queue is empty.");
        return queue.Peek();
    }

    public static void PrintQueue<T>(Queue<T> queue)
    {
        if (queue == null) throw new ArgumentNullException(nameof(queue));
        Console.WriteLine("Queue elements:");
        foreach (var item in queue)
            Console.Write(item + " ");
        Console.WriteLine();
    }

    public static bool Contains<T>(Queue<T> queue, T element)
    {
        if (queue == null) throw new ArgumentNullException(nameof(queue));
        return queue.Contains(element);
    }

    public static void Clear<T>(Queue<T> queue)
    {
        if (queue == null) throw new ArgumentNullException(nameof(queue));
        queue.Clear();
    }
}
