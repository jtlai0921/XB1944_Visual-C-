using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab_07_02
{
   class Program
   {
      static void Main(string[] args)
      {
         Node root = null, ptr = null;
         BinaryTree btree = new BinaryTree();
         int[] ary = { 63, 24, 90, 37, 12, 84, 41, 29, 23, 103, 7, 71 };

         for (int j = 0; j < 12; j++)
            root = btree.AppendItem(root, ary[j]);
         WriteLine("中序走訪 BST:");
         btree.Inorder(root);
         WriteLine();
         ptr = btree.FindItem(root);   //呼叫函式查訪節點
         WriteLine($"\n最小值 -> {ptr.Item}");

         ReadKey();
      }
   }
}
