using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0201
{
   class LargeValue
   {
      static void Main(string[] args)
      {
         int num1, num2;
         Write("輸入第一個數值 -> ");
         num1 = int.Parse(ReadLine());
         Write("輸入第二個數值 -> ");
         num2 = Convert.ToInt32(ReadLine());
         if (num1 > num2)
            WriteLine($"最大值 {num1}");
         else
            WriteLine($"最大值 {num2}");
         ReadKey();
      }
   }
}
