using System;
using System.Collections.Generic;
using System.Text;
//1.	WAP add elements to List<String>,insert at specifies=d position ,
//update and delete a element.
namespace Projects.Collection_test1
{
    class List_update
    {
        static void Main(string[] args)
        {
            List<String> ll = new List<String>();
            ll.Add("Ashwini");
            ll.Add("Gauri");
            ll.Add("Prajkta");
            ll.Add("Ram");
            foreach (String s in ll)
            {
                Console.WriteLine(s);
            }
            ll.Remove("Prajkta");
            Console.WriteLine("After Remove:");
            ll[2] = "PQR";
            foreach (String s in ll)
            {
                Console.WriteLine(s);
            }
        }
    }
}
