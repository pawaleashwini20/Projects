using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Char_alpha_digit
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter String:");
            String s = Console.ReadLine();
            char[] ch = s.ToCharArray();
            String[] sp = s.Split(" ");
            int alpha = 0, digit = 0,sp_ch = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] >= 'a' && s[i] <= 'z') || (s[i] >='A' && s[i] <= 'Z'))
                {
                    alpha++;
                }
                else if (s[i] >= '0' && s[i] <= '9')
                {
                    digit++;
                }
                else 
                {
                    sp_ch++;
                }
            }
            Console.WriteLine("Alpha:"+alpha);
            Console.WriteLine("Digit:"+digit);
            Console.WriteLine("Special char:"+sp_ch);
        }
    }
}
