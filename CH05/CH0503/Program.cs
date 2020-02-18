using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0503
{
   class Program
   {
      static void Main(string[] args)
      {
         //1.產生泛型類別物件
         Stack<int> numbers = new Stack<int>();
         //2.Push()方法新增項目
         numbers.Push(11);
         numbers.Push(22);
         numbers.Push(33);
         numbers.Push(44);
         //3.讀取項目
         foreach (int data in numbers)
            Write($"{data,3}");
         WriteLine();
         //4.移除了Stack頂端物件
         WriteLine($"移除了{numbers.Pop()}");
         //5.回傳Stack頂端物件
         WriteLine($"堆疊頂端物件[{numbers.Peek()}]");
         ReadKey();
      }
   }
}
