using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0306
{
   class Program
   {
      static void Main(string[] args)
      {
         int outer, inner;//巢狀for的計數器
         int[] sum = new int[3];//存放每個人的總分

         string[] student = { "Mary", "Tomas", "John" };

         //讀取名字並輸出，{0,7}表示預設7個欄位來存放
         foreach (string item in student)         
            Write("{0, 8}", item);         
         WriteLine();

         int[,] score = {{75, 64, 96}, {55, 67, 39},
                   {45, 92, 85}, {71, 69, 81} };
         //GetLength()方法取得第1、2維陣列
         int row = score.GetLength(0);
         int column = score.GetLength(1);

         //讀取列數
         for (outer = 0; outer < row; outer++)
         {
            //讀取欄的元素
            for (inner = 0; inner < column; inner++)   
               Write($"{score[outer, inner], 8}");            
            WriteLine();
 
            sum[0] += score[outer, 0];//第1欄分數相加
            sum[1] += score[outer, 1];//第2欄分數相加
            sum[2] += score[outer, 2];//第3欄分數相加
         }
         string line = new string('-', 27);
         WriteLine(line);
         WriteLine($"合計: {sum[0]} {sum[1], 6} {sum[2], 7}");
 
         ReadKey();
      }
   }   
}
