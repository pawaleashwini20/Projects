using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.String_Assignment
{
    class Negative_ELE_SQ
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 3, -19, 29, 5, -61, 44, 7, -9 };
            Console.WriteLine(string.Join(" ", arr));
            int j = 0;
           for (int i = 0; i < arr.Length; i++)
           {
                if (arr[i] < 0)
                {
                    arr[i]=arr[i - 1] * arr[i - 1];
                }
           }
            

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
