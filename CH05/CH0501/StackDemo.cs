using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0501
{
   class StackDemo
   {
      static void Main(string[] args)
      {
         StackAry list = new StackAry();
         list.PushItem("Mary"); //把項目壓入堆疊
         list.PushItem("Tomas");
         list.PushItem("Vicky");
         list.Display();       //輸出堆疊內容
 
         list.PopItem();       //把項目從堆端頂端彈出
         list.PopItem();
         list.PopItem();
         list.Display();
         ReadKey();
      }
   }
}
