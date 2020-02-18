using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//使用氣泡排序法做遞增排序
namespace CH0901
{
   class Chapter09
   {
      static void Main(string[] args)
      {
         int[] number = { 25, 33, 11, 514, 78, 65, 57, 321 };
         int j;
         int len = number.Length;

         WriteLine("---- 排序前 ----");
         for (j = 0; j < len; j++)
            Write($"{number[j], -4}");
         WriteLine();

         Sorting(number, len);//呼叫靜態方法做氣泡排序

         WriteLine("\n** 氣泡排序法 **");
         for (j = 0; j < len; j++)
            Write($"{number[j], -4}");

         ReadKey();
      }

      //定義靜態方法 - 氣泡排序
      static void Sorting(int[] ary, int num)
      {
         int j, k, tmp;
         for (j = num - 1; j >= 1; j--)
         {
            for (k = 0; k <= j - 1; k++)
            {
               ///Step 1. 將相鄰的兩個元素互相比較
               ///Step 2. 兩個元素互換，值大者向前利
               ///Step 3. 重覆前述兩個步驟，直到無法互換為止
               if (ary[k] > ary[k + 1])
               {
                  tmp = ary[k];
                  ary[k] = ary[k + 1];
                  ary[k + 1] = tmp;
               }
               //Write($"\n[{k}] = {ary[k]}"); 
            }
         }
      }
   }
}
