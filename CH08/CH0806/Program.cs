using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0806
{
   class Program
   {      
      static void Main(string[] args)
      {
         int[,] edges = {{5, 4, 1350}, {5, 6,  300},
                         {6, 4,  900}, {6, 8, 1300},
                         {6, 7,  850}, {4, 3, 1100},
                         {7, 8,  930}, {3, 2,  800},
                         {3, 1, 1000}, {2, 1,  300},
                         {8, 1, 1650} };
         
         Dijkstra shortPath = new Dijkstra(edges, 9);
         WriteLine("圖形以相鄰矩陣表示");
         shortPath.Display();
         shortPath.OneToAllPath(5);
         ReadKey();
      }
   }
}
