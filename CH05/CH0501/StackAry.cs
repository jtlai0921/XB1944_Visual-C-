using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0501
{
   class StackAry
   {
      //屬性Name 儲存名稱, Index取得陣列位置，兩者皆採自動實做並設初值 
      public string[] Name { get; set; } = new string[5];
      private string name;
      public int Index { get; set; } = 0;

      //將元素從堆疊頂端壓入
      public void PushItem(string data)
      {
         if (Index <= Name.Length)
         {
            Name[Index] = data;  //將元素存入堆疊內
            Index++;  //向頂端移動
         }
         else
         {
            WriteLine("堆疊已滿");
         }
      }

      //將元素從堆疊頂端彈出
      public void PopItem()
      {
         if (Index > 0)
         {
            Index--;   //向底部移動
            WriteLine($"{Name[Index]} 被移除");
         }
         else
            WriteLine("堆疊已空");
      }

      //輸出堆疊項目
      public void Display()
      {
         if (Index <= 0)
            WriteLine("堆疊是空的");
         else
         {
            Write($"堆疊項目：");
            for(int j = 0; j < Index; j++)
               Write($"{Name[j], 7},");
         }
         WriteLine();
      }
   }
}
