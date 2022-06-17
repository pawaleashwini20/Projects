using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Task_Que
{
    class Arithmatic_Op
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two number:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Addition is:" + (n1 + n2));
            Console.WriteLine("Substraction is:" + (n1 - n2));
            Console.WriteLine("division is:" + (n1 / n2));
            Console.WriteLine("Multplication is:" + (n1 * n2));
        }
    }
}
