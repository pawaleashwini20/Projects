using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Array_1D_Test
{
    class Zero_Last
    {

        public static void Main()
        {
            int[] arr = { 1, 9, 8, 4, 0, 0, 2, 7, 0, 6, 0, 9 };
            int n = arr.Length;
           
            Console.WriteLine("Array after pushing all zeros to the back: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
                 int count = 0;
                for (int j = 0; j < n; j++)
                    {
                        if (arr[j] != 0)
                        // here count is incremented
                        arr[count++] = arr[j];
                    }
                    while (count < n)
                    arr[count++] = 0;
            }
            }
        }
}
