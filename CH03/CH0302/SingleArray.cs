using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//foreach廻圈讀取陣列
namespace CH0302
{
   class SingleArray
   {
      static void Main(string[] args)
      {
         int[] score = { 98, 64, 71 };//宣告一維陣列並初始化

         Write("讀取陣列：");
         //foreach讀取陣列元素
         foreach (int item in score)
            Write($"{item, 4}");         

         //方法GetType()取得宣告陣列的型別
         Type aryType = score.GetType();
         WriteLine($"\n陣列型別 = {aryType}");         

         ReadKey();
      }
   }
}
