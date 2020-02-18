using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH0608
{
   //定義環狀單向鏈結串列節點
   public class Node
   {
      //自動實作屬性
      public int Item { get; set; } //資料
      public Node Next { get; set; }  //指向下一個節點的參考

      public Node(int data)
      {
         Item = data;
         Next = null;
      }
   }
}
