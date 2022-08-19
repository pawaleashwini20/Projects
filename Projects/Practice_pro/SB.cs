using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class SB
    {
        static void Main(string[] args)
        {
            int n = 5;
            int cnt = 0;
            int sum = 0;
            int[] arr = new int[n];
            Console.WriteLine("Enter element:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i=2; i < arr.Length;i++)
            {
                cnt = 0;
                for (int j = 1; j < arr.Length; j++)
                {
                    if (i % j == 0)
                    {
                        cnt++;
                    }

                }
                if (cnt == 2)
                {
                    Console.WriteLine("----------------"+i);
                    sum = sum+ i;
                }
            }
            Console.WriteLine("Sum:"+sum);
        }
    }
}
