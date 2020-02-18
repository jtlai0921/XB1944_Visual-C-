using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//第九章-Q1--改善氣泡排序法

namespace Lab_09_01
{
   class BubbleQ1
   {
      static void Main(string[] args)
      {
         int[] number = {25, 33, 11, 514, 78, 65, 57, 321};
         int j;
         int len = number.Length;

         WriteLine("---- 排序前 ----");
         for (j = 0; j < len; j++)
            Write($"{number[j],-4}");
         WriteLine();

         Sorting(number, len);//呼叫靜態方法進行氣泡排序

         WriteLine("\n** 氣泡排序法做改善 **");
         for (j = 0; j < len; j++)
            Write($"{number[j],-4}");
         
         ReadKey();
      }

      //定義靜態方法做氣泡排序
      static void Sorting(int[] ary, int num)
      {
         int j, k, tmp;
         bool flag = true;
         for (j = num - 1; (j >= 1 && flag); j--)
         {
            flag = false;
            for (k = 0; k <= j - 1; k++)
            {
               if (ary[k] > ary[k + 1])
               {
                  tmp = ary[k];
                  ary[k] = ary[k + 1];
                  ary[k + 1] = tmp;
                  flag = true;
               }
               WriteLine($"ary[{k}] = {ary[k]}");
            }
         }         
      }
   }
}
