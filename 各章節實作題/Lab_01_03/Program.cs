using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/* Q3 - 101~200 偶數和以while廻圈求取 */
namespace Lab_01_03
{
   class Program
   {
      static void Main(string[] args)
      {
         int count = 101;
         int total = 0;
         while(count <= 200)
         {
            total += count;            
            count += 2;            
         }         
         WriteLine($"101 ~ 200 偶數和: {total}");
         ReadKey();
      }
   }
}
