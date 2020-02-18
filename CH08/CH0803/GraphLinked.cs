using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0803
{
   //以單向鏈結串列實作圖形
   public class GraphLinked
   {
      public Node First { get; set; } = null;//指向第一個節點的參考
      public Node Last { get; set; } = null; //指向最後節點的參考

      //加入圖形的新節點
      public void AddItem(int data)
      {
         //new運算子產生新節點newNode並配置記憶體
         Node newNode = new Node(data);

         //如果第一個節點First是空的，就把新節點設為首、尾節點
         if (First == null)
         {
            First = newNode;
            Last = newNode;
         }
         else //有第一個節點就走訪
         {
            Last.Next = newNode;//把最後節點的Next參考指向新節點
            Last = newNode;//新節點變成最後節點
         }
      }
 
      //輸出鏈結串列節點
      public void Display()
      {
         Node current;   //指向目前節點
         if (First == null)
            WriteLine("鏈結串列是空的");
         current = First; //從第一個節點開始準備走訪串列

         //空串不是空的情形下讀取節點
         while (current != null)
         {
            Write($"[{current.Edge}]->");
            current = current.Next;
            if (current == null)
               Write("null");
         }
         WriteLine();
      }
   }
}
