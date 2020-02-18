using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0801
{
   class Program
   {
      static int[,] matrix = new int[5, 5];//二維矩陣
      static void Main(string[] args)
      {
         int j, k;
         int[,] data = {{1, 2}, {2, 1}, {1, 3}, {3, 1},
                        {2, 4}, {4, 2}, {3, 4}, {4, 3}};

         GraphCreate(data, data.GetLength(0));

         WriteLine("圖形以相鄰矩陣儲存");
         WriteLine("-----1--2--3--4");
         for (j = 1; j < 5; j++)
         {
            Write($"{j} |");
            for (k = 1; k < 5; k++)
               Write($"{matrix[j, k], 3}");
            WriteLine();
         }
         ReadKey();
      }

      //定義靜態方法來表示圖形
      public static void GraphCreate(int[,] ary, int len)
      {
         int start, finish, j;

         for (j = 0; j < len; j++)
         {
            start = ary[j, 0];
            finish = ary[j, 1];
             matrix[start, finish] = 1;
         }
         WriteLine();
      }
   }
}
