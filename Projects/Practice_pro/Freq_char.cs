using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Freq_char
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            String s = Console.ReadLine();
            char[] ch = s.ToCharArray();
          
            int[] freq = new int[s.Length];
            
            for (int i = 0; i < s.Length; i++)
            {
                freq[i] = 1;
                for (int j = i + 1; j < s.Length; j++)
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
                if (ch[i] != '0' && ch[i] != ' ')
                {
                    Console.WriteLine( ch[i]+":"+freq[i]);
                }
            }
        }
    }
}
