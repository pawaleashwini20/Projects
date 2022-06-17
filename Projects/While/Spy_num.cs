using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.While
{
    class Spy_num
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = int.Parse(Console.ReadLine());
            int num2;
            num2 = num;
            int sum = 0, rev = 0,mult=1;
            while (num > 0)
            {
                rev = num % 10;
                sum = sum + rev;
                mult = rev * mult;
                num = num / 10;

            }
            Console.WriteLine("sum:" + sum);
            Console.WriteLine("Multiplication:" + mult);
            if (mult == sum)
            {
                Console.WriteLine("SPY number :" + num2);
            }
            else 
            {
                Console.WriteLine("Noy SPY Number :" + num2);
            }
        }
    }
}
