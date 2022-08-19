using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Collections
{
    class Dictionary_Demo
    {
        static void Main(string[] args)
        {
            List<Emp> l = new List<Emp>();
            l.Add(new Emp("Deepa", 8));
            l.Add(new Emp("Ram", 9));

            Dictionary<String,int> d = new Dictionary<String,int>();
            d.Add("Ashwini", 90);
            d.Add("Riya", 98);
            d.Add("XYZ", 86);
            Console.WriteLine(d["Riya"]);
            d["XYZ"] = 78;
            foreach (KeyValuePair<String, int> a in d)
            {
                Console.WriteLine(a.Key+":"+a.Value);
            }
        }
    }
}
