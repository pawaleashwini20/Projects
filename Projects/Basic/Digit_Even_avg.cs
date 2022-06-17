using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Basic
{
    class Digit_Even_avg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());
            int rem = 0, cnt = 0,sum=0;
            double avg;
            while (n > 0)
            {
                rem = n % 10;
                if (rem % 2 == 0)
                {
                    cnt++;
                   // Console.WriteLine(rem);
                    sum = sum + rem;
                }
                n = n / 10;
               
            }
            Console.WriteLine("Sum is:" + sum);
            Console.WriteLine("Count:"+cnt);
            avg = sum/cnt;
            Console.WriteLine("Avg :" + avg);
        }
    }
}
