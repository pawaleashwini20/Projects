using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Strings
{
    class Similar_char
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            String s = Console.ReadLine();
            char[] ch = s.ToCharArray();
            char ch_new=' ';
            for (int i = 0; i < ch.Length; i++)
            {
                for (int j = i + 1; j < ch.Length; j++)
                {
                    if (ch[i] == ch[j])
                    {
                        //Console.WriteLine(ch[i]+" ");
                        ch_new = ch[j];
                        break;
                    }

                }

            }
            Console.WriteLine(ch_new);
        }
    }
}
