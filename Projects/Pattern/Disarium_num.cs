using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Pattern
{
    class Disarium_num
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int n = int.Parse(Console.ReadLine());
            int n2 = n;
            int digit = 0, rem, sum = 0;
            while (n2 > 0)
            {
                digit++;
                n2 = n2 / 10;
            }
            Console.WriteLine(digit);
            n2 = n;
            while (n2 > 0)
            {
                rem = n2 % 10;
                sum = sum + (int)Math.Pow(rem, digit);
                n2 = n2 / 10;
                digit--;

            }
            if (n== sum)
            {
                Console.WriteLine("Given nubmer is Disarium Number");
            }
            else
            {
                Console.WriteLine("Given number is not Disarium Number");
            }
        }

    }
}
