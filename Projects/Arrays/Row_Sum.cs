using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Arrays
{
    class Row_Sum
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum = sum + arr[i, j];
                    Console.Write(arr[i,j]+" ");
                }
                Console.Write(" :"+sum);
                Console.WriteLine();

            }
        }
    }
}
