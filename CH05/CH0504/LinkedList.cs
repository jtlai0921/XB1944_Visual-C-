using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0504
{
   public class LinkedList
   {
      protected Node Top;//指向堆疊頂端的參考

      //統計堆疊的項數數，屬性採自動實做並給初值
      public int Size { get; set; } = 0;
 
      //建構函式初始化頂端節為空值
      public LinkedList()
      { Top = null; }

      //從堆疊頂端壓入元素
      public void PushItem(int data)
      {
         //1.產生新節點newNode，把新節點參考Next指向頂端節點Top
         Node newNode = new Node(data) { Next = Top };
         //2.變更新節點為頂端節點
         Top = newNode;
         Size++;
      }

      //從堆疊頂端彈出項目
      public void PopItem()
      {
         Node ptr = Top;

         if (Top != null)
         {
            Top = Top.Next;
            WriteLine($"堆疊頂端彈出的項目 {ptr.Item}");
            Size--;
         }
         else
            WriteLine("堆疊是空的");
      }

      //回傳堆疊頂端元素
      public int PeekItem()
      {
         if (Top != null)
            return Top.Item;
         else
            return -1;
      }

      //輸出堆疊內容
      public void Display()
      {
         Node current = Top;   //指向目前節點的參考為頂端節點
         if (Top == null)
            WriteLine("鏈結串列是空的");
         else
         {
            //空串不是空的情形下讀取節點
            while (current != null)
            {
               Write($"[{current.Item}]->");
               current = current.Next;
            }
            WriteLine();
         }
      }
   }
}
