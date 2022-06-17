using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Loopping
{
    class PrimeNum
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = int.Parse(Console.ReadLine());
            bool isprime = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isprime = false;
                }

            }
            if (isprime == true)
            {
                Console.WriteLine("Prime Number:" + num);
            }
            else 
            {
                Console.WriteLine("Not Prime Number:" + num);
            }
        }
    }
}
