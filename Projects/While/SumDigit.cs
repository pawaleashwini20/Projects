using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.While
{
    class SumDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = int.Parse(Console.ReadLine());
            int c = 0;
            int rev = 0, sum = 0;
            while (num > 0)
            {
                rev = num % 10;
                
                sum = sum + rev;
                num = num / 10;
            }
            Console.WriteLine("Numner sum is:" + sum);
        }
    }
}
