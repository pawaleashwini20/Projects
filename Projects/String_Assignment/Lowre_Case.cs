using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.String_Assignment
{
    class Lowre_Case
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            String s = Console.ReadLine();
            Console.WriteLine("Original string:"+s);
            String s1 = s.ToLower();
            Console.WriteLine("New:"+s1);
        }
    }
}
