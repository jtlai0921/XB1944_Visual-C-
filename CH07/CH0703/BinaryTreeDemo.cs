using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace CH0703
{
   class BinaryTreeDemo
   {
      static void Main(string[] args)
      {
         Node first = null;
         char[] ary = new char[9] { 'E', 'F', 'D', 'H', 'B', 'C', 'G', 'A', 'I' };
         
         BinaryTree btree = new BinaryTree();
         first = btree.CreateBTree(ary, ary.Length);

         WriteLine("--------前序走訪二元樹--------");
         btree.Preorder(first);

         WriteLine("\n\n--------中序走訪二元樹--------");
         btree.Inorder(first);

         WriteLine("\n\n--------後序走訪二元樹--------");
         btree.Postorder(first);

         ReadKey();
      }
   }
}
