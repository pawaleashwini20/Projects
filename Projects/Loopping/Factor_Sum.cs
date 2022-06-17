using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Loopping
{
    class Factor_Sum
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());
            int fact = 1;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                    Console.Write("Num divisible by:"+i+"\n");
                }
            }
            Console.WriteLine("Sum is:" + sum);
        }

    }
}
