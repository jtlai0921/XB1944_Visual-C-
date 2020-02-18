using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0608
{
   class Program
   {
      static void Main(string[] args)
      {       
         CircularLinked list = new CircularLinked();
         int[] data = { 28, 67, 8, 31, 57, 100, 30, 73, 43, 54 };
         foreach (int item in data)
            list.Enqueue(item);
         WriteLine("環狀鏈結串列：");
         list.Display();
         list.Josephus(10, 3);
         WriteLine();
         Write("勝出節點-->");
         list.Display();

         ReadKey();
      }
   }
}
