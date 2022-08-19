using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Buzz
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            for (int i = 0; i < 50; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("BuzzFizz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
