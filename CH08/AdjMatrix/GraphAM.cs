using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AdjMatrix
{
   class GraphAM
   {
      internal int count;
      internal int[,] adj;

      private List<List<Edge>> Adj;

      public class Edge : IComparable<Edge>
      {
         internal int dest;
         internal int cost;

         public Edge(int dst, int cst)
         {
            dest = dst;
            cost = cst;
         }

         int IComparable<Edge>.CompareTo(Edge other)
         {
            return cost - other.cost;
         }
      }

      public GraphAM(int item)
      {
         count = item;
         adj = new int[count, count];
         Adj = new List<List<Edge>>();
         for (int i = 0; i < item; i++)
         {
            Adj.Add(new List<Edge>());
         }
      }

      public virtual void AddDirectedEdge(int src, int dst, int cost)
      {
         adj[src, dst] = cost;
      }

      public virtual void AddUndirectedEdge(int src, int dst, int cost)
      {
         AddDirectedEdge(src, dst, cost);
         AddDirectedEdge(dst, src, cost);
      }

      public virtual void Display()
      {
         for (int j = 0; j < count; j++)
         {
            Write($"Node index [{j}] is connected with : ");
            for (int k = 0; k < count; k++)
            {
               if (adj[j, k] != 0)
                  Write($"{k} ");
            }
            WriteLine();
         }
      }

      public bool SearchBFS(GraphAM gph, int source, int target)
      {
         int count = gph.count;
         bool[] visited = new bool[count];
         Queue<int> que = new Queue<int>();
         que.Enqueue(source);
         visited[source] = true;

         while (que.Count > 0)
         {
            int curr = que.Dequeue();
            List<Edge> adl = gph.Adj[curr];
            foreach (Edge adn in adl)
            {
               if (visited[adn.dest] == false)
               {
                  visited[adn.dest] = true;
                  que.Enqueue(adn.dest);
               }
            }
         }
         return visited[target];
      }

      public bool DFSStack(GraphAM gph, int source, int target)
      {
         int count = gph.count;
         bool[] visited = new bool[count];

         Stack<int> stk = new Stack<int>();
         stk.Push(source);
         visited[source] = true;

         while (stk.Count > 0)
         {
            int curr = stk.Pop();
            List<Edge> adl = gph.Adj[curr];
            foreach (Edge adn in adl)
            {
               if (visited[adn.dest] == false)
               {
                  visited[adn.dest] = true;
                  stk.Push(adn.dest);
               }
            }
         }
         return visited[target];
      }

      public bool dfs(GraphAM gph, int source, int target)
      {
         int count = gph.count;
         bool[] visited = new bool[count];
         dfsUtil(gph, source, visited);
         return visited[target];
      }

      public void dfsUtil(GraphAM gph, int index, bool[] visited)
      {
         visited[index] = true;
         List<Edge> adl = gph.Adj[index];
         foreach (Edge adn in adl)
         {
            if (visited[adn.dest] == false)
            {
               dfsUtil(gph, adn.dest, visited);
            }
         }
      }

   }
}
