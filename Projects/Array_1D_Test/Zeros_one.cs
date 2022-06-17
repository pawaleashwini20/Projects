using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Array_1D_Test
{
    class Zeros_one
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 0, 2, 0, 4, 0, 5, 0 };
            int[] arr2 = new int[arr.Length];
            /*foreach (int a in arr)
            {
                Console.Write(" ", a);
            }*/
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    arr[i]=1;
                }
            }
     
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
