using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0504
{
   class StackLinkedDemo
   {
      static void Main(string[] args)
      {
         LinkedList list = new LinkedList();
         int data, option;
         while(true)
         {
            WriteLine(" **** 堆疊的操作 ****");
            WriteLine("1. PUSH");
            WriteLine("2. POP");
            WriteLine("3. PEEK");
            WriteLine("4. DISPLAY");
            WriteLine("5. EXIT");
            Write("--請選取項目--> ");
            option = int.Parse(ReadLine());
            switch (option)
            {
               case 1:
                  Write("輸入數值--> ");
                  data = Convert.ToInt32(ReadLine());
                  list.PushItem(data);
                  break;
               case 2:
                  list.PopItem(); break;
               case 3:
                  data = list.PeekItem();
                  if (data != -1)
                     WriteLine($"堆疊頂端元素 [{data}]");
                  else
                     WriteLine("堆疊是空的");
                  break;
               case 4:
                  list.Display(); break;
               case 5:
                  //結束執行程序
                  Environment.Exit(0); break;
            }
         }         
      }
   }
}
