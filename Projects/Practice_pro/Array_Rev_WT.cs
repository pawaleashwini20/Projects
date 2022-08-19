using System;
using System.Collections.Generic;
using System.Text;
//Array reverse
namespace Projects.Practice_pro
{
    class Array_Rev_WT
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 1, 0, 4, 6, 90 };
            Console.WriteLine(String.Join(" ",arr));
            Console.WriteLine("/////////////////");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
