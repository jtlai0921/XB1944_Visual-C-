using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//費氏搜尋樹
namespace CH1005
{
   class Chapter10
   {
      //private const int LEN = 12; 
      static void Main(string[] args)
      {
         int[] number = {25, 49, 54, 69, 74, 118, 130,
            141, 152, 163, 186, 432};

         int find, target;
         int len = number.Length;

         while(true)
         {
            Write("輸入欲搜尋的值，按-1結束->");
            find = Convert.ToInt32(ReadLine());

            if (find == -1) //輸入-1表示結束程式
               break;
            //呼叫方法做費氏樹搜尋
            target = FiboSearch(number, find, len);

            if (target == len)
               WriteLine($"*** 鍵值{find}沒有找到 ***\n");
            else
               WriteLine($"鍵值{number[target]}的位置[{target}]");
         }
      }

      //產生費氏級數
      static int fiboNums(int num)  
      {
         if (num == 1 || num == 0)
            return num;
         return fiboNums(num - 1) + fiboNums(num - 2);
      }

      //依陣列取得費氏樹的根節點的k值
      static int RootNode(int pos, int len)
      {
         while (fiboNums(pos) <= len)
            pos++;
         pos--; //根節點 Fib(k - 1), k = 7
         //WriteLine($"K Value = {pos}");
         return pos;
      }

      static int FiboSearch(int[] ary, int key, int len)
      {
         int root, rtLeft, fn2, tmp;
         int index = RootNode(2, len); //回傳費氏樹根節點
         //依K值所得費氏樹建立根節點 Fib(index - 1) = fib(6) = 8
         root = fiboNums(index);  
         //WriteLine($"fib[{index}] = {root}");
         //取得左子樹根節點 Fib(5) = 5
         rtLeft = fiboNums(index - 1);
         //取得右子樹根節點，F(6) - F(5) = 8 - 5 = 3
         fn2 = root - rtLeft;
         //WriteLine($"rtLeft = {rtLeft}, 2nd left = {fn2}");
         root--;   //配合陣列索引從零開始儲存資料

         //依據鍵值開始查找
         while(true)
         {
            if (key == ary[root])
               return root;
            else
            {
               if (index == 2) //沒有找到鍵值
                  return len;
               /*       8  費氏樹根節點 Fib(6) = 8
                       /
                      5   左子樹根節點 rtLeft
                     /
                    3     右子樹根節點 fn2
               */
               //向左子樹繼續查找
               if (key < ary[root])
               {
                  root -= fn2;
                  tmp = rtLeft;
                  rtLeft = fn2;
                  fn2 = tmp - fn2;
                  index -= 1;
               }
               else   //向右子樹繼續查找
               {
                  if (index == 3) return len;
                  root += fn2;    //右子樹根節點
                  rtLeft -= fn2;  //右子樹右子節點
                  fn2 -= rtLeft;  //右子樹右右子節點
                  index -= 2;
               }
            }
         }
      }
   }
}
