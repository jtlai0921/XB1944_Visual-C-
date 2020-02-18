using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH0702
{
   //定義雙向鏈結結構的節點
   public class Node
   {
      //自動實作屬性
      public char Item { get; set; }    //資料欄
      public Node LNext { get; set; }  //指向前一個節點鏈結
      public Node RLink { get; set; }  //指向下一個節點鏈結

      //定義建構函式 - 傳入數值
      public Node(char data)
      {
         Item = data;
         LNext = null;
         RLink = null;
      }
   }
}
