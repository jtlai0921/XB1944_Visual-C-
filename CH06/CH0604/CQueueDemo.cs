using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0604
{
   class CQueueDemo
   {
      static void Main(string[] args)
      {
         int choice, num;
         CQueue list = new CQueue();
         int[] data = {11, 22, 33, 44};

         foreach (int item in data)
            list.Enqueue(item);
         list.Display();

         string line = new string('*', 30);
         while (true)
         {
            WriteLine(line);
            WriteLine(" <1> 輸入 新項目  (Enqueue)");
            WriteLine(" <2> 刪除 佇項項目 (Dequeue)");
            WriteLine(" <3> 列印 佇項項目");
            WriteLine(" <4> 退出");
            WriteLine(line);
            Write(" --請輸入選項-->... ");
            choice = int.Parse(ReadLine());
            switch (choice)
            {
               case 1:
                  Write("輸入新值--> ");
                  num = int.Parse(ReadLine());
                  list.Enqueue(num); break;
               case 2:
                  list.Dequeue(); break;
               case 3:
                  list.Display(); break;
               case 4: Environment.Exit(0); break;
            }
         }
      }
   }
}
