using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0305
{
   class TwoArray
   {
      static void Main(string[] args)
      {
         //宣告3*4二維陣列
         int[,] number = {{11, 12, 13, 14},
                          {21, 22, 23, 24},
                          {31, 32, 33, 34}};
         int j, k;
         //GetLength()方法取得第1、2維陣列
         int row = number.GetLength(0);
         int column = number.GetLength(1);

         WriteLine("******** for ********");
         //讀取列數
         for (j = 0; j < row; j++)
         {
            //讀取欄的元素
            for (k = 0; k < column; k++)
               Write($"{number[j, k], 4}|");
            WriteLine();
         }

         WriteLine("-------------- foreach --------------");
         foreach (int item in number)
            Write($"{item, 3}");
         ReadKey();
      }
   }
}
