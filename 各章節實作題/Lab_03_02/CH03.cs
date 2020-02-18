using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//第三章 實作題(2)
namespace Lab_03_02
{
   class CH03
   {
      static void Main(string[] args)
      {
         int outer, inner;//巢狀for的計數器
         int[] sum = new int[3];//存放每個人的總分

         string[] course = {"國文", "英文", "數學", "總分"};

         //讀取名字並輸出，{0,7}表示預設7個欄位來存放
         foreach (string item in course)
            Write($" {item, -4}");
         WriteLine();

         int[,] score = {{85, 78, 66, 0},
                         {95, 88, 79, 0},
                         {84, 76, 67, 0}, 
                         {81, 73, 54, 0} };

         //GetLength()方法取得第1、2維陣列
         int row = score.GetLength(0);
         int column = score.GetLength(1);

         //讀取列數
         for (outer = 0; outer < row; outer++)
         {
            //將每列前3欄元素相加
            for (inner = 0; inner < column - 1; inner++)
            {
               score[0, 3] = score[0, 0] + score[0, 1] + score[0, 2];              
               score[1, 3] = score[1, 0] + score[1, 1] + score[1, 2];
               score[2, 3] = score[2, 0] + score[2, 1] + score[2, 2];
               score[3, 3] = score[3, 0] + score[3, 1] + score[3, 2];
            }
            //讀取每一欄的元素
            for (inner = 0; inner < column; inner++)
               Write($" {score[outer, inner], -6}");       
            WriteLine();
         }
         string line = new string('-', 27);
         WriteLine(line);         

         ReadKey();
      }
   }
}
