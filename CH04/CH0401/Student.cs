using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0401
{
   class Student
   {
      private string stuName;//私有欄位
      public string name     //公開屬性
      {
         get { return stuName; } //存取子get取得名稱
         set { stuName = value; }//存取子set設定名稱
      }
      public int score { get; set; } = 84; //自動實做屬性

      public void Display() =>   //運算式主體定義
         WriteLine($"Hi! {name}, 分數: {score}");
   }
}
