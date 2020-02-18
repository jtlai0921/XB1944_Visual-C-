using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0510
{
   class Program
   {
      static void Main(string[] args)
      {
         for (int j = 1; j <= 5; j++)
            WriteLine($"{j}! = {Factorial(j)}");
         ReadKey();
      }

      //定義靜態方法來計算階乘
      public static int Factorial(int N)
      {
         int result;     //儲存階乘計算結果

         if (N == 0)
            result = 1;  //基本案例，終止遞廻
         else            //若階乘為2(含)以上，呼叫自己的方法
         {
            result = N * Factorial(N - 1);//以遞廻呼叫
            WriteLine($"{N}呼叫前一次，{N} * Factorial{N - 1}");
         }
         return result;
      }
   }
}
