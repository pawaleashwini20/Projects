using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Test_loop_1
{
    class Fact
    {
        static void Main(string[] args)
        {
            int fact = 1,sum=0;
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
                sum = sum + i;
            }
            Console.WriteLine("Fact is:" + fact);
            Console.WriteLine("Sum is:"+sum);
        }
    }
}
