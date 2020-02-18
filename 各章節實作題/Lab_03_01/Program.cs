using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//第三章 實作題(1)
namespace Lab_03_01
{
   class Program
   {
      static void Main(string[] args)
      {
         string[] name = { "Peter", "Michelle", "Tomas", "Julie", "Charles" };
         foreach (string item in name)
         {
            Write($"\n{item, -10}");
            Write($"長度：{item.Length}");
         }
         WriteLine();
         for (int j = 0; j < name.Length; j++)
            Write($"{name[j], -10}");
         ReadKey();
      }
   }
}
