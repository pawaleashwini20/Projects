using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.String_Assignment
{
    class Merge_arr
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 3, 4, 5 };
            int[] arr1 = { 6, 7, 8, 9 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine("\n-----------");
            int n = arr.Length + arr1.Length;
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            int[] merge = new int[n];
            int j = 0;
            Console.WriteLine("\nNew Array:\n");
            for (int i = 0; i < arr.Length; i++)
            {
                merge[j++] = arr[i];
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                merge[j++] = arr1[i];
            }
            for (j = 0; j < n; j++)
            {
                Console.Write(merge[j] + " ");
            }

        }
    }
}
