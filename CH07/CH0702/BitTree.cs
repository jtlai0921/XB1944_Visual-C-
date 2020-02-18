using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/*    產生的二元樹
          E            
         / \           
        D   F          
       /     \         
      B       H        
     / \     / \       
    A   C   G   I      */

namespace CH0702
{
   //雙向鏈結實作二元樹
   public class BitTree
   {
      protected Node root;

      //定義預設建構函式--初始化根節點為空值
      public BitTree()=>root = null;

      //產生二元樹
      public void CreateBTree(char[] ary, int len)
      {
         for (int j = 0; j < len; j++)
            root = AppendItem(ary[j]);
      }

      //把節點新增到二元樹
      public Node AppendItem(char data)
      {
         Node ptr, papa = null;
         Node newNode = new Node(data)
         {
            Item = data, LNext = null, RLink = null
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

      public void Display()
      {
         Node ptr = root.LNext;
         WriteLine($"Root = {root.Item}");
         Write("左子樹--> ");
         while (ptr != null)
         {
            Write($"[{ptr.Item}]");
            ptr = ptr.LNext;
         }
         WriteLine();
         ptr = root.RLink;
         Write("右子樹--> ");
         while (ptr != null)
         {
            Write($"[{ptr.Item}]");
            ptr = ptr.RLink;
         }
         WriteLine();
      }
   }
}
