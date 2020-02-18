using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//以除法所得餘數產生雜湊函數
namespace CH1006
{
   class Chapter10
   {
      static void Main(string[] args)
      {
         int[] number = { 4, 13, 21, 34, 42, 63 };
         runHash(number);

         ReadKey();
      }

      //定義靜態方法
      static void runHash(int[] ary)
      {
         const int PRIME = 11;
         int pos, j;
         int[] hash = new int[PRIME];

         Write("取得餘數：");
         //讀取陣列並以除法取得餘數
         for (j = 0; j < 6; j++)
         {
            pos = ary[j] % PRIME;
            Write($"{pos, -3}");
            //餘數為索引，存入雜湊函數
            hash[pos] = ary[j];
         }
         WriteLine();

         //讀取雜湊函數
         for (pos = 0; pos < PRIME; pos++)
            Write($"Hash[{pos, 2}] = {hash[pos], 3}\n");
         WriteLine();
      }
   }   
}
