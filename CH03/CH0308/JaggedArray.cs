using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0308
{
   class JaggedArray
   {
      static void Main(string[] args)
      {
         //step1. 宣告不規則陣列-列長有3
         string[][] course = new string[3][];

         //step2. 以new運算子將每列的陣列元素初始化
         course[0] = new string[]
            {"Peter", "英文會話", "程式設計", "國文"};
         course[1] = new string[]
             {"Charles", "國文", "  計算機概論"};
         course[2] = new string[]
             {"Johnson", "多媒體論", "應用文", " 英文", "數學"};

         //step3. 利用雙層for -- 外層取得列數，內層for讀取列的每個元素
         for (int one = 0; one < course.Length; one++)
         {
            for (int two = 0; two < course[one].Length; two++)
               Write($"{course[one][two], -8}");            
            WriteLine();
         }
 
         ReadKey();
      }
   }
}
