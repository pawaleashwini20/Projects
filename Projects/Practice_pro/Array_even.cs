using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Array_even
    {
        public void Even(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine("\nEnen:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.Write(arr[i]+"  ");
                }
            }
        }
        public void MinMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("\nMax is:"+max);
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("min is:"+min);
        }
        public void Reverse(int[] arr)
        {
            for (int i=arr.Length-1;i>=0;i--)
            {
                Console.Write(arr[i]+" ");
            }
        }
        public void ReverseWT(int[] arr)
        {
            int temp;
            int i = 0;
            int j = arr.Length - 1;
            while (i < j)
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
            Console.WriteLine("/////////////");
            Console.WriteLine(String.Join(" ",arr));
        }
        public void Array_alternate(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i=i+2)
            {
               sum=sum+arr[i] ;
            }
            Console.WriteLine("sum of alternate"+sum);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of Array:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array_even e = new Array_even();
            e.Even(arr);
            e.MinMax(arr);
            e.Reverse(arr);
            e.ReverseWT(arr);
            e.Array_alternate(arr);
        }
    }
}
