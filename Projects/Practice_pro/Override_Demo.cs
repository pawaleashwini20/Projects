using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class over
    {
        public virtual void Add(int a, int b)
        {
            Console.WriteLine("Addition :"+a+b);
        }

    }
    class over1 : over 
    {
        public override void Add(int a, int b)
        {
            base.Add(a,b);
            Console.WriteLine("Ovwe1 Add:"+a+b);
        }
    }
    class Override_Demo
    {
        static void Main(string[] args)
        {
            int a = 10, b = 2;
            over1 o = new over1();
           // over p = new over();
           // p.Add(a, b);
            o.Add(a, b);
        }
    }
}
