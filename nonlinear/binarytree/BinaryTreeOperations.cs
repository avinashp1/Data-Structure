using System;

public class TreeNode<T>
{
    public T Value;
    public TreeNode<T> Left, Right;
    public TreeNode(T value) { Value = value; }
}

public static class BinaryTreeOperations
{
    public static void InOrder<T>(TreeNode<T> node)
    {
        if (node == null) return;
        InOrder(node.Left);
        Console.Write(node.Value + " ");
        InOrder(node.Right);
    }
    // Add more operations as needed
}
