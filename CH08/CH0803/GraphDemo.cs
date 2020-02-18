using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0803
{
   class GraphDemo
   {
      static readonly bool[] visited = new bool[7]; //記錄已走訪的陣列
      static readonly int[] list = new int[10];     //儲存佇列項目
      static readonly GraphLinked[] travel = new GraphLinked[7];
      static readonly Node[] head = new Node[7];
      static int Rear { get; set; } = -1;  //指向佇列後端的參考
      static int Front { get; set; } = -1;  //指向佇列前端的參考

      static void Main(string[] args)
      {
         int item = 0;
         const int Row = 14;
         int[,] vertex = { //宣告二維矩陣來儲存圖形頂點
               {1, 2}, {2, 1}, {1, 4}, {4, 1}, {1, 3},
               {3, 1}, {4, 2}, {2, 4}, {4, 3}, {3, 4},
               {3, 5}, {5, 3}, {5, 6}, {6, 5} };

         WriteLine("---圖形以相鄰串列表示---\n");
         for (int j = 1; j < 7; j++)
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

         for (int j = 1; j < 7; j++)
         {
            Write($"頂點[{j}] ==> ");
            travel[j].Display();
         }
         WriteLine("先廣後深搜尋法(BFS)的搜尋順序如下：");
         SearchBFS(1);
         //WriteLine("先深後廣搜尋法(DFS)搜尋順序如下：");
         //SearchDFS(1);
         ReadKey();
      }

      //定義靜態方法，把資料從佇列後端存入
      public static void Enqueue(int data)
      {
         if (Rear >= 10) return;
         Rear++;
         list[Rear] = data;
      }

      //定義靜態方法，把資料從佇列前端移除再變更Front參考
      public static int Dequeue()
      {
         if (Front == Rear)    //檢查佇列是否是空的
            WriteLine("空的佇列，無法刪除項目");
         Front++;          //參考Front向後移動
         return list[Front];
      }
 
      //先廣後深(BFS)搜尋法
      public static void SearchBFS(int data)
      {
         Node current;
         head[data] = new Node(data);
         Enqueue(data);        //將第一個頂點存入佇列
         visited[data] = true;    //將走訪過的頂點設定為1
         Write($"頂點[{head[data].Edge}] > "); //輸出走訪過的頂點
         while (Front != Rear)
         {
            data = Dequeue();  //從佇列取出頂點
            current = travel[data].First; //先記錄目前頂點的位置
            while (current != null)
            {
               if (visited[current.Edge] == false)
               {
                  Enqueue(current.Edge);
                  visited[current.Edge] = true; //已走訪過則記錄
                  Write($"頂點[{current.Edge}] > ");
               }
               current = current.Next;
            }
         }
         WriteLine();
      }      
   }
}
