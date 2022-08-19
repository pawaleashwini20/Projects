using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Remove_dupli
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            String s = Console.ReadLine();
            char[] ch = s.ToCharArray();
            char[] merge = new Char[ch.Length];
            int k = 0;
            for (int i = 0; i < s.Length; i++)
            {
                bool isvisite = true;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (ch[i] == ch[j])
                    {
                        isvisite = false;
                        break;
                    }
                }
                if (isvisite == true)
                {
                    merge[k] = ch[i];
                    k++;
                }
            }
            Console.WriteLine(String.Join(" ",merge));
        }
    }
}
