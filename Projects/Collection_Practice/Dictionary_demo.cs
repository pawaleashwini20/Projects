using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Collection_Practice
{
    class Dictionary_demo
    {
        static void Main(string[] args)
        {
            Dictionary<String, int> d =new Dictionary<String,int>();
            d.Add("Ram", 102);
            d.Add("Rani", 103);
            d.Add("ABC", 104);
            d.Add("Gauri", 105);
            Console.WriteLine( "Kay" +"==>"+" value");
            Console.WriteLine("------------------------");
            foreach (KeyValuePair<String, int> s in d)
            {
                Console.WriteLine(s.Key+"==>"+s.Value);
            }
            List<String> key = new List<String>(d.Keys);
            foreach (String s in key)
            {
                Console.WriteLine("Keys:"+s);
            }
            List<int> value = new List<int>(d.Values);
            foreach (int s in value)
            {
                Console.WriteLine("Values:"+s);
            }
        }
    }
}
