using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0407
{
   class PolyonmialApp
   {
      static void Main(string[] args)
      {
         Node result = null;
         Polynomial poly = new Polynomial();
         string line = new string('-', 35);
         WriteLine(line);
         WriteLine("多項式的表示：X^B");

         WriteLine("第一個多項式");
         result = poly.ShowPoly1();
         poly.Display(result);

         WriteLine("第二個多項式");
         result = poly.ShowPoly2();
         poly.Display(result);

         WriteLine(line);
         WriteLine("兩個多項式相加結果");
         result = poly.AddItem();
         poly.Display(result);
         ReadKey();
      }
   }
}
