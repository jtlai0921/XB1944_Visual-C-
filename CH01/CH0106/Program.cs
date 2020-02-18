using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0106
{
   class Program
   {
      static void Main(string[] args)
      {
         char key;
         do
         {
            Write("是否繼續？");
            key = char.Parse(ReadLine());
         } while (key == 'y' || key == 'Y');
         ReadKey();
      }
   }
}
