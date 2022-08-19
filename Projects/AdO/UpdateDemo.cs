using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Projects.AdO
{
    
    class UpdateDemo
    {
        static void Main(string[] args)
        {
            SqlConnection con = DBConnect.getConnection();
            Console.WriteLine("Enter id ,marks");
            int id = int.Parse(Console.ReadLine());
            String name = Console.ReadLine();
            int marks = int.Parse(Console.ReadLine());
            SqlCommand cmd = new SqlCommand("update stud  set name=@name where id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
           cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@marks", marks);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Console.WriteLine("Record updated.....");
            }
        }
    }
}
