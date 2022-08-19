using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.String_Assignment
{
    class Two_numSum
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Enter nummber:");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            int sum = n1 + n2;
            Console.WriteLine("Sum:"+sum);
        }
    }
}
