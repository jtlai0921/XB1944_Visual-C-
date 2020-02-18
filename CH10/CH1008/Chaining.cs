using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH1008
{
   class Chaining
   {
      const int PRIME = 13; //設定質數
      readonly Node[] hash = new Node[PRIME];  //儲存雜湊值的雜湊表

      //清空雜湊表，將串列的節點初始化為null
      public Chaining()
      {
         for (int j = 0; j < PRIME; j++)
            hash[j] = null;
      }

      //建立雜湊函數-採用運算式主體-依傳入值取得餘數
      public int RunHash(int num) => num % PRIME;

      //定義方法-產生雜湊表
      public void CreateHT(int key)
      {
         Node ptr = new Node();
         Node newNode = new Node   //初始化start節點
         {
            Item = key, Next = null
         };

         int pos = RunHash(key);  //呼叫雜湊函數取得位置
         ptr = hash[pos];

         if (ptr != null)
         {
            newNode.Next = ptr;  //目前節點參考ptr指向新節點的下一個節點
            hash[pos] = newNode; //新節點資料存入hast陣列
         }
         else
            hash[pos] = newNode; //以新節點為首節點
      }

      //定義方法查找鍵值回到位置pos
      public int SearchHash(int key)
      {
         Node ptr;
         int pos = RunHash(key);         
         ptr = hash[pos];

         //沒有找到就回傳-1
         if (ptr == null)
            return -1;

         while (ptr.Next != null && ptr.Item != key)
            ptr = ptr.Next;

         return pos;
      }

      //輸出串列內容
      public void Display()
      {
         Node ptr;

         for (int j = 0; j < PRIME; j++)
         {
            Write($"\n[{j, 2}] -> ");
            ptr = hash[j];
            while (ptr != null)
            {
               Write($"|{ptr.Item, 3}|");
               ptr = ptr.Next;
            }            
         }
      }
   }
}
