using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//使用插入排序法做遞增排序
namespace CH0904
{
   class Chpater09
   {
      static void Main(string[] args)
      {
         int[] number = {12, 135, 56, 43, 152, 458, 63, 32, 91};         
         int j;
         int len = number.Length;

         WriteLine("---- 排序前 ----");
         for (j = 0; j < len; j++)
            Write($"{number[j],-4}");
         WriteLine();

         Sorting(number, len - 1);//呼叫靜態方法

         WriteLine("\n** 插入排序法 **");
         for (j = 0; j < len; j++)
            Write($"{number[j],-4}");

         ReadKey();
      }

      //定義靜態方法做排序
      static void Sorting(int[] ary, int num)
      {
         int j, preid, key;
         for (j = 1; j <= num; j++)
         {
            preid = j - 1; //比較時，取得前元素preid的位置
            key = ary[j];  //將欲插入元素設為鍵值

            /* 處理陣列中前、後項比大小的問題
               欲插入位置的前元素 > 欲插入鍵值
               變更索引後將項目向前移動 */
            while ((ary[preid] > key) && (preid >= 0))
            {
               //前元素向後移，挪出一個空位
               ary[preid + 1] = ary[preid];               
               preid -= 1;
            }
            ary[preid + 1] = key; //鍵值插到空出的位置
         }         
      }
   }
}
