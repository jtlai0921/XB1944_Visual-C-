using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0515
{
   class Program
   {
      static void Main(string[] args)
      {
         //二維陣列，「1」表示牆，無路；「0」表示可行走的路
         int[,] maze = new int[7, 10]{
               { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
               { 1, 0, 1, 0, 1, 0, 0, 0, 0, 1 },
               { 1, 0, 1, 0, 1, 0, 1, 1, 0, 1 },
               { 1, 0, 1, 0, 1, 1, 1, 0, 0, 1 },
               { 1, 0, 1, 0, 0, 0, 0, 0, 1, 1 },
               { 1, 0, 0, 0, 1, 1, 1, 0, 0, 1 },
               { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 } };

         WriteLine("老鼠走迷宮的路徑");
         FindPath(maze, 1, 1);
         Visited(maze);
         
         ReadKey();
      }

      //定義靜態方法，輸出陣列內容
      public static void Visited(int[,] ary)
      {
         for(int j = 0; j < ary.GetLength(0); j++)
         {
            for(int k = 0; k < ary.GetLength(1); k++)
               Write($"{ary[j, k], 3}");
            WriteLine();
         }
      }

      //定義靜態方法FindPath()，老鼠走迷宮的路徑
      public static bool FindPath(int[,] ary, int X, int Y)
      {
         string line = new string('-', 32);
         //記錄移動的座標X, Y
         WriteLine($"移動，X = {X}, Y = {Y}");
         Visited(ary);//輸出迷宮(二維陣列)
         WriteLine(line);
         //超出二維陣列範圍或陣列的元素為1的話予以忽略
         if (X >= 7 || Y >= 10) return false;
         if (ary[X, Y] == 1) return false;
         //將可行走過的路以「2」標示
         if (ary[X, Y] == 0) ary[X, Y] = 2;
         if (ary[X, Y] == 2 && (X == 6 || Y == 8)) return true;

         //開始位置(X = 1, Y = 1)，結束位置(X = 5, Y = 8)取得可走路徑
         if (Y < 8 && ary[X, Y + 1] == 0) //向右
            if (FindPath(ary, X, Y + 1)) return true;
 
         if (X < 5 && ary[X + 1, Y] == 0) //向下
            if (FindPath(ary, X + 1, Y)) return true;

         if (Y > 0 && ary[X, Y - 1] == 0) //向左
            if (FindPath(ary, X, Y - 1)) return true;

         if (X > 0 && ary[X - 1, Y] == 0) //向上
            if (FindPath(ary, X - 1, Y)) return true;
         
         return false;
      }
   }
}
