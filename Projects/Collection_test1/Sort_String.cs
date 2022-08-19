using System;
using System.Collections.Generic;
using System.Text;
//8.WAP to sort the elements of List that contains String objects. Print List.
namespace Projects.Collection_test1
{
    class Sort_String
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
            Console.WriteLine("After Sort:");
            ll.Sort();
            foreach (String s in ll)
            {
                Console.WriteLine(s);
            }
        }
    }
}
