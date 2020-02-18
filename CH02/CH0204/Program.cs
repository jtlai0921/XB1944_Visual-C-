using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//只有輸出時間，無輸入的資料
namespace CH0204
{
   class Program
   {
      static void Main(string[] args)
      {
         //以結構DateTime的屬性取得當前的日期和時間
         DateTime monent = DateTime.Now;
         //呼叫函式ToLongTiemString()將時間的時、分、秒轉為字串表示
         WriteLine($"現在時間：{monent.ToLongTimeString()}");
         ReadKey();
      }
   }
}
