using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0601
{
   //以陣列結構實作佇列
   class Queue
   {
      protected int[] list = new int[10];  //儲存佇列項目
      public int Rear { get; set; } = -1;  //指向佇列後端的參考
      public int Front { get; set; } = 0;  //指向佇列前端的參考

      //定義成員方法，把資料從佇列後端存入
      public void Enqueue(int data)
      {
         try
         {
            Rear++;               //參考Rear向後移動
            list[Rear] = data;    //把項目存入佇列
         }
         catch(IndexOutOfRangeException ex)when(Rear >= 10)
         {
            //超出陣列範圍輸出錯誤訊息
            WriteLine(ex.Message);
         }
      }

      //定義成員方法，把資料從佇列前端移除再變更Front參考
      public void Dequeue()
      {
         if (Front == Rear)    //檢查佇列是否是空的
            WriteLine("空的佇列，無法刪除項目");
         else
         {
            //呼叫Array類別來移除陣列第一個項目
            Array.Clear(list, Front, 1);
            Front++;          //參考Front向後移動
         }
      }

      //定義成員方法，輸出佇列項目
      public void Display()
      {
         for (int j = 0; j < list.Length; j++)
            Write($"{list[j], 4}");
         WriteLine();
         WriteLine($" Rear = {Rear}, Front = {Front}");
      }
   }
}
