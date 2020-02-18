using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//定義環狀單向類別
namespace CH0404
{
   public class CircularLinkedList
   {
      protected Node first;

      //定義預設建構函式--初始化第一個節點為空值
      public CircularLinkedList()
      {
         first = null;
      }

      //case 1 -- 輸出節點
      public void Display()
      {
         Node current;   //指向目前節點
         
         if (first == null)
            WriteLine("鏈結串列是空的");
         else
         {
            current = first; //從第一個節點開始準備走訪串列
            
            //串列有節點的情形下才讀取節點
            while (current != null)
            {
               Write($"[{current.Item}]->");
               current = current.Next;
               if (current == first)
                  break;
            }
            WriteLine();
         }
      }

      //直接以陣列產生鏈結串列
      public void CreateList()
      {
         //產生一維陣列並初始化
         int[] number = new int[4] { 65, 124, 43, 255 };

         //讀取陣列元素，並呼叫成員方法AddList()將元素加至串列最後節點處
         foreach (int n in number)
            AddLast(n);
      }      

      //case 2 -- 新增節點到第一個節點之前
      public void AddFirst(int data)
      {
         //產生新節點newNode，把新節點參考Next指向第一個節點first
         Node newNode = new Node(data) { Next = first };
         //目前節點的參考指向第一個節點
         Node current = first;
         if (first == null)
            newNode.Next = newNode;
         else
         {
            //1.目前節點的參考未指向第一個節點的情形下才走訪
            while (current.Next != first)
               current = current.Next;
            //2.目前節點的Next參考指向新節點
            current.Next = newNode;
         }
         first = newNode;   //3.設新節點為第一個節點
      }

      //case 3 -- 新增節點到最後一個節點之後
      public void AddLast(int data)
      {
         //指向目前節點的參考current
         Node current;

         //如果第一個節點first是空的，就把新節點設為第一個節點
         if (first == null)
         {
            first = new Node(data);
            first.Next = first;
         }
         else   //有第一個節點就以while廻圈走訪
         {
            Node newNode = new Node(data);
            current = first;
            //走訪串列到最後節點
            while (current.Next != first)
               current = current.Next;
            //1.目前節點的Next指標指向新節點
            current.Next = newNode;
            //2.新節點的Next指標指向第一個節點
            newNode.Next = first;
         }
      }

      //case 4 -- 刪除 指定節點
      public void RemoveAt(int data)
      {
         Node current, previous;
         //若第一個節點被刪除，指定下一個節點為第一個節點
         if (first.Item == data)
         {
            current = first;
            while (current.Next != first)
               current = current.Next;
            WriteLine($"節點[{first.Item}]已被移除");
            //1.將目前節點Next鏈結指向第二個節點
            current.Next = first.Next;
            //2.變更第二個節點為第一個節點
            first = first.Next;
         }
         else //情形二：首節點以外的節點要被刪除
         {
            current = first;
            //目前節點的Next指標未指向第一個節點情形做走訪
            while(current.Next != first)
            {
               previous = current; //從目前節點的前一個節點開始
               current = current.Next;
               if(current.Item == data)
               {
                  //1.被刪節點的前一個節點，其Next鏈結指向被刪節點的下一個節點
                  previous.Next = current.Next;
                  //2.移向下一個節點
                  current = current.Next;
               }
            }
         }
      }
   }
}
