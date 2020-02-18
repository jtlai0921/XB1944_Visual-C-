using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0602
{
   //以鏈結串列實作佇列
   public class Queue
   {
      protected Node Front { get; set; } = null;
      protected Node Rear { get; set; } = null;

      //定義成員方法來新增佇列項目
      public void Enqueue(int data)
      {
         Node newNode = new Node(data)
               { Item = data, Next = null };//產生新節點
         //如果佇列是空的，將Front參考指向新節點，而Rear指向新節點
         if (Rear == null)
         {
            Front = newNode;
            Rear = Front;
         }
         //把原為末節點的Next參考指向新節點
         Rear.Next = newNode;
         //再把Rear參考指向新節點
         Rear = newNode;
      }

      //定義方法來移除佇列項目
      public int Dequeue()
      {
         int number;
         Node current = Front;  //指向目前節點的參考為頂端節點
         if (Front == null) throw
                new InvalidOperationException("空白佇列");
         else   //佇列有節點的情形下才做刪除
         {
            //取得刪除節點的值給變數number儲存
            number = Front.Item;
            //Front參考指向第二個節點
            Front = current.Next;
         }
         return number;
      }

      //定義方法回傳佇列前端項目
      public int Peek()
      {
         if (Front == null) throw 
               new InvalidOperationException("空白佇列");
         return Front.Item;
      }

      //輸出佇列內容
      public void Display()
      {
         Node current = Front;   //指向目前節點的參考為頂端節點
         WriteLine("--佇列項目--");
         //走訪串列的節點並取得節點的資料
         while (current != null)
         {
            Write($"[{current.Item}]<-");
            current = current.Next;
         }
         Write($"\nFront = {Front.Item}, Rear = {Rear.Item}");
         WriteLine();
      }
   }
}
