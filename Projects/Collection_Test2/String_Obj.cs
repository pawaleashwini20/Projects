using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
//1.	WAP to sort the elements of List that contains String objects. Print List.
namespace Projects.Collection_Test2
{
   
    class String_Obj
    {
        static void Main(string[] args)
        {
            List<String> ll = new List<string>();
            ll.Add("ABC");
            ll.Add("ZXY");
            ll.Add("POQ");
            ll.Add("LMN");
            ll.Add("ASD");
            ll.Add("KJH");
            ll.Add("BBB");
            foreach (String s in ll)
            {
                Console.WriteLine(s);
            }
            ll.Sort();
            Console.WriteLine("After Sort.........");
            foreach (String s in ll)
            {
                Console.WriteLine(s);
            }
        }
    }
}
