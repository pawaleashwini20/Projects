using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Conditional_Stmt
{
    class Ter_EvenOdd
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            String result = (num % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine("Number is:" + result);
        }
    }
}
