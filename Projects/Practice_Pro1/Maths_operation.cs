using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_Pro1
{
   
   
    class Maths_operation
    {
        public  int sum(int n)
        {
            int rem = 0;
            int sum = 0;
            while (n>0)
            {
                rem = n % 10;
                sum = sum + rem;
                n = n / 10;
            }
           return sum;
        }
        public int reverse(int n)
        {
            int sum = 0,rem=0;
            while (n > 0)
            {
                rem = n % 10;
                sum = (sum * 10) + rem;
                n = n / 10;
            }
            return sum;
        }
        public void armstrong(int n)
        {
            int rem = 0;
            int sum = 0;
            int n1 = n;
            while (n > 0)
            {
                rem = n % 10;
                sum = sum + (rem * rem * rem);
                n = n / 10;

            }
            string s;
            if (sum == n1)
            {
                Console.WriteLine("Armstrong");
            }
            else
                Console.WriteLine("Not armstrong....");
           
        }
        static void Main(string[] args)
        {
            int k;
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());
            Maths_operation m =new  Maths_operation();
           k=m.sum(n);
            Console.WriteLine(k);
            Console.WriteLine(m.reverse(n));
            m.armstrong(n);

        }
    }
}
