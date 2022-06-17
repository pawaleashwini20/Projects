using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Task_Que
{
    class Interest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter P,R,T:");
            float p = float.Parse(Console.ReadLine());
            float r = float.Parse(Console.ReadLine());
            float t = float.Parse(Console.ReadLine());
            float S_Interest = (p * r * t) / 100;
            Console.WriteLine("Simple Interest is:"+S_Interest);
        }
    }
}
