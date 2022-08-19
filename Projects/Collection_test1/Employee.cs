using System;
using System.Collections.Generic;
using System.Text;
//9.	WAP to create a class Employee with (name, designation and age).
//Now create and add Employee objects elements to list.
//Sort the List by age in descending order and print List.
namespace Projects.Collection_test1
{
    class Emplo
    {
        public String name;
       public String desig;
     public   int age;
        public String Name
        {
            set { this.name = value; }
            get { return name; }
        }
        public String Desig
        {
            set { this.desig = value; }
            get { return desig; }
        }
        public int Age
        {
            set { this.age = value; }
            get { return age; }
        }
        public override string ToString()
        {
            return ("Name:" + Name + "Disignation:" + Desig + "Age:" + Age);
        }
    }
    class Employee
    {
        public String name;
        public String desig;
        public int age;
        public override string ToString()
        {
            return ("Name:" + name + "\tDisignation:" + desig + "\tAge:" + age);
        }
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>()
            {
          
                //Create 3 Student details
                new Employee{ name = "Ashwini", desig = "CEO  ",age = 50 },
                new Employee{ name="Gauri",desig="Employee",age=29},
                new Employee{name="Sara",desig="Teacher",age=25},
                new Employee{name="Sayali",desig="Teacher",age=26},

            };
        
            foreach (Employee e in emp)
            {

                // Call the to string method
                Console.WriteLine(e.ToString());
            }
        }
    }
}
