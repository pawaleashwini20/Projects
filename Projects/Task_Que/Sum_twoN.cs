using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Task_Que
{
    class Sum_twoN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two number:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int sum;
            Console.WriteLine("Sum is:" + (n1 + n2));
        }
    }
}
