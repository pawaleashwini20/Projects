using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Pattern
{
    class MenuDriven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.circle2.\n2.Rectangle\n3.Triangle\n4.Square");
            int cnt;
            do
            {
                Console.WriteLine("Enter yr choice:");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter radius:");
                            float r = float.Parse(Console.ReadLine());
                            // float h = float.Parse(Console.ReadLine());
                            Console.WriteLine("Area of circle: " + (3.14 * r * r));
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Enter Length,breadth:");
                            float b = float.Parse(Console.ReadLine());
                            float l = float.Parse(Console.ReadLine());
                            Console.WriteLine("Area of Rectangle: " + (l * b));
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Enter Length,breadth:");
                            float b = float.Parse(Console.ReadLine());
                            float l = float.Parse(Console.ReadLine());
                            Console.WriteLine("Area of Rectangle: " + (l * b) / 2);
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Enter side:");
                            float s = float.Parse(Console.ReadLine());

                            Console.WriteLine("Area of Square: " + (s * s));
                        }
                        break;
                    default:
                        Console.WriteLine("wrong choice");
                        break;
                }
                Console.WriteLine("Do u want to continue...press 1 and 0 to teminate..");
                cnt = int.Parse(Console.ReadLine());

            } while (cnt != 0);
        }
    }
}
