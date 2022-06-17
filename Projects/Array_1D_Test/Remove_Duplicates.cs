using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Array_1D_Test
{
    class Remove_Duplicates
    {
        public static void Main()
        {
            int[] arr = { 1,1, 9, 9,8, 4,50,50};
            Console.WriteLine(string.Join(" ",arr));
            int n = arr.Length;

            Console.WriteLine("Remove Duplicate\n");
            int[] arr2 = new int[arr.Length];
            int p = 0;
            //bool isvisited = false;
            int cnt = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                cnt = 1;
                bool isvisited = false;
                for (int j = i - 1; j >= 0; j--)
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
                    if (cnt == 1)
                    {
                        arr2[p] = arr[i];
                        p++;
                    }
                   // Console.WriteLine(arr[i] + " : " + cnt);
                }

            }
            for (int i = 0; i < p; i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }
           
        }
        
} 
