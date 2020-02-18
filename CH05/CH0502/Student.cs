using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Console;

namespace CH0502
{
   //建立泛型類別Student，含有T型別參數，能以不同型別來建立資料
   class Student<T>
   {
      private int index;//陣列索引值
      private T[] score = new T[5]; //儲存6個元素

      //將資料放入陣列，stirng, int型別
      public void StoreArray(T arrData)
      {
         if (index < score.Length)
         {
            score[index] = arrData;
            index++;
         }
      }

      //讀取陣列元素
      public void Display()
      {
         foreach (T item in score)
         {
            Write($"{item, -6} ");
         }
         WriteLine();
      }
   }
}
