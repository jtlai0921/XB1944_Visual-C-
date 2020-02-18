using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace CH0805
{
   public class MSTree
   {
      const int MAX = 100;
      readonly Node[] newNode = new Node[MAX];
      private Graph Gr = new Graph();//圖形物件
      readonly int[,] matrix = new int[MAX, MAX];
      public int Vertices { get; set; }//總頂點數
      public int TotalEdge { get; set; }//總邊線數

      //成員方法-讀取二維矩陣檔案
      public void CreateEdge()
      {
         string filePath = @"D:\DS for Visual C#\CH08\CH0805\matrix.dat";
         int j, k;
         if (!File.Exists(filePath))
         {
            WriteLine("檔案不存在...按任意字元結束");
            ReadKey();
            Environment.Exit(0);
         }
         // 讀取檔案並取得總節點數
         using (StreamReader sr = new StreamReader(filePath))
         {
            Vertices = int.Parse(sr.ReadLine());

            for (j = 1; j <= Vertices; j++)
            {
               string tmp = sr.ReadLine();
               string[] tmpAry = tmp.Split(' ');

               for (k = 1; k <= Vertices; k++)
                  matrix[j, k] = Convert.ToInt16(tmpAry[k - 1]);
            }
         }
      }

      //產生含有權值的相鄰陣列
      public void MakeAdjust()
      {
         Node ptr;
         int j, k, weight = 0;
         //讀取7*7 二維陣列
         for (j = 0; j <= Vertices; j++)
         {
            for (k = j + 1; k <= Vertices; k++)
            {
               weight = matrix[j, k];

               if (weight != 0)
               {
                  ptr = new Node()
                  {
                     Start = j,
                     Halt = k,
                     Cost = weight,
                     IsDouble = false
                  };
                  newNode[++TotalEdge] = ptr;
               }
            }
         }
      }

      //輸出圖形的頂點
      public void Display()
      {
         int j = 1;
         WriteLine($"頂點 = {Vertices} 邊線 = {TotalEdge}");
         while (j <= TotalEdge)
         {
            Write($"(V{newNode[j].Start}, V{newNode[j].Halt})" +
                  $" cost = {newNode[j].Cost, 2}");
            j++;
            WriteLine();
         }
      }

      //成員方法 -取得最小權值
      public Node SmallestCost()
      {
         int j, min = 1;
         int minweight = 1000;

         for (j = 1; j <= TotalEdge; j++)
         {
            if (newNode[j].IsDouble == false &&
                  newNode[j].Cost < minweight)
            {
               minweight = newNode[j].Cost;
               min = j;
            }
         }
         newNode[min].IsDouble = true;
         return newNode[min];
      }

      //成員方法-取得花費最小擴張樹
      public void Kruskal()
      {
         Node ptr = new Node();

         for (int j = 1; j <= Vertices; j++)
            Gr.vertex[j] = 0;
         Gr.Edges = 0;
         string line = new string('*', 22);
         WriteLine(line);
         WriteLine("圖形的最小擴張樹(MST)");
         //走訪圖形取得最小權值
         while (Gr.Edges != Vertices - 1)
         {
            ptr = SmallestCost();

            if (!IsCompare(ptr))
               Write($"(V{ptr.Start}, V{ptr.Halt})" +
                     $", cost = {ptr.Cost, 2}");
            WriteLine();
         }
      }

      public bool IsCompare(Node ptr)
      {
         int v1 = ptr.Start;
         int v2 = ptr.Halt;

         Gr.vertex[v1]++;
         Gr.vertex[v2]++;
         Gr.Edges++;
         if (Gr.vertex[v1] >= 2 && Gr.vertex[v2] >= 2)
         {
            if (v2 == 2)
               return false;
            Gr.vertex[v1]--;
            Gr.vertex[v2]--;
            Gr.Edges--;
            return true;
         }
         else
            return false;
      }
   }
}
