using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0707
{
   class AVLTreeDemo
   {
      static void Main(string[] args)
      {
         int num, choice;
         bool hti = false;
         Node root = null;
         AVLTree btree = new AVLTree();
         string line = new string('*', 22);
         while (true)
         {
            WriteLine(line);
            WriteLine(" <1> 新增 <2> 列印 <3>結束");
            WriteLine(line);
            Write(" --請輸入選項-->... ");
            choice = int.Parse(ReadLine());
            switch (choice)
            {
               case 1:
                  Write("輸入新值 --> ");
                  num = int.Parse(ReadLine());
                  if (btree.FindItem(root, num) == null)
                     root = btree.AddItem(root, num, ref hti);
                  else
                     WriteLine("不能輸入重複的值");
                  break;
               case 2:
                  if (root == null)
                  {
                     WriteLine("二元樹是空的...");
                     continue;
                  }
                  WriteLine("--二元樹--");
                  btree.Display(root, 1);
                  WriteLine();
                  WriteLine("中序走訪二元樹 --> ");
                  btree.Inorder(root);
                  WriteLine("\n"); break;
               case 3: Environment.Exit(0); break;
            }
         }
      }
   }
}
