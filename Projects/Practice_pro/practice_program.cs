using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    //wap to reverse array
    class practice_program
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 3, 1, 6, 85, 6 };
            Console.Write(string.Join(" ",arr));
            Console.WriteLine("\nAfter reverse");
            /* for (int i = arr.Length-1; i >= 0; i--)
             {
                 Console.Write(arr[i]+" ");
             }*/
            int temp;
            int i = 0;
            int j = arr.Length - 1;
            while (i < j)
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
            Console.WriteLine("///////////////");
            Console.WriteLine(String.Join(" ",arr));
        }
    }
}
