using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Frequency_char
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            string s = Console.ReadLine();
            Console.WriteLine("String is:"+s);
            char[] ch = s.ToCharArray();
            int[] freq = new int[ch.Length];
            for (int i = 0; i < ch.Length; i++)
            {
                freq[i] = 1;
                for (int j = i + 1; j < ch.Length; j++)
                {
                    if (ch[i] == ch[j])
                    {
                        freq[i]++;
                        ch[j] = '0';
                    }
                }
                
            }
            for (int i = 0; i < freq.Length; i++)
            {
                if (ch[i] != ' ' && ch[i] != '0')
                {
                    Console.WriteLine(ch[i]+":"+freq[i]);
                }
            }
        }
    }
}
