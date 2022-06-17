using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Arrays
{
    class Sum_2D
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter row,Coulmn");
            int i = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            int[ , ] arr = new int[i, j];
            int[,] arr1 = new int[i, j];
            int[,] sum = new int[i, j];
            Console.WriteLine("Enter element:");
            int a = 0;
            for (int m = 0; m < arr.GetLength(0); m++)
            {
                for (int n = 0; n < arr.GetLength(1); n++)
                {
                    //a = int.Parse(Console.ReadLine());
                     arr[m,n]= int.Parse(Console.ReadLine());
                    //arr[i, j] = a;
                    //Console.WriteLine(arr[i,j]+"  ");
                }
            }
            for (int m = 0; m < arr.GetLength(0); m++)
            {
                for (int n = 0; n < arr.GetLength(1); n++)
                {
                    Console.Write(arr[m, n]+"  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Second array:");

            for (int m = 0; m < arr1.GetLength(0); m++)
            {
                for (int n = 0; n < arr1.GetLength(1); n++)
                {
                    //a = int.Parse(Console.ReadLine());
                    arr1[m, n] = int.Parse(Console.ReadLine());
                    //arr[i, j] = a;
                    //Console.WriteLine(arr[i,j]+"  ");
                }
            }
            for (int m = 0; m < arr1.GetLength(0); m++)
            {
                for (int n = 0; n < arr1.GetLength(1); n++)
                {
                    Console.Write(arr1[m, n] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Sum is:\n");
            for (int m = 0; m < sum.GetLength(0); m++)
            {
                for (int n = 0; n < sum.GetLength(1); n++)
                {
                    Console.WriteLine( "sum[i, j] ="+ arr[i, j] + arr1[i, j]);
                }
            }
            /*for (int m = 0; m < sum.GetLength(0); m++)
            {
                for (int n = 0; n < sum.GetLength(1); n++)
                {
                    Console.Write(sum[m, n] + "  ");
                }
                Console.WriteLine();
            }*/
        }
    }
}
