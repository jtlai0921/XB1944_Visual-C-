using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//將矩陣轉置
namespace CH0311
{
   class Matrix
   {
      static void Main(string[] args)
      {
         int j, k;
         int[,] ary1 = new int[3, 4]
               {{11, 12, 13, 14},
                {22, 24, 26, 28},
                {33, 36, 39, 41}};
         int[,] ary2 = new int[4, 3];
         int rw = ary1.GetLength(0);   //列
         int col = ary1.GetLength(1);  //欄

         WriteLine("------原來矩陣------");
         for (j = 0; j < rw; j++)
         {
            for (k = 0; k < col; k++)
               Write($"{ary1[j, k],4}|");
            WriteLine();
         }

         Transpose(ref ary1, ref ary2, rw, col);
         WriteLine("\n--轉置後矩陣--");
         for (j = 0; j < col; j++)
         {
            for (k = 0; k < rw; k++)
               Write($"{ary2[j, k],4}");
            WriteLine();
         }
         ReadKey();
      }

      //靜態方法轉置矩陣 
      static void Transpose(ref int[,] ary1, ref int[,] ary2,
            int rows, int cols)
      {
         int j, k;
         for (j = 0; j < rows; j++)
         {
            for (k = 0; k < cols; k++)
               ary2[k, j] = ary1[j, k];
         }
      }
   }
}
