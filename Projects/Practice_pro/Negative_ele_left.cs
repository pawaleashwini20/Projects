using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Negative_ele_left
    {
        static void Main(string[] args)
        {
            int[] arr = { -2, 1, 3, -5, -4, 6, -5, 70 };
            Console.WriteLine(String.Join(" ",arr));
            int temp = 0,j = 0;
            for(int i = 0;i < arr.Length;i++)
            {
                if (arr[i] < 0)
                {
                    if (i != j)
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                    j++;
                }
            }
            Console.WriteLine(String.Join(" ",arr));
        }
    }
}
