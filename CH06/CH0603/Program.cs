using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0603
{
   class Program
   {
      static void Main(string[] args)
      {
         Queue<string> queue = new Queue<string>();

         string[] weeks = {
            "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

         foreach (string item in weeks)
            queue.Enqueue(item); //將項目新增佇列尾端

         WriteLine("--佇列項目--");
         foreach (string item in queue)
            Write($"{item,6}");

         WriteLine($"\n佇列有 {queue.Count} 個節點");
         WriteLine($"佇列的首節點：{queue.Peek(), 7}");
         WriteLine($"移除佇列的首節點：{queue.Dequeue()}");
         WriteLine($"移除佇列的首節點：{queue.Dequeue()}");
         WriteLine($"目前佇列有 {queue.Count} 個節點");

         ReadKey();
      }
   }
}
