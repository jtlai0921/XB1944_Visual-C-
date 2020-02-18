using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AdjMatrix
{
   class Program
   {
      static void Main(string[] args)
      {
         GraphAM graph = new GraphAM(5);
         
         graph.AddDirectedEdge(1, 1, 3);
         graph.AddDirectedEdge(0, 4, 2);
         graph.AddDirectedEdge(1, 2, 1);
         graph.AddDirectedEdge(2, 3, 1);
         graph.AddDirectedEdge(4, 1, -2);
         graph.AddDirectedEdge(4, 3, 1);
         graph.Display();
         WriteLine(graph.dfs(graph, 0, 2));
         WriteLine(graph.SearchBFS(graph, 0, 2));
         WriteLine(graph.DFSStack(graph, 0, 2));
         ReadKey();
      }
   }
}
