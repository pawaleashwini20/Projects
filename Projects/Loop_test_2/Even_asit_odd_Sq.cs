using System;
using System.Collections.Generic;
using System.Text;
//3.	 WAP to print number from 1 to 50 if number is even then print as it is and number is odd
//then print its square
namespace Projects.Loop_test_2
{
    class Even_asit_odd_Sq
    {
        static void Main(string[] args)
        {

             for (int i = 1; i < 50; i++)
            {
                int r = (i % 2 == 0) ? i : i * i;
                Console.WriteLine(r);
            }
        }
    }
}
