using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Collections;
using static System.Console;

namespace CH0502
{
   class GenericsDemo
   {
      static void Main(string[] args)
      {
         //建立泛型類別物件 -- 學生名稱
         Student<string> persons = new Student<string>();
         persons.StoreArray("Tomas");
         persons.StoreArray("John");
         persons.StoreArray("Eric");
         persons.StoreArray("Steven");
         persons.StoreArray("Mark");
         persons.Display();

         //建立泛型類別物件 -- 成績
         Student<int> Score = new Student<int>();
         Score.StoreArray(78);
         Score.StoreArray(83);
         Score.StoreArray(48);
         Score.StoreArray(92);
         Score.StoreArray(65);
         Score.Display(); 

         ReadKey();
      }
   }
}
