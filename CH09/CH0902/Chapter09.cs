using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//使用雙向氣泡排序法做遞增排序
namespace CH0902
{
   class Chapter09
   {
      static void Main(string[] args)
      {
         int[] number = { 95, 27, 90, 514, 49, 82, 7, 13, 95, 321 };
         int j;
         int len = number.Length;

         WriteLine("---- 排序前 ----");
         for (j = 0; j < len; j++)
            Write($"{number[j],-4}");
         WriteLine();

         Sorting(number, len);//呼叫靜態方法

         WriteLine("\n** 雙向氣泡排序法 **");
         for (j = 0; j < len; j++)
            Write($"{number[j],-4}");
         ReadKey();
      }

      //定義靜態方法
      static void Sorting(int[] ary, int num)
      {
         int first = 0, last = ary.Length - 1;
         int shift = 0, j, tmp;

         while (first < last) //shift為偏移量
         {
            //由前向後走訪陣列找出最大值
            for (j = first; j < last; j++)
            {
               if (ary[j] > ary[j + 1])
               {
                  tmp = ary[j];
                  ary[j] = ary[j + 1];
                  ary[j + 1] = tmp;                  
                  shift = j;
               }
               //WriteLine($"[{j}] = {ary[j], 4}");
            }
            last = shift;

            //由後向前走訪陣列找出最小值
            for (j = last; j > first; j--)
            {
               if (ary[j] < ary[j - 1])
               {
                  tmp = ary[j];
                  ary[j] = ary[j - 1];
                  ary[j - 1] = tmp;
                  shift = j;
               }
            }
            first = shift;
         }
      }
   }
}
