using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Arrays
{
    class Alternate_ele
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine(arr[]+" ");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\nAlternate element:");
            for (int i = 0; i < arr.Length - 1; i=i+2)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
