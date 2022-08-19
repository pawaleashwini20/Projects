using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Word_rev
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            String s = Console.ReadLine();
            String[] ch = s.Split(" ");
            for (int i = 0; i < ch.Length; i++)
            {
                for (int j = i + 1; j < ch.Length; j++)
                {
                    String temp = ch[i];
                    ch[i] = ch[j];
                    ch[j] = temp;
                }
            }
            Console.WriteLine(String .Join(" ",ch));
        }
    }
}
