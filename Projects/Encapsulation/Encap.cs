using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Encapsulation
{
    class ABC
    {
        private String name;
        private int id;
        public String Name
        {
            get;
            set;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
    class Encap
    {
        static void Main(string[] args)
        {
            ABC a = new ABC();
            a.Name = "ASHWINI";
            a.Id = 101;
            Console.WriteLine("Name:"+a.Name+"  ID:"+a.Id);
        }
    }
}
