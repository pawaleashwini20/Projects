using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Conditional_Stmt
{
    class IsChar
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter Character:");
            char ch = Console.ReadLine()[0];
            if ((ch >='a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine("Alphabet");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("character is digit");
            }
            else 
            {
                Console.WriteLine("character is Special Symbol");
            }
        }
    }
}
