using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0514
{
   class Program
   {
      static void Main(string[] args)
      {
         Hanoi(3, 'A', 'B', 'C');
         ReadKey();
      }

      //定義靜態方法-
      public static void Hanoi(int num, char start, char tmp, char target)
      {
         if (num == 1)   //終止條件
            WriteLine($"移動第{num}圓盤，從{start} --> {target}");
         else
         {
            Hanoi(num - 1, start, target, tmp);
            WriteLine($"移動第{num}圓盤，從{start} --> {target}");
            Hanoi(num - 1, tmp, start, target);
         }
      }
   }
}
