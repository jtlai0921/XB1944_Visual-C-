using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH0408
{
   class SparseMatrixApp
   {
      static void Main(string[] args)
      {
         Node head;
         int rows, cols, j, k;
         int[,] sparse = new int[4, 5]
                      {{  0,  4,  0, 0, 3 },
                       { -12, 3,  0, 9, 0 },
                       {   0, 0, 11, 0, 2 },
                       {   0, 0,  0, 6, 0 } };
         rows = sparse.GetLength(0);//取得陣列列長度
         cols = sparse.GetLength(1);//取得陣列欄長度
         SparseMatrix matrix = new SparseMatrix();
         matrix.CreateItem(rows, cols);
         for (j = 0; j < 4; j++)
         {
            for (k = 0; k < 5; k++)
            {
               if (sparse[j, k] != 0)
                  //head = insert(head, j, k, sparse[j, k]);
            }
         }
         ReadKey();
      }
   }
}
