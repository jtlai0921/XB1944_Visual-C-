using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab_04_04
{
   //第4章-實作<4>
   class Program
   {
      static void Main(string[] args)
      {
         SinglyLinked list = new SinglyLinked();
         int[] data = { 13, 67, 445, 96, 513 };
         foreach (int item in data)
            list.AddFirst(item);
         list.Display();
         WriteLine($"總節點 : {list.Size()}");
         ReadKey();
      }
   }
}
