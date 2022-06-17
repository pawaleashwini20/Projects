using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Arrays
{
  //acending order
    class Char_Sort
    {
        static void Main(string[] args)
        {
            char[] ch = new char[5];
            Console.WriteLine("Enter Element:");
            for (int i = 0; i < ch.Length; i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ",ch));
            for (int i = 0; i < ch.Length; i++)
            {
                for (int j = i + 1; j < ch.Length; j++)
                {
                    if (ch[i] >ch[j])
                    {
                        char temp = ch[i];
                        ch[i] = ch[j];
                        ch[j] = temp;
                    }
                }
            }
            Console.WriteLine("After swap:");
            Console.WriteLine(string.Join(" ",ch));
        }
    }
}
