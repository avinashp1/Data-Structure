using System;
using System.Collections.Generic;

public class Graph
{
    public Dictionary<int, List<int>> AdjacencyList { get; } = new();

    public void AddEdge(int u, int v, bool undirected = false)
    {
        if (!AdjacencyList.ContainsKey(u)) AdjacencyList[u] = new List<int>();
        AdjacencyList[u].Add(v);
        if (undirected)
        {
            if (!AdjacencyList.ContainsKey(v)) AdjacencyList[v] = new List<int>();
            AdjacencyList[v].Add(u);
        }
    }

    public IEnumerable<int> BFS(int start)
    {
        if (!AdjacencyList.ContainsKey(start)) yield break;
        var visited = new HashSet<int>();
        var q = new Queue<int>();
        q.Enqueue(start);
        visited.Add(start);
        while (q.Count > 0)
        {
            var u = q.Dequeue();
            yield return u;
            if (!AdjacencyList.TryGetValue(u, out var neighbors)) continue;
            foreach (var v in neighbors)
            {
                if (visited.Add(v)) q.Enqueue(v);
            }
        }
    }

    public IEnumerable<int> DFS(int start)
    {
        if (!AdjacencyList.ContainsKey(start)) yield break;
        var visited = new HashSet<int>();
        var stack = new Stack<int>();
        stack.Push(start);
        while (stack.Count > 0)
        {
            var u = stack.Pop();
            if (!visited.Add(u)) continue;
            yield return u;
            if (!AdjacencyList.TryGetValue(u, out var neighbors)) continue;
            foreach (var v in neighbors)
            {
                if (!visited.Contains(v)) stack.Push(v);
            }
        }
    }

    public void PrintGraph()
    {
        foreach (var kvp in AdjacencyList)
        {
            Console.Write($"{kvp.Key}: ");
            foreach (var v in kvp.Value)
                Console.Write(v + " ");
            Console.WriteLine();
        }
    }
}
