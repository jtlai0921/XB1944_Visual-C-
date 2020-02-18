using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0607
{
   //單向鏈結串列實作優先佇列
   public class PriorityQueue
   {
      protected Node Front { get; set; } = null;//指向佇列前端參考

      //定義成員方法，佇列後端新增項目
      public Node Enqueue(int data, int precede)
      {
         Node ptr; //指向目前節點的參考
         Node newNode = new Node(data, precede)
            { Item = data, Prior = precede };
 
         //接收的權值會和佇列的權值做比較
         if (Front == null || precede < Front.Prior)
         {
            newNode.Next = Front;
            Front = newNode;
         }
         else
         {
            ptr = Front; //目前節點參考指向前端節點
            //走訪節點，且節點的優先權較小
            while (ptr.Next != null && 
                  ptr.Next.Prior <= precede)
               ptr = ptr.Next;
            //新節點的參考Next指向下一個節點
            newNode.Next = ptr.Next;
            //目前節點的參考指向新節點
            ptr.Next = newNode;
         }
         return Front;
      }

      //定義方法來移除佇列前端項目
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

      //輸出佇列內容
      public void Display()
      {
         Node ptr;
         ptr = Front;
         if (Front == null)
            WriteLine("空的佇列，無法輸出內容");
         else
         {
            WriteLine("---優先佇列---");
            while (ptr != null)
            {
               WriteLine($"{ptr.Item, 4}, 權值 = [{ptr.Prior}]");
               ptr = ptr.Next;
            }
         }
      }
   }
}
