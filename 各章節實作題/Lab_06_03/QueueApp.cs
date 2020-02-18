using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//第六章實作題<3>
namespace Lab_06_03
{
   class QueueApp
   {
      static void Main(string[] args)
      {
         QueueforStk queue = new QueueforStk();
         int[] data = { 12, 4, 36, 48, 60 };
         //新增項目到堆疊裡
         foreach (int item in data)
            queue.Enqueue(item);
         WriteLine("移除佇列項目");
         //連續移除三個項目
         for (int j = 0; j < 3; j++)
            Write($"{queue.Dequeue()} ");

         ReadKey();
      }
   }
}
