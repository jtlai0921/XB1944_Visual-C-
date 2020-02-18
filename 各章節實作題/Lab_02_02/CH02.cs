using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//CH02 - Q<2>
namespace Lab_02_02
{
   class CH02
   {
      static void Student(string name, int[] score, int course)
      {
         Write($"Hi! {name}, ");
         int total = 0;
         float avg;
         for (int j = 0; j < 5; j++)
         {
            total += score[j];
         }
         avg = total / (float)course;
         if (avg >= 60)
            WriteLine($"總分: {total}, 平均: {avg:f2}");
         else
            WriteLine($"總分:{total}, 平均:{avg:f2}");
      }

      static void Main(string[] args)
      {
         string st1 = "Tomas";
         int[] sc1 = { 78, 65, 92, 84, 43 };
         string st2 = "Vicky";
         int[] sc2 = { 61, 52, 45, 79, 86 };
         string st3 = "Peter";
         int[] sc3 = { 97, 82, 53, 65, 65 };
         Student(st1, sc1, sc1.Length);
         Student(st2, sc2, sc2.Length);
         Student(st3, sc3, sc3.Length);
         ReadKey();
      }
   }
}
