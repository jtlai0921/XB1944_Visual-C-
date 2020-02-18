using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0607
{
   class Program
   {
      static void Main(string[] args)
      {
         int choice, num, weight;
         PriorityQueue queue = new PriorityQueue();
         string line = new string('*', 22);
         while (true)
         {
            WriteLine(line);
            WriteLine(" <1> 新增 佇列 項目");
            WriteLine(" <2> 移除 佇列 項目");
            WriteLine(" <3> 列印 佇項項目");
            WriteLine(" <4> 退出");
            WriteLine(line);
            Write(" --請輸入選項-->... ");
            choice = int.Parse(ReadLine());
            switch (choice)
            {
               case 1:
                  Write("輸入新值 --> ");
                  num = int.Parse(ReadLine());
                  Write("輸入權值 --> ");
                  weight = int.Parse(ReadLine());
                  queue.Enqueue(num, weight);
                  break;
               case 2:
                  queue.Dequeue(); break;
               case 3:
                  queue.Display(); break;
               case 4: Environment.Exit(0); break;
            }
         }
      }
   }
}
