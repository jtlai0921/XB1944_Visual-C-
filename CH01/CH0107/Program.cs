using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; //匯入靜態類別Console

namespace CH0107
{
   class Program
   {
      static void Main(string[] args)
      {
         int counter, sum = 0;

         //for廻圈配合continue, break敘述
         for (counter = 0; counter <= 20; counter++)
         {
            if (counter % 2 == 0)//找出奇數
            {
               continue;   //繼續廻圈 
            }
            sum += counter;
            if (sum > 60) //第二個if敘述
               break;     //中斷廻圈 
            WriteLine($"Counter = {counter}, Sum = {sum}");
         }
         ReadKey();
      }
   }
}
