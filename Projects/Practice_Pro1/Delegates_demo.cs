using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_Pro1
{
    class Delegates_demo
    {
        delegate int m(int x, int y);
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Mult(int x, int y)
        {
            return x * y;
        }
        static void Main(string[] args)
        {
            m del = new m(Add);
            int result=del(10, 20);
            Console.WriteLine("result :" +result);
            del = new m(Mult);
            result = del(12, 2);
            Console.WriteLine("Result:"+result);

        }

        
    }

}
