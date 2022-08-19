using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Collection_Practice
{
    class Emp
    {
        private int id;
        private String name;
        private String city;
        public Emp(int id, String name, String city)
        {
            this.id = id;
            this.name = name;
            this.city = city;
        }
        public int Id
        {
            set;
            get;
        }
        public String Name
            {
            set;
            get;
            }
       public String City
        {
            set;
            get;
        }
        public override string ToString()
        {
            return ("ID: " + id + " Name: " + name + " City: " + city);
        }
    }
    class Dictionary_demo1
    {
        static void Main(string[] args)
        {
            Dictionary<Emp, int> dd = new Dictionary<Emp, int>();
            dd.Add(new Emp(101, "AAA", "Pune"), 10000);
            dd.Add(new Emp(102, "BBB", "Munbai"), 20000);
            dd.Add(new Emp(103, "CCC", "satara"), 30000);
            foreach(KeyValuePair<Emp,int> e in dd)
            {
                Console.WriteLine(e.Key+"====>"+e.Value);
            }
        }
    }
}
