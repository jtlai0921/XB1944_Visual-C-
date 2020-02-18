using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//第九章-Q3--使用插入排序法做遞減排序
namespace Lab_09_03
{
   class InsertionQ3
   {
      static void Main(string[] args)
      {
         int[] number = {185, 625, 134, 47, 731, 125, 42, 416};
         int j;
         int len = number.Length;

         WriteLine("---- 排序前 ----");
         for (j = 0; j < len; j++)
            Write($"{number[j], -4}");
         WriteLine();

         Sorting(number, len - 1);//呼叫靜態方法進行插入排序

         WriteLine("\n** 插入排序法做遞減排序 **");
         for (j = 0; j < len; j++)
            Write($"{number[j],-4}");

         ReadKey();
      }

      //定義靜態方法做插入排序
      static void Sorting(int[] ary, int num)
      {
         int j, preid, key;
         for (j = 1; j <= num; j++)//移出一個空位來挪動元素
         {             
            key = ary[j];  //將欲插入元素設為鍵值
            preid = j;     //比較時，設前元素preid位置

            //處理陣列中前、後項比大小的問題，欲插入位置的前元素 <= 欲插入鍵值
            while (preid > 0 && ary[preid - 1] <= key)
            {
               //值小者向後挪出一個空位
               ary[preid] = ary[preid - 1];
               //WriteLine($"{preid} = {ary[preid]}");//查看
               preid -= 1;
            }
            ary[preid] = key;//鍵值插到空出的位置
         }         
      }
   }
}
