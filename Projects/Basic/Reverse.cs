using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Basic
{
    class Reverse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());
            int rem = 0;
            int sum = 0;
            while (n > 0)
            {
                rem = n % 10;
                //sum = (sum * 10) + rem;
                sum = sum + rem;
                n = n / 10;
            }
            Console.WriteLine("reverse is:"+sum);
        }
    }
}
