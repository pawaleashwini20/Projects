using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Assignment
{
    class Divide_5_11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());
            if (num % 5 == 0 || num % 11 == 0)
            {
                Console.WriteLine("Divisible by 5 or 11 "+num);
            }
            else 
            {
                Console.WriteLine("Not divisible by 5 or 11");
            }
        }
    }
}
