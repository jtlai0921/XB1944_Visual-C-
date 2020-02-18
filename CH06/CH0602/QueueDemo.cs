using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0602
{
   class QueueDemo
   {
      static void Main(string[] args)
      {
         Queue list = new Queue();
         int[] data = { 78, 344, 65, 126 };

         foreach (int item in data)
            list.Enqueue(item);
         list.Display();
         WriteLine($"回傳佇列前端項目：{list.Peek()}");
         WriteLine($"刪除佇列前端項目：{list.Dequeue()}");
         list.Display();
         ReadKey();
      }
   }
}
