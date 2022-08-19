using System;
using System.Collections.Generic;
using System.Text;
//6.	WAP to create Dictionary where key is of string type and value of float
//type and print all key-value pairs.
namespace Projects.Collection_Test2
{
    class Dictionary_Demo
    {
        static void Main(string[] args)
        {
            Dictionary<String, float> d = new Dictionary<String, float>();
            d.Add("A", 12.5f);
            d.Add("B", 23.5f);
            d.Add("C", 34.6f);
            d.Add("G", 56.9f);
            d.Add("Z", 76.88f);
            d.Add("P", 0.00f);
            Console.WriteLine("Dictionary Kay Value....");
            foreach (KeyValuePair<String, float> kv in d)
            {
                Console.WriteLine(kv.Key+"==>"+kv.Value);
            }
        }
    }
}
