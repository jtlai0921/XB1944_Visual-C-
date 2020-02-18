using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0407
{
   public class Polynomial
   {
      protected Node item1, item2, result;

      //定義預設建構函式--初始化指向相關節點的參考為空值
      public Polynomial()
      {
         result = null; //儲存多項式
         item1 = null;  //儲存第一個多項式
         item2 = null;  //儲存第二個多項式
      }

      //產生多項式並加入非零項
      public Node CreateItem(Node A, int data, int pow)
      {
         //指向目前節點的參考current, new運算子產生新節點newNode並配置記憶體
         Node current;
         Node newNode = new Node(data, pow);
         
         //如果第一個節點first是空的，就把新節點設為第一個節點
         if (A == null)
            A = newNode;
         else //有第一個節點就走訪
         {
            current = A;
            while (current.Next != null)//走訪串列到最後節點
               current = current.Next;
            //目前節點的Next指標指向新節點
            current.Next = newNode;
         }
         return A;
      }

      //兩個多項式相加
      public Node AddItem()
      {
         Node ptr1, ptr2, newNode;
         Node previous = null;
         ptr1 = item1;
         ptr2 = item2;

         while (ptr1 != null || ptr2 != null) //將兩個多項式相加
         {
            newNode = new Node() { Next = null};
            //第一個多項式指數 > 第二個多項式
            if (ptr1 != null && (ptr2 == null || 
                  ptr1.Exp > ptr2.Exp))
            {
               newNode.Coef = ptr1.Coef;
               newNode.Exp = ptr1.Exp;
               ptr1 = ptr1.Next;
            }
            //第一個多項式指數 < 第二個多項式
            else if (ptr1 == null || ptr1.Exp < ptr2.Exp)
            {
               newNode.Coef = ptr2.Coef;
               newNode.Exp = ptr2.Exp;
               ptr2 = ptr2.Next;
            }
            else //把兩個指數相同的多項數相加
            {
               newNode.Coef = ptr1.Coef + ptr2.Coef;
               newNode.Exp = ptr1.Exp;
                
               if (ptr1 != null) ptr1 = ptr1.Next;
               if (ptr2 != null) ptr2 = ptr2.Next;
            }
            //若兩個多項式相加結果非零時，就以result儲存結果
            if (newNode.Coef != 0)
            {
               if (result == null)
                  result = newNode;
               else
                  previous.Next = newNode;
               previous = newNode;
            }
            else
               newNode = null;
         }
         return result;
      }

      //取得第一個多項式
      public Node ShowPoly1()
      {
         item1 = CreateItem(item1, 3, 7);
         item1 = CreateItem(item1, 8, 4);
         item1 = CreateItem(item1, 1, 3);
         item1 = CreateItem(item1, 7, 1);
         return item1;
      }

      public Node ShowPoly2() //取得第二個多項式
      {
         item2 = CreateItem(item2, 4, 5);
         item2 = CreateItem(item2, 6, 4);
         item2 = CreateItem(item2, -2, 1);
         return item2;
      }
 
      //輸出多項式
      public void Display(Node result)
      {
         Node current = null;   //指向目前節點
         current = result; //從第一個節點開始準備走訪串列

         //串列不是空的情形下讀取節點
         while (current != null)
         {
            Write($"{current.Coef}X^{current.Exp}");
            if (current.Next != null && 
                  current.Next.Coef >= 0)
               Write(" + ");
            else Write(" ");
            current = current.Next;
         }
         WriteLine();
      }
   }
}
