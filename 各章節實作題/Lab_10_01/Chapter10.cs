using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//第10章-Q1
namespace Lab_10_01
{
   class Chapter10
   {
      static void Main(string[] args)
      {
         int[] number = { 179, 91, 86, 76, 97, 217,
                          57, 87, 56, 66, 433, 24 };
         int min = SmallValue(number);
         Write($"最小值 = {min}");

         ReadKey();
      }

      //定義靜態方法找出最小值
      static int SmallValue(int[] ary)
      {
         int smallest, j;
         smallest = ary[0]; //先設第一個元素是最小值

         for (j = 0; j < 12; j++)
         {
            if (ary[j] < smallest)
               smallest = ary[j];
         }
         return smallest;
      }
   }
}
