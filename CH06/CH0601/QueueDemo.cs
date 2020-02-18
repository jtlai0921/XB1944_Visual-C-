using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0601
{
   class QueueDemo
   {
      static void Main(string[] args)
      {
         int choice, num;
         Queue list = new Queue();
         int[] data = { 11, 21, 31, 41, 51, 61 };
         int len = data.Length;//取得陣列長度
         string line = new string('*', 30);
         while(true)
         {
            WriteLine(line);
            WriteLine(" <1> 產生 佇列 ");
            WriteLine(" <2> 輸入 新項目  (Enqueue)");
            WriteLine(" <3> 刪除 佇項項目 (Dequeue)");
            WriteLine(" <4> 列印 佇項項目");
            WriteLine(" <5> 退出");
            WriteLine(line);
            Write(" --請輸入選項-->... ");
            choice = int.Parse(ReadLine());
            switch (choice)
            {
               case 1:
                  for (int j = 0; j < len; j++)
                     list.Enqueue(data[j]);
                  break;
               case 2:
                  Write("輸入新值--> ");
                  num = int.Parse(ReadLine());
                  list.Enqueue(num); break;
               case 3:
                  list.Dequeue(); break;
               case 4:
                  list.Display(); break;
               case 5: Environment.Exit(0); break;
            }
         }
      }
   }
}
