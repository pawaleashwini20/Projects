using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Conditional_Stmt
{
    class LeapYear
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter Year:");
            int year = int.Parse(Console.ReadLine());
            if (year % 400 == 0)
            {
                Console.WriteLine("Leap Year" + year);
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("Not Leap Year" + year);
            }
            else if (year % 4 == 0)
            {
                Console.Write("Leap Year" + year);
            }
        }
    }
}
