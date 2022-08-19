using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_Pro1
{
    class String_Op
    {
        public void Reverse(String s)
        {
            Console.WriteLine("String is:"+s);
            string rev = "";
            for (int i =s.Length-1; i>=0; i--)
            {
                rev = rev + s[i];
            }
            Console.WriteLine("REverse is:"+rev);
        }
        public void Vowels(String s)
        {

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' ||
                    s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
                {
                    Console.WriteLine("Vowels:" + s[i]);
                }
            }

        }
        public void asending(String s)
        {
            char[] ch = s.ToCharArray();
            char[] num = new char[ch.Length];
            char[] ch1 = new char[s.Length];
            int n = 0, m = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] >= '0' && ch[i] <= '9')
                {
                    num[n] = ch[i];
                    n++;
                    //Console.WriteLine(ch[i]+" ");
                }
                else if (ch[i] >= 'A' && ch[i] <= 'Z' || ch[i] >= 'a' && ch[i] <= 'z')
                {
                    ch1[n] = ch[i];
                    n++;
                }
            }
            Console.WriteLine(String.Join(" ", ch1));
            Console.WriteLine("Final o/p:");

            Console.WriteLine("//////////////////////////");   
            Array.Sort(num);
            Array.Sort(ch1);
            Console.Write(String.Join("", ch1));
            Console.Write(String.Join("", num));
            
           

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            string s = Console.ReadLine();
            String_Op so = new String_Op();
          //  so.Reverse(s);
            //so.Vowels(s);
            so.asending(s);
        }
    }
}
