using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0304
{
   class SortingArray
   {
      static void Main(string[] args)
      {
         int index = 0;
         //宣告陣列並初始化元素
         int[] number = { 68, 173, 19, 524 };

         Write("排序前：");
         //讀取排序前的陣列元素
         foreach (int element in number)
            Write($"{element, 4}");

         Array.Sort(number);//遞增排序
         Array.Reverse(number);//反轉陣列元素

         Write("\n遞減排序：");
         //讀取排序後元素
         for (int item = 0; item < number.Length; item++)
            Write($"{number[item], 4}");
         WriteLine();

         //取得排序後的位置
         index = Array.IndexOf(number, 19);
         WriteLine($"元素19, index = {index}");

         ReadKey();
      }
   }
}
