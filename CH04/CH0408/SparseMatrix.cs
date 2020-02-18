using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0408
{
   //定義稀疏矩陣類別
   class SparseMatrix
   {
      protected Node first;
      public SparseMatrix() { first = null; }

      //定義成員方法來建立稀疏矩陣
      public void CreateItem(int row, int col)
      {
         int len;
         
         //以列、欄的最大值來取得陣列長度
         if (row > col)
            len = row;
         else
            len = col;

         //設陣列的列、欄
         first.Row = row;
         first.Column = col;
         
         //return head;
      }

      public Node InsertItem(int row, int col, int data)
      {
         Node newNode = new Node()
         {
            Row = row, Column = col, Item = data
         };
         

         //
         Node pos = &head[colm];
         //¨«³X¦ê¦C¨Ó´¡¤J¦C
         while ((pos->down != &head[colm]) && row > pos->down->row)
            pos = pos->down;        //²¾¦V¤U¤@­Ó¸`ÂI

         newNode->down = pos->down; //·s¸`ÂI«ü¦V¤U¤@­Ó¸`ÂI
         pos->down = newNode;       //«e¤@­Ó¸`ÂI¦¨¬°·s¸`ÂI

         //¥Ñ«ü¼ÐrightÂà´«¬°¦ê¦Cªº¦C
         pos = &head[row];
         //¨«³X¦ê¦C¨Ó´¡¤JÄæ
         while (pos->right != &head[row] &&
               colm > pos->right->colm)
            pos = pos->right;

         newNode->right = pos->right; //·s¸`ÂI«ü¦V¤U¤@­Ó¸`ÂI
         pos->right = newNode;       //«e¤@­Ó¸`ÂI¦¨¬°·s¸`ÂI
         return head;
      }
   }
}
