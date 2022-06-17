using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Basic
{
    class Digit_alternate_sum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());
            int first = 0,sum=0,rem,cnt=0;
            while (n > 0)
            {
                rem = n % 10;
                cnt++;
                if (cnt % 2 == 0)
                {
                    Console.WriteLine(cnt);
                    sum = sum + rem;
                }
                n = n / 10;
            }
            Console.WriteLine("Sum:"+sum);
        }
    }
}
