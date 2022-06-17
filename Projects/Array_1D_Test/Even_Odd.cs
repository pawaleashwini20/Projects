using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Array_1D_Test
{
    //create a Array of integer and count the number of even  and odd elements from array.
    class Even_Odd
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int a in arr)
            {
                Console.Write(a+" ");
            }
            int cnt_Odd = 0, cnt_Even = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    cnt_Even++;

                }
                else 
                {
                    cnt_Odd++;
                }
            }
            Console.WriteLine("\nEven:"+cnt_Even +"  Odd:"+cnt_Odd);
        }
    }
}
