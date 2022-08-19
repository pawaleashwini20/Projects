using System;
using System.Collections.Generic;
using System.Text;
//2.	WAP to create a new List, add some colors (string) and print the collection.
namespace Projects.Collection_test1
{
    class Color_List
    {
        static void Main(string[] args)
        {
            List<String> ll = new List<String>();
            ll.Add("Red");
            ll.Add("Black");
            ll.Add("Pink");
            ll.Add("Green");
            ll.Add("White");
            ll.Add("Yellow");
            foreach (String s in ll)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Using Collection:");
            var color = new List<String>() { "Red","Black","Pink","Green","White","Yellow"};
            foreach (String ss in color)
            {
                Console.WriteLine(ss);
            }
        }
    }
}
