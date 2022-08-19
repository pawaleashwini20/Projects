using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class String_Op1
    {
        public void Reverse(String s)
        {
            Console.WriteLine("String is:" + s);
            String[] str = s.Split(" ");
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i+1; j < str.Length; j++)
                {
                    String temp = str[i];
                    str[i] = str[j];
                    str[j] = temp;
                }
            }
            Console.WriteLine("///////////");
            Console.WriteLine(String.Join(" ",str));
        }
        public void Occurrance(String s)
        {
            Console.WriteLine("String is:"+s);
            char[] ch = s.ToCharArray();
            int[] freq = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                freq[i] = 1;
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (ch[i] == ch[j])
                    {
                        freq[i]++;
                        ch[j] = '0';
                    }
                }
            }
            Console.WriteLine("/////////");
            for (int i = 0; i < freq.Length; i++)
            {
                if (ch[i] !=' ' && ch[i] !='0')
                {
                    Console.WriteLine(ch[i]+":"+freq[i]);
                }
            }

        }
        public void Remove_Duplicate(String s)
        {
            char[] ch = s.ToCharArray();
            char[] merge = new char[s.Length];
            int k = 0;

            for (int i = 0; i < s.Length; i++)
            {
                bool isvisite = true;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (ch[i] == ch[j])
                    {
                        isvisite = false;
                        break;
                    }
                }
                if (isvisite == true)
                {
                    merge[k]=ch[i];
                    k++;
                }
            }
            Console.WriteLine("//////");
            for (int i = 0; i < merge.Length; i++)
            {
                Console.WriteLine(merge[i]);                       
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            String s = Console.ReadLine();
            String_Op1 so = new String_Op1();
            so.Reverse(s);
            so.Occurrance(s);
            so.Remove_Duplicate(s);
        }
    }
}
