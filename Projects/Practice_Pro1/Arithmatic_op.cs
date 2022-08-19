using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_Pro1
{
    class Arithmatic_op
    {
        public void Sum_Num(int n)
        {
            int x = n;
            int rem, sum = 0;
            while (n > 0)
            {
                rem = n % 10;
                sum = sum + rem;
                n = n / 10;
            }
            Console.WriteLine("Addition of number is:"+sum);
        }
        public void Reverse(int n)
        {
            int x = n;
            int rem, sum = 0;
            while (n > 0)
            {
                rem = n % 10;
                sum = (sum * 10) + rem;
                n = n / 10;
            }
            Console.WriteLine("Reverse is:"+sum);
            if (x == sum)
            {
                Console.WriteLine("Palindrom...");
            }
            else
            {
                Console.WriteLine("Not Palindrom....");
            }
        }
        public void Armstrong(int n)
        {
            int x = n;
            int rem, sum = 0;
            while (n > 0)
            {
                rem = n % 10;
                sum = sum+(rem * rem * rem);
                n = n = n / 10;

            }
            if (x == sum)
            {
                Console.WriteLine("Armstrong...");
            }
            else 
            {
                Console.WriteLine("Not Armstrong...");
            }
        }
        public void One_By_One(int n)
        {
            int rem, sum = 0;
            int cnt = 0;
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
            Console.WriteLine("One by one sum:"+sum);
        }
        public void Max(int n)
        {
            int max = 0;
            int min = 9;
            int rem, sum = 0;
            while (n != 0)
            {
                rem = n % 10;
                if (rem > max)
                {
                    max = rem;
                }
               /* else if (rem < min)
                {
                    min = rem;
                    //n = n / 10;
                }*/
                n = n / 10;
                
            }
            Console.WriteLine("Max iS:" + max);
        }
           
          public void Min(int n)
          {
            int min = 9;
            int rem;

            while (n != 0)
            {
                rem = n % 10;
                if (rem<min)
                {
                    min = rem;
                    //n = n / 10;
                }
                n = n / 10;
            }
            Console.WriteLine("Min is:"+min);
          }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int n = int.Parse(Console.ReadLine());
            Arithmatic_op ao = new Arithmatic_op();
            ao.Sum_Num(n);
            ao.Reverse(n);
            ao.Armstrong(n);
            ao.One_By_One(n);
            ao.Max(n);
            ao.Min(n); 
        }
    }
}
  