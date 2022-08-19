using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Collections
{
    class myStringBuilderSort : IComparer<StringBuilder>
    {
        public int Compare(StringBuilder x, StringBuilder y)
        { 
            return x.ToString().CompareTo(y.ToString());
        }
    }
    class Clompare_Demo
    {
        static void Main(string[] args)
        {
            SortedList<StringBuilder, int> sb = new SortedList<StringBuilder, int>(new myStringBuilderSort());
            sb.Add(new StringBuilder("Amit"), 90000);
            sb.Add(new StringBuilder("sham"), 800);
            sb.Add(new StringBuilder("Riya"), 90000);
            sb.Add(new StringBuilder("Soham"), 90000);
            foreach(KeyValuePair<StringBuilder,int>kv in sb)
            {
                Console.WriteLine(kv.Key+"==>"+kv.Value);
            }
            Dictionary<StringBuilder, int> dd = new Dictionary<StringBuilder, int>(sb);
        }
    }
}
