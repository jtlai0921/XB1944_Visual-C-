using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//第五章實作題<4>，利用泛型類別Stack<T>實作堆疊
namespace Lab_05_04
{
   class Program
   {
      static void Main(string[] args)
      {
         string express = "7 5 + 4 * 3 8 - 2 6 + * -";
         //string express = "10 8 + 6 5 * -";
         WriteLine($"後序運算式--> {express}");
         int result = PostfixEvaluate(express);
         WriteLine($"運算結果 --> {result}");

         ReadKey();
      }

      //定義靜態方法-以後序式直接運算' 依序讀取到堆疊，利用<OP1>運算元<OP2>完成計算
      public static int PostfixEvaluate(string expn)
      {
         Stack<int> stk = new Stack<int>();
         //去除空白字元，取出運算元和運算子
         string[] tokens = expn.Split(' ');
         string line = new string('=', 36);
         WriteLine(line);
         WriteLine($"運算元1 運算子 運算元2");

         foreach (string token in tokens)
         {
            //檢查"+-*/"是否在字串中
            if ("+-*/".Contains(token))
            {
               int num2 = stk.Pop();
               Write($"{num2,6}");
               int num1 = stk.Pop(); //儲存前次運算
               Write($"{token,6} {num1,8}");
               WriteLine();

               //依據運算子將兩個運算元所得壓入堆疊
               switch (token)
               {
                  case "+": stk.Push(num1 + num2);
                     break;
                  case "-": stk.Push(num1 - num2);
                     break;
                  case "*": stk.Push(num1 * num2);
                     break;
                  case "/": stk.Push(num1 / num2);
                     break;
               }
            }
            else
               stk.Push(Convert.ToInt32(token));
         }
         WriteLine(line);
         return stk.Pop();
      }
   }
}
