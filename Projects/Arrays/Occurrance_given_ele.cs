using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Arrays
{
    class Occurrance_given_ele
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of Array:");
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
                Console.WriteLine(arr[i]+" ");
            }
            int cnt = 0;
            Console.WriteLine("Enter element to search:");
            int key = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                
               // bool isvisited = false;
                 if (arr[i] == key)
                    {
                        cnt++;
                    }
                
               
                   
                
            }
            Console.WriteLine(key + ":" + cnt);
        }
    }
}
