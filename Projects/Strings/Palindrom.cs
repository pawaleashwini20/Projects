using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Strings
{
    class Palindrom
    {
        public void input(String str)
        {
            String rev="";
            Console.WriteLine("string is:"+str);
            String str1 = str;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev = rev + str[i];
            }
            Console.WriteLine("Reverse String is:"+rev);
            if (str1.Equals(rev))
            {
                Console.WriteLine("Palindrom");
            }
            else 
            {
                Console.WriteLine("Not Palindrom");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            String s = Console.ReadLine();
            Palindrom p = new Palindrom();
            p.input(s);
        }
    }
}
