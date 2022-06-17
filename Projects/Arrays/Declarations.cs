using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Arrays
{
    class Declarations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array size:");
            int n = int.Parse(Console.ReadLine());
            int[] arr= new int[n];
            Console.WriteLine("Enter Elements in array:");
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                arr[i] = x;
            }
            //Traditional for loop
            Console.WriteLine("Array is:\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i]+" ");
            }
            //foeeach loop
            Console.WriteLine("\nArray is:");
            foreach (int x in arr)
            {
                Console.Write(x+"  ");
            }
            //ForEach loop
            Console.WriteLine("Array is:");
             //arr.ToList().ForEach(x => Console.Write(x));

            Console.WriteLine(string.Join(" ",arr));
        }

    }
}
