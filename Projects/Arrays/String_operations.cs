using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Arrays
{
    class String_operations
    {
        public void Reverse(String str)
        {
            string rev = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev = rev + str[i];
            }
            Console.WriteLine("Reverse is"+rev);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter String:");
            String s = Console.ReadLine();
            String_operations so = new String_operations();
            so.Reverse(s);
        }
    }
}
