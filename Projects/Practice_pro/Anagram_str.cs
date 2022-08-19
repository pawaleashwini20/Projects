using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Anagram_str
    {
        static void Main(string[] args)
        {
            String s = "listen";
            String s1 = "silent";
            char[] ch = s.ToLower().ToCharArray();
            Char[] ch1 = s1.ToLower().ToCharArray();
            Array.Sort(ch);
            Array.Sort(ch1);
            String var1 = new string(ch);
            String var2 = new string(ch1);
            if (var1 == var2)
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
