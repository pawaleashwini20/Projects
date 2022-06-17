using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Methods
{
    class Student
    {
        int id;
        String name;
        float per;
        Student()
            {
                this.id=id;
            this.name = name;
            this.per = per;
            }
        public void Details(int id, String name, int m1, int m2, int m3)
        {
            Console.WriteLine("Student id:"+id);
            Console.WriteLine("Student Name:" + name);
            Console.WriteLine("Student Marks sub1:" + m1);
            Console.WriteLine("Student Marks sub2:" + m2);
            Console.WriteLine("Student Marks sub3:" + m3);
        }
        public void Percentage(int m1, int m2, int m3)
        {
            Console.WriteLine("Student Marks sub1:" + m1);
            Console.WriteLine("Student Marks sub2:" + m2);
            Console.WriteLine("Student Marks sub3:" + m3);
            int total = m1 + m2 + m3;
            Console.WriteLine("Total:"+total);
            float tot = (float)300;
            float per =((total /tot)*100);
            Console.WriteLine("percentage:"+per);
        }
        public void display(int id,String name)
        {
            Console.WriteLine("------Student Information----------");
            Console.WriteLine("Id:"+id);
            Console.WriteLine("Name:"+name);
            Console.WriteLine("percentage:"+this.per);
        }
        static void Main(string[] args)
        {
            int i, s1, s2, s3;
            String n;
            Console.WriteLine("Enter Id,Name,3 sub Marks:");
            i = int.Parse(Console.ReadLine());
            n = Console.ReadLine();
            s1 = int.Parse(Console.ReadLine());
            s2 = int.Parse(Console.ReadLine());
            s3= int.Parse(Console.ReadLine());
            Student s = new Student();
            s.Details(i, n, s1, s2, s3);
            s.Percentage(s1, s2, s3);
            s.display(i,n);
        }
    }
}
