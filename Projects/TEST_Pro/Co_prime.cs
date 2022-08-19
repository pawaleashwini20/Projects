using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.TEST_Pro
{
    class Co_prime
    {
            static void Main(string[] args)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int gcd = 0;
                int c = 0;
                for (int i = 1; i <= n; i++)
                {
                    for (int divisor = 1; divisor <= i; divisor++)
                    {
                        if (n % divisor == 0 && i % divisor == 0)
                            gcd = divisor;
                    }

                    if (gcd == 1)
                        c++;
                }
                Console.WriteLine(c);

            }
        }
    }
