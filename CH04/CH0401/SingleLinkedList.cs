using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0401
{
   class SingleLinkedList
   {
      static void Main(string[] args)
      {
         Student peter = new Student();//產生物件
         peter.name = "Peter";
         peter.Display();
         ReadKey();
      }
   }
}
