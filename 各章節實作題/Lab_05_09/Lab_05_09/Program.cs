using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab_05_09
{
   class Program
   {
      static void Main(string[] args)
      {
         int[] ary = { 11, 22, 33, 44, 55, 66 };
         WriteLine("--讀取陣列--");
         for (int j = 0; j < 6; j++)
            Write($"{ary[j]} ");
         WriteLine();

         WriteLine("\n**呼叫遞廻反轉陣列**");
         Reverst(ary, 0);
         
         ReadKey();
      }

      public static void Reverst(int[] ary, int num)
      {
         if (num < ary.Length)                     //終止條件 
         {
            //遞廻串列列印函數呼叫
            Reverst(ary, num + 1);
            Write($"{ary[num]} ");
         }
      }
   }
}
