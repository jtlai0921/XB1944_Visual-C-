using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0509
{
   class Program
   {
      static void Main(string[] args)
      {
         int result = TotalNums(5);
         WriteLine($"總和：{result}");
         ReadKey();
      }

      //靜態方法-以遞廻方式呼叫
      public static int TotalNums(int num)
      {
         int total;
         if (num == 1)
            total = 1; //終止遞廻
         else
            total = TotalNums(num - 1) + num;   //遞廻關係式
         return total;
      }
   }
}
