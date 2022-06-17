using System;
using System.Collections.Generic;
using System.Text;
//Sum of Digit and Multiplication is same i.e 123=1+2+3=6   1*2*3=6
namespace Projects.Test_loop_1
{

    class Spy_num
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());
            int n2 = n;
            int rev, sum=0, mult=1;
            while (n > 0)
            {
                rev = n % 10;
                sum = sum + rev;
                mult = mult * rev;
                n = n / 10;
            }
            if (sum == mult)
            {
                Console.WriteLine("SPY Number");
            }
            else 
            {
                Console.WriteLine("Not Spy Number");
            }
        }
    }
}
