using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Merge_without_duplicate
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 1, 3, 4, 5, 0 };
            int[] arr2 = { 2, 4, 6, 9, 11 };
            int[] merge = new int[arr1.Length + arr2.Length];
            int k = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                merge[k] = arr1[i];
                k++;
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                bool ispresent = true;
                for (int j = k-1; j >=0; j--)
                {
                    if (merge[j] == arr2[i])
                    {
                        ispresent = false;
                        break;
                    }

                }
                if (ispresent ==true)
                {
                    merge[k] = arr2[i];
                    k++;
                }
               
            }
            Console.WriteLine("//////////////////");
            for (int i = 0; i < k; i++)
            {
                Console.Write(merge[i]+" ");
            }
        }
    }
}
