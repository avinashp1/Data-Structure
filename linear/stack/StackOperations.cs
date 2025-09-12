using System;
using System.Collections.Generic;

public static class StackOperations
{
    public static void Push<T>(Stack<T> stack, T item) => stack.Push(item);
    public static T Pop<T>(Stack<T> stack) => stack.Pop();
    public static T Peek<T>(Stack<T> stack) => stack.Peek();
    public static void PrintStack<T>(Stack<T> stack)
    {
        Console.WriteLine("Stack elements:");
        foreach (var item in stack)
            Console.Write(item + " ");
        Console.WriteLine();
    }
}
