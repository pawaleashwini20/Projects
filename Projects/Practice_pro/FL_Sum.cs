using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class FL_Sum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());
            int l = n % 10;
            int f;
            int sum = 0;
            while (n > 0)
            {
                int rem = n % 10;
                sum = (sum*10) + rem;
                n = n / 10;
            }
            Console.WriteLine(" rev:" + sum);
            f = sum % 10;
            int fl = l + f;
            Console.WriteLine("FL sum:"+fl);
        }
    }
}
