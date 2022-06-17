using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Conditional_Stmt
{
    class Vowels
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter character:");
            char ch = Console.ReadLine()[0];
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'a' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("Vowals");
            }
            else
                Console.WriteLine("Constant");
        }
    }
}
