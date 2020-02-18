using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0402
{
   class Chapter04
   {
      static void Main(string[] args)
      {
         string line = new string('-', 15);

         //產生3個物件chin, eng, math
         Score chin = new Score("國文", 96);
         Score eng = new Score("英文", 81);
         Score math = new Score("數學", 64);
         //將3個科目的分數相加
         int total = chin.Number + eng.Number + math.Number;

         WriteLine("--林小明成績--");
         WriteLine($"{chin.Course}: {chin.Number, 3}");
         WriteLine($"{eng.Course}: {eng.Number, 3}");
         WriteLine($"{math.Course}: {math.Number, 3}");
         WriteLine(line);
         WriteLine($"總分 {total, 4}");
         ReadKey();
      }
   }
}
