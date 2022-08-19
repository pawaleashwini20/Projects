using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Collections
{
    class Dictionary_Color
    {
        static void Main(string[] args)
        {
            List<String> ll = new List<String>()
            { "Red","Blue","Pink","Gray","Red","Green","Pink"};
            //Occurrance Of All element...
            Dictionary<String, int> dd = new Dictionary<string, int>();
            foreach (String color in ll)
            {
                if (dd.ContainsKey(color))
                {
                    int oldvalue = dd[color];
                    dd[color] = oldvalue+1;
                }
                else 
                {
                    dd.Add(color, 1);
                }
            }
            foreach (KeyValuePair<String, int> aa in dd)
            {
                Console.WriteLine(aa.Key+":"+aa.Value);
            }
            Console.WriteLine("///Remove//");
            String colorToDelete = "Red";
            ll.Remove(colorToDelete);
            while (true)
            {
                int index = ll.IndexOf(colorToDelete);
                if (index != -1)
                {
                    ll.RemoveAt(index);
                }
                else
                {
                    break;
                }
                
            }
            foreach(String cc in ll)
            {
                Console.WriteLine(cc);
            }
        }
    }
}
