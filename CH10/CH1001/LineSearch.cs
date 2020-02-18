using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//使用線性搜尋
namespace CH1001
{
   class LineSearch
   {
      static void Main(string[] args)
      {
         int[] number = { 117, 325, 54, 19, 63, 113, 749, 25, 41, 213, 68, 92 };
         int target, search;
         Write("輸入欲搜尋的值->");
         search = int.Parse(ReadLine());

         target = SearchSeq(search, number); //呼叫函式做搜尋

         if (target != -1)
            WriteLine($"有找到，陣列索引 = {target}");
         else
            WriteLine("無此搜尋值");

         ReadKey();
      }

      //定義函式SearchSeq()做線性搜尋 - 未排序資料
      public static int SearchSeq(int key, int[] ary)
      {
         int index;

         for (index = 0; index < ary.Length; index++)
         {
            if (ary[index] == key)  //比對陣列元素是否等於欲搜尋的鍵值
               return index;       //回傳索引
         }
         return -1;                  //沒有找到以0回傳
      }
   }
}
