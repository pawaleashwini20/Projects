using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.String_Assignment
{
    class Arithmatic_op
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two number:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Adition:"+(n1+n2));
            Console.WriteLine("Substraction:" + (n1 - n2));
            Console.WriteLine("multiplication:" + (n1 * n2));
            Console.WriteLine("Divisionion:" + (n1 / n2));
        }
    }
}
