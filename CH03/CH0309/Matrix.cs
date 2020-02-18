using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;//滙入靜態類別

//兩個矩陣相加
namespace CH0309
{
   class Matrix
   {
      static void Main(string[] args)
      {
         int[,] ary1 = new int[3, 3]
            {{5, 3, 2}, {11, 7, 13}, {9, 13, 15}};
         int[,] ary2 = new int[3, 3]
            {{1, 6, 8}, {4, 12, 16}, {9, 18, 21}};

         int[,] ary3 = new int[3, 3];//空的陣列, 儲存ary1, ary2相加結果

         int k, j;
         for (k = 0; k < ary1.GetLength(0); k++) //讀取ary1陣列的列數
         {
            for (j = 0; j < ary1.GetLength(1); j++) //讀取ary1陣列的欄數         
               Write($"{ary1[k, j],3}|");   //輸出ary1

            var result = (k == 1) ? " + " : "   ";
            Write($"{result}");

            for (j = 0; j < ary2.GetLength(1); j++)
               Write($"{ary2[k, j],3}|");   //輸出ary2

            result = (k == 1) ? " = " : "   ";
            Write($"{result}");

            for (j = 0; j < ary3.GetLength(1); j++)
            {
               //將ary1, ary2兩個陣列相加
               ary3[k, j] = ary1[k, j] + ary2[k, j];
               Write($"{ary3[k, j],3}|");
            }
            WriteLine();
         }

         ReadKey();
      }
   }
}
