using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0505
{
   class InfixToPostfix
   {
      protected char[] stack = new char[20];
      public int Top { get; set; } = -1;//指向堆疊頂端的參考
 
      public void ToPostfix(char[] infix, char[] postfix)
      {
         int pos = 0, k = 0;
         char token;
         
         while (infix[pos] != '\0')
         {
            if (infix[pos] == '(')  //左括號壓入STACK
            {
               PushItem(stack, infix[pos]); //呼叫堆疊的PushT()方法
               pos++;
            }
            else if (infix[pos] == ')') //右括號從堆疊彈出
            {
               while ((Top != -1) && (stack[Top] != '('))//輸出運算式到左括號
               {
                  postfix[k] = PopItem(stack); //把彈出的運算式儲存到後序運算式陣列
                  k++;
               }
               if (Top == -1)
               {
                  WriteLine("運算式不正確");
                  break;
               }
               token = PopItem(stack); //移除左括號
               pos++;
            }
            //IsDigit()判斷是否為十位數的數字，IsLetter()判斷是否為字母
            else if (Char.IsDigit(infix[pos]) || Char.IsLetter(infix[pos]))
            {
               postfix[k] = infix[pos];
               k++;
               pos++;
            }
            else if (infix[pos] == '+' || infix[pos] == '-'
                  || infix[pos] == '*' || infix[pos] == '/'
                  || infix[pos] == '%')
            {
               //依運算子的優先權
               while ((Top != -1) && (stack[Top] != '(')
                     && (Priority(stack[Top])
                     > Priority(infix[pos])))
               {
                  postfix[k] = PopItem(stack);
                  k++;
               }
               PushItem(stack, infix[pos]);
               pos++;
            }
            else
            {
               WriteLine("運算式的字元不對");
               break;
            }
         }
         while ((Top != -1) && (stack[Top] != '('))
         {
            postfix[k] = PopItem(stack);//彈出堆疊內其它運算子
            k++;
         }
         postfix[k] = '\0';
      }

      //依先乘除後加減的優先權
      public int Priority(char op)
      {
         switch (op)
         {
            case '*': case '/': case '%': return 3;
            case '+': return 2;
            case '-': return 1;
            default: return 0;
         }
      }

      //將項目壓入堆疊
      public void PushItem(char[] stack, char value)
      {
         if (Top == stack.Length - 1)
            WriteLine("堆疊已滿");
         else
         {
            Top++;
            stack[Top] = value;
         }
      }

      //從堆疊彈出項目
      public char PopItem(char[] stack)
      {
         char val = ' ';
         if (Top == -1)
            WriteLine("堆疊是空的！");
         else
         {
            val = stack[Top];
            Top--;
         }
         return val;
      }
   }
}
