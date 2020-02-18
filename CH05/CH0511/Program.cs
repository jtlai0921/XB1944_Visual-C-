using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0511
{
   class Program
   {
      static void Main(string[] args)
      {
         Write("輸入第一個數--> ");
         int num1 = Convert.ToInt32(ReadLine());
         Write("輸入第二個數--> ");
         int num2 = Convert.ToInt32(ReadLine());
         int result = Gcd(num1, num2);
         WriteLine($"GCD = {result}");
         ReadKey();
      }

      //定義靜態方法取得最大公因數
      public static int Gcd(int M, int N)
      {
         //如果兩個數值相同就回傳其中的一個
         if (M == N)
            return M;               //基本案例
         else if (M > N)
            return Gcd(M - N, N);   //遞廻關係式
         else
            return Gcd(M, N - M);
      }
   }
}
