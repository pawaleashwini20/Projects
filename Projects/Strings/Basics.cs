using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Strings
{
    class Basics
    {
        static void Main(string[] args)
        {
            String s = "Ashwini";
            String s1 = new string("Ashwini");
            Console.WriteLine(s);
            Console.WriteLine(s1);
            Console.WriteLine(s.GetHashCode());
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine("==:" + (s == s1));//Content
            Console.WriteLine("Equals:" + s.Equals(s1));//Address
            s1 = s1 + "Pawale";//concate with +
            Console.WriteLine(s1);
            Console.WriteLine(s.GetHashCode());
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s.Equals(s1));
            string s2="Ashwini";
            string str = string.Concat(s2, "Pawale");//concate with Concate method
            Console.WriteLine("concate:"+str);
            int x = str.LastIndexOf('a');
            Console.WriteLine("lastt index:"+x);
            string s3 = "India is my country";
            string s4 = "MY";
            Console.WriteLine("Trim:"+s3.Trim());
            Console.WriteLine("Uppercase:"+s3.ToUpper());
        }
    }
}
