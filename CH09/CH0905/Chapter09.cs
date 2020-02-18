using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//使用二元插入排序法做遞增排序
namespace CH0905
{
   class Chapter09
   {
      static void Main(string[] args)
      {
         int[] number = {78, 156, 43, 134, 37, 63, 24, 91};
         int j;
         int len = number.Length;

         WriteLine("---- 排序前 ----");
         for (j = 0; j < len; j++)
            Write($"{number[j],-4}");
         WriteLine();

         Sorting(number, len);//呼叫靜態方法做排序

         WriteLine("\n** 二元插入排序法 **");
         for (j = 0; j < len; j++)
            Write($"{number[j],-4}");

         ReadKey();
      }

      //定義靜態方法做排序
      static void Sorting(int[] ary, int num)
      {
         int j, pos, key, first, last, mid;
         for (pos = 0; pos < num; pos++)
         {
            key = ary[pos];//設欲插入元素為鍵值
            first = 0;
            last = pos - 1;

            //取得鍵值欲插入位置
            while (first <= last)
            {
               mid = (first + last) / 2;  //算出位置
               //插入鍵值 < 目前鍵值，插到目前元素前方
               if (key < ary[mid])
                  last = mid - 1;
               else //插入鍵值 > 目前鍵值，插到目前元素後方
                  first = mid + 1;
            }

            for (j = pos; j > first; j--)//取得位置
               ary[j] = ary[j - 1];
            
            ary[first] = key; //插入新元素
         }
      }
   }
}
