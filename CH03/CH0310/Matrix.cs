using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//兩個矩陣相乘
namespace CH0310
{
   class Matrix
   {
      static void Main(string[] args)
      {
         int j, k;
         //宣告兩個矩陣ary1, ary2並初始化
         int[,] ary1 = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
         int[,] ary2 = new int[2, 3] { { 7, 9, 11 }, { 8, 10, 12 } };
         int[,] ary3;
         //使用關鍵字ref須將矩陣ary1, ary2初始化，實際引數和形式參數都要有
         MatrixMulti(ref ary1, ref ary2, out ary3);

         //讀取矩陣ary3 - 相乘結果
         for (j = 0; j < 3; j++)
         {
            for (k = 0; k < 3; k++)
               Write($"{ary3[j, k],4}|");
            WriteLine();
         }
         ReadKey();
      }

      //定義靜態方法，將兩個矩陣相乘 
      public static void MatrixMulti(ref int[,] matrix1,
            ref int[,] matrix2, out int[,] matrixR)
      {
         //關鍵字out須在方法內將矩陣matrixR配置記憶體
         matrixR = new int[3, 3];
         int j, k, m;
         //取得每個矩陣的列、欄數
         int ary1col = matrix1.GetLength(1);
         int ary2col = matrix2.GetLength(1);
         int rows = matrixR.GetLength(0);//列數

         for (j = 0; j < rows; j++)
         {
            for (k = 0; k < ary2col; k++)
            {
               for (m = 0; m < ary1col; m++)
                  matrixR[j, k] += matrix1[j, m] * matrix2[m, k];
            }
         }
      }
   }
}
