using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.String_Assignment
{
    class Alpha_digit_cnt
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            String s = Console.ReadLine();
            int alpha = 0, digit = 0,Sp_char=0;

            for (int i = 0; i < s.Length; i++)
            {
              // char ch = s.charAt(i);
                if ((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= 'A' && s[i] <= 'Z'))
                {
                    alpha++;
                }
                else if (s[i] >= '0' && s[i] <= '9')
                {
                    digit++;
                }
                else
                {
                    Sp_char++;
                }
            }
            Console.WriteLine("Alphabets are:"+alpha);
            Console.WriteLine("digits are:" + digit);
            Console.WriteLine("Special Character are:" + Sp_char);
        }
    }
}
