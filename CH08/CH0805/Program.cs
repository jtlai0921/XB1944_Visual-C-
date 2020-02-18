using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0805
{
   class Program
   {
      static void Main(string[] args)
      {
         MSTree tree = new MSTree();
         WriteLine("讀取圖形取得長度");
         tree.CreateEdge();
         tree.MakeAdjust();
         tree.Display();
         tree.Kruskal();

         ReadKey();
      }
   }
}
