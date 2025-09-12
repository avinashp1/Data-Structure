using System;
using System.Collections.Generic;

public class TreeNode<T>
{
    public T Value { get; set; }
    public TreeNode<T> Left { get; set; }
    public TreeNode<T> Right { get; set; }
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

    public static void PreOrder<T>(TreeNode<T> node)
    {
        if (node == null) return;
        Console.Write(node.Value + " ");
        PreOrder(node.Left);
        PreOrder(node.Right);
    }

    public static void PostOrder<T>(TreeNode<T> node)
    {
        if (node == null) return;
        PostOrder(node.Left);
        PostOrder(node.Right);
        Console.Write(node.Value + " ");
    }

    public static void LevelOrder<T>(TreeNode<T> root)
    {
        if (root == null) return;
        var q = new Queue<TreeNode<T>>();
        q.Enqueue(root);
        while (q.Count > 0)
        {
            var n = q.Dequeue();
            Console.Write(n.Value + " ");
            if (n.Left != null) q.Enqueue(n.Left);
            if (n.Right != null) q.Enqueue(n.Right);
        }
    }
}
