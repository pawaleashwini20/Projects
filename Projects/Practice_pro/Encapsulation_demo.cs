using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Demo
    {
        private String name;
        private String name1;
        public String Name
        {
            get;
            set;

        }
        public string Name1
        {
            get;
            set;
        }

    }
    class Encapsulation_demo
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            d.Name="Ashwini";
            d.Name1 = "Pawale";
            Console.WriteLine("First Name:"+d.Name+"\tLast Name:"+d.Name1);
            Console.WriteLine(d.Name+d.Name1);
        }
    }
}
