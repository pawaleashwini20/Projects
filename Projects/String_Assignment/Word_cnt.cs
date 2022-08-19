using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.String_Assignment
{
    class Word_cnt
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            String s = Console.ReadLine();
            int n = 0;
            int cnt = 0;
            while (n <= s.Length - 1)
            {
                if (s[n] == ' ' || s[n] == '\n' || s[n] == '\t')
                {
                    cnt++;
                }
                n++;
            }
            Console.WriteLine("count:" + cnt);
        }
    }
}
