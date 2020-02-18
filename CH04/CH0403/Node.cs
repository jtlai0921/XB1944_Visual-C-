using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH0403
{
   public class Node   //定義鏈結串列的節點
   {
      //自動實作屬性
      public int Item { get; set; } //資料欄
      public Node Next { get; set; }//鏈結欄，指向下一個節點  

      //定義建構函式 - 傳入數值
      public Node(int data)
      {
         Item = data;
         Next = null;
      }
   }
}
