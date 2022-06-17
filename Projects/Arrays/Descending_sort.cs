using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Arrays
{
    class Descending_sort
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
                Console.Write(ch[i]+" ");

            }
            for (int i = 0; i < ch.Length; i++)
            {
                for (int j = i + 1; j < ch.Length; j++)
                {
                    if (ch[i] < ch[j])
                    {
                        char temp = ch[i];
                        ch[i] = ch[j];
                        ch[j] = temp;
                    }
                }
            }
            Console.WriteLine("Ater swap:");
            Console.Write(string.Join(" ",ch));


        }


    }
}
