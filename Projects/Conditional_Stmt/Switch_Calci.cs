using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Conditional_Stmt
{
    class Switch_Calci
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter Two number:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("1.Addition\n2.Substraction\n2.Multiplication\n4.Division");
            Console.WriteLine("Enter Yr Choice:");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Addition is:" +(a+b));
                    break;
                case 2:
                    Console.WriteLine("Substraction is" + (a - b));
                    break;
                case 3:
                    Console.WriteLine("Multiplication is" + (a * b));
                    break;
                case 4:
                    Console.WriteLine("Division is:" + (a / b));
                    break;
                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }
        }
    }
}
