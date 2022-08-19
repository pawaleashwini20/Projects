using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Basic
{
    class Standerd_Rail
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter Date of joinning in Day-Month-Year  format.");

            Console.WriteLine("Enter Day");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Months");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Year");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Date is:" + d + "-" + m + "-" + y);
            Console.WriteLine("Add 10 Days in date");
            int new_d = d + 10;
            if (new_d >= 30)
            {
                m = m + 1;
                m = 1;
            }
            else if (m > 13)
            {
                y = y + 1;
            }
            Console.WriteLine("Date of OnBoarding:"+new_d + "-" + m + "-" + y);
        }
    }
}
