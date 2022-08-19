using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
   
    class Array_op
    {
        public void reverseArr(int[] arr)
        {
            Console.WriteLine("Array is:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("Reverse Array is:");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]+" ");
            }
        }
        public void Even_Odd(int[] arr)
        {
            int[] even = new int[arr.Length];
            int[] odd = new int[arr.Length];
            int k = 0,n=0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even[k] = arr[i];
                    k++;
                }
                else 
                {
                    odd[n] = arr[i];
                    n++;
                }
            }
            Console.WriteLine("//even//");
           // Console.WriteLine(String.Join(" ",even));
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(even[i]+" ");
            }
            Console.WriteLine("//Odd//");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(odd[i] + " ");
            }
        }
        public void Asending(int[] arr)
        {
            int k = 0;
            int l = arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine(String.Join(" ",arr));
            for (int i = 0; i<l/ 2; i++)
            {
                Console.Write(arr[i]+" ");
            }
            for (int j = l-1; j >=l/2; j--)
            {
                Console.Write(arr[j]+" ");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter array Element:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array_op a = new Array_op();
            a.reverseArr(arr);
            a.Even_Odd(arr);
            a.Asending(arr);
        }
    }
}
