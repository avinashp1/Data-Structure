using System;
using System.Collections.Generic;

internal static class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("DataStructure examples - clearly labelled method calls");

        Execute("ArrayOperations.PrintArray<T>", () => RunArrayExamples());
        Execute("ListOperations.*", () => RunListExamples());
        Execute("LinkedListOperations.*", () => RunLinkedListExamples());
        Execute("StackOperations.*", () => RunStackExamples());
        Execute("QueueOperations.*", () => RunQueueExamples());
        Execute("BinaryTreeOperations.*", () => RunBinaryTreeExamples());
        Execute("Graph.* (Print/BFS/DFS)", () => RunGraphExamples());

        Console.WriteLine("Done.");
    }

    private static void Execute(string title, Action action)
    {
        Console.WriteLine();
        Console.WriteLine("=== " + title + " ===");
        try
        {
            action();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[EXCEPTION in {title}] {ex.GetType().Name}: {ex.Message}");
        }
        Console.WriteLine("=== End " + title + " ===");
    }

    private static void RunArrayExamples()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Calling: ArrayOperations.PrintArray(int[])");
        ArrayOperations.PrintArray(arr);

        Console.WriteLine("Calling: ArrayOperations.InsertElement<int>(arr, 99, 2)");
        arr = ArrayOperations.InsertElement(arr, 99, 2);
        ArrayOperations.PrintArray(arr);

        Console.WriteLine("Calling: ArrayOperations.RemoveElement<int>(arr, 3)");
        arr = ArrayOperations.RemoveElement(arr, 3);
        ArrayOperations.PrintArray(arr);

        Console.WriteLine("Calling: ArrayOperations.InsertInMiddle<int>(arr, 77)");
        arr = ArrayOperations.InsertInMiddle(arr, 77);
        ArrayOperations.PrintArray(arr);

        string[] sarr = { "a", "b", "c" };
        Console.WriteLine("Calling: ArrayOperations.PrintArray(string[])");
        ArrayOperations.PrintArray(sarr);

        Console.WriteLine("Calling: ArrayOperations.InsertElement<string>(sarr, \"z\", 1)");
        sarr = ArrayOperations.InsertElement(sarr, "z", 1);
        ArrayOperations.PrintArray(sarr);

        Console.WriteLine("Calling: ArrayOperations.FindElement(arr, 99)");
        Console.WriteLine("Index of 99: " + ArrayOperations.FindElement(arr, 99));
        Console.WriteLine("Calling: ArrayOperations.Reverse(arr)");
        var reversedArr = ArrayOperations.Reverse(arr);
        ArrayOperations.PrintArray(reversedArr);
    }

    private static void RunListExamples()
    {
        var list = new List<int> { 1, 2, 3 };
        Console.WriteLine("Calling: ListOperations.PrintList<List<int>>");
        ListOperations.PrintList(list);

        Console.WriteLine("Calling: ListOperations.InsertElement<List<int>>(list, 10, 1)");
        ListOperations.InsertElement(list, 10, 1);
        ListOperations.PrintList(list);

        Console.WriteLine("Calling: ListOperations.RemoveElement<List<int>>(list, 2)");
        ListOperations.RemoveElement(list, 2);
        ListOperations.PrintList(list);

        Console.WriteLine("Calling: ListOperations.InsertInMiddle<List<int>>(list, 99)");
        ListOperations.InsertInMiddle(list, 99);
        ListOperations.PrintList(list);

        Console.WriteLine("Calling: ListOperations.FindElement(list, 99)");
        Console.WriteLine("Index of 99: " + ListOperations.FindElement(list, 99));
        Console.WriteLine("Calling: ListOperations.Reverse(list)");
        ListOperations.Reverse(list);
        ListOperations.PrintList(list);
    }

    private static void RunLinkedListExamples()
    {
        var ll = new LinkedList<int>();
        Console.WriteLine("Calling: LinkedListOperations.AddFirst");
        LinkedListOperations.AddFirst(ll, 2);
        LinkedListOperations.AddFirst(ll, 1);
        Console.WriteLine("Calling: LinkedListOperations.AddLast");
        LinkedListOperations.AddLast(ll, 3);
        Console.WriteLine("Calling: LinkedListOperations.PrintLinkedList");
        LinkedListOperations.PrintLinkedList(ll);

        Console.WriteLine("Calling: LinkedListOperations.Remove(ll, 2)");
        LinkedListOperations.Remove(ll, 2);
        LinkedListOperations.PrintLinkedList(ll);

        Console.WriteLine("Calling: LinkedListOperations.FindElement(ll, 3)");
        Console.WriteLine("Found 3: " + LinkedListOperations.FindElement(ll, 3));
        Console.WriteLine("Calling: LinkedListOperations.Reverse(ll)");
        LinkedListOperations.Reverse(ll);
        LinkedListOperations.PrintLinkedList(ll);
    }

    private static void RunStackExamples()
    {
        var stack = new Stack<int>();
        Console.WriteLine("Calling: StackOperations.Push");
        StackOperations.Push(stack, 1);
        StackOperations.Push(stack, 2);
        StackOperations.Push(stack, 3);
        Console.WriteLine("Calling: StackOperations.PrintStack");
        StackOperations.PrintStack(stack);

        Console.WriteLine("Calling: StackOperations.Pop");
        int popped = StackOperations.Pop(stack);
        Console.WriteLine($"Popped: {popped}");
        StackOperations.PrintStack(stack);

        Console.WriteLine("Calling: StackOperations.Peek");
        int top = StackOperations.Peek(stack);
        Console.WriteLine($"Top: {top}");

        Console.WriteLine("Calling: StackOperations.Contains(stack, 2)");
        Console.WriteLine("Contains 2: " + StackOperations.Contains(stack, 2));
        Console.WriteLine("Calling: StackOperations.Clear(stack)");
        StackOperations.Clear(stack);
        StackOperations.PrintStack(stack);
    }

    private static void RunQueueExamples()
    {
        var queue = new Queue<int>();
        Console.WriteLine("Calling: QueueOperations.Enqueue");
        QueueOperations.Enqueue(queue, 1);
        QueueOperations.Enqueue(queue, 2);
        QueueOperations.Enqueue(queue, 3);
        Console.WriteLine("Calling: QueueOperations.PrintQueue");
        QueueOperations.PrintQueue(queue);

        Console.WriteLine("Calling: QueueOperations.Dequeue");
        int d = QueueOperations.Dequeue(queue);
        Console.WriteLine($"Dequeued: {d}");
        QueueOperations.PrintQueue(queue);

        Console.WriteLine("Calling: QueueOperations.Peek");
        int p = QueueOperations.Peek(queue);
        Console.WriteLine($"Peek: {p}");

        Console.WriteLine("Calling: QueueOperations.Contains(queue, 2)");
        Console.WriteLine("Contains 2: " + QueueOperations.Contains(queue, 2));
        Console.WriteLine("Calling: QueueOperations.Clear(queue)");
        QueueOperations.Clear(queue);
        QueueOperations.PrintQueue(queue);
    }

    private static void RunBinaryTreeExamples()
    {
        // Build a small tree:
        //      1
        //     / \
        //    2   3
        var root = new TreeNode<int>(1)
        {
            Left = new TreeNode<int>(2),
            Right = new TreeNode<int>(3)
        };

        Console.WriteLine("Calling: BinaryTreeOperations.PreOrder");
        BinaryTreeOperations.PreOrder(root);
        Console.WriteLine();

        Console.WriteLine("Calling: BinaryTreeOperations.InOrder");
        BinaryTreeOperations.InOrder(root);
        Console.WriteLine();

        Console.WriteLine("Calling: BinaryTreeOperations.PostOrder");
        BinaryTreeOperations.PostOrder(root);
        Console.WriteLine();

        Console.WriteLine("Calling: BinaryTreeOperations.LevelOrder");
        BinaryTreeOperations.LevelOrder(root);
        Console.WriteLine();

        Console.WriteLine("Calling: BinaryTreeOperations.Find(root, 2)");
        Console.WriteLine("Found 2: " + BinaryTreeOperations.Find(root, 2));
        Console.WriteLine("Calling: BinaryTreeOperations.Height(root)");
        Console.WriteLine("Height: " + BinaryTreeOperations.Height(root));
    }

    private static void RunGraphExamples()
    {
        var g = new Graph();
        Console.WriteLine("Calling: Graph.AddEdge(1,2, undirected:true)");
        g.AddEdge(1, 2, true);
        Console.WriteLine("Calling: Graph.AddEdge(1,3)");
        g.AddEdge(1, 3);
        Console.WriteLine("Calling: Graph.AddEdge(2,4)");
        g.AddEdge(2, 4);
        Console.WriteLine("Calling: Graph.PrintGraph");
        g.PrintGraph();

        Console.WriteLine("Calling: Graph.BFS(1)");
        PrintSequence(g.BFS(1));

        Console.WriteLine("Calling: Graph.DFS(1)");
        PrintSequence(g.DFS(1));

        Console.WriteLine("Calling: g.HasEdge(1, 2)");
        Console.WriteLine("HasEdge(1,2): " + g.HasEdge(1, 2));
        Console.WriteLine("Calling: g.VertexCount()");
        Console.WriteLine("VertexCount: " + g.VertexCount());
    }

    private static void PrintSequence<T>(IEnumerable<T> seq)
    {
        Console.Write("Sequence: ");
        foreach (var x in seq) Console.Write(x + " ");
        Console.WriteLine();
    }
}
