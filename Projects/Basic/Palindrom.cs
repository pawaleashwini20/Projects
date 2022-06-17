using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Basic
{
    class Palindrom
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());
            int num = n;
            int rem = 0, sum = 0;
            while(n>0)
                {
                rem = n % 10;
                sum = sum*10+rem;
                n = n / 10;
                }
            if (num == sum)
            {
                Console.WriteLine("Palindrom");
            }
            else 
            {
                Console.WriteLine("Not palindrom");
            }

        }
    }
}
