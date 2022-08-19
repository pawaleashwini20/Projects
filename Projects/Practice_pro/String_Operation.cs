using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projects.Practice_pro
{
    class String_Operation
    {
        public void Reverse(String s)
        {
            String rev = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev = rev + s[i];
            }
            Console.WriteLine("Reverse is:"+rev);
        }
        public void Word(String s)
        {
            Console.WriteLine("Word reverse");
            String[] str = s.Split(" ");
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    String temp = str[i];
                    str[i] = str[j];
                    str[j] = temp;
                }
            }
            Console.WriteLine(String.Join(" ",str));
        }
        public void Remove_Duplicate(String s)
        {
            char[] merge = new char[s.Length]; 
            char[] ch = s.ToCharArray();
            int k = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                bool isvisite = true;
                for (int j = i + 1; j < ch.Length; j++)
                {
                    if (ch[i] == ch[j])
                    {
                        isvisite = false;
                        break;
                    }
                }
                if (isvisite == true)
                { 
                        merge[k] = ch[i];
                        k++;
                    
                }
            }
            Console.WriteLine(String.Join(" ",merge));
        }
        public void Cancate_S(String s)
        {
            Console.WriteLine("Enter String");
            String s1 = Console.ReadLine();
            String s2 =s1+("AAA");
            Console.WriteLine(s2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            String s = Console.ReadLine();
            String_Operation so = new String_Operation();
            so.Reverse(s);
            so.Word(s);
            so.Remove_Duplicate(s);
            so.Cancate_S(s);
        }
    }
}
