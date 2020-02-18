using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab_01_01
{
   class CH01
   {
      static void Main(string[] args)
      {
         int num1, num2;
         Write("輸入第一個數 ->");
         num1 = Convert.ToInt32(ReadLine());//轉換為int型別
         Write("輸入第二個數 ->");
         num2 = Convert.ToInt32(ReadLine());//轉換為int型別
         var ans = (num1 >= num2) ? num1 : num2;
         WriteLine(ans);

         ReadKey();
      }
   }
}
