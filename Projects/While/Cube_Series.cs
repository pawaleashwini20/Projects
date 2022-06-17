using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.While
{
    class Cube_Series
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Number:");
            int num = int.Parse(Console.ReadLine());
            //int num = 1;
            int sq, cube, total;
            while (num >= 1)
            {
                sq=num* num;
                cube = num * num * num;
                total = sq + cube;
                Console.WriteLine(total + " ");
                num++;
                if (num == 10)
                {
                    break;
                }
            }

        }
    }
}
