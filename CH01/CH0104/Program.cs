using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0104
{
   class Program
   {
      static void Main(string[] args)
      {
         int total = 0; //設定變數儲存累加結果
         for (int j = 0; j <= 10; j++)
            total += j;
         WriteLine($"1加到10 結果 {total}");
         ReadKey();
      }
   }
}
