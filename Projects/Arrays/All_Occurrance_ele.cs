using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Arrays
{
//Find all Occurrance of element in Array
    class All_Occurrance_ele
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter Elements in array:");
            for (int i = 0; i <n; i++)
            {
                int x=int.Parse(Console.ReadLine());
                arr[i] = x;
            }
            Console.WriteLine("Array is:\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i]+" ");
            }
            int cnt = 0;
            Console.WriteLine("Occurrrance of element:\n");
            //bool isvisited = false;
            for (int i = 0; i < arr.Length; i++)
            {
                cnt = 1;
                bool isvisited = false;
                for (int j = i - 1; j >=0; j--)
                {
                    if (arr[j] == arr[i])
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
                    Console.WriteLine(arr[i]+" : "+cnt);
                }

            }
        }
    }
}
