using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0513
{
   class Program
   {
      static void Main(string[] args)
      {
         int num = 1;
         for (int n = 0; n <= 15; n++)
         {
            WriteLine($"{n, 2} -> {Fibo(num), 4}");
            num++;
         }
         ReadKey();
      }

      //定義靜態方法來取得費氏數列
      public static int Fibo(int num)
      {
         if ((num == 1) || (num == 2))
            return 1;                      //基本案例，終止遞廻
         else
            return Fibo(num - 1) + Fibo(num - 2);   //遞廻關係式
      }
   }
}
