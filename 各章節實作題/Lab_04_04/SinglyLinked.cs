using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab_04_04
{
   //實作單向鏈結串列
   public class SinglyLinked
   {
      private Node first;//指向第一個節點的參考
      public int Count { get; set; } = 0;//統計節點數

      public int Size() => Count;//回傳節點數

      //新增節點到第一個節點之前
      public void AddFirst(int data)
      {
         first = new Node(data) { Next = first };
         Count++;
      }

      //輸出鏈結串列的節點
      public void Display()
      {
         Node current = first;
         while (current != null)
         {
            Write($"{current.Item} -> ");
            current = current.Next;
         }
         WriteLine();
      }
   }
}
