﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Arrays
{
    class Even
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter elements:");
            for(int i=0;i<n;i++)
            {
                int x = int.Parse(Console.ReadLine());
                arr[i] = x;

            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine("Enen elements are:");
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }

        }
    }
}
