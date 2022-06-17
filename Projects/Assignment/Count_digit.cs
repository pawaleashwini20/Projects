using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Assignment
{
    class Count_digit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());
            int rem = 0,cnt = 0;
            while (n > 0)
            {
                rem=n % 10;
                cnt++;
                n = n / 10;
            }
            Console.WriteLine("Number of digit is:"+cnt);
        }
    }
}
