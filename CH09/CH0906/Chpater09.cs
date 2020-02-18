using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//使用謝耳排序法做遞增排序
namespace CH0906
{
   class Chpater09
   {
      static void Main(string[] args)
      {
         int[] number = {145, 231, 10, 314, 17, 452, 78, 63, 39, 276};
         int j;
         int len = number.Length;

         WriteLine("---- 排序前 ----");
         for (j = 0; j < len; j++)
            Write($"{number[j],-4}");
         WriteLine();

         Sorting(number, len);//呼叫靜態方法進行謝耳排序

         WriteLine("\n** 謝耳排序法 **");
         for (j = 0; j < len; j++)
            Write($"{number[j],-4}");

         ReadKey();
      }

      //定義靜態方法做謝耳排序
      static void Sorting(int[] ary, int num)
      {
         int j, k, offset, item;
         offset = num / 2; //開始間隔值5, 10­個元素分5組

         while (offset != 0)
         {
            //依間隔值產生插入式排序
            for (j = offset; j < num; j++)
            {
               item = ary[j]; //欲插入元素
               k = j;

               while (k >= offset && item < ary[k - offset])
               {
                  ary[k] = ary[k - offset];
                  k -= offset;
               }
               ary[k] = item;  //插入元素
            }
            offset /= 2; //取得下一個間隔值
         }
      }

   }
}
