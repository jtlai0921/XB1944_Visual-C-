using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH0804
{
   //定義單向鏈結串列的節點
   public class Node
   {
      //自動實作屬性
      public int Edge { get; set; }
      public Node Next { get; set; }

      //定義建構函式 - 傳入數值
      public Node(int data)
      {
         Edge = data;
         Next = null;
      }
   }
}
