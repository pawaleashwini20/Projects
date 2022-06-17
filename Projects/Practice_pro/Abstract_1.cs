using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    interface add
    {
        public  int Add(int a, int b);
    }
    interface sub
    {
        public int Sub(int a, int b);
    }
    interface mult
    {
        public  int Mult(int a, int b);
    }
    interface div
    {
        public int Div(int a, int b);
    }

    
    class Operartion :add,sub,mult,div
    {
       public int Add(int a,int b)
        {
          //  int k = a + b;
            return(a+b);
         //   Console.WriteLine(k);
        }
        public int Sub(int a,int b)
        {
            return (a - b);
        }
        public int Mult(int a,int b)
        {
           return (a *b);
           // Console.WriteLine();
        }
        public int Div(int a, int b)
        {
            return (a / b);
        }
    }
    class Abstract_1
    {
        static void Main(string[] args)
        {
            Operartion o = new Operartion();
            int p=o.Add(10, 40);
            Console.WriteLine(p);
            int q,r,n;
            Console.WriteLine((o.Sub(20, 5)));
            Console.WriteLine(o.Mult(30, 5));
            Console.WriteLine(o.Div(30, 5));
          //  o.Div(100, 50);
        
        }
    }
}
