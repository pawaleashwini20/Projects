using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Arrays
{
    class Positive_Negative_ele
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, -2, 3, -8, -3, 11, 5, -6, 2 ,22};
            Console.WriteLine(string.Join(" ",arr));
            for (int i = 0; i < arr.Length; i++)
            {
                //for (int j = i + 1; j < arr.Length; j++)
                //{
                    if (arr[i] < 0)
                    {
                        Console.Write(arr[i+1] * arr[i+1] + "  ");
                    }
                    else
                    {
                        Console.Write(arr[i]+ "  ");
                    }
                //}
            }
        }
    }
}
