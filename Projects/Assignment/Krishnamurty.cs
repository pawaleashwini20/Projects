using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Assignment
{
    class Krishnamurty
    {
        static void Main(string[] args)
        {
            int j, i, x, sum = 1, k = 0, num;

            Console.WriteLine("Enter Number");
            int n = int.Parse(Console.ReadLine());
            num = n;
            while (num > 0)
            {
                x = num % 10;
                sum = 1;
                for (i = x; i >= 1; i--)
                {
                    sum = sum * i;
                }
                k = k + sum;
                num = num / 10;
            }
            if (n == k)

                Console.WriteLine(" Krishnamurthy Number:"+n);
            else
                Console.WriteLine(" not Krishnamurthy Number: "+n);
        }
    }
}
