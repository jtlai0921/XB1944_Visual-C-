using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0701
{
   class Program
   {
      static void Main(string[] args)
      {
         char[] fbtree = new char[16]; //以完滿二元樹儲存
         char[] ary = { ' ', 'E', 'D', 'F', 'B', 'H', 'A', 'C', 'G', 'I' };
         int j;

         CreateBTree(fbtree, ary, 9);
         string line = new string('-', 46);
         WriteLine(line);
         for (j = 1; j < 16; j++)
            Write($"|{fbtree[j], 2}");
         WriteLine();
         WriteLine(line);
         for (j = 1; j < 16; j++)
            Write($"|{j, 2}");
         ReadKey();
      }

      //定義靜態方法
      public static void CreateBTree(char[] tree,
            char[] ary, int len)
      {
         int j, level;                   //level樹的階曾

         tree[1] = ary[1];               //產生根節點
         for (j = 2; j <= len; j++)      //產生其它節點
         {
            level = 1;                   //從第一個階層開始
            while (tree[level] != 0)     //是否有子樹
            {
               if (ary[j] > tree[level]) //左？右子樹
                  level = level * 2 + 1; //右子樹 
               else
                  level = level * 2;     //左子樹 
            }
            tree[level] = ary[j];        //存入節點
         }
      }
   }
}
