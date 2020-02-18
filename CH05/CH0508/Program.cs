using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0508
{
   class Program
   {
      static void Main(string[] args)
      {
         int result = TotalNums(1, 10);
         WriteLine($"1~10 累加總和: {result}");
         ReadKey();
      }

      //等差級數公式
      public static int TotalNums(int N1, int N2)
      {
         int total = (N1 + N2) * 10 / 2;
         return total;
      }
   }
}
