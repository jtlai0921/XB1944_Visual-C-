using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0707
{
   public class AVLTree
   {
      protected Node ptr = null;
      //插入節點時以AVL樹做調整
      public Node AddItem(Node ptr, int data, ref bool ht)
      {
         Node pivot, crucial;
         Node newNode = new Node(data)
         { Balance = 0, LNext = null, RLink = null};
         if (ptr == null)
         {
            ptr = newNode;
            ht = true;
         }

         //輸入的值 < 目前節點的值
         if (data < ptr.Item)
         {
            //以遞廻呼叫新增節點到左子樹
            ptr.LNext = AddItem(ptr.LNext, data, ref ht);
            if (ht == true)
            {
               //判斷平衡係數三種狀況：1, 0, -1
               switch (ptr.Balance)
               {
                  case -1: ptr.Balance = 0;//右子樹重
                     ht = false; break;
                  case 0: ptr.Balance = 1; break; //兩邊平衡
                  //左子樹重，對它進行調整
                  case 1: crucial = ptr.LNext;
                     if (crucial.Balance == 1)
                     {
                        WriteLine("以LL型做調整");
                        //把目前節點的左子節點調整為關鍵節點crucial
                        ptr.LNext = crucial.RLink;
                        //再把原是ptr所指的節點變成關鍵節點的右子節點
                        crucial.RLink = ptr;
                        //調整後平衡係數設為0
                        ptr.Balance = 0;
                        crucial.Balance = 0;
                        ptr = crucial;
                     }
                     else
                     {
                        WriteLine("以LR型做調整");
                        //把關鍵節點的右子樹設為樞紐
                        pivot = crucial.RLink;
                        //再把原為關鍵節點變成樞紐的左子節點
                        crucial.RLink = pivot.LNext;
                        //樞紐節點的左子節點為關鍵節點
                        pivot.LNext = crucial;
                        //原是目前節點改變為樞紐節點的右子節點
                        ptr.LNext = pivot.RLink;
                        pivot.RLink = ptr;

                        if (pivot.Balance == 1)
                           ptr.Balance = -1;
                        else
                           ptr.Balance = 0;

                        if (pivot.Balance == -1)
                           crucial.Balance = 1;
                        else
                           crucial.Balance = 0;
                        pivot.Balance = 0;
                        ptr = pivot;
                     }
                     ht = false; break;
               }
            }
         }

         if (data > ptr.Item)
         {
            //以遞廻呼叫新增節點到右子樹
            ptr.RLink = AddItem(ptr.RLink, data, ref ht);
            if (ht == true)
            {
               //判斷平衡係數三種狀況：1, 0, -1
               switch (ptr.Balance)
               {
                  case 1:
                     ptr.Balance = 0;//左子樹重
                     ht = false; break;
                  case 0: ptr.Balance = -1; break; //兩邊平衡
                  //右子樹重，對它進行調整
                  case -1:
                     crucial = ptr.RLink;
                     if (crucial.Balance == -1)
                     {
                        WriteLine($"以RR型做調整");
                        //設目前節點的右子節點為關鍵邊點，逆時旋轉
                        ptr.RLink = crucial.LNext;
                        //把ptr原來所指節點調整為左子節點
                        crucial.LNext = ptr;
                        ptr.Balance = 0;
                        crucial.Balance = 0;
                        ptr = crucial;
                     }
                     else
                     {
                        WriteLine("以RL型做調整");
                        //把關鍵節點的左子樹旋轉
                        pivot = crucial.LNext;
                        //把關鍵節點的左子樹旋轉為右子樹
                        crucial.LNext = pivot.RLink;
                        pivot.RLink = crucial;
                        ptr.RLink = pivot.LNext;
                        pivot.LNext = ptr;
                        
                        if (pivot.Balance == -1)
                           ptr.Balance = 1;
                        else
                           ptr.Balance = 0;

                        if (pivot.Balance == 1)
                           crucial.Balance = -1;
                        else
                           crucial.Balance = 0;
                        pivot.Balance = 0;

                        ptr = pivot;
                     }
                     ht = false; break;
               }
            }
         }
         return ptr;
      }

      //搜尋二元樹的節點
      public Node FindItem(Node ptr, int data)
      {
         if (ptr != null)
         {
            if (data < ptr.Item)
               ptr = FindItem(ptr.LNext, data);
            else if (data > ptr.Item)
               ptr = FindItem(ptr.RLink, data);
         }
         return ptr;
      }
      //輸出二元樹的節點
      public void Display(Node ptr, int level)
      {
         int j;
         //WriteLine($"ptr = {ptr.Item}");
         if (ptr != null)
         {
            Display(ptr.RLink, level + 1);
            //WriteLine();
            for (j = 0; j < level; j++)
               Write("  ");
            WriteLine($"[{ptr.Item}]");
            Display(ptr.LNext, level + 1);
         }
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
