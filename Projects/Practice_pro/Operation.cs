using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Operation
    {
        public void Add(int n)
        {
            Console.WriteLine("Number is:" + n);
            int rev = 0;
            int sum = 0;
            while(n>0)
            {
                rev = n % 10;
                sum = sum + rev;
                n = n / 10;
            }
            Console.WriteLine("Sum is:" + sum);
        }
        public void Reverse(int n)
        {
            int n1 = n;
            int sum = 0;
            int rem = 0;
            while (n > 0)
            {
                rem = n % 10;
                sum = (sum * 10) + rem;
                n = n / 10;
            }
            Console.WriteLine("Reverse is:" + sum);
            if (n1 == sum)
            {
                Console.WriteLine("Palindron");

            }
            else
            {
                Console.WriteLine("Not palindron..");
            }
        }
        public void Armstrong(int n)
        {
            int n1 = n;
            int rem = 0;
            int sum = 0;
            while (n > 0)
            {
                rem = n % 10;
                sum = sum + (rem * rem * rem);
                n = n / 10;
            }

            Console.WriteLine("Sum is:"+sum);
            if (n1 == sum)
            {
                Console.WriteLine("Armstrong..");
            }
            else
            {
                Console.WriteLine("Not Armstrong...");
            }
        }
        public void Even_Digit_sum(int n)
        {
            int rem = 0;
            int cnt = 0, sum = 0 ;
            while (n > 0)
            {
                rem = n % 10;
                cnt++;
                if (cnt % 2 != 0)
                {
                    sum = sum + rem;
                }
                n = n / 10;
            }
            Console.WriteLine("Even place digit sum:"+sum);
        }
        static void Main(String[] args)
        {
            Console.WriteLine("Enter number:");
            int num =int.Parse(Console.ReadLine());
            Operation o = new Operation();
            o.Add(num);
            o.Reverse(num);
            o.Armstrong(num);
            o.Even_Digit_sum(num);
        }
    }
}
