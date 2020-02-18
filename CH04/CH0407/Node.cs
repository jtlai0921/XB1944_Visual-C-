using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH0407
{
   //以鏈結串列結構來定義多項式
   public class Node
   {
      //自動實作屬性
      public int Coef { get; set; }    //多項式非零係數
      public int Exp { get; set; }     //多項式指數
      public Node Next { get; set; }   //鏈結參考 Next 指向下一個節點

      public Node() {; } //預設建構函式
      //定義建構函式 - 傳入數值
      public Node(int data, int pow)
      {
         Coef = data;
         Exp = pow;
         Next = null;
      }
   }
}
