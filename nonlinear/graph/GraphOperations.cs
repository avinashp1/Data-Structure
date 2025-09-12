using System;
using System.Collections.Generic;

public class Graph
{
    public Dictionary<int, List<int>> AdjacencyList = new();
    public void AddEdge(int u, int v)
    {
        if (!AdjacencyList.ContainsKey(u)) AdjacencyList[u] = new List<int>();
        AdjacencyList[u].Add(v);
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
