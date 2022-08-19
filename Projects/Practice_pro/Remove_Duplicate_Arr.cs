using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Remove_Duplicate_Arr
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 1, 3, 2, 5, 3, 66, 77, 8, 6, 9, 0, 9 };
            int[] arr1 = new int[arr.Length];
           // bool isvisit = true;
            int cnt = 0;
            int p = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                cnt = 0;
                bool isvisite = true;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[i] == arr[j])
                    {
                        isvisite = false;
                        break;
                    }

                }
                if (isvisite == true)
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
                        arr1[p] = arr[i];
                        p++;
                    }
                }
            }
            for (int i = 0; i < p; i++)
            {
                Console.WriteLine(arr1[i]);
            }
        }
    }
}
