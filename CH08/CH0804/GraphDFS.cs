using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0804
{
   class GraphDFS
   {
      static readonly bool[] visited = new bool[6]; //記錄已走訪的陣列
      static readonly GraphLinked[] travel = new GraphLinked[6];

      static void Main(string[] args)
      {
         int item = 0;
         const int Row = 18;
         int[,] vertex = { //宣告二維矩陣來儲存圖形頂點
               {1, 2}, {2, 1}, {1, 5}, {5, 1}, {2, 3}, 
               {3, 2}, {2, 4}, {4, 2}, {3, 4}, {4, 3},
               {3, 5}, {5, 3}, {4, 5}, {5, 4},
               {2, 5}, {5, 2}, {1, 4}, {4, 1} };

         WriteLine("---圖形以相鄰串列表示---\n");
         for (int j = 1; j < 6; j++)
         {
            visited[j] = false;
            travel[j] = new GraphLinked();
            //讀取圖形的頂點
            for (int k = 0; k < Row; k++)
            {
               if (vertex[k, 0] == j)
               {
                  item = vertex[k, 1];
                  travel[j].AddItem(item);
               }
            }
         }

         for (int j = 1; j < 6; j++)
         {
            Write($"頂點[{j}] ==> ");
            travel[j].Display();
         }
         WriteLine("先深後廣搜尋法(DFS)搜尋順序如下：");
         SearchDFS(1);
         ReadKey();
      }

      //定義靜態方法-先深後廣搜尋法(DFS)
      public static void SearchDFS(int data)
      {
         visited[data] = true;
         Write($"頂點[{data}] > ");

         while ((travel[data].First) != null)
         {
            //如果尚未走訪，進行DFS遞迴呼叫
            if (visited[travel[data].First.Edge] == false) 
               SearchDFS(travel[data].First.Edge);
            travel[data].First = travel[data].First.Next;
         }
         WriteLine();
      }
   }
}
