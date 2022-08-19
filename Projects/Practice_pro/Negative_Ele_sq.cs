using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Negative_Ele_sq
    {
        static void Main(string[] args)
        {
            int[] arr = { 1,2, -3, 9, 5, -8, 6, 5 };
            Console.WriteLine(String.Join(" ",arr));
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] < 0)
                {
                    arr[i] = arr[i - 1] * arr[i - 1];
                }
            }
            Console.WriteLine("///////////////////");
            Console.WriteLine(String.Join(" ",arr));
        }
    }
}
