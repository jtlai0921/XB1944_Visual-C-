using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//for讀取陣列元素
namespace CH0303
{
   class SingleArray
   {
      static void Main(string[] args)
      {
         int total = 0;
         //宣告一維陣列並配置記憶體
         int[] score = new int[5];
         score[0] = 78;
         //方法SetValue()指定陣列元素和位置
         score.SetValue(95, 1);
         score.SetValue(68, 2);
         score.SetValue(84, 3);
         score.SetValue(97, 4);

         Write("分數：");
         //for廻圈讀取陣列並把分數加總
         for (int j = 0; j <= score.GetUpperBound(0); j++)
         {
            //方法GetValue()取得指定位置的值
            Write($"{score.GetValue(j), 4}");
            total += score[j];
         }
         WriteLine($"\n分數合計 = {total}");

         ReadKey();
      }
   }
}
