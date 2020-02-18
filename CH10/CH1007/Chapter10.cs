using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//線性探測法解決碰撞-若有碰撞移向下一個位置
namespace CH1007
{
   class Chapter10
   {
      const int PRIME = 13; //設定質數
      static readonly int[] hash = new int[PRIME];  //儲存雜湊值的雜湊表

      static void Main(string[] args)   //主程式
      {

         int[] number = {126, 432, 597, 459, 685, 106, 534,
                   659, 343, 680, 308, 372};
         int j, item, target;

         WriteLine("--雜湊表--");
         //讀取陣列number產生雜湊表
         for (j = 0; j < number.Length; j++)
            LinearProb(hash, number[j]);

         //輸出雜湊表
         for (j = 0; j < PRIME; j++)  
         {
            if (hash[j] != -1)
               WriteLine($"[{j, 2}] = {hash[j], 4}");
            else
               WriteLine($"{j}");
         }

         while(true)
         {
            Write("輸入欲搜尋的值，按-1結束->");
            item = Convert.ToInt32(ReadLine());
            if (item != -1)
            {
               target = searchHash(item);
               if (target != -1)
                 WriteLine($"鍵值{item}的索引{target}");
               else
                  WriteLine($"無此鍵值 {item} !");
            }
            else
               break;
         }
      }

      //建立雜湊函數-採用運算式主體
      static int runHash(int num) => num % PRIME;

      //定義靜態方法查找鍵值
      static int searchHash(int key)  
      {
         int pos = runHash(key);   //產生雜湊函數

         // 查找雜湊表的元素，有找到的話就回傳位置pos
         while (hash[pos] != key)
         {
            pos = (pos + 1) % PRIME;
            //沒有找到就回傳-1
            if (hash[pos] == 0 || pos == runHash(key)) 
               return -1;
         }
         return pos;
      }

      //定義靜態方法將陣列元素放入雜湊表
      static void LinearProb(int[] hash, int key)
      {
         int pos = runHash(key);   //產生雜湊函數
         //讀取陣列求得餘數，碰撞時以線性探測處理
         while (hash[pos] != 0)
         {
            pos = (pos + 1) % PRIME;
         }               
         hash[pos] = key; //存入雜湊表
      }
   }
}
