using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Arrays
{
    class Reverse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter Array element:");
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                arr[i] = x;
            }
            for (int i = 0; i <n; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine("Reverse:");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]+"  ");
            }
        }
    }
}
