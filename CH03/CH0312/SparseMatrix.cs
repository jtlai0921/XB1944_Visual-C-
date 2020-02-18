using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//將稀疏矩陣壓縮
namespace CH0312
{
   class SparseMatrix
   {
      static void Main(string[] args)
      {
         int[,] sparse = new int[5, 5]{
               { 0,  0,  0, 27,  0 },
               { 0,  0, 13,  0,  0 },
               { 0, 41,  0,  0, 36 },
               {52,  0,  9,  0,  0 },
               { 0,  0,  0, 18,  0 } };

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
         int[,] matrix = new int[8, 3];
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
