using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.String_Assignment
{
    class Unique_ele
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter Element:");
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                arr[i] = x;
            }
            Console.WriteLine("Array is:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\nunique element:");
            for (int i = 0; i < arr.Length; i++)
            {
                int cnt = 1;
                bool isvisited = false;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[i] == arr[j])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int k = i + 1; k < arr.Length; k++)
                    {
                        if (arr[i] == arr[k])
                        {
                            cnt++;
                        }
                    }
                    if (cnt == 1)
                    {
                        Console.WriteLine(arr[i] + " " + cnt);
                    }
                }
            }

        }
    }
}
