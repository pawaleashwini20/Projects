using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.While
{
    class Armstrong
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());
            int rev = 0, sum = 0,num2;
            num2 = num;
            while (num > 0)
            {
                rev = num % 10;
                sum = (sum + (rev*rev*rev));
                num = num / 10;
            }
            if (num2 == sum)
            {
                Console.WriteLine("Armstrong number:" + num2);
            }
            else
            {
                Console.WriteLine("not Armstrong number:" + num2);
            }


        }
    }
}
