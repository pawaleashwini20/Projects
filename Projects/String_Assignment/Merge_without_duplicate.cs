using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.String_Assignment
{
    class Merge_without_duplicate
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 3, 2, 5, 11, 8 };
            int[] arr2 = { 2, 6, 9, 8, 0, 10 };
            int[] c = new int[arr1.Length + arr2.Length];
            Console.WriteLine(String.Join(" ",arr1));
            Console.WriteLine(String.Join(" ",arr2));
            int j = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                c[j] = arr1[i];
                j++;
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                bool ispresent = false;
                for (int k = j - 1; k >= 0; k--)
                {
                    if (c[k] == arr2[i])
                    {
                        ispresent = true;
                        break;
                    }
                }
                if (ispresent == false)
                {
                    c[j] = arr2[i];
                    j++;
                }
            }
            Console.WriteLine("////////////////");
            for (int i = 0; i < j; i++)
            {
                Console.Write(c[i]+" ");
            }
        }
      
    }
}
