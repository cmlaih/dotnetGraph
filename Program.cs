using System;
using System.Collections.Generic;

public class Graph
{
    private List<List<int>> adjacencyList;
    private bool[,] adjacencyMatrix;
    private int verticesCount;

    public Graph(int verticesCount)
    {
        this.verticesCount = verticesCount;
        adjacencyList = new List<List<int>>(verticesCount);
        adjacencyMatrix = new bool[verticesCount, verticesCount];

        for (int i = 0; i < verticesCount; i++)
        {
            adjacencyList.Add(new List<int>());
        }
    }

    public void AddEdge(int from, int to)
    {
        adjacencyList[from - 1].Add(to - 1); // Adjusting for zero-based index
        adjacencyMatrix[from - 1, to - 1] = true; // Adjusting for zero-based index
    }

    public void DisplayAdjacencyList()
    {
        Console.WriteLine("Adjacency List:");
        for (int i = 0; i < verticesCount; i++)
        {
            Console.Write((i + 1) + ": "); // Adjusting for one-based index display
            foreach (var edge in adjacencyList[i])
            {
                Console.Write((edge + 1) + " "); // Adjusting for one-based index display
            }
            Console.WriteLine();
        }
    }

    public void DisplayAdjacencyMatrix()
    {
        Console.WriteLine("Adjacency Matrix:");
        for (int i = 0; i < verticesCount; i++)
        {
            for (int j = 0; j < verticesCount; j++)
            {
                Console.Write(adjacencyMatrix[i, j] ? "1 " : "0 ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        Graph graph = new Graph(6); // The graph has 6 vertices

        // Add the edges as they appear in the graph image
        graph.AddEdge(1, 2);
        graph.AddEdge(2, 1);
        graph.AddEdge(1, 3);
        graph.AddEdge(3, 1);
        graph.AddEdge(1, 6);
        graph.AddEdge(6, 1);
        graph.AddEdge(2, 4);
        graph.AddEdge(4, 2);
        graph.AddEdge(3, 4);
        graph.AddEdge(4, 3);
        graph.AddEdge(3, 5);
        graph.AddEdge(5, 3);
        graph.AddEdge(4, 6);
        graph.AddEdge(6, 4);


        graph.DisplayAdjacencyList();
        graph.DisplayAdjacencyMatrix();
    }
}

