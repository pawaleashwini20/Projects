using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Practice_pro
{
    class Custom_Exception:ApplicationException
    {
    }
    class Emp:IComparable<Emp>
    {
        public Emp(int id,string name,string city)
        {
            this.id = id;
            this.name = name;
            this.city = city;
        }
        int id;
        String name;
        string city;
        public int Id
        {
            set
            {
                //this.id = value;
                if (id == null)
                {
                    throw new Custom_Exception();
                }
                else 
                {
                    this.id=value;
                }
            }
            get { return id; }
        }
        public int CompareTo(Emp e)
        { 
            return this.city.CompareTo(e.city);
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
        public override String ToString()
        {
            return ("ID:" + id + "\tName:" + name + "\tCity:" + city);
        }
       /* static void Main(string[] args)
        {
          Emp c = new Emp();
            c.Id = 101;
            c.Name = "Ashwini";
            c.city = "Pune";
            Console.WriteLine("Id:"+c.id+" Name:"+c.Name+ " City:" +c.city);

        }*/
    }
}
