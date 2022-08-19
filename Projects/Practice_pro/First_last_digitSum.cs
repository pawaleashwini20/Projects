using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class First_last_digitSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());
            int rem = 0, cnt = 0, sum = 0,fd=0,ld=0 ;
            ld = n % 10;
            while (n > 0)
            {
                rem = n % 10;
                sum = (sum * 10) + rem;
                n = n / 10;
            }
            Console.WriteLine("reverse is:"+sum);
            fd = sum % 10;
            int FL_sum = fd + ld;
            Console.WriteLine("First last digit sum is:"+FL_sum);
        }
    }
}
