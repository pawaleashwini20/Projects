using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Array_1D_Test
{
    class Min_Frequency
    {
        static void Main(string[] args)
        {
            char[] arr = { 'a', 'b', 't', 'c', 'd', 'c', 'r', 'p', 'b', 't', 'd' };
            Console.WriteLine(String.Join(" ", arr));
            //bool isvisited = true;
            int cnt = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                cnt = 1;
                bool isvisited = true;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[j] == arr[i])
                    {
                        isvisited = false;
                        break;
                    }

                }
                if (isvisited == true)
                {
                    for (int k = i + 1; k < arr.Length; k++)
                    {
                        if (arr[i] == arr[k])
                        {
                            cnt++;

                        }
                    }
                    Console.WriteLine(arr[i] + "  " + cnt);


                    if (cnt == 1)
                    {
                        Console.WriteLine(arr[i] + " "+cnt);
                    }
                }
            }
        }
    }
}