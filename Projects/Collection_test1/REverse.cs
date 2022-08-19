using System;
using System.Collections.Generic;
using System.Text;

//7.	WAP to print list in reverse order .
namespace Projects.Collection_test1
{
    class REverse
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();
            li.Add(100);
            li.Add(200);
            li.Add(300);
            li.Add(400);
            li.Add(500);
           // int[] a = li.ToArray();
            foreach (int i in li)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine("After Reverse:");
            li.Reverse();
            foreach (int i in li)
            {
                Console.WriteLine(i);

            }
        }
    }
}
