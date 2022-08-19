using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Projects.Collection_Practice
{
    class ArrayList1
    {
        static void Main(string[] args)
        {
            ArrayList aa = new ArrayList();
            aa.Add(1);
            aa.Add("Hiii");
            aa.Add(2);
            aa.Add(6);
            Console.WriteLine("Array list is:");
            foreach (var s in aa)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("size of:"+aa.Count);
            aa.Remove("Hiii");
            foreach (var s in aa)
            {
                Console.WriteLine(s);
            }


        }
    }
}
