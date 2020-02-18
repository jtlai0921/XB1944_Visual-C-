using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0606
{
   class QLinkedListDemo
   {
      static void Main(string[] args)
      {
         int choice, num;
         QLinkedList deque = new QLinkedList();
         int[] data = { 11, 22, 33, 44 };

         //讀取陣列
         Write("原有陣列--> ");
         foreach (int item in data)
            Write($"{item, 3}");
         WriteLine();
         string line = new string('*', 32);
         while (true)
         {
            WriteLine(line);
            WriteLine(" <1> 佇列 前端 新增 項目");
            WriteLine(" <2> 佇列 後端 新增 項目");
            WriteLine(" <3> 刪除 佇項 後端項目");
            WriteLine(" <4> 列印 佇項項目");
            WriteLine(" <5> 退出");
            WriteLine(line);
            Write(" --請輸入選項-->... ");
            choice = int.Parse(ReadLine());
            switch (choice)
            {
               case 1:
                  foreach(int item in data)
                     deque.HeadEnqueue(item);
                  Write("輸入新值 --> ");
                  num = int.Parse(ReadLine());
                  deque.HeadEnqueue(num);
                  break;
               case 2:
                  Write("輸入新值 --> ");
                  num = int.Parse(ReadLine());
                  deque.TailEnqueue(num); break;
               case 3:
                  deque.Dequeue(); break;
               case 4:
                  deque.Display(); break;
               case 5: Environment.Exit(0); break;
            }
         }
      }
   }
}
