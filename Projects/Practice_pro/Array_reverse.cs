using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Array_reverse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array size:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr=new int[n];
            Console.WriteLine("Enter element:");
            for (int m = 0; m < arr.Length; m++)
            {
                arr[m] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array is:");
            for (int m = 0; m < arr.Length; m++)
            {
                Console.Write(arr[m]+" ");
            }
            Console.WriteLine("\nReverse is:");
            int i = 0;
            int j = arr.Length - 1;
            int temp;
            while (i <j)
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
            Console.Write(String.Join(" ",arr));
        }
    }
}
