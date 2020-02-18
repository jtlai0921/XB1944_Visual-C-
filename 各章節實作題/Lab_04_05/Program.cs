using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//第四章實作<5>
namespace Lab_04_05
{
   class Program
   {
      static void Main(string[] args)
      {
         int key, opt;
         bool target;
         CircularLinked list = new CircularLinked();

         int[] data = { 78, 122, 43, 517, 63 };
         foreach (int item in data)
            list.AddLast(item);
         string line = new string('*', 30);
 
         while (true)
         {
            WriteLine("1. 輸出鏈結串列節點");
            WriteLine("2. 節點 新增 最後節點 之後");
            WriteLine("3. 查找 節點");
            WriteLine("4. 刪除 第一個節點");
            WriteLine("5. 結束選單");
            WriteLine(line);

            Write("--請選取項目--> ");
            opt = int.Parse(ReadLine());

            switch (opt)
            {
               case 1: list.Display(); break;

               case 2:
                  Write("輸入新值--> ");
                  key = int.Parse(ReadLine());
                  list.AddLast(key);
                  break;

               case 3:
                  Write("輸入欲查找節點--> ");
                  key = int.Parse(ReadLine());
                  target = list.FindNode(key);
                  if (target == false) WriteLine("無此節點");
                  //else WriteLine($"節點[{key}]的位置是 {target} ");
                  break;

               case 4:
                  list.RemoveFirst(); break;

               case 5:
                  //結束執行程序
                  Environment.Exit(0); break;
            }
            WriteLine();
         }
      }
   }
}
