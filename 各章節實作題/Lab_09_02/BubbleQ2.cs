using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//第九章-Q2--使用氣泡排序法做遞減排序
namespace Lab_09_02
{
   class BubbleQ2
   {
      static void Main(string[] args)
      {
         int[] number = {55, 234, 78, 37, 165, 23, 81, 46, 69, 37};
         int j;
         int len = number.Length;

         WriteLine("---- 排序前 ----");
         for (j = 0; j < len; j++)
            Write($"{number[j],-4}");
         WriteLine();

         Sorting(number, len);//呼叫靜態方法進行氣泡排序

         WriteLine("\n** 氣泡排序法做遞減排序 **");
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
               if (ary[k] < ary[k + 1])
               {
                  tmp = ary[k];
                  ary[k] = ary[k + 1];
                  ary[k + 1] = tmp;
                  flag = true;
               }
            }
         }
      }
   }
}
