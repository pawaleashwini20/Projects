﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.String_Assignment
{
    class Centimeter_meter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            float n = int.Parse(Console.ReadLine());
            float M = n / 100;
            float KM = n / 100000;
            Console.WriteLine("In Meter:" + M);
            Console.WriteLine("In KilloMter:" + KM);
        }
    }
}
