using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Collections
{
    class Delegate_Mix
    {
       // public delegate int m11(int a,char c);
        //public delegate int m22(byte a, String s);
        //public delegate int m33(byte a, String s);
        static double m1(int r, char c)
            {
           // Console.WriteLine("in M1"+r+c);
            return r*3.14;
            }
        static bool m2(long a, String s)
        {
            return true;
        }
        static void m3(byte a, String e)
        {
            //return true;
           Console.WriteLine("in m3"+a+":"+e);
        }
        static void Main(String[] args)
        {
            Func<int,char,double> m11 = m1;
            m1(10, 'A');
            Func<long, string, bool> A = m2;
            bool bb = A(10, "yes/no");
           Action<byte,String>aa = m3;
            aa(223,"ABC");
        }
    }
}
