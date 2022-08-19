using System;
using System.Collections.Generic;
using System.Text;
//2.	Write a program to merge two sorted array of number such that new array is
//sorted array and there should be no duplicate in new array.[1M]


namespace Projects.Test_Paper15_aug
{
    class Remover_Duplicates
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 4, 5, 6, 7, 8 };
            Console.Write(String.Join(" ", arr1));
            Console.WriteLine("\n");
            Console.Write(String.Join(" ", arr2));
            int[] merge = new int[arr1.Length+arr2.Length];
            int l = arr1.Length + arr2.Length;
            int k = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                merge[k] = arr1[i];
                k++;
            }
           // Console.WriteLine("merge Array:");
            //Console.Write(String.Join(" ", merge));
            for (int i = 0; i < arr2.Length; i++)
            {
                bool isvisite = true;
                for (int j= k - 1; j >= 0; j--)
                {
                    if (merge[j] == arr2[i])
                    {
                        isvisite = false;
                        break;
                    }
                }
                if (isvisite == true)
                {
                    merge[k] = arr2[i];
                    k++;
                }
            }
            Console.WriteLine("\nnew Array....");
            for (int i = 0; i <k; i++)
            {
                Console.Write(merge[i]+"  ");
              
            }
        }
    }
}
