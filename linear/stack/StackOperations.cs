using System;
using System.Collections.Generic;

public static class StackOperations
{
    public static void Push<T>(Stack<T> stack, T item)
    {
        if (stack == null) throw new ArgumentNullException(nameof(stack));
        stack.Push(item);
    }

    public static T Pop<T>(Stack<T> stack)
    {
        if (stack == null) throw new ArgumentNullException(nameof(stack));
        if (stack.Count == 0) throw new InvalidOperationException("Stack is empty.");
        return stack.Pop();
    }

    public static T Peek<T>(Stack<T> stack)
    {
        if (stack == null) throw new ArgumentNullException(nameof(stack));
        if (stack.Count == 0) throw new InvalidOperationException("Stack is empty.");
        return stack.Peek();
    }

    public static void PrintStack<T>(Stack<T> stack)
    {
        if (stack == null) throw new ArgumentNullException(nameof(stack));
        Console.WriteLine("Stack elements:");
        foreach (var item in stack)
            Console.Write(item + " ");
        Console.WriteLine();
    }
}
