using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0806
{
   public class Matrix
   {
      protected const int INFINITE = 10000000;
      protected int[,] Plot { get; set; }
      // 建構函式
      public Matrix(int[,] ary, int len)
      {
         int j, k, start, halt;
         Plot = new int[len, len];//儲存相鄰陣列

         //依二維陣列長度傳入的長度len，讀取其元素
         for (j = 1; j < len; j++)
         {
            for (k = 1; k < len; k++)
            {
               if (j != k)
                  Plot[j, k] = INFINITE;
               else
                  Plot[j, k] = 0;
            }
         }

         for (j = 0; j < ary.GetLength(0); j++)
         {
            start = ary[j, 0];//開始頂點
            halt = ary[j, 1]; //結束頂點
            Plot[start, halt] = ary[j, 2];
         }
      }

      // 將圖形以相鄰矩陣方式輸出
      public void Display()
      {
         for (int j = 1; j < Plot.GetLength(0); j++)
         {
            for (int k = 1; k < Plot.GetLength(1); k++)
               if (Plot[j, k] == INFINITE)
                  Write("   ∞");
               else
               {
                  if (Plot[j, k] == 0) Write("");
                  Write($"{Plot[j, k],5}");
               }
            WriteLine();
         }
      }
   }

   // Dijkstra演算法類別繼承Matrix類別
   class Dijkstra : Matrix
   {
      public int[] Cost { get; set; }
      public int[] Visited { get; set; }

      // 建構函式以base()函式呼叫父類別的建構函式
      public Dijkstra(int[,] matrix, int len) : 
            base(matrix, len)
      {
         Cost = new int[len];
         Visited = new int[len];
         for (int i = 1; i < len; i++) Visited[i] = 0;
      }

      // 單點對全部頂點最短距離
      public void OneToAllPath(int single)
      {
         int limitless, j, k;
         int target = 1;

         //取得從頂點<5>到<4>、<6>的權值
         for (j = 1; j < Plot.GetLength(0); j++)
         {
            Cost[j] = Plot[single, j];
            //WriteLine($"{j}| Cost = {Cost[j]}");
         }
         //WriteLine();  

         Visited[single] = 1; //儲存找過的頂點
         Cost[single] = 0;
         for (j = 1; j < Plot.GetLength(0) - 1; j++)
         {
            limitless = INFINITE;

            //十算頂點<5>到各頂點最短路徑的權值
            for (k = 1; k < Plot.GetLength(1); k++)
               if (limitless > Cost[k] && Visited[k] == 0)
               {
                  target = k;
                  limitless = Cost[k];
                  //WriteLine($"{k}| Cost = {Cost[k]}");
               }
            Visited[target] = 1;
            for (k = 1; k < Plot.GetLength(1); k++)
            {
               if (Visited[k] == 0 &&
                     Cost[target] + Plot[target, k] < Cost[k])
                  Cost[k] = Cost[target] + Plot[target, k];
             }
         }
         WriteLine("\n頂點[5]到各頂點的最短距離");
         for (k = 1; k < Plot.GetLength(0); k++)
            WriteLine($"(V5 <==> V{k})" +
               $"最短距離 = {Cost[k],5:N0}");
      }
   }
}
