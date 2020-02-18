using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0105
{
   class Program
   {
      static void Main(string[] args)
      {
         int remain;//餘數
         WriteLine("輸入兩個整數值，求取最大公因數");

         Write("輸入第一個數值：");
         //取得除數
         int divisor = Convert.ToInt32(ReadLine());
         Write("輸入第二個數值：");
         //取得被除數
         int divided = Convert.ToInt32(ReadLine());

         Write($"{divisor} 與 {divided} 的");

         while (divided != 0)//被除數不能為0
         {
            remain = divisor % divided; //求取餘數
            divisor = divided; //被除數(diveded)更換成除數(divisor)
            divided = remain;  //將前式所得餘數更換為除數(divisor)
         }
         WriteLine($"最大公因數：{divisor} ");

         ReadKey();
      }
   }
}
