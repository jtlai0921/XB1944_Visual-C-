using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab_04_05
{
   //以巢狀類別實作單向環狀鏈結串列
   class CircularLinked
   {
      private Node first, last;
      
      //新增節點到最後一個節點之後
      public void AddLast(int data)
      {
         Node newNode = new Node(data);
         //如果最後節點last是空的，就把新節點設為第一個、最後節點
         if (last == null)
         {
            first = newNode;
            last = newNode;
         }
         else
         {
            //1.最後節點的Next參考指向新節點
            last.Next = newNode;
            //2.新節點鏈結Next指向最後節點
            newNode.Next = last;
            //3.最後節點參考指向新節點
            last = newNode;
         }
      }

      //定義成員方法-移除第一個節點
      public void RemoveFirst()
      {
         //若第一個節點被刪除，指定下一個節點為第一個節點
         Node current = first;
         
         while (current.Next != first)
            current = current.Next;
         WriteLine($"節點[{first.Item}]已被移除");
         //1.將目前節點Next鏈結指向第二個節點
         current.Next = first.Next;
         //2.變更第二個節點為第一個節點
         first = first.Next;
      }

      //定義成員方法-走訪串列查找節點
      public bool FindNode(int data)
      {
         int pos = 1;         //設第一個節點的位置編號為1
         Node ptr = first;    //目前指標ptr指向第一個節點
         if (first == null)
            return false;
         do   //串列有節點的情形下才走訪
         {
            if (ptr.Item == data)
            {
               WriteLine($"節點[{data}]的位置<{pos}>");
               return true;
            }
            pos++;            //記錄位置
            ptr = ptr.Next;   //移向下一個節點
         } while (ptr != null);
         return false; 
      }
      
      //定義成員方法-輸出串列的節點
      public void Display()
      {
         Node current;   //指向目前節點

         if (first == null)
            WriteLine("鏈結串列是空的");
         current = first; //從第一個節點開始準備走訪串列

         //串列有節點的情形下才讀取節點
         while (current != null)
         {
            Write($"[{current.Item}]->");
            current = current.Next;
            if (current == last)
               break;
         }
         WriteLine($"[{current.Item}] -> null");
      }
   }
}
