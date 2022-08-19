using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Interface_demo
{
    interface Add
    {
        int add(int a, int b);
    }
    interface Sub
    {
        int sub(int a, int b);
    }
    interface Mult
    {
        int mult(int a, int b);
    }
    interface Div
    {
        int div(int a, int b);
    }
    class Contain : Add, Sub, Mult, Div
    {
        public int add(int a, int b)
        {
            return (a + b);
        }
        public int sub(int a, int b)
        {
            return (a - b);
        }
        public int mult(int a, int b)
        {
            return (a * b);
        }
        public int div(int a, int b)
        {
            return (a / b);
        }

    }
    class Operations
    {
        static void Main(string[] args)
        {
            Contain c = new Contain();
            
            Console.WriteLine("Enter p and q");
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            Console.WriteLine("Arithmatic operations:");
           
          Console.WriteLine("1.Addition\n2.Substraction\n3.Multiplication\n4.Division");
            int cnt = 1;
            do
            {
                Console.WriteLine("enter ur choice:");
                int ch = int.Parse(Console.ReadLine());
              //  Console.WriteLine("1.Addition\n2.Substraction\n3.Multiplication\n4.Division");
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Addition:" + c.add(p, q));
                        break;
                    case 2:
                        Console.WriteLine("Substraction:" + c.sub(p, q));
                        break;
                    case 3:
                        Console.WriteLine("Multiplication:" + c.mult(p, q));
                        break;
                    case 4:
                        Console.WriteLine("Division:" + c.div(p, q));
                        break;
                    default:
                        Console.WriteLine("Wrong choice...");
                        break;
                }
                Console.WriteLine("Do u want to continue...press 1 & 0 to terminate");
                cnt = Convert.ToInt32(Console.ReadLine());
            }
            while (cnt!= 0);
            
        }
    }
}
