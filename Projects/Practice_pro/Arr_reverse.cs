using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Arr_reverse
    {
       public void Rev(int[] arr)
        {
            int temp;
            int i = 0;
            int j = arr.Length - 1;
            while (i < j)
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            
            }
            Console.WriteLine();
            Console.WriteLine(String.Join(" ",arr));
        }
        public void Rev_wt(int[] arr)
        {
            //  Console.WriteLine(String.Join(" ", arr));
            Console.WriteLine("reverse:\n");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]+" ");
            }
        }
        public void Even(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i]+" :even");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of Array:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter Element:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            foreach(int a in arr)
            {
                Console.Write(a+" ");   
            }
            Arr_reverse ar = new Arr_reverse();
            ar.Rev(arr);
            //ar.Rev_wt(arr);
            ar.Even(arr);
        }
    }
}
