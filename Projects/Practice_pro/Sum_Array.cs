using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Sum_Array
    {
        public void Sum(int[] arr1)
        {
            int sum = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                sum += arr1[i];
            }
            Console.WriteLine("Sum is"+sum);
        }
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter size:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter Array element:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Sum_Array s = new Sum_Array();
            s.Sum(arr);
        }
    }
}
