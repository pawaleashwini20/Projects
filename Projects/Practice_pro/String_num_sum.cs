using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class String_num_sum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            String s = Console.ReadLine();
            char[] ch = s.ToCharArray();
            char[] n = new char[s.Length];
            char[] n1 = new char[s.Length];
            int j = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] >= '0' && ch[i] <= '9')
                {
                    n[j] = ch[i];
                    j++;
                }
                else if ((ch[i] >= 'a' && ch[i] <= 'z') || (ch[i] >= 'A' && ch[i] <= 'Z'))
                {
                    n1[j] = ch[i];
                    j++;
                }
                else 
                {
                    n1[j] = ch[i];
                    j++;
                }
            }
           // Array.Sort(n);
          //  Console.WriteLine(String.Join(" ",n));
             Array.Sort(n);
            Array.Sort(n1);
            Console.WriteLine("After sort:");
            Console.Write(String.Join("", n));
            Console.Write(String.Join("", n1));
        }
    }
}
