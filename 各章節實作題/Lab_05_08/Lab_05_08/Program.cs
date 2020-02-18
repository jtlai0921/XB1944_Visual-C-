using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//第五章實作題<8>
namespace Lab_05_08
{
   class Program
   {
      static void Main(string[] args)
      {
         Random rand = new Random((int)DateTime.Now.Ticks);
         int[] numbers = new int[10];
         //產生1~200的隨機數存入numbers陣列
         for (int j = 0; j < 10; j++)
            numbers[j] = rand.Next(201);
         //讀取陣列
         for (int j = 0; j < 10; j++)
            Write($"{numbers[j]} ");
         int result = AryTotal(numbers, numbers.Length);
         WriteLine($"\n陣列元素總和 = {result}");
         ReadKey();
      }

      //定義靜態方法-遞廻呼叫-計算陣列總和
      public static int AryTotal(int[] ary, int len)
      {
         if (len == 0)
            return 0;//基本案例
         else //遞廻關係式
            return AryTotal(ary, len - 1) + ary[len - 1];
      }
   }
}
