using System;
using System.Xml.Linq;

class DijkstraSimple
{
    static int V = 5;

    static int MinDistance(int[] dist, bool[] visited)
    {
        int min = int.MaxValue, minIndex = -1;
        for (int v=0;v<V;v++)
            if (!visited[v] && dist[v]<=min)
            {
                min=dist[v];
                minIndex=v;
            }
        return minIndex;
    }

    static void PrintPath(int[] parent,int j)
    {
        if (parent[j] == -1) { Console.Write(j); return; }
        PrintPath(parent, parent[j]);
        Console.Write(" -> " + j);
    }

    static void Dijkstra(int[,] graph, int src)
    {
        int[] dist = new int[V];
        bool[] visited = new bool[V];
        int[] parent=new int[V];

        for (int i=0;i<V;i++)
        {
            dist[i] = int.MaxValue;
            visited[i] = false;
            parent[i] = -1;
        }
        dist[src] = 0;

        for (int count =0;count<V-1;count++)
        {
            int u=MinDistance(dist, visited);
            visited[u] = true;

            for (int v=0;v<V;v++)
            {
                if (!visited[v] && graph[u,v] !=0 && dist[u] != int.MaxValue && dist[u] + graph[u,v] <  dist[v])
                {
                    dist[v] = dist[u]+ graph[u,v];
                    parent[v] = u;
                }
            }
        }
        Console.WriteLine("Node\tDistance\tPath");
        for (int i = 0; i < V; i++)
        {
            Console.Write(i + "\t" + dist[i] + "\t\t");
            PrintPath(parent, i);
            Console.WriteLine();
        }
    }
    static void Main()
    {
        int[,] graph =
        {
            {0,10,0,30,100 },
            {0,0,50,0,0 },
            {0,0,0,0,10 },
            {0,0,20,0,60 },
            {0,0,0,0,0 }
        };

        Console.WriteLine("Dijkstra Algorithm starting from Node 0:\n");
        Dijkstra(graph, 0);
    }

}
/*
Output:

Dijkstra Algorithm starting from Node 0:

Node Distance        Path
0       0               0
1       10              0 -> 1
2       50              0 -> 3 -> 2
3       30              0 -> 3
4       60              0 -> 3 -> 2 -> 4
*/