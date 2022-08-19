using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    
    class String_Demo
    {
        public void reverse(String s)
        {
            String rev = "";
            for (int i = s.Length-1; i >= 0; i--)
            {
                rev = rev + s[i];
            }
            Console.WriteLine("Reverse is: "+rev);
        }
        public void Word_rev(String s)
        {
            String temp;
            string[] str=s.Split(" ");
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    temp = str[i];
                    str[i] = str[j];
                    str[j] = temp;
                }
            }
            Console.WriteLine(String.Join(" ",str));
        }
        public void vowels(String s)
        {
            int cnt = 0;
            char[] ch = s.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == 'a' || ch[i] == 'e' || ch[i] == 'i' || ch[i] == 'o' || ch[i] == 'u')
                {
                    cnt++;
                }
            }
            Console.WriteLine("Vowels are:"+cnt);
        
        }
        public void upper(String s)
        {
            char c;
            char[] ch = s.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                c= ch[i];
                if (char.IsLower(c))
                {
                    Console.WriteLine(char.ToUpper(c));
                }
                else 
                {
                    Console.WriteLine(char.ToLower(c));
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String..");
            String s = Console.ReadLine();
            String_Demo d = new String_Demo();
           // d.reverse(s);
           // d.Word_rev(s);
            //d.vowels(s);
            d.upper(s);
        }
    }
}
