using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_Pro1
{
    
    class Arrays_op
    {
        public void reverse(int[] arr)
        {
            Console.WriteLine("Array is:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine("reverse is:");
            for (int i =arr.Length-1; i >= 0; i--)
            {
                Console.Write(arr[i]+" ");
            }

        }
        public void Min(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }

            }
            Console.WriteLine("Min is:"+min);

        }
        public void Max(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Max is:"+max);
        }
        public void Even(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i] + " : " + "Even");
                }
                else
                {
                    Console.WriteLine(arr[i]+" : "+"Odd");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Size");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter Array element:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Arrays_op ao = new Arrays_op();
            ao.reverse(arr);
            ao.Min(arr);
            ao.Max(arr);
            ao.Even(arr);
        }
    }
}
