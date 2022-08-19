using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class String_operations
    {
            public void Reverse(String str)
            {
                string rev = "";
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    rev = rev + str[i];
                }
                Console.WriteLine("Reverse is: " + rev);
            }
        public void num_cnt(String str)
        {
            int cnt = 0;
            char[] ch = str.ToCharArray();
            char[] ch_n = new char[str.Length];
            char[] ch_n1 = new char[str.Length];
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] >= '0' && ch[i] <= '9')
                {
                    ch_n[cnt] = ch[i];
                    cnt++;
                }
                else 
                {
                    ch_n1[cnt] = ch[i];
                    cnt++;
                }
            }
            Console.WriteLine("Total number in String are:"+cnt);
            Console.WriteLine(String.Join(" ",ch_n));
            Array.Sort(ch_n);
            Console.Write(String.Join("", ch_n));
            Console.Write(String.Join("", ch_n1));
        }
        public void sum_digit(String str)
        {
            char[] ch_n = new char[str.Length];
            double sum = 0;
            int cnt = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    ch_n[cnt] = str[i];
                    cnt++;
                    double x = char.GetNumericValue(str[i]);
                    sum = sum + x;
                }
            }
         
            Console.WriteLine("Sum of digit:"+sum);
        }
            static void Main(string[] args)
            {
                Console.WriteLine("enter String:");
                String s = Console.ReadLine();
                String_operations so = new String_operations();
                so.Reverse(s);
                so.num_cnt(s);
                   so.sum_digit(s);
            }
        
    }
}
