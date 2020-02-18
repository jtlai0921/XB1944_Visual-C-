using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0507
{
   class Program
   {
      static void Main(string[] args)
      {
         int total = 0;
         for (int j = 1; j < 11; j++)
         {
            total += j;
            Write($"{total, 4}");
         }
         ReadKey();
      }
   }
}
