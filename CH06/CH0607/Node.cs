using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH0607
{
   //定義單向鏈結串列的節點
   public class Node
   {
      //自動實作屬性
      public int Item { get; set; } //資料
      public int Prior { get; set; }//權值
      public Node Next { get; set; }//指向下一個節點的參考

      //定義建構函式 - 傳入資料、權值
      public Node(int data, int pri)
      {
         Item = data;
         Prior = pri;
         Next = null;
      }
   }
}
