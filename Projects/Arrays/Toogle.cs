using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Arrays
{
    class Toogle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array:");
            int n = int.Parse(Console.ReadLine());
            char[] ch = new char[n];
            Console.WriteLine("Enter character element:");
            for (int i = 0; i < ch.Length; i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());

            }
            for (int i = 0; i < ch.Length; i++)
            {
                Console.Write(ch[i] + " ");

            }
            for (int i = 0; i < ch.Length; i++)
            {
                for (int j = i + 1; j < ch.Length; j++)
                {
                    if (ch[i] =='a' || ch[i] =='z')
                    {
                        ch[i] =(char)(ch[i]+32);
                    }
                   else if (ch[i] == 'A' || ch[i] == 'Z')
                    {
                        ch[i] = (char)(ch[i] - 32);
                    }
                }
            }
        }
    }
}
