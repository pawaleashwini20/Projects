using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_Pro1
{
    class Vowels
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            String s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                {
                    Console.WriteLine(s[i]+"::Vowels....");
                }
            }

        }
    }
}
