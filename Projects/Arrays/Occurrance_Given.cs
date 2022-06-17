using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Arrays
{
    class Occurrance_Given
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine("Enter size of Array:");
              int n = Convert.ToInt32(Console.ReadLine());
              int[] arr = new int[n];
              Console.WriteLine("Enter Array element:");
              for (int i = 0; i < n; i++)
              {
                  int x = int.Parse(Console.ReadLine());
                  arr[i] = x;
              }
              Console.WriteLine("Array is:\n");
              for (int i = 0; i < n; i++)
              {
                  Console.WriteLine(arr[i] + " ");
              }
              Console.WriteLine("Enter element to search:");
              int key = int.Parse(Console.ReadLine());
      */
            int[] arr = { 1, 2, 3, 4, 1, 1, 1 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
            int key = 1;
            int cnt = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                
                
                if (arr[i] == key)
                {
                    cnt++;
                }


               // Console.WriteLine(key + ":" + cnt);

            }
            Console.WriteLine(key + ":" + cnt);
        }
    }
}
