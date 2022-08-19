using System;
using System.Collections.Generic;
using System.Text;
//10.	WAP to replace all the 0’s with 1’s in your array. Your array is
//[26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34].
namespace Projects.String_Assignment
{
    class Replace_0_1
    {
        static void Main(string[] args)
        {

        
        int[] arr = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };
        int[] arr2 = new int[arr.Length];
            /*foreach (int a in arr)
            {
                Console.Write(" ", a);
            }*/
            for (int i = 0; i<arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            for (int i = 0; i<arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    arr[i]=1;
                }
            }
     
            Console.WriteLine();
        for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
