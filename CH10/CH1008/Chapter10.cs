using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//使用分隔鏈結(Separate Chaining)法
namespace CH1008
{
   //實作鏈結串列
   class Chapter10
   {
      static void Main(string[] args)
      {
         int[] number = {156, 681, 467, 633, 511, 100,
                          57, 164, 472, 438, 445, 366, 118};
         int j, value, target = 0;
 
         Chaining list = new Chaining();

         Write("--- 雜湊表 ---");
         //讀取陣列number產生雜湊表
         for (j = 0; j < number.Length; j++)
            list.CreateHT(number[j]);
         list.Display();

         while(true)
         {
            Write("\n\n輸入欲搜尋的值, 按<-1>結束-> ");
            value = int.Parse(ReadLine());
            if (value != -1)
            {
               target = list.SearchHash(value);
               if (target != -1)
               {
                  WriteLine($"鍵值[{value}]在串列[{target}]");
               }
               else
                  WriteLine($"無此搜尋值{value}");
            }
            else
               Environment.Exit(0);
         }
      }     
   }
}
