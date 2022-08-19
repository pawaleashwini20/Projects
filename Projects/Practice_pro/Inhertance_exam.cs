using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Inher1
    {
        public virtual void add()
        {
            Console.WriteLine("Addition...........");
        }
        public virtual void sub(int a, int b)
        {
            Console.WriteLine( a-b);
        }
    }
    class Inher2:Inher1
    {
       
        public virtual void mult(int a, int b)
        {
            base.add();
            base.sub(a, b);
            Console.WriteLine(a*b);
        }
    }
    class simple : Inher2
    {
       public void sim()
        {
           
            Console.WriteLine("simple");
        }
    }
    class Inhertance_exam:simple
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter p & q");
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            Inhertance_exam e = new Inhertance_exam();
          //  e.add(p, q);
          //  e.sub(p, q);
            e.sim();
            //  e.mult(p,q);
            Inher2 i = new Inhertance_exam();
            i.mult(p, q);
        }
    }
}
