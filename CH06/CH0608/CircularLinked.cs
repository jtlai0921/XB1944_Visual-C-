using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0608
{
   //環狀單向鏈結串列實作佇列
   public class CircularLinked
   {
      protected Node First { get; set; } = null;//指向第一個節點的參考

      //case 4 -- 新增節點到最後一個節點之後
      public void Enqueue(int data)
      {
         //指向目前節點的參考current
         Node current;

         //如果第一個節點first是空的，就把新節點設為第一個節點
         if (First == null)
         {
            First = new Node(data);
            First.Next = First;
         }
         else   //有第一個節點就以while廻圈走訪
         {
            Node newNode = new Node(data);
            current = First;
            //走訪串列到最後節點
            while (current.Next != First)
               current = current.Next;
            //1.目前節點的Next指標指向新節點
            current.Next = newNode;
            //2.新節點的Next指標指向第一個節點
            newNode.Next = First;
         }
      }

      //Josephus問題
      public void Josephus(int len, int step)
      {
         Node ptr = First;
         WriteLine("移除節點");
         int count = 1;

         //由於有人出列，每次走訪後依count來變數節點數
         for (count = len; count > 1; count--)
         {
            for (int j = 0; j < step - 1; j++)
               ptr = ptr.Next;
            Write($"{ptr.Item,4}");
            RemoveAt(ptr);   //從串列中移除被淘汰者
            ptr = ptr.Next;
         }
      }

      //移除節點
      public void RemoveAt(Node key)
      {
         Node current, prev;
         if (First == key)//移除第一個節點
         {
            current = First;
            //移動指標
            while (current.Next != First)
               current = current.Next;
            //將目前節點的參考指向第二個節點
            current.Next = First.Next;
            //首節點變更為下一個節點
            First = First.Next;
         }
         else   //情形二：首節點以外的節點要被移除
         {
            current = First;
            prev = null;
            //移動指標找到刪除的節點
            while (current.Next != First)
            {
               prev = current;
               current = current.Next;
               if (current == key)
               {
                  //前一個節點的指標指向目前節點的下一個節點
                  prev.Next = current.Next;
                  current = current.Next;
               }
            }
         }
      }

      //輸出節點
      public void Display()
      {
         Node current = First;
         
         while (current != null)
         {
            Write($"{current.Item,4}");
            current = current.Next;
            if (current == First)
               break;
         }
         WriteLine();
      }
   }
}
