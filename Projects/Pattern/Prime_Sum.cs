using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Pattern
{
    class Prime_Sum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());
            int cnt = 0;
            int sum = 0;
            for (int i = 2; i <= n; i++)
            {
                cnt = 0;
                for (int j = 1; j <= n; j++)
                {
                    if (i % j == 0)
                    {
                        cnt++;
                    }
                }
                if (cnt == 2)
                {
                    Console.WriteLine(i);
                    sum = sum + i;
                  //  Console.WriteLine("sum is:"+sum);
                }
                
            }
            Console.WriteLine("sum is:" + sum);
        }
    }
}
