using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06_03
{
   class QueueforStk
   {
      public QueueforStk()
      {
         stk1 = new Stack<int>();
         stk2 = new Stack<int>();
      }
      private Stack<int> stk1;
      private Stack<int> stk2;

      //定義成員方法-新增項目到佇列
      public void Enqueue(int value)
      {
         stk1.Push(value);
      }

      //定義成員方法-從佇列移除項目
      public int Dequeue()
      {
         int value;
         if (stk2.Count != 0)
         {
            return stk2.Pop();
         }
         while (stk1.Count != 0)
         {
            value = stk1.Pop();
            stk2.Push(value);
         }
         return stk2.Pop();
      }
   }  
}
