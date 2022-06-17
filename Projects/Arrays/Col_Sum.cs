using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Arrays
{
    class Col_Sum
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    
                    Console.Write(arr[i, j] + " ");

                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------");
                for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum = sum + arr[j, i];
                    Console.Write(arr[j, i] + " ");
                    
                }
                Console.WriteLine("  " + sum);
             //  Console.WriteLine();
                //Console.Write("   " + sum);


            }
            //Console.Write("   " + sum);

        }
    }
}
