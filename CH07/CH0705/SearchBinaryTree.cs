using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0705
{
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

      //查找二元搜尋樹的節點
      public Node FindBSTItem(Node ptr, int data)
      {
         while (ptr != null)        //走訪二元搜尋樹
         {
            if (ptr.Item == data)   //找到了就回傳此節點的值
               return ptr;
            else
            {
               if (ptr.Item > data) //節點的值是否大於接收的參數值
                  ptr = ptr.LNext;  //左子節點 
               else
                  ptr = ptr.RLink;  //右子節點 
            }
         }
         return null;
      }

      //以遞廻查找二元搜尋樹的節點
      public Node FindBSTItemTo(Node ptr, int data)
      {
         Node left, right;

         if (ptr != null)
         {
            if (ptr.Item == data)
               return ptr;
            else
            {
               left = FindBSTItemTo(ptr.LNext, data); //往左子樹找
               right = FindBSTItemTo(ptr.RLink, data); //往右子樹找
            }
            if (left != null)//左子樹有此值
               return left;
            else
            {
               if (right != null)//右子樹有此值
                  return right;
               else
                  return null;
            }
         }
         else
            return null;
      }
   }
}