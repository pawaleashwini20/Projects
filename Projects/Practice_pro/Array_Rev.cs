using System;
using System.Collections.Generic;
using System.Text;
//Array reverse with third variable.
namespace Projects.Practice_pro
{
    class Array_Rev
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 2, 7, 9, 8, 60 };
            Console.WriteLine(String.Join(" ",arr));
            int temp;
            int i = 0;
            int j = arr.Length - 1;
            while (i <j)
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
            Console.WriteLine("//////////////////");
            Console.WriteLine(String.Join(" ",arr));
        }
    }
}
