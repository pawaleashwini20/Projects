using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class String_pro
    {
        public static void Reverse(String s)
        {
            Console.WriteLine("Reverse..............");
            String str = s;
            string[] str1 = str.Split(" ");
            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = i + 1; j < str1.Length; j++)
                {
                    String temp = str1[i];
                    str1[i] = str1[j];
                    str1[j] = temp;
                }
            }
            Console.WriteLine(String.Join(" ",str1));
        }
        public static void TotalWord(String s)
        {
            Console.WriteLine("Word Count................");
            int cnt = 0;
            int i = 0;
            while(i<=s.Length-1)
            {
                if (s[i] == ' ' || s[i] =='\t' || s[i] == '\n')
                {
                    cnt++;
                }
                i++;

                 
            }
            Console.WriteLine("Word Count is:::"+cnt);
        }
        public static void OccurranceAll(String s)
        {
            Console.WriteLine("Occurrance of All................");
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
                for (int k = 0; k < freq.Length; k++)
                {
                    if(ch[k]!=' '  &&  ch[k]!='0')
                    Console.WriteLine(ch[k]+" : "+freq[k]);
                }
            
        }
        public static void RemoveDupli(String s)
        {
            Console.WriteLine("RemoveDuplicates.......... ");
            char[] ch = s.ToCharArray();
            int[] freq = new int[s.Length];
            char[] merge = new char[s.Length];
            int k= 0;
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
                    merge[k] = ch[i];
                    k++;
                }
            }
            for (int i = 0; i < merge.Length; i++)
            {
                Console.Write(String.Join(" ",merge[i]));
            }
        
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            string s = Console.ReadLine();
            
            Reverse(s);
            TotalWord(s);
            OccurranceAll(s);
            RemoveDupli(s);
        }
    }
}
