using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0205
{
   class Program
   {
      //運算式主體
      static int CalcAdd(int x, int y) => x + y;
      static int CalcMulte(int x, int y) => x * y;

      static void Main(string[] args)
      {
         int num1 = 15, num2 = 25;
         int add = CalcAdd(num1, num2);
         int result = CalcMulte(num1, num2);
         WriteLine($"CalcAdd(15, 25) = {add}");
         WriteLine($"CalcMulte(15, 25) = {result}");
         
         ReadKey();
      }
   }
}
