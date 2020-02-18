using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0705
{
   class FindBstDemo
   {
      static void Main(string[] args)
      {
         Node first = null, search = null;
         SearchBinaryTree sbtree = new SearchBinaryTree();

         int[] ary = { 60, 25, 93, 34, 18, 79 };
         first = sbtree.CreateBTree(ary, ary.Length);

         Write("輸入欲查找的節點--> ");
         int target = Convert.ToInt32(ReadLine());
         search = sbtree.FindBSTItemTo(first, target);
         if (search != null)
            Write($"找到二元搜尋樹的節點-->{search.Item}");
         else
            Write($"二元搜尋樹的節點[{target}]沒有找到");
         ReadKey();
      }
   }
}
