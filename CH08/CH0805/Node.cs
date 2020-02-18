using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH0805
{
   //定義圖形的頂點
   public class Node
   {
      //自動實做屬性
      public int Start { get; set; }//開始頂點
      public int Halt { get; set; } //結束頂點
      public int Cost { get; set; } //權值
      public bool IsDouble { get; set; } //是否重複項
   }

   //定義圖形
   public class Graph
   {
      private const int MAX = 100;     // 最大節點數
      public int[] vertex = new int[MAX];
      public int Edges { get; set; }
   }
}
