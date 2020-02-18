using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0702
{
   class BitTreeDemo
   {
      static void Main(string[] args)
      {
         char[] ary = new char[9]{ 'E', 'D', 'F', 'B', 'H', 'A', 'C', 'G', 'I' };
         BitTree btree = new BitTree();
         btree.CreateBTree(ary, ary.Length);         
         btree.Display();
         ReadKey();
      }
   }
}
