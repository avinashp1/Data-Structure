using System;
using System.Collections.Generic;

public static class QueueOperations
{
    public static void Enqueue<T>(Queue<T> queue, T item) => queue.Enqueue(item);
    public static T Dequeue<T>(Queue<T> queue) => queue.Dequeue();
    public static T Peek<T>(Queue<T> queue) => queue.Peek();
    public static void PrintQueue<T>(Queue<T> queue)
    {
        Console.WriteLine("Queue elements:");
        foreach (var item in queue)
            Console.Write(item + " ");
        Console.WriteLine();
    }
}
