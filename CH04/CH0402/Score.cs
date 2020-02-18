using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0402
{
   class Score
   {
      //定義兩個自動實做屬性
      public int Number { get; set; }    //分數
      public string Course { get; set; } //科目

      //產生建構函式-初始化科目、分數
      public Score(string subject, int grade)
      {
         Course = subject; //儲存科目
         Number = grade;   //儲存分數
      }
      ~Score() { } //解構函式 
   }
}
