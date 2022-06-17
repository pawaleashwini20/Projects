using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Assignment
{
    class Sum_Even_n
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number:");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Sum is:"+sum);
        }
    }
}
