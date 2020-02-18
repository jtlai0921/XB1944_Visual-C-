using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0605
{
   class DQueueDemo
   {
      static void Main(string[] args)
      {
         int choice, num;
         DQueue deque = new DQueue();


         int[] data = { 11, 22, 33, 44 };

         foreach (int item in data)
            deque.Enqueue(item);
         deque.Display();

         string line = new string('*', 32);
         while (true)
         {
            WriteLine(line);
            WriteLine(" <1> 輸入 新項目");
            WriteLine(" <2> 刪除 佇列 前端項目");
            WriteLine(" <3> 刪除 佇列 後端項目");
            WriteLine(" <4> 列印 佇項項目");
            WriteLine(" <5> 退出");
            WriteLine(line);
            Write(" --請輸入選項-->... ");
            choice = int.Parse(ReadLine());
            switch (choice)
            {
               case 1:
                  Write("輸入新值--> ");
                  num = int.Parse(ReadLine());
                  deque.Enqueue(num); break;
               case 2:
                  deque.HeadDequeue(); break;
               case 3:
                  deque.TailDequeue(); break;
               case 4:
                  deque.Display(); break;
               case 5: Environment.Exit(0); break;
            }
         }
      }
   }
}
