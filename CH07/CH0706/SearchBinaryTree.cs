using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0706
{
   //以雙卹鏈結串列實作二元搜尋樹
   class SearchBinaryTree
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
      public Node FindBSTItem(Node ptr, int data, ref int pos)
      {
         Node papa = ptr;           //指定目前節點為父節點
         pos = 0;
         while (ptr != null)        //走訪二元搜尋樹
         {
            if (ptr.Item == data)   //找到了就回傳此節點的值
               return papa;
            else
            {
               papa = ptr;
               if (ptr.Item > data) //節點的值是否大於接收的參數值
               {
                  ptr = ptr.LNext;  //左子節點
                  pos--;
               }
               else
               {
                  ptr = ptr.RLink;  //右子節點
                  pos = 1;
               }
            }
         }
         return null;
      }

      //刪除二元搜尋樹的節點
      public Node RemoveItem(Node root, int data)
      {
         Node ptr = null, papa, child;
         int pos = 0;
         //取得接收參數值的父節點參考
         papa = FindBSTItem(root, data, ref pos);
         //父節點為空值表示沒有找到
         if (papa == null)
            return root;
         switch(pos)
         {
            case -1: ptr = papa.LNext; break;//左子節點
            case 1: ptr = papa.RLink; break; //右子節點
            case 0: ptr = papa; break; //根節點
         }

         //狀況一：沒有左子樹
         if (ptr.LNext == null)
         {
            //­根節點否？不是的話，父節點的右鍵結指向目前節點的右子節點
            if (papa != ptr)
               papa.RLink = ptr.RLink;
            else //根節點指向右子節點
               root = root.RLink;
            WriteLine($"節點[{data}]已移除");
            return root;
         }

         //狀況二：沒有右子樹
         if (ptr.RLink == null)
         {
            //­根節點否？不是的話，父節點的左鍵結指向目前節點的左子節點
            if (papa != ptr)
               papa.LNext = ptr.LNext;
            else //根節點指向右子節點
               root = root.LNext;
            WriteLine($"節點[{data}]已移除");
            return root;
         }

         //狀況三：有左、右子樹
         papa = ptr;//父節點指向目前節點
         child = ptr.LNext;//目前節點的左鏈結為子節點
         //找到最右的葉節點--從父節點開始向右子樹尋找
         while (child.RLink != null) 
         {
            papa = child;
            child = child.RLink;
         }
         WriteLine($"節點[{data}]已移除");
         //子節點資料設為目前節點
         ptr.Item = child.Item;
         //父節點的左鏈結若指向子節點，往下一個子節點來找到最右的葉節點
         if (papa.LNext == child) 
            papa.LNext = child.LNext;
         else
            papa.RLink = child.RLink;
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
