using System;
using System.Collections.Generic;

namespace tesk13
{
    internal class Program
    {
        
         static void AddingToList(int[,] arr, List<int> num)
        {
            int rows = arr.GetUpperBound(0) + 1;
            int columns = arr.Length / rows;

            int n = 1;
            for (int j = 0; j < columns; j++)
            {
                for (int i = 0; i < rows; )
                {
                    if (j % 2 == 0)
                    {
                        if(i==0) i = rows - 1;
                        num.Add(arr[i, j]);
                        i--;
                        if (i == 0)
                        {
                            num.Add(arr[i, j]);
                            j++;
                        }
                    }
                    else
                    {
                        num.Add(arr[i,j]);
                        i++;
                    }

                }
            }
            
        }

         static string CheckSequence(List<int> num)
         {
             for (int i = 1; i < num.Count; i++)
             {
                 if (i == num.Count - 1)
                 {
                     if (!(num[i] > num[i-1] && num[i-1] > num[i-2]) && !(num[i] < num[i-1] && num[i-1] < num[i-2]))
                     {
                         return "Последовательность неупорядоченная";
                     }
                 }else if(!(num[i + 1] > num[i] && num[i] > num[i - 1]) && !(num[i + 1] < num[i] && num[i] < num[i - 1]))
                 {
                     return "Последовательность неупорядоченная";
                 }

             }
             return "Последовательность упорядоченная";
         }
    
         
        public static void Main()
        {
            int[,] arr = {{3, 4, 9, 10}, 
                           {2, 5, 8,11},
                           {1, 6, 7, 12}};

            List<int> num = new List<int>();

            AddingToList(arr, num);
            
            Console.Write(CheckSequence(num));

            
        }
    }
}