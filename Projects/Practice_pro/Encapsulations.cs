using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Encap
    {
        private int id;
        private int mob;
        private String name;
        public int Id
        {
            get { return id; }
            set { id = value; }
            
        }
        public int Mob
        {
            get { return mob; }
            set { mob = value; }
        }
        public String Name
        {
            get;
            set;
        }

    }
    class Encapsulations
    {
        Encap en;
        private String city;
        public String City
        {
            get { return city; }
            set { city = value; }
        }
        static void Main(string[] args)
        {
            Encapsulations e = new Encapsulations();
            e.city = "pune";
            Console.WriteLine("city:"+e.city);
            e.en = new Encap();
            e.en.Id = 101;
            e.en.Mob = 1234567898;
            e.en.Name = "Ashwini";
            Console.WriteLine(" ID:"+e.en.Id+" name:"+e.en.Name+" Mobile:"+e.en.Mob+" city:"+e.city);
        }
    }
}
