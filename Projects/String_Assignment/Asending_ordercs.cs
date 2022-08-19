using System;
using System.Collections.Generic;
using System.Text;
//9.	WAP sort array elements in ascending order
namespace Projects.String_Assignment
{
    class Asending_ordercs
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 22, 1, 44, 5, 0, 6, 4, 345, 11 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Array.Sort(arr);
            Console.WriteLine("------------");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("----------------");
            for (int i=arr.Length-1; i>=0;i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
