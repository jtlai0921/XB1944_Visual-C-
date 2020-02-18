using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH0408
{
   //定義環狀串列節點
   public class Node
   {
      //自動實作屬性
      public int Item { get; set; }     //資料欄
      public int Row { get; set; }      //矩陣的列
      public int Column { get; set; }   //矩陣的欄
      public Node Right { get; set; }   //指向同一列鏈結
      public Node Down { get; set; }    //指向同一欄鏈結

      //定義預設建構函式
      public Node() { Right = null; Down = null; }
   }
}
