using System;
using System.Collections.Generic;
using System.Text;
//2.WAP to create a class Employee with (name, designation ,salary).
//Now create and add Employee objects elements to List. Print List.
namespace Projects.Collection_Test2
{
    class Emp:IComparable<Emp>
    {
       public String e_name;
        public String e_desi;
        public int e_sal;
        public Emp(String e_name,String e_desi,int e_sal)
        {
            this.e_name = e_name;
            this.e_desi = e_desi;
            this.e_sal = e_sal;
        }
        public String E_name
            {
                get;
                set;
            }
        public String E_desi
        {
            get;
            set;
        }
        public int E_sal
        {
            get;
            set;
        }
        public int CompareTo(Emp e)
        {
            return this.e_name.CompareTo(e.e_name);
        }
        public override string ToString()
        {
            return ("Name:" + e_name + "Designation:" + e_desi + "Salry:" + e_sal);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter name,Desiganation,sal");
            String e_name = Console.ReadLine();
            String e_desi = Console.ReadLine();
            int e_sal = int.Parse(Console.ReadLine());
            Console.WriteLine("\tName  \tDesi  \tsalary");
            Console.WriteLine("\tName: "+e_name+"\tDesignation: "+e_desi+"\tsalary: "+e_sal);
        }

        public override bool Equals(object obj)
        {
            return obj is Emp emp &&
                   e_name == emp.e_name &&
                   e_desi == emp.e_desi &&
                   e_sal == emp.e_sal;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(e_name, e_desi, e_sal);
        }
    }
}
