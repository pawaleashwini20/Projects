using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_Pro1
{
    class String_op1
    {
        static void reverse(String s)
        {
            String rev = "";
            for (int i = s.Length-1; i >= 0; i--)
            {
                rev = rev + s[i];
            }
            Console.WriteLine(rev);
        }
        static void word_rev(String s)
        {
            string[] ch = s.Split(" ");
            for (int i = 0; i < ch.Length; i++)
            {
                for (int j = i + 1; j < ch.Length; j++)
                {
                    string temp = ch[i];
                    ch[i] = ch[j];
                    ch[j] = temp;
                }
            
            }
            Console.WriteLine(String.Join(" ",ch));
        }
        static void reverse1(string s)
        {

            char[] ch = s.ToCharArray();
            int i =0;
            int j =ch.Length-1 ;

            char temp;
                while (i < j)
            {
                temp = ch[i];
                ch[i] =ch[j];
                ch[j] = temp;
                i++;
                j--;
            
            }
            Console.WriteLine(String.Join("",ch));
        }
        static void Digit_Sum(String s)
        {
            char[] ch = new char[s.Length];
            char[] num = new char[s.Length];
            char[] str = s.ToCharArray();
            int k = 0,j=0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    num[k] = str[i];
                    k++;
                }
                else if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A') && str[i] < 'Z')
                {
                    ch[j] = str[i];
                    j++;
                }
            }
            
            Console.WriteLine(String.Join("",num));
            Array.Sort(num);
            Console.WriteLine(String.Join("", num));
            Console.WriteLine(String.Join("",ch));
        
        }
        static void upper_lower(String s)
        {
            char[] ch = s.ToCharArray();
            char c;
            for (int i = 0; i < ch.Length; i++)
            {
                c = ch[i];
                if (char.IsLower(c))
                {
                    Console.Write(char.ToUpper(c));
                }
                else
                {
                    Console.Write(char.ToLower(c));
                }
            }
        }
        static void Anagram(String s)
        {
            Console.WriteLine("Enter string2:");
            String s2 =Console.ReadLine();

            char[] ch = s.ToLower().ToCharArray();
            char[] ch2 = s2.ToLower().ToCharArray();
            Array.Sort(ch);
            Array.Sort(ch2);
            String str1 = new string(ch);
            String str2 = new string(ch2);
            if (str1 == str2)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not Anagram..");
            }
        
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            String s = Console.ReadLine();
            //reverse(s);
            // word_rev(s);
            //reverse1(s);
            //  Digit_Sum(s);
            //upper_lower(s);
            Anagram(s);
        }

    }
}
