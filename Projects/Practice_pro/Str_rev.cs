using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Str_rev
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ente String:");
            String s = Console.ReadLine();
            String rev = "";
            for (int i = s.Length-1; i >= 0; i--)
            {
                rev = rev + s[i];
            }
            Console.WriteLine("reverse:"+rev);
            if (s.Equals(rev))
            {
                Console.WriteLine("Palindron");
            }
            else
            {
                Console.WriteLine("Not Palindron");
            }
        }
    }
}
