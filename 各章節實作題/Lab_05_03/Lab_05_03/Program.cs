using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//第五章實作題<3>
namespace Lab_05_03
{
   class Program
   {
      static void Main(string[] args)
      {
         string express = "6+2*9/3+4*5-8";
         string result = InfixToPrefix(express);
         WriteLine($"中序運算式-> {express}");
         WriteLine($"前序運算式-> {result}");

         ReadKey();
      }

      //定義靜態方法，把中序轉為前序
      public static string InfixToPrefix(string sample)
      {
         //將讀取的字串sample變為字元陣列
         char[] ary = sample.ToCharArray();
         //將字元陣列反轉，才能由右而左讀取
         ReverseWord(ary);
         MakeParanthesis(ary);
         ary = InfixToPostfix(ary);
         //再把字元反轉一次
         ReverseWord(ary);
         sample = new string(ary);
         return sample;
      }

      //定義靜態方法-中序轉後序-以字元陣列來處理
      public static char[] InfixToPostfix(char[] ary)
      {
         Stack<char> stk = new Stack<char>();
         string output = string.Empty;
         char tmp;

         foreach (char ch in ary)
         {
            if (ch <= '9' && ch >= '0')
               output += ch;
            else
            {
               switch (ch)
               {
                  case '+':
                  case '-':
                  case '*':
                  case '/':
                  case '%':
                  case '^':
                     while (stk.Count != 0
                           && Priority(ch) < Priority(stk.Peek()))
                     {
                        tmp = stk.Pop();
                        output = $"{output} {tmp}";
                     }
                     stk.Push(ch);
                     output = $"{output} "; break;
                  case '('://左括號壓入堆疊
                     stk.Push(ch); break;
                  case ')'://左括號彈出
                     while (stk.Count != 0 && (tmp = stk.Pop()) != '(')
                        output = $"{output} {tmp}";
                     break;
               }
            }
         }

         //彈出堆疊內其它運算子
         while (stk.Count != 0)
         {
            tmp = stk.Pop();
            output = $"{output} {tmp}";
         }
         return output.ToCharArray();
      }

      //定義靜態方法 - 處理運算子的優先權，值愈大表示優先權愈高
      public static int Priority(char op)
      {
         if (op == '(') return 0;
         else if (op == '+' || op == '-') return 1;
         else if (op == '*' || op == '/' || op == '%') return 2;
         else if (op == '^') return 3;
         return 4;
      }

      //定義靜態方法 - 依序讀取字元陣列並反轉
      public static void ReverseWord(char[] sample)
      {
         int lower = 0;//下界值
         int upper = sample.Length - 1;//上界值
         char key;

         while (lower < upper)
         {
            key = sample[lower];
            sample[lower] = sample[upper];
            sample[upper] = key;
            lower++;
            upper--;
         }
      }

      //定義靜態方法-處理圓括號問題
      public static void MakeParanthesis(char[] sample)
      {
         int lower = 0;
         int upper = sample.Length - 1;
         while (lower <= upper)
         {
            if (sample[lower] == '(')
               sample[lower] = ')';
            else if (sample[lower] == ')')
               sample[lower] = '(';
            lower++;
         }
      }
   }
}
