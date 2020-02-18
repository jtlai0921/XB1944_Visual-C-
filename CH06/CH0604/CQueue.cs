using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0604
{
   class CQueue
   {
      private static readonly int maxSize = 6;  //佇列最大空間
      protected int[] list = new int[maxSize];  //儲存佇列項目
      
      public int Rear { get; set; } =  0;  //指向佇列後端的參考
      public int Front { get; set; } = 0;  //指向佇列前端的參考
      public int Count { get; set; }       //計算佇列的項目數

      //定義方法-判斷是否為空的佇列，使用運算式主體
      public bool IsEmpty() => Count == 0;

      //定義方法-判斷是否為滿的佇列，使用運算式主體
      public bool IsFull() => Count == maxSize;

      //定義成員方法，把資料從佇列後端存入
      public void Enqueue(int data)
      {
         if (!IsFull())
         {
            list[Rear] = data;
            Rear = (Rear + 1) % maxSize;
            Count++;
         }
         else
               WriteLine("佇列已滿");
      }

      //定義成員方法，把資料從佇列前端移除再變更Front參考
      public void Dequeue()
      {
         if (IsEmpty())
            WriteLine("空的佇列，無法刪除項目");
         else
         {
            WriteLine($"項目[{list[Front]}]已移除");
            Front = (Front + 1) % maxSize;
            Count--;
         }
      }

      //定義成員方法，輸出佇列項目
      public void Display()
      {
         for (int j = Front; j < Count + Front; j++)
            Write($"{list[j % maxSize],4}");
         WriteLine();
         WriteLine($" Count = {Count}, Rear = {Rear}, Front = {Front}");
      }
   }
}
