﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH0706
{
   //定義雙向鏈結串列的節點，有左。右兩個鏈結
   public class Node
   {
      //自動實作屬性
      public int Item { get; set; }    //資料欄
      public Node LNext { get; set; }  //指向前一個節點鏈結
      public Node RLink { get; set; }  //指向下一個節點鏈結

      //定義建構函式 - 傳入字元
      public Node(int data)
      {
         Item = data;
         LNext = null;
         RLink = null;
      }
   }
}
