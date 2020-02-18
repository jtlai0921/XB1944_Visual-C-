using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//CH02-Q<3>
namespace Lab_02_03
{
   class Program
   {
      static void Main(string[] args)
      {
         int k = 100000;
         while (k >= 5)
         {
            k /= 10;
            WriteLine($"Ans = {k}");
         }
         ReadKey();
      }
   }
}
