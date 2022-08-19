using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Upper
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            String s = Console.ReadLine();
            char[] ch = s.ToCharArray();
            char c;
            for (int i = 0; i < ch.Length; i++)
            {
                c = ch[i];
                if (char.IsLower(c))
                {
                    Console.Write(char.ToUpper(c));
                }
                else 
                {
                    Console.Write(char.ToLower(c));
                }
            }
        }
    }
}
