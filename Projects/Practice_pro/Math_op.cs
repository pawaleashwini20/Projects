using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Math_op
    {
        public void reverse(int n)
        {
            int rem = 0;
            int sum = 0;
            while (n > 0)
            {
                rem = n % 10;
                sum = (sum * 10) + rem;
                n = n / 10;
            }
            Console.WriteLine("reverseis:"+sum);
        }
        public void Palindrom(int n)
        {
            int n1 = n;
            int rem = 0;
            int sum = 0;
            while (n > 0)
            {
                rem = n % 10;
                sum = (sum * 10) + rem;
                n = n / 10;
            }
            Console.WriteLine("reverse is"+sum);
            if (n1 ==sum)
            {
                Console.WriteLine("Palindrom");
            }
            else 
            {
                Console.WriteLine("Not palindrom");
            }
        }
        public void Armstrong(int n)
        {
            int n1 = n;
            int sum = 0;
            int rem = 0;
            while (n > 0)
            {
                rem = n % 10;
                sum = sum+(rem * rem * rem);
                n = n / 10;
            }
            if (n1 == sum)
            {
                Console.WriteLine("Armstromg..");
            }
            else 
            {
                Console.WriteLine("Not Armstrong..");
            }
        }
        public void odd_digit(int n)
        {
            int rem = 0;
            int cnt = 0;
            int sum = 0;
            while (n > 0)
            {
                rem = n % 10;
                cnt++;
                if (cnt % 2 == 0)
                {
                    sum += rem;
                }
                n = n / 10;
            }
            Console.WriteLine("Odd digit sum:"+sum);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());
            Math_op m = new Math_op();
            m.reverse(n);
            m.Palindrom(n);
            m.Armstrong(n);
            m.odd_digit(n);
        }
    }
}
