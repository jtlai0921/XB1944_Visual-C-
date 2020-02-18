using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0506
{
   class Program
   {
      static void Main(string[] args)
      {
         int N = 5;
         ShowNum(N);
         ReadKey();
      }

      //靜態方法以遞呼叫本身
      public static void ShowNum(int num)
      {
         if (num > 0)
         {
            Write($"{num, 3}");
            ShowNum(num - 1);
         }
      }
   }
}
