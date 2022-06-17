using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Loopping
{
    class Count_Odd
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Odd number from 1-20");
            int cnt = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    cnt++;
                }
            }
            Console.WriteLine("Odd numbers are:" + cnt);
        }
    }
}
