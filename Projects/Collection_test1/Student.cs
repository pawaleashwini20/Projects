using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Collection_test1
{
    class Student
    {
      public  int stu_id;
      public  string stu_dept;
       public  string stu_name;
       
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
        static void Main(string[] args)
        {
            Student ss = new Student();
            Console.WriteLine("Id:"+ss.Id+"Name:"+ss.Name+"Department:"+ss.Dept);
        }
    }
}
