using System;
using System.Collections.Generic;
using System.Text;
//2.	Write a program to print all factors of given numbers

namespace Projects.Loop_test_2
{
    class Factors_Number
    {
        static void Main(string[] args)
        {
            int fact = 1, sum = 0;
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
         
        }
    }
}
