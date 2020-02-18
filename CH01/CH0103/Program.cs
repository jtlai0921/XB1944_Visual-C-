using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; //匯入靜態類別

namespace CH0103
{
   class Program
   {
      //以byte為列舉型別，定義星期常數值，0代表星期天
      enum Weeks : byte
      {
         Sunday, Monday, Tuesday,
         Wednesday, Thursday, Friday, Saturday
      }

      static void Main(string[] args)
      {
         Write("輸入0~6數值，轉換星期 -- ");
         byte days = byte.Parse(Console.ReadLine());

         switch (days)//進行多重條件判斷
         {
            case 0: //數值0是星期天，存取列舉成員
               WriteLine($"{Weeks.Sunday} 是星期天");
               break;
  
            case 1:  //數值1是星期一
               WriteLine($"{Weeks.Monday} 是星期一");
               break;
      
            case 2:  //數值2是星期二
               WriteLine($"{Weeks.Tuesday} 是星期二");
               break;
 
            case 3:  //數值3是星期三
               WriteLine($"{Weeks.Wednesday} 是星期三");
               break;

            case 4:  //數值4是星期四
               WriteLine($"{Weeks.Thursday} 是星期四");
               break;

            case 5:  //數值5是星期五
               WriteLine($"{Weeks.Friday} 是星期五");
               break;

            case 6:  //數值6是星期六
               WriteLine($"{Weeks.Saturday} 是星期六");
               break;
            default: //輸入0~6以外的數值
               WriteLine("數字不正確，重新輸人");
               break;
         }
         ReadKey();
      }
   }
}
