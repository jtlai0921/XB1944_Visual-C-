using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/* CH02-Q<5>
   求出介於100到200中所有奇數之總和 */
namespace Lab_02_05
{
   class CH02
   {
      static void Main(string[] args)
      {
         int total = 0;
         Write("100 ~ 200 之和 -> ");
         for (int j = 100; j <= 200; j++)
         {
            if (j % 2 == 1)               
               total += j;               
         }
         WriteLine($"{total}");
         ReadKey();
      }
   }
}
