using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_Pro1
{
    class Array_OP
    {
        public void Add_Ele(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("Sum of array:"+sum);

        }
        public void Even(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i]+":Even");
                }
            }

        }
        public void Zeros(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    arr[i] = 1;
                }
            }
            Console.WriteLine(String.Join(" ",arr));
        }
        public void RemoveDuplicate(int[] arr)
        {
           
            int[] arr1 = new int[arr.Length];
             int k=0;
            int cnt = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                bool isvisite = true;
                for (int j = i - 1; j > 0; j--)
                {
                    if (arr[j] == arr[i])
                    {
                        isvisite = false;
                        break;

                    }

                }
                if (isvisite == true)  
                {
                    arr1[k] = arr[i];
                    k++;

                }

            }
            Console.WriteLine(String.Join(" ",arr1));

        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 2, 7, 0, 99, 8, 7, 6, 4, 8 };
            Console.WriteLine(String.Join(" ", arr));
            Console.WriteLine("//////////////////////////////");
            Array_OP a = new Array_OP();
          //  a.Add_Ele(arr);
            //a.Even(arr);
          //  a.Zeros(arr);
            a.RemoveDuplicate(arr);
        }
    }
}
