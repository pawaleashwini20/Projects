using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Arrays
{
    class half_Acending_desending
    {

        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 2, 7, 8, 5, 9, 0 };
                for(int i = 0;i < arr.Length;i++)
                {
                 for (int j = i + 1; j < arr.Length; j++)
                     {
                      if (arr[i] > arr[j])
                         {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                         }

                     }
                }
            Console.WriteLine("-----");
            Console.WriteLine(string.Join(" ",arr));
            for (int i = 0; i < arr.Length / 2; i++)
            {
                Console.Write(arr[i]+" ");
            }
            for (int j = arr.Length - 1;j>=arr.Length/2;j--)
            {
                Console.Write(arr[j]+" ");
            }
        }
    }
}
