using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/* CH02-Q<6>
   輸入一個數值number並計算其階乘值 */
namespace Lab_02_06
{
   class CH02
   {
      static void Main(string[] args)
      {
         int j, num, total = 1;
         Write("輸入一個數值, 計算階乘-> ");
         num = Convert.ToInt32(ReadLine());

         for (j = 1; j <= num; j++)
         {
            total *= j;
            WriteLine($"階乘 {j}! = {total:N0}");
         }

         ReadKey();
      }
   }
}
