using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Collection_Practice
{
    class Students
    {
        private int id;
        private String name;
        private String city;
        public Students(int id, string name, String city)
        {
            this.id = id;
            this.name = name;
            this.city = city;
        }
        public  int Id
        {
            set { this.id = value; }
            get { return id; }
        }
        public string Name
        {
            set { this.name = value; }
            get { return name; }
        }
        public string City
        {
            set { this.city = value; }
            get { return city; }
        }
        public override String ToString()
        {
            return("Id: " + Id + " Name: " + Name + " City: " + City);
        }
    }
    class List_Practice
    {
        static void Main(string[] args)
        {
           // int id; string name;String city;
            List<Students> ls = new List<Students>();
              // ls.Add(new Students(id,name,city));
                ls.Add(new Students(11, "Ashwini", "pune"));
                ls.Add(new Students(12, "Gauri", "peth"));
                ls.Add(new Students(13, "Ram", "Mumbai"));
                ls.Add(new Students(14, "sara", "Delhi"));
              // ls.Add(new Students(id, name,city));
            
            foreach (Students s in ls)
            {
                Console.WriteLine(s);
            }
        }
    
    }
}
