using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//第五章實作<2>，利用泛型類別Stack<T>提供的Push(), Pop()相關方法來簡化程式
namespace Lab_05_02
{
   class Program
   {
      static void Main(string[] args)
      {
         //讀取堆疊
         Write("讀取堆疊內容--> ");
         ReverseWord();

         ReadKey();
      }

      //定義靜態方法-輸出堆疊內容
      public static void Display(string[] word)
      {
         foreach (string item in word)
            Write($"{item} ");
         WriteLine();
      }

      //靜態方法-反轉陣列元素
      public static void ReverseWord()
      {
         string[] word = { "One", "Two", "Three", "Four" };
         Stack<string> stk = new Stack<string>();
         InsertAtBottom(stk, word);

         string[] word2 = new string[4];

         //把堆疊彈出項目加到第二個陣列
         for (int j = 0; j < 4; j++)
            word2[j] = stk.Pop();
         Display(word2);

         Write("反轉後堆疊--> ");
         InsertAtBottom(stk, word2);
         foreach (var i in stk)
            Write($"<{i}> ");
      }

      //定義靜態方法，把陣列元素壓入堆疊
      public static void InsertAtBottom(Stack<string> stk, string[] ary)
      {
         //WriteLine($"Count = {stk.Count}");
         for (int j = 0; j < ary.Length; j++)
            stk.Push(ary[j]);
      }
   }
}
