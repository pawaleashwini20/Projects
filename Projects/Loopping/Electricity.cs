using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Loopping
{
    class Electricity
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter Units:");
            double unit = double.Parse(Console.ReadLine());
            double amt,S_Charge,Total;
            if (unit <= 50)
            {
                amt = unit * 0.50;
            }
            else if (unit <= 150)
            {
                amt = 25 + ((unit - 50) * 0.75);
            }
            else if (unit <= 250)
            {
                amt = 100 + ((unit - 150) * 1.20);
            }
            else
            {
                amt = 220 + ((unit - 250) * 1.50);
            }
            S_Charge = amt * 0.20;
            Total= amt + S_Charge;
            Console.WriteLine("Total Bill:" + Total);
        }
    }
}
