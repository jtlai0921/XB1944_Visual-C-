using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0706
{
   class FindBSTDemo
   {
      static void Main(string[] args)
      {
         Node first = null;
         SearchBinaryTree bstree = new SearchBinaryTree();
         int[] data = { 60, 25, 93, 34, 18, 79 };
         first = bstree.CreateBTree(data, data.Length);
         WriteLine("--------中序走訪二元樹--------");
         bstree.Inorder(first);

         Write("\n輸入欲除移的節點--> ");
         int target = Convert.ToInt32(ReadLine());

         first = bstree.RemoveItem(first, target);
         WriteLine("二元搜尋樹所餘的節點");
         bstree.Inorder(first);

         ReadKey();
      }
   }
}
