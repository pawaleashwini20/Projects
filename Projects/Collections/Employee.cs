using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Collections
{
    class Employee : IComparable<Employee>
    {

        public String name;
        public String dept;
        public int eno;
        public Employee(int eno, string name, string dept)
        {
            this.eno = eno;
            this.name = name;
            this.dept = dept;
        }
        public int CompareTo(Employee other)
        {
            return this.name.CompareTo(other.name);
        }
        public override string ToString()
        {
            return ("\tEno:"+eno+"\tName:" + name + "\tDepartment:" +dept);
        }
    }
}

