using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH1002
{
   class ImproveSearch
   {
      static void Main(string[] args)
      {

         int[] number = 
            {19, 25, 41, 54, 63, 68, 92,
            113, 117, 213, 325, 749 };

         int target, search;
         Write("輸人欲搜尋的值->");
         search = int.Parse(ReadLine());

         target = LinearSearch(number, search);

         if (target != -1)
            WriteLine($"搜尋值的索引: {target}");
         else
            WriteLine("無此鍵值");
         
         ReadKey();
      }

      //定義靜態方法
      static int LinearSearch(int[] ary, int key)
      {
         int index;

         //讀取陣列查找鍵值key
         for (index = 0; index < 12; index++)
         {
            //若陣列元素的值等於key, 回傳其位置
            if (ary[index] == key)
               return index;
            else if (ary[index] > key)
               return -1;
         }
         return -1;
      }
   }
}
