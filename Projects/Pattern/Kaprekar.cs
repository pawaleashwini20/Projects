using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Pattern
{
    class Kaprekar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number:");
            int n = int.Parse(Console.ReadLine());
            
            int temp = n;
            int sq = n * n;
            int sum = 0, rem, sum1 = 0,rem1 ;
            while (n > 0)
            {
                rem = n % 10;
                sum = sum + rem;
                n = n / 10;
            }
            while (sq > 0)
            {
                rem1 = sq % 10;
                sum1 = sum1 + rem1;
                sq = sq / 10;
            }
            Console.WriteLine("sum  square:" + sum1);
            Console.WriteLine("sum:"+sum);
            if (sum == sum1)
            {
                Console.WriteLine("Karpekar Number..");
            }
            else
            {
                Console.WriteLine("not Karpekar Number..");
            }
        }
    }
}
