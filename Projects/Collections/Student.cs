using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Projects.Collections
{
    class Student:IComparer<Student>
    {
        public Student(int stu_id,String stu_name,string stu_dept)
        {
            this.stu_id = stu_id;
            this.stu_name = stu_name;
            this.stu_dept = stu_dept;

         }
           public  int stu_id;
          public   string stu_dept;
            public string stu_name;
        

        public int Id
            {
                set { this.stu_id = value; }
                get { return stu_id; }
            }
            public String Dept
            {
                set { this.stu_dept = value; }
                get { return stu_dept; }
            }
            public String Name
            {
                set { this.stu_name = value; }
                get { return stu_name; }
            }
            public override string ToString()
            {
                return stu_id + " " + stu_name + " " + stu_dept;
            }
           /* static void Main(string[] args)
            {
               Student ss = new Student(111,"AAA", "CSC");
           // Student ss = new Student();
            Console.WriteLine("Id:" + ss.Id + "Name:" + ss.Name + "Department:" + ss.Dept);
            }*/

        public int Compare(Student x,Student y)
        {
            throw new NotImplementedException();
        }
    }
    }


