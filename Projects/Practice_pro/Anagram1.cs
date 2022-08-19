using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Anagram1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 String:");
            String s1 = Console.ReadLine();
            String s2 = Console.ReadLine();
            char[] ch1 = s1.ToLower().ToCharArray();
            char[] ch2 = s2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string str1 = new string(ch1);
            string str2 = new string(ch2);
            if (str1==str2)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not Anagram");
            }
        }
    }
}
