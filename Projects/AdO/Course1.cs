using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Projects.AdO
{
   static class Course11
    {
        public static SqlConnection getConnection()
        {
            string str = "server=LAPTOP-BEPSO077\\SQLEXPRESS;Database=Thinkq;Integrated Security=True";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(str);
                con.Open();
                Console.WriteLine("Connection Establish....");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return con;
        }
    }

    class Course1
    {
        static void Main(string[] args)
        {
            SqlConnection con = Course11.getConnection();
            Console.WriteLine("Enter id,Name,fee,Duration");
            int id = int.Parse(Console.ReadLine());
            String name = Console.ReadLine();
            int fee = int.Parse(Console.ReadLine());
            String Duration = Console.ReadLine();
            SqlCommand cmd = new SqlCommand("insert into Course values(@id,@name,@fee,@Duration)", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@fee", fee);
            cmd.Parameters.AddWithValue("@Duration", Duration);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Console.WriteLine("Record Inserted....");
            }
        }

    }
}
