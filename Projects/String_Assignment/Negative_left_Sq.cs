using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.String_Assignment
{
    //11.	WAP to replace all negative value with its immediate left elements square. Means
    //arr[] = [12, 3,-19, 29, 5, -61, 44, 7, -9] 
//Output array will be[12, 3, 9, 29, 5, 25, 44, 7, 49].

    class Negative_left_Sq
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 3, -19, 29, 5, -61, 44, 7, -9 };
            Console.WriteLine(string.Join(" ", arr));
            for (int i = 0; i < arr.Length; i++)
            {
               
                if (arr[i] < 0)
                {
                    Console.Write(arr[i - 1] * arr[i - 1] + "  ");
                }
                else
                {
                    Console.Write(arr[i] + "  ");
                }
                
            }
            Console.WriteLine("////////////////////////////////////");
            Console.WriteLine(string.Join(" ",arr));
        }
    }
}
