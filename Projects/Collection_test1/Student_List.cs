using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Collection_test1
{
    class Student_List
    {

      public  int stu_id;
      public  string stu_dept;
       public string stu_name;
        //int stu_semester;
        public override string ToString()
        {
            return stu_id + " " + stu_name + " " +stu_dept ;
        }
        static void Main(string[] args)
        {
            List<Student> stu = new List<Student>()
            {
          
         //Create 3 Student details
            new Student{ stu_id = 101, stu_name = "Ashwini",
                     stu_dept = "CS" },
            new Student{ stu_id = 102, stu_name = "Reva",
                     stu_dept = "Engg" },
             new Student{ stu_id = 103, stu_name = "Shree",
                     stu_dept = "IT"},
            };
            foreach (Student e in stu)
            {

                // Call the to string method
                Console.WriteLine(e.ToString());
            }

        }
    }

 }
