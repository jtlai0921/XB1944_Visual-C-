using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//使用選擇排序法做遞減排序
namespace CH0907
{
   class Chapter09
   {
      static void Main(string[] args)
      {
         int[] number = {145, 231, 10, 135, 18, 455, 77, 65, 33, 278};
         int j;
         int len = number.Length;

         WriteLine("---- 排序前 ----");
         for (j = 0; j < len; j++)
            Write($"{number[j],-4}");
         WriteLine();

         Sorting(number, len);//呼叫靜態方法進行選擇排序

         WriteLine("\n** 選擇排序法 **");
         for (j = 0; j < len; j++)
            Write($"{number[j],-4}");

         ReadKey();
      }

      //定義靜態方法進行選擇排序
      static void Sorting(int[] ary, int num)
      {
         int j, max, k, tmp;
         for (j = 0; j < num - 1; j++)
         {
            max = j;   //以第一個元素為最大值
            //依序找出陣列中最大值
            for (k = j + 1; k < num; k++) 
            {
               if (ary[k] > ary[max])
                  max = k;
               //WriteLine($"[{k}] = {ary[k]}");
            }
            tmp = ary[max];
            ary[max] = ary[j];
            ary[j] = tmp;            
         }
      }
   }
}