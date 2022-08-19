using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class ArmStrong
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            int rem = 0;
            int n1 = n;
            int sum = 0;
            while (n > 0)
            {
                rem = n % 10;
                sum =  sum+(rem*rem*rem);
                n = n / 10;
            }
            Console.WriteLine(sum);
            if (n1 == sum)
            {
                Console.WriteLine("Armstrong..");
            }
            else
            {
                Console.WriteLine("Not Armstrong...");
            }
        }
    }
}
