using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Remove_Duplicate
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 1, 2, 3, 6, 7, 8, 9 };
            int p = 0;
            foreach(int a in arr)
                {
                Console.Write(a+" ");
                }
            //bool isvisit = true;
            Console.WriteLine("After remove duplicate:\n");
            int[] arr1 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                int cnt = 1;
                bool isvisit = true;
                for (int j = i -1; j >=0; j--)
                {
                    if (arr[i] == arr[j])
                    {
                        isvisit = false;
                        break;
                    }
                }
                if (isvisit == true)
                {
                    for (int k = i+1; k < arr1.Length; k++)
                    {
                        if (arr[i] == arr[k])
                        {
                            cnt++;
                        }
                      //  Console.WriteLine(arr1[i]);
                    }
                    if (cnt == 1)
                    {
                        arr1[p] = arr[i];
                        p++;
                    }
                }
               
            }
            for (int i = 0; i < p; i++)
            {
                Console.Write(arr1[i]+" ");
            }
        }
    }
}
