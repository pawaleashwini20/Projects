using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Array_operation
    {
        Array_operation(int[] arr)
        {
            Console.WriteLine("Enter Array element:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            foreach(int a in arr)
            {
                Console.Write(a+" ");
            }

        }
        public void Reverse(int[] arr)
        {
            Console.WriteLine("Reverse is:");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]+ " ");
            }

        
        }
        public void Even(int[] arr)
        {
            Console.WriteLine("\nEven:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.Write(arr[i]+"  ");
                }
            }
        }
        public void Search(int[] arr)
        {
            Console.WriteLine("\nEnter Key to Search:");
            int k = int.Parse(Console.ReadLine());
            int cnt = 0;
            for (int i = 0;i< arr.Length; i++)
            {
                if (arr[i] == k)
                {
                    Console.WriteLine(k+" Occires at "+i+" position");
                }
            }
        }
        public void Duplicate(int[] arr)
        {
            Console.WriteLine("\nafter remove Duplicate:");
            int[] merge = new int[arr.Length];
            int k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                bool isvisite = true;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[i] == arr[j])
                    {
                        isvisite = false;
                        break;
                    }
                }
                if (isvisite == true)
                {
                    merge[k] = arr[i];
                    k++;
                }
            }
            for (int i = 0; i < k; i++)
            {
                Console.Write(merge[i] + " ");
            }
        }
        public void Unique(int[] arr)
        {
            Console.WriteLine("\nUnique elements:");
            int[] merge = new int[arr.Length];
            int k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                bool isvisite = true;
                int cnt = 1;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[i] == arr[j])
                    {
                        isvisite = false;
                        break;
                    }
                }
                if (isvisite == true)
                {
                    for(k=i+1;k<arr.Length;k++)
                    {
                        if (arr[i] == arr[k])
                        {
                            cnt++;
                        }

                    }
                    if (cnt == 1)
                    {
                        Console.WriteLine(arr[i]+":"+cnt);
                    }
                   
                }
            }
          
        }
        public void Occurrance(int[] arr)
        {
            Console.WriteLine("\nOccurrance of element:");
            int[] freq = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                freq[i] = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        freq[i]++;
                        arr[j] = '0';
                    }
                }
            }
            for (int i= 0;i< freq.Length;i++)
            {
                if (arr[i] != ' ' && arr[i] != '0')
                {
                    Console.WriteLine(arr[i]+" : "+freq[i]);
                }
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Enter size of Array:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Array_operation ar = new Array_operation(arr);
            ar.Reverse(arr);
            ar.Even(arr);
            ar.Search(arr);
            ar.Duplicate(arr);
            ar.Unique(arr);
            ar.Occurrance(arr);
        }
    }
}
