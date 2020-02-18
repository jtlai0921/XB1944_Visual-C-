using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//使用合併排序法做遞增排序
namespace CH0909
{
   class Chapter09
   {
      static void Main(string[] args)
      {
         int[] number = {797, 126, 51, 413, 218, 64, 372, 313, 645, 570};
         int j;
         int len = number.Length;

         WriteLine("---- 排序前 ----");
         for (j = 0; j < len; j++)
            Write($"{number[j],-4}");
         WriteLine();

         Sorting(number, 0, len - 1);//呼叫靜態方法進行合併排序

         WriteLine("\n** 合併排序法 **");
         for (j = 0; j < len; j++)
            Write($"{number[j],-4}");

         ReadKey();
      }

      //定義靜態方法進行合併排序
      static void Sorting(int[] ary, int first, int last)
      {
         int j, k, item, mid, count;
         int len = ary.Length;
         int[] data = new int[len]; //暫存合併的資料

         if (first < last)
         {
            mid = (first + last) / 2;    //分割陣列

            Sorting(ary, first, mid);    //以遞迴處理陣列的前半部
            Sorting(ary, mid + 1, last); //以遞迴處理陣列的後半部

            //j 取得前半部, item 則是陣列data第一個資料
            j = item = first;
            k = mid + 1;               //取得後半部的第一個資料
            count = last - first + 1;  //合併的資料個數

            //把左、右半部的數值依照大小合併後放入陣列data
            while (j <= mid && k <= last)
            {
               if (ary[j] <= ary[k])
                  data[item++] = ary[j++];
               else
                  data[item++] = ary[k++];
            }

            //將前半部所餘資料複製到陣列data
            while (j <= mid)
               data[item++] = ary[j++];

            //將後半部所餘資料複製到陣列data
            while (k <= last)
               data[item++] = ary[k++];

            //將陣列data內容複製到陣列ary
            for (j = 0; j < count; j++, last--)
               ary[last] = data[last];
         }
      }
   }
}
