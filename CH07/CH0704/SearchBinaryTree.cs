﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/*    中序走訪二元樹
          60  
         /   \
       25     93
      / \     /
    18   34  79
Output: 18, 25, 34, 60, 79, 93 */

namespace CH0704
{
   //雙向鏈結串列實作二元樹
   public class SearchBinaryTree
   {
      protected Node root;

      //定義預設建構函式--初始化根節點為空值
      public SearchBinaryTree() => root = null;

      //產生二元樹
      public Node CreateBTree(int[] ary, int len)
      {
         for (int j = 0; j < len; j++)
            root = AppendItem(ary[j]);
         return root;
      }

      //把節點新增到二元樹
      public Node AppendItem(int data)
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

      //定義方法-中序走訪二元樹
      public void Inorder(Node root)
      {
         if (root != null)
         {
            Inorder(root.LNext);        //1.先走訪左子樹
            Write($"[{root.Item}]->");  //2.再拜訪樹根
            Inorder(root.RLink);        //3.最後走訪右子樹
         }
      }
   }
}
