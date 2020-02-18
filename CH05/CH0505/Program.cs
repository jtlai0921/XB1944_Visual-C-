using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;
using static System.Console;

namespace CH0505
{
   class Program
   {
      static void Main(string[] args)
      {
         InfixToPostfix express = new InfixToPostfix();
         char[] infix = new char[20];
         char[] postfix = new char[20];
         Write("輸入中序運算式--> ");
         string word = ReadLine();
         for (int j = 0; j < word.Length; j++)
            infix[j] = word[j];
         express.ToPostfix(infix, postfix);
         WriteLine("--中序轉為後序運算式--");
         WriteLine(postfix);
         ReadKey();
      }
   }
}
