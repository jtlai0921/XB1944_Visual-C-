using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//第三章 實作題(三)
namespace Lab_03_03
{
   class CH03
   {
      static void Main(string[] args)
      {
         int[,] sparse = new int[5, 6]{
               { 0,  0, 24,  0,  0,  0 },
               { 0,  0,  0, 35,  0,  0 },
               {17,  0,  0,  0,  0, 58 },
               { 0,  0,  0,  0, 43,  0 },
               { 0, 62,  0,  0,  0,  0 } };

         //取得矩陣列數、欄數
         int rows = sparse.GetLength(0);
         int cols = sparse.GetLength(1);
         int nonZero = 0; //統計矩陣中非零項目
         int j, k;
         WriteLine("------稀疏陣列------");
         for (j = 0; j < rows; j++)
         {
            for (k = 0; k < cols; k++)
            {
               Write($"{sparse[j, k],3}|");
               if (sparse[j, k] != 0)
                  nonZero += 1;
            }
            WriteLine();
         }
         //處理稀疏矩陣
         int idx = 1;
         int[,] matrix = new int[76, 3];
         matrix[0, 0] = rows;
         matrix[0, 1] = cols;
         matrix[0, 2] = nonZero;

         //依據稀疏矩陣來取得非零元素的列、欄索引和值
         for (j = 0; j < rows; j++)
         {
            for (k = 0; k < cols; k++)
            {
               if (sparse[j, k] != 0)
               {
                  matrix[idx, 0] = j + 1;
                  matrix[idx, 1] = k + 1;
                  matrix[idx, 2] = sparse[j, k];
                  idx += 1;
               }
            }
         }

         WriteLine("\n壓縮後的稀疏陣列");
         for (j = 0; j < nonZero + 1; j++)
         {
            for (k = 0; k < 3; k++)
               Write($"{matrix[j, k],4}|");
            WriteLine();
         }

         ReadKey();
      }
   }
}
