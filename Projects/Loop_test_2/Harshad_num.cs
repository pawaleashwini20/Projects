using System;
using System.Collections.Generic;
using System.Text;
//5.To find whether the given number is a Harshad number or not, calculate the sum of the
//digit of the number then, check whether the given number is divisible by the sum of its digit.
//If yes, then given number is a Harshad number
namespace Projects.Loop_test_2
{
    class Harshad_num
    {
        public static void Main(String[] args)
        {
           // int num = 156;
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());
            int rem = 0, sum = 0, n;
            n = num;
            while (num > 0)
            {
                rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }


            if (n % sum == 0)
            {
                Console.WriteLine(n + " is a harshad number");
            }
            else
            {
                Console.WriteLine(n + " is not a harshad number");
            }
        }
    }
}
