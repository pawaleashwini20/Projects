using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.String_Assignment
{
    class Array_rev
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 1, 33, 5, 4, 66, 100, 21, 200 };
            int l = arr.Length;
            for (int i = l-1; i>0; i--)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
