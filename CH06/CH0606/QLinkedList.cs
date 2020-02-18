using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0606
{
   //以單向鏈結實作輸出限制性雙佇列
   public class QLinkedList
   {
      protected Node Front { get; set; } = null;//指向佇列前端參考
      protected Node Rear { get; set; } = null; //指向佇列後端參考

      //定義成員方法，佇列前端新增項目--等同把新節點加到首節點之前，成為串列首節點
      public void HeadEnqueue(int data)
      {
         //new運算子產生新節點newNode並配置記憶體，把資料存入佇列
         Node newNode = new Node(data) { Item = data};

         //如果沒有前端節點，就把新節點設為前端節點
         if (Front == null)          //是否是第一次存入
         {
            newNode.Next = null;
            Rear = newNode;         //Rear指向新節點
         }
         else
            //新節點的Next參考指向前端第一個節點
            newNode.Next = Front;
         //前端節點參考Front指向新節點
         Front = newNode;
      }

      //定義成員方法，佇列後端新增項目--等同把新節點加到末節點之後，成為串列末節點
      public void TailEnqueue(int data)
      {
         Node newNode = new Node(data)
         { Item = data, Next = null };//產生新節點
         //如果佇列是空的，將Front參考指向新節點，而Rear指向新節點
         if (Rear == null)
            Front = newNode;

         //把原為末端節點的Next參考指向新節點
         Rear.Next = newNode;
         //再把Rear參考指向新節點
         Rear = newNode;
      }

      //定義方法來移除佇列項目--等同把串列的首節點移除
      public void Dequeue()
      {
         int number;
         Node current = Front;  //指向目前節點的參考為頂端節點
         if (Front == null) throw
                new InvalidOperationException("空白佇列");
         else   //佇列有節點的情形下才做刪除
         {
            //取得欲刪除節點的值給變數number儲存
            number = current.Item;
            //Front參考指向第二個節點
            Front = Front.Next;
            WriteLine($"前端節點[{number}]已移除");
         }
      }

      public void Display()
      {
         Node current;   //指向目前節點
         if (Front == null)
            WriteLine("鏈結串列是空的");
         current = Front; //從第一個節點開始準備走訪串列

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
