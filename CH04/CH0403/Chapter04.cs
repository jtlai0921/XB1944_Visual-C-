using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0403
{
   class Chapter04
   {
      static void Main(string[] args)
      {
         int opt, num, pos;
         LinkedList list = new LinkedList();         
         list.CreateList();
         string line = new string('-', 25);
         WriteLine(line);
         while(true)
         {
            WriteLine(" 1. 輸出鏈結串列節點");
            WriteLine(" 2. 統計鏈結串列節點");
            WriteLine(" 3. 搜尋 節點");
            WriteLine(" 4. 新節點插到 第一個節點 之前");
            WriteLine(" 5. 新節點插到 最後節點 之後");
            WriteLine(" 6. 新節點插到 指定節點 之後");
            WriteLine(" 7. 新節點插到 指定節點 之前");
            WriteLine(" 8. 新節點插到 指定位置");
            WriteLine(" 9. 刪除第一個節點");
            WriteLine("10. 刪除最後一個節點");
            WriteLine("11. 刪除 指定節點");
            WriteLine("12. 反轉 串列節點");
            WriteLine("99. 結束選單");
            WriteLine(line);

            Write("--請選取項目--> ");
            opt = int.Parse(ReadLine());            

            switch(opt)
            {
               case 1 : list.Display(); break;
               case 2 : list.NodeSize(); break;
               case 3 :
                  Write("輸入欲查找節點--> ");
                  num = int.Parse(ReadLine());
                  list.FindNode(num);
                  break;
               case 4 :
                  Write("輸入新值--> ");
                  num = int.Parse(ReadLine());
                  list.AddFirst(num);
                  break;
               case 5:
                  Write("輸入新值--> ");
                  num = int.Parse(ReadLine());
                  list.AddLast(num);
                  break;
               case 6:
                  Write("輸入新值--> ");
                  num = int.Parse(ReadLine());
                  Write("輸入欲指定節點--> ");
                  pos = Convert.ToInt32(ReadLine());
                  list.InsertBehind(num, pos);
                  break;
               case 7:
                  Write("輸入新值--> ");
                  num = int.Parse(ReadLine());
                  Write("輸入欲指定節點--> ");
                  pos = Convert.ToInt32(ReadLine());
                  list.InsertAhead(num, pos);
                  break;
               case 8:
                  Write("輸入新值--> ");
                  num = int.Parse(ReadLine());
                  Write("輸入欲指定位置--> ");
                  pos = Convert.ToInt32(ReadLine());
                  list.InsertAt(num, pos);
                  break;
               case 9 : list.RemoveFirst(); break;
               case 10 : list.RemoveLast(); break;
               case 11:
                  Write("輸入欲刪除節點--> ");
                  num = int.Parse(ReadLine());
                  list.RemoveAt(num);
                  break;
               case 12 : list.RevertNode();break;                  
               case 99:
                  //結束執行程序
                  Environment.Exit(0); break;
            }
            WriteLine();
         }         
         //ReadKey();
      }
   }
}
