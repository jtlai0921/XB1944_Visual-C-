using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//第五章實作題<10>
namespace Lab_05_10
{
   class Program
   {
      static void Main(string[] args)
      {
         WriteLine($"5^3 = {Power(5, 3)}");
         ReadKey();
      }

      //定義靜態方法計算冪次方
      public static int Power(int x , int num)
      {
         if (num == 0)
            return 1;
         else
            return x * Power(x, num - 1);
      }
   }
}
