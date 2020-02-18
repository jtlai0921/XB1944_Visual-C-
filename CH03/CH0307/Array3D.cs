using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;//滙入靜態類別

namespace CH0307
{
   class Array3D
   {
      static void Main(string[] args)
      {
         //宣告三維陣列並初始化
         int[,,] arr3D = new int[2, 2, 3] {
            { { 11, 12, 13 }, { 22, 24, 26 } },
            { { 33, 35, 37 }, { 44, 46, 48 } } };

         Write($"元素：{arr3D[1, 1, 1]}, " +
               $"第2個表格，位於第2列 第2欄\n");

         //GetLength()方法取得多維陣列的Table, Row, Column
         int table = arr3D.GetLength(0);
         int row = arr3D.GetLength(1);
         int column = arr3D.GetLength(2);

         Write($"表格 {table} 個, ");
         Write($"二維表格: {row} * {column}\n");

         //3層for廻圈；第一層先讀表格(table)
         for (int first = 0; first < table; first++)
         {
            WriteLine($"----表格 {first + 1} ----");

            //第二層for廻圈讀列(row)
            for (int second = 0; second < row; second++)
            {
               //第三層for廻圈讀欄(column)
               for (int thrid = 0; thrid < column; thrid++)
               {
                  //依序輸出多維陣列的元素
                  Write($"{arr3D[first, second, thrid],3} |");
               }

               WriteLine();   //換行

            }//end second for-loop

            WriteLine();   //換行

         }//end first for-loop

         ReadKey();//螢幕暫停
      }
   }
}
