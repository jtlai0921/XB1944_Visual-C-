using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0108
{
   class Program
   {
      //定義靜態方法
      public static double CalcAverage(double Chin_score,
            double Eng_score, double Math_score)
      {
         //變數Average_score儲存平均分數
         double Average_score = (
            Chin_score + Eng_score + Math_score) / 3;
         return Average_score;   //回傳計算後的平均分數
      }

      static void Main(string[] args)
      {
         double chinese, english, math, equal;//各科分數
         Write("請輸人名字：");
         string studentName = ReadLine();
         Write("請輸人國文分數：");
         chinese = double.Parse(ReadLine());
         Write("請輸人英文分數：");
         english = double.Parse(ReadLine());
         Write("請輸人數學分數：");
         math = double.Parse(ReadLine());

         //呼叫方法 -- 計算平均分數
         equal = CalcAverage(chinese, english, math);
         WriteLine($"{studentName}！你好！" +
            $"，3科平均 = {equal:N3}");

         ReadKey();
      }
   }
}
