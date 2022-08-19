using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Zero_last
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Size:");
            int num = int.Parse(Console.ReadLine());
            int cnt = 0;
            int[] arr = new int[num];
                int n = arr.Length;
            Console.WriteLine("Enter array element");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array is:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine("///////////////");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
                cnt = 0;
                for (int j = 0; j < n; j++)
                {
                    if (arr[j] != 0)
                    {
                        arr[cnt++]=arr[j];
                    }
                   
                }
                while (cnt < n)
                {
                    arr[cnt++] = 0;
                }
            }
          //  Console.WriteLine("//////////////");
            //Console.WriteLine(String.Join(" ",arr));
        }
    }
}
