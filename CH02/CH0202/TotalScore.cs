using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0202
{
   class TotalScore
   {
      static void Main(string[] args)
      {
         int total = 0;
         int[] score = {98, 72, 65};
 
         //foreach廻圈讀取陣列元素
         foreach (int item in score)
            total += item; 
         WriteLine($"分數 {total}");

         ReadKey();
      }
   }
}
