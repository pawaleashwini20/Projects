using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Array_1D_Test
{
    class Coprime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());
            int gcd = 0;
            int cnt = 0;
            for (int i = 1; i <=n; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    if (n % j == 0 && i % j == 0)
                    {
                        gcd=j;
                        
                    }
                 }
                if (gcd == 1)
                {
                    cnt++;
                }
            }
                Console.WriteLine(cnt);
            

        }
    }
}
