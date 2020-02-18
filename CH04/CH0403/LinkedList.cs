using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0403
{
   public class LinkedList
   {
      protected Node first;

      //定義預設建構函式--初始化第一個節點為空值
      public LinkedList()
      {
         first = null;
      }

      //直接以陣列產生鏈結串列
      public void CreateList()
      {
         //產生一維陣列並初始化
         int[] number = new int[4]{ 65, 124, 43, 255 };
         //讀取陣列元素，並呼叫成員方法AddList()將元素加至串列最後節點處
         foreach(int n in number)
            AddLast(n);
      }

      //case 4 -- 新增節點到第一個節點之前
      public void AddFirst(int data)
      {
         //1.產生新節點newNode，把新節點指標Next指向第一個節點first
         Node newNode = new Node(data) { Next = first };
         //2.變更新節點為第一個節點
         first = newNode;
      }

      //case 5 -- 新增節點到最後一個節點之後
      public void AddLast(int data)
      {
         //指向目前節點的參考current, new運算子實體化新節點newNode
         Node current;
         Node newNode = new Node(data);

         //如果第一個節點first是空的，就把新節點設為第一個節點
         if (first == null)
            first = newNode;
         else //有第一個節點就走訪
         {
            current = first;
            while (current.Next != null)//走訪串列到最後節點
               current = current.Next;
            //目前節點的Next參考指向新節點
            current.Next = newNode;
         }
      }

      //case 6 -- 新節點加到指定節點之後
      public void InsertBehind(int data, int special)
      {
         Node ptr = first; //把參考ptr指向第一個節點

         while(ptr != null)//走訪串列查找指定節點
         {
            if (ptr.Item == special)
               break;
            ptr = ptr.Next;
         }

         if (ptr == null)
            WriteLine($"串列中沒有節點[{special}]");
         else
         {
            //1.產生新節點newNode，把新節點指標Next指向目前節點ptr的下一個節點
            Node newNode = new Node(data){ Next = ptr.Next };
            //2.目前節點ptr的指標Next指向新節點
            ptr.Next = newNode;
         }
      }

      //case 7 -- 新節點加到指定節點之前
      public void InsertAhead(int data, int special)
      {
         Node newNode;   //新節點

         //如果是空串列就不用再查找
         if (first == null)
            WriteLine("鏈結串列是空的！");

         //情形一：如果指定節點是第一個節點
         if (special == first.Item)
            AddFirst(data);

         //情形二：指定節點非第一個節點，以while廻圈走訪串列，找出指定節點的前一個節點
         else
         {
            Node ptr = first;//目前指標指向第一個節點，準備走訪
            while (ptr.Next != null)
            {
               //找到指定節點的前一個
               if (ptr.Next.Item == special)
                  break;
               ptr = ptr.Next;
            }

            //確認目前節點Next指向下一個節點是存在的，加入新節點
            if (ptr.Next == null)
               WriteLine($"串列裡無此節點[{special}]");
            else
            {
               //1.產生新節點newNode，把新節點指標Next指向目前節點ptr的下一個節點
               newNode = new Node(data) { Next = ptr.Next };
               //2.變更目前節點的Next指標指向新節點
               ptr.Next = newNode;
            }
         }
      }

      //case 8 -- 指定位置加入新節點，原有節點向後移動
      public void InsertAt(int data, int pos)
      {
         Node newNode;   //新點節
         int j;

         //指定位置是第一個節點，新增節點到第一個節點之前，變成第一個節點
         if (pos == 1)
            AddFirst(data);//呼叫方法加到第一個節點之前         
         else  //找到指定位置的前一個節點(pos - 1)來新增節點
         {            
            Node ptr = first;   //目前參考指向新節點
            for (j = 1; j < pos - 1 && ptr != null; j++)
               ptr = ptr.Next;

            //新節點加到指定位置
            if (ptr == null)
               WriteLine($"只有位置{j}可插入");
            else
            {
               //1.產生新節點newNode，把新節點指標Next指向目前節點Next指標所指的下一個節點
               newNode = new Node(data) { Next = ptr.Next };
               //2.目前節點Next指標指向新節點
               ptr.Next = newNode;
            }
         }
      }

      //case 9 -- 刪除第一個節點
      public void RemoveFirst()
      {
         //若第一個節點被刪除，指定下一個節點為第一個節點
         if (first == null)
            return;
         first = first.Next;
      }
 
      //case 10 -- 刪除最後一個節點
      public void RemoveLast()
      {
         if (first == null)
            WriteLine("串列是空的");

         else if(first.Next == null)
            first = null;
         
         else
         {
            Node ptr = first;   //目前指標指向第一個節點
            while (ptr.Next.Next != null)
               ptr = ptr.Next;
            ptr.Next = null;   //刪除最後節點，Next設為null
         }
      }
 
      //case 11 -- 刪除指定節點
      public void RemoveAt(int data)
      {
         if(first == null)
            WriteLine("串列是空的...");

         //第一個節點被刪除
         if(first.Item == data)
            first = first.Next;
         else //刪除第一個節點之外的其他節點
         {
            Node ptr = first;

            //走訪串列來查找欲刪除節點
            while (ptr.Next != null)
            {
               //下一個節點的資料符合欲刪除節點
               if (ptr.Next.Item == data)
                  break;
               ptr = ptr.Next;
            }
            if (ptr.Next == null)
               WriteLine($"串列無此節點[{data}]");
            else   //目前所在節點的Next指標指向被刪除節點的下一個節點
               ptr.Next = ptr.Next.Next;
         }
      }

      //反轉串列元素
      public void RevertNode()
      {
         Node previous = null, current; //previous為上一個節點

         while (first != null)
         {
            current = first;          //由第一個節點開始走訪
            first = current.Next;     //移向下一個節點
            current.Next = previous;  //目前節點current的Next指標指向上一個節點
            previous = current;       //目前指標指向前一個節點
         }
         first = previous;
      }

      //case 2 -- 統計鏈結串列節數
      public void NodeSize()
      {
         int num = 0;
         Node ptr = first;
         while(ptr != null)
         {
            num++;
            ptr = ptr.Next;
         }
         WriteLine($"節點數：{num}");
      }

      //case 3 -- 走訪串列查找節點
      public bool FindNode(int data)
      {
         int pos = 1;         //設第一個節點的位置編號為1
         Node ptr = first;    //目前指標ptr指向第一個節點

         //串列有節點的情形下才走訪
         while(ptr != null)
         {
            if (ptr.Item == data)
               break;         //找到節點的話就中斷程式
            pos++;            //記錄位置
            ptr = ptr.Next;   //移向下一個節點
         }

         if(ptr == null)      //空的串列就不會再查找
         {
            WriteLine($"未發現節點[{data}]");
            return false;
         }
         else
         {
            WriteLine($"節點[{data}]的位置是 {pos}");
            return true;
         }         
      }
 
      //case 1 -- 輸出節點
      public void Display()
      {
         Node current;   //指向目前節點
         if(first == null)
            WriteLine("鏈結串列是空的");
         current = first; //從第一個節點開始準備走訪串列

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
