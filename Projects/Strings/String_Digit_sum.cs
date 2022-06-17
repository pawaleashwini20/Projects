using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Strings
{
    class String_Digit_sum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            String str = Console.ReadLine();
            double sum = 0;
            double avg = 0;
            int cnt = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <='9')
                {
                    Console.WriteLine(str[i]);
                    cnt++;
                    double x = Char.GetNumericValue(str[i]);
                    sum = sum + x;
                }
            }
            avg = sum / cnt;
            Console.WriteLine("Count is:"+cnt);
            Console.WriteLine("Sum:"+sum);
            Console.WriteLine("Avg is:" + avg);
        }
    }
}
