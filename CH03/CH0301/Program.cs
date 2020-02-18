using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//未使用陣列來儲存各科成績
namespace CH0301
{
   class Program
   {
      static void Main(string[] args)
      {
         //宣告3個變數來儲存3科的分數 
         int chin, eng, math;
         chin = 98;
         eng = 64;
         math = 71;
         WriteLine($"國文 = {chin}), 英文 = {eng}, 數學 = {math}");
         ReadKey();
      }
   }
}
