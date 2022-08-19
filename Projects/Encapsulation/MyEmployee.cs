using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Encapsulation
{
    class MyDate
    {
        private int dd;
        private int mm;
        private int yy;
        public int Dd
        {
            get { return dd; }
            set { dd = value; }
        }
        public int Mm
        {
            get { return mm; }
            set { mm = value; }
        }
        public int Yy
        {
            get;
            set;
        }
    }
    class MyDepartment
    {
        private int did;
        private String dname;
        public int Did
        {
            get { return did; }
            set { did = value; }
        }
        public String Dname
        {
            get;
            set;
        }
    }
    class MyEmployee
    {
        private int id;
        private String name;
        MyDepartment dept;
        MyDate dt;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Name
        {
            get;
            set;
        }
        public MyDepartment Dept
        {
            get { return dept; }
            set { dept = value; }
        }
        public MyDate Dt
            {
            get { return dt; }
            set { dt = value; }
            }
        static void Main(string[] args)
        {
            MyEmployee e = new MyEmployee();
            e.Id = 200;
            e.Name = "Ashwini";
            e.Dept = new MyDepartment();
            e.Dept.Did = 1;
            e.Dept.Dname = "Sales";

            e.Dt = new MyDate();
            e.Dt.Dd = 2;
            e.Dt.Mm = 6;
            e.Dt.Yy = 2022;
            Console.WriteLine(e);
            Console.WriteLine(e.Id + " " + e.Name + " " + e.Dept.Did + " " + e.Dept.Dname + " " + e.Dt.Dd + "/" + e.Dt.Mm + "/" + e.dt.Yy);
        }
    }
}
