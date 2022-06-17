using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Assignment
{
    class Palindrom_num
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = int.Parse(Console.ReadLine());
            int num2;
            num2 = num;
            int rev = 0, sum = 0;
            while (num > 0)
            {
                rev = num % 10;
                sum = sum * 10 + rev;
                num = num / 10;
            }
            Console.WriteLine("Sum is:" + sum);
            if (sum == num2)
            {
                Console.WriteLine("Number is Palindrom number.");
            }
            else
            {
                Console.WriteLine("Number is not Palindrom number.");
            }
        }
    }
}
