using System;
using System.Collections.Generic;
using System.Text;
//Write a program to print all numbers between 1 and 100 except the numbers which
//are divisible by 5or 10

namespace Projects.Loop_test_2
{
    class Num_divide_5_100
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 != 0 || i % 10 != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
