using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Loopping
{
    class Salary
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter Basic salary:");
            double sal = double.Parse(Console.ReadLine());
            double HRA,DA,F_sal;
            if (sal <= 1000)
            {
                DA = sal * 0.8;
                HRA = sal * 0.2;
            }
            else if (sal <= 20000)
            {
                DA = sal * 0.9;
                HRA = sal * 0.25;
            }
            else 
            {
                DA = sal * 0.95;
                HRA = sal * 0.3;
            }
            F_sal = sal + HRA + DA;
            Console.WriteLine("Salary is:" + F_sal);
        }
    }
}
