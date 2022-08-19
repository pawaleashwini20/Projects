using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class String_digit_sum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            String s = Console.ReadLine();
            int cnt = 0;
            double sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= '0' && s[i] <= '9')
                {
                    Console.Write(s[i]);
                    cnt++;
                    double x = char.GetNumericValue(s[i]);
                    sum = sum + x;
                }

            }
            Console.WriteLine("cnt:"+cnt);
            Console.WriteLine("Sum:"+sum);
        }
    }
}
