using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Collection_test1
{
    class Dictionary_key_value
    {
        static void Main(string[] args)
        {
            Dictionary<String, int> d = new Dictionary<String, int>();
            d.Add("Ashwini", 90);
            d.Add("Riya", 98);
            d.Add("XYZ", 86);
            d.Add("Ram", 78);
            d.Add("Praju", 46);
            Console.WriteLine("Key Value Pair:");
            foreach (KeyValuePair<String, int> a in d)
            {
                Console.WriteLine(a.Key + ":" + a.Value);
            }

            foreach(KeyValuePair<string, int> a in d)
            {
                Console.WriteLine("Key: {0}, Value: {1}", a.Key, a.Value);
              //  Console.WriteLine(a);
            }
            Console.WriteLine("Keys...");
            List<String> keys = new List<String>(d.Keys);
            foreach (String s in keys)
            {
                Console.WriteLine("Kay:"+s);
            }
            Console.WriteLine("Value...");
            List<int> values = new List<int>(d.Values);
            foreach (int v in values)
            {
                Console.WriteLine("Value:"+v);
            }
        }
    }
}
