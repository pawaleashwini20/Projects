using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Number_palindrom
    {
        public void palindrom(int n)
        {
            Console.WriteLine("Number is:" + n);
            int rem = 0;
            int sum = 0;
            int n1 = n;
            while (n > 0)
            {
                rem = n % 10;
                sum = (sum * 10) + rem;
                n = n / 10;
            }
            if (n1 == sum)
            {
                Console.WriteLine("palindrom:" + n1);
            }
            else
            {
                Console.WriteLine("Not palindrom:" + n1);
            }
        }
        public void sum(int n)
        {
            int sum = 0;
            int rem = 0;
            while (n > 0)
            {
                rem = n % 10;
                sum = sum + rem;
                n = n / 10;
            }
            Console.WriteLine("Sum is:" + sum);
        }
        public void reverse(int n)
        {
            int rem = 0;
            int rev=0;
            while (n > 0)
            {
                rem = n % 10;
                rev = (rev* 10)+rem;
                n = n / 10;
            }
            Console.WriteLine("Reverse:"+rev);
        }
        public void Alternate_sum(int n)
        {
            int rem = 0;
            int sum = 0;
            int cnt = 0;
            while (n > 0)
            {
                rem = n % 10;
                cnt++;
                if ((cnt+1) % 2 == 0)
                {
                    sum = sum + rem;
                }
                n = n / 10;
            }
            Console.WriteLine("Alternate digigt sum:"+sum);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());
            Number_palindrom p = new Number_palindrom();
            p.palindrom(num);
            p.sum(num);
            p.reverse(num);
            p.Alternate_sum(num);
        }
    }
}
