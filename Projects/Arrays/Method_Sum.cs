using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Arrays
{
    class Method_Sum
    {
        public void sum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    sum = sum + arr[i];
                }
            }
            Console.WriteLine(sum);
        }
            static void Main(string[] args)
            {
                int[] a = { 1, 2, 3, 8, 4, 7 };
                Method_Sum m = new Method_Sum();
                m.sum(a);
            }
        }
    }

