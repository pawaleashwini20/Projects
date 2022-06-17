using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Arrays
{
    class Sum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter elements:");
            int[] arr = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                arr[i] = x;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i]+" ");
            }
            for (int i = 0; i < n; i++)
            {
                sum=sum+arr[i];
            }
            Console.WriteLine("Sum is:"+sum);
        }
    }
}
