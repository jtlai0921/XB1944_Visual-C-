using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0203
{
   class ThreeNums
   {
      static void Main(string[] args)
      {
         int num1, num2, num3;
         Write("輸入第一個數值 -> ");
         num1 = int.Parse(ReadLine());
         Write("輸入第二個數值 -> ");
         num2 = Convert.ToInt32(ReadLine());
         Write("輸入第三個數值 -> ");
         num3 = Convert.ToInt32(ReadLine());
         WriteLine($"相加結果 {num1 + num2 + num3}");

         ReadKey();
      }
   }
}
