using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//使用堆積排序法做遞增排序
namespace CH0908
{
   class Chapter09
   {
      static void Main(string[] args)
      {
         int[] number = {58, 46, 72, 23, 130, 35, 12, 95};
         int j;
         int len = number.Length;

         WriteLine("---- 排序前 ----");
         for (j = 0; j < len; j++)
            Write($"{number[j],-4}");
         WriteLine();

         Sorting(number);//呼叫靜態方法進行堆積排序

         WriteLine("\n** 堆積排序法 **");
         for (j = 0; j < len; j++)
            Write($"{number[j],-4}");

         ReadKey();
      }

      //定義靜態方法做排序
      static void Sorting(int[] ary)
      {
         int length, index, k;
         length = ary.Length - 1;
         index = length / 2;  //取得有子節點的父節點位置

         //從最後一個父節點開始，依據index將目前待排序調整為最大堆積樹
         for (k = index; k >= 0; k--)
            HeapDown(ary, k, length);

         //走訪陣列，逐步把根節點(最大者)與最後一個節點互換，不斷調整最大堆積樹
         for (k = length; k > 0; k--)
         {
            if (ary[0] > ary[k])
            {
               Swap(ref ary, 0, k);//呼叫靜態方法將兩個元素置換
               HeapDown(ary, 0, k - 1);
            }
         }
      }

      //定義靜態方法來產生最大堆積樹
      static void HeapDown(int[] ary, int first, int last)
      {
         int large;
         //從子樹找出最大值並記錄其位置
         large = 2 * first + 1;

         //找出大兒子並向上移一層
         while (large <= last)
         {
            if (large < last && ary[large] < ary[large + 1])
               large++;

            //­若大兒子大於父節點，兩者互換

            /*if(ary[large] > ary[first])   //遞減
            {
               Swap(ref ary, large, first);
               first = large;
               large = 2 * first + 1;
            }
            else
               break;*/

            if (ary[large] < ary[first])   //遞增
               break;
            else
            {
               Swap(ref ary, first, large);
               first = large;
               large = 2 * first + 1;
            }
         }
      }

      //定義靜態方法Swap()，將兩個元素互換
      static void Swap(ref int[] ary, int item1, int item2)
      {
         int tmp = ary[item1];
         ary[item1] = ary[item2];
         ary[item2] = tmp;
      }
   }
}
