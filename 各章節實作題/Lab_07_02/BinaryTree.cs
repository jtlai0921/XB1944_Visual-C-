using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab_07_02
{
   class BinaryTree
   {
      //protected Node root;

      //定義預設建構函式--初始化根節點為空值
      //public BinaryTree() => root = null;

      //產生二元樹
      public void CreateBTree(int[] ary, int len)
      {
         Node root = null;
         for (int j = 0; j < len; j++)
            root = AppendItem(root, ary[j]);
      }

      //把節點新增到二元樹
      public Node AppendItem(Node root, int data)
      {
         Node ptr, papa = null;
         Node newNode = new Node(data)
         {
            Item = data,
            LNext = null,
            RLink = null
         };
         if (root == null)
            return newNode;
         else
         {
            ptr = root;//設目前節點參考指向根節點

            //走訪二元樹
            while (ptr != null)
            {
               papa = ptr; //父節點參考papa
               //目前節點的值 > 接收的參數值
               if (ptr.Item > data)
                  ptr = ptr.LNext; //指向左子節點
               else
                  ptr = ptr.RLink; //指向右子節點
            }
            //父節點的值 > 接收的參數值
            if (papa.Item > data)
               papa.LNext = newNode;  //新節點為左子節點
            else
               papa.RLink = newNode;  //新節點為右子節點
         }
         return root;
      }

      /*  查訪二元搜尋樹的節點  */
      public Node FindItem(Node root)
      {
         Node ptr = root;

         while (ptr.LNext != null)
            ptr = ptr.LNext;
         return ptr;
      }

      //以中序走訪輸出二元樹
      public void Inorder(Node root)
      {
         if (root != null)
         {
            Inorder(root.LNext);        //1.先走訪左子樹
            Write($"[{root.Item}]>");  //2.再拜訪樹根
            Inorder(root.RLink);        //3.最後走訪右子樹
         }
      }
   }
}
