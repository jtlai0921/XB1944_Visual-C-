using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/* Q2 - 判斷閏年, 被4或400整除才是閏年 */
namespace Lab_01_02
{
   class CH01
   {
      static void Main(string[] args)
      {
         int year;
         Write("輸入西元紀年 ->");
         year = int.Parse(ReadLine());
         if (year % 400 == 0)
            WriteLine($"{year} 閏年");
         else if (year % 100 == 0)
            WriteLine($"{year} 非閏年");
         else if (year % 4 == 0)
            WriteLine($"{year} 是閏年");
         else
            WriteLine($"{year} 不是閏年");
         ReadKey();
      }
   }
}
