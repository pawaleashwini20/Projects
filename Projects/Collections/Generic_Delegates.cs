using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Collections
{
    class Generic_Delegates
    {
        public static double Add1(int x, float y, double z)
            {
            return x + y + z;
            }
        public static void Add2(int x, float y, double z)
        {
            Console.WriteLine("Add:"+(x+y+z));
        }
        public static bool CheckL(String x)
        {
            if (x.Length > 5)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            Func<int, float, double, double> obj1 = Add1;
            double result=obj1(100, 12.3f, 123);
            Console.WriteLine("Add1:"+result);
            Action<int, float, double> obj2 = Add2;
            obj2(100, 12.3f, 123);
            Predicate<String> obj3 = CheckL;
            bool result1 = obj3("ash");
            Console.WriteLine("Result is:"+result1);
            //Ananomous method
            Action<int,char,double> obj4 =(x,y,z)=>
                {
                   Console.WriteLine("Anamomous:"+(100+'A'+12.34));
                };

        }
    }
}
