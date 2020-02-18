using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//第10章 - Q2
namespace Lab_10_02
{
   class Chapter10
   {
      static void Main(string[] args)
      {
         int[] number = { 117, 325, 513, 119, 89, 163, 749, 41, 213, 833 };

         //利用Array類別的Sort()方法將陣列排序
         Array.Sort(number);
         //輸出排序後陣列
         for(int j = 0; j < number.Length; j++)
            WriteLine($"[{j, 2}] = {number[j]}");

         int find, target;

         Write("輸入欲搜尋鍵值(41-833)-> ");
         find = int.Parse(ReadLine());
         target = SearchBinaryNonRecu(number, find);
         
         if (target == -1)
            WriteLine($"*** 無此鍵值 <{find}> 索引 ***\n");
         else
            WriteLine($"鍵值 <{number[target]}> 的索引 {target}");

         ReadKey();
      }

      //定義靜態方法
      static int SearchBinaryNonRecu(int[] ary, int key)
      {
         int low = 0, mid;
         int high = ary.Length - 1;
         
         while (low < high)
         {
            mid = (low + high) / 2;  //取得陣列中間項
            
            if (key == ary[mid])     //找到鍵值就回傳
               return mid;
            else if (key < ary[mid]) //向前半部繼續查找
               high = mid - 1;
            else                     //向後半部繼續查找
               low = mid + 1;
         }
         return -1;
      }
   }
}
