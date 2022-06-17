using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Conditional_Stmt
{
    class Switch_Days
    {
        public static void Main(String[] args)
        {
            // Console.WriteLine("Enter Number:");
            //int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine("1.One\n2.Two\n3.Three\n4.Four\n5.Five\n6.Six\n7.Seven");
            Console.WriteLine("Enter Yr Choice:");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Monday...");
                    break;
                case 2:
                    Console.WriteLine("Tuesday...");
                    break;
                case 3:
                    Console.WriteLine("Wednesday...");
                    break;
                case 4:
                    Console.WriteLine("Thusday...");
                    break;
                case 5:
                    Console.WriteLine("Friday...");
                        break;
                case 6:
                    Console.WriteLine("Saturday...");
                    break;
                case 7:
                    Console.WriteLine("Sunday...");
                    break;
                default:
                    Console.WriteLine("Wring choice...");
                    break;
            }
        }
    }
}
