using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Basic
{
    class Arr_rev
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 5, 3, 7, 8, 9 };
            int per = arr[0];

            //perfect square from array
            /* for (int i = 0; i < arr.Length; i++)
             {
                 float d = (float)Math.Sqrt(arr[i]);
                 if (d % 1 == 0)
                 {
                     Console.WriteLine(arr[i]);
                 }
             }*/
            //Array Reverse

            /*   for (int i = arr.Length-1; i >= 0; i--)
               {
                   Console.Write(arr[i]+"  ");
               }*/
            for (int i = 0; i < arr.Length; i++)
            {
                int n = arr[i];
                bool isprime = true;
                for (int j = 2; j < n; j++)
                {
                    if (n % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime == true)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
