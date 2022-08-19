using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Array_mim_max
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 9, 7, 0, -8, 6 };

            int max = arr[0];
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max=arr[i];
                }
            }
            Console.WriteLine(max);
           // int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine(min);
        }
    }
}
