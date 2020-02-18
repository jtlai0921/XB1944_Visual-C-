using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0802
{
   //以單向鏈結串列實作圖形
   public class GraphicsLinked
   {
      protected Node first;//指向第一個節點的參考
      protected Node last; //指向最後節點的參考

      //定義預設建構函式--初始化第一個節點為空值
      public GraphicsLinked()
      {
         first = null;
         last = null;
      }

      //加入圖形的新節點
      public void AddItem(int data)
      {
         //new運算子產生新節點newNode並配置記憶體
         Node newNode = new Node(data);

         //如果第一個節點first是空的，就把新節點設為首、尾節點
         if (first == null)
         {
            first = newNode;
            last = newNode;
         }
         else //有第一個節點就走訪
         {
            last.Next = newNode;//把最後節點的Next參考指向新節點
            last = newNode;//新節點變成最後節點
         }
      }

      //輸出鏈結串列節點
      public void Display()
      {
         Node current;   //指向目前節點
         if (first == null)
            WriteLine("鏈結串列是空的");
         current = first; //從第一個節點開始準備走訪串列

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
