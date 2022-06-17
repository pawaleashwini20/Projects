using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year:");
            int n = int.Parse(Console.ReadLine());
            if (n % 4 == 0 || n % 400 == 0)
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Not Leap year");
            }
        }
    }
}
