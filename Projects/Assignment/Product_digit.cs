using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Assignment
{
    class Product_digit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());
            int rem = 0, pro= 1;
            while (n > 0)
            {
                rem = n % 10;
                pro = pro * rem;
                n = n / 10;
            }
            Console.WriteLine("Number of digit is:" + pro);
        }
    }
}
