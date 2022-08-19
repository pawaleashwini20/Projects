using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.String_Assignment
{
    class Duplicate_word
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            String s = Console.ReadLine();
            s = s.ToLower();
            String[] word = s.Split(' ');
            int cnt = 0;
            Console.WriteLine("Duplicates are:");
            for (int i = 0; i < word.Length; i++)
            {
                 cnt = 1;
                for (int j = i + 1; j < word.Length; j++)
                {
                    if (word[i].Equals(word[j]))
                    {
                        cnt++;
                        word[j] = "0";
                    }
                }
                if (cnt > 1 && word[i] != "0")
                {
                    Console.WriteLine(word[i]+":");
                }
            }
        }
    }
}
