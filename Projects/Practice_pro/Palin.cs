using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Palin
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int n1 = n;
            while (n > 0)
            {
                int rem = n % 10;
                sum = (sum * 10) + rem;
                n = n / 10;
            }
            Console.WriteLine("reverse:"+sum);
            if (n1 == sum)
            {
                Console.WriteLine("Palindron");
            }
            else
            {
                Console.WriteLine("not palindron");
            }
        }
        
    }
}
