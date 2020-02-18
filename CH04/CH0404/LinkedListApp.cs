using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0404
{
   class LinkedListApp
   {
      static void Main(string[] args)
      {
         int opt, num, pos;
         CircularLinkedList list = new CircularLinkedList();
         list.CreateList();//產生環狀單向類別
         string line = new string('-', 25);
         WriteLine(line);
         while (true)
         {
            WriteLine("1. 輸出鏈結串列節點");            
            WriteLine("2. 新節點 插到 第一個節點 之前");
            WriteLine("3. 新節點 插到 最後節點 之後");            
            WriteLine("4. 刪除 指定節點");            
            WriteLine("5. 結束選單");
            WriteLine(line);

            Write("--請選取項目--> ");
            opt = int.Parse(ReadLine());

            switch (opt)
            {
               case 1: list.Display(); break;
               
               case 2:
                  Write("輸入新值--> ");
                  num = int.Parse(ReadLine());
                  list.AddFirst(num);
                  break;

               case 3:
                  Write("輸入新值--> ");
                  num = int.Parse(ReadLine());
                  list.AddLast(num);
                  break;

               case 4:
                  Write("輸入欲刪除節點--> ");
                  num = int.Parse(ReadLine());
                  list.RemoveAt(num); break;
               
               case 5:
                  //結束執行程序
                  Environment.Exit(0); break;
            }
            WriteLine();
         }         
      }
   }
}
