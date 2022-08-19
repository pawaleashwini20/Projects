using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.TEST_Pro
{
    class Age
    {
        public static void people()
        {
            int age = 0;
            age = age + 7;
            Console.WriteLine("Age is"+age);
        }
        static void Main(string[] args)
        {
            Age Age = new Age();
            Age.people();
        }
    }
}
