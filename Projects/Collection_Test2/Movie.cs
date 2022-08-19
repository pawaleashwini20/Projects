using System;
using System.Collections.Generic;
using System.Text;
//7.	Make use of such collection that stores moviename such that
//last entered movie is first deleted and accordingly previous one.

namespace Projects.Collection_Test2
{
    class Movie
    {
        private const string V = "  ";
        private static string Out;

        static void Main(string[] args)
        {
            Stack<String> s = new Stack<String>();
            s.Push("Robot");
            s.Push("India");
            s.Push("Mela");
            s.Push("Race");
            s.Push("Sairat");
            foreach (String ss in s)
            {
                Console.WriteLine(ss);
            }
            /*int x = 3;
            bool v=s.TryPop();
            V = "Race";*/
            s.Pop();
            Console.WriteLine("After operation...");
            foreach (String ss in s)
            {
                Console.WriteLine(ss);
            }


        }
    }
}
