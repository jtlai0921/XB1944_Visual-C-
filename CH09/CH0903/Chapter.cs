using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//使用快速排序法做遞增排序
namespace CH0903
{
   class Chapter
   {
      static void Main(string[] args)
      {
         int[] number = {337, 141, 86, 254, 113, 67, 141, 92, 75, 21};
         int j;
         int len = number.Length;

         WriteLine("---- 排序前 ----");
         for (j = 0; j < len; j++)
            Write($"{number[j],-4}");
         WriteLine();

         Sorting(number, 0, len - 1);//呼叫靜態方法

         WriteLine("\n** 快速排序法 **");
         for (j = 0; j < len; j++)
            Write($"{number[j],-4}");

         ReadKey();
      }

      //定義靜態方法-排湑
      static void Sorting(int[] ary, int first, int last)
      {
         int pos; //取得pivot位置

         //陣列的首項first必須小於末項last才能排序
         if (first < last)
         {
            pos = Division(ary, first, last); //分割陣列

            Sorting(ary, first, pos - 1);     //遞廻處理陣列前半部
            Sorting(ary, pos + 1, last);      //遞廻處理陣列後半部
         }
      }

      //定義靜態方法-分割陣列
      static int Division(int[] ary, int first, int last)
      {
         int j, pivot, k, tmp;
         j = first;
         k = last;
         pivot = ary[first]; //設陣列第一個元素為基準點pivot

         while (j < k)
         {
            /// 設定pivot後, j > k && ary[k] >= pivot情形下 
            /// 由左而右查找比pivot大的值, 比對後將兩者互換
            while (j < k && ary[k] >= pivot)
               k--;
            if (j < k)
            {
               tmp = ary[j];
               ary[j] = ary[k];
               ary[k] = tmp;
            }

            //由右而左查找比pivot小的值
            while (j < k && ary[j] <= pivot)
               j++;
            if (j < k)
            {
               tmp = ary[j];
               ary[j] = ary[k];
               ary[k] = tmp;
            }               
         }
         return j;
      }
   }
}
