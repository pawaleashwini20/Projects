using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Task_Que
{
    class Student
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 subject Marks:");
            float n1 =float.Parse(Console.ReadLine());
            float n2 = float.Parse(Console.ReadLine());
            float n3 = float.Parse(Console.ReadLine());
            float n4 = float.Parse(Console.ReadLine());
            float n5 = float.Parse(Console.ReadLine());
            int total = 500;
            char grade;
            float tot= n1 + n2 + n3 + n4 + n5;
            float per=((tot/total)*100);
            float avg = (float)(tot/ 5.0);
            // percentage = (float)((total / 500.0) * 100);
            if (avg >= 90)
            {
                grade = 'A';
            }
            else if (avg >= 80 && avg < 90)
            {
                grade = 'B';
            }
            else if (avg >= 70 && avg < 80)
            {
                grade = 'C';

            }
            else if (avg >= 60 && avg < 70)
            {
                grade = 'D';
            }
            else
            {
                grade = 'E';
            }

            Console.WriteLine("Percentage:" + per);
            Console.WriteLine("average:" + avg);
            Console.WriteLine("grade:" + grade);
        }
    }
}
