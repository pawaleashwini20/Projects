using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Projects.AdO
{
    static class Course12
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

    class SelectCourse
    {
        static void Main(string[] args)
        {


            SqlConnection con = Course12.getConnection();
            SqlCommand sqlcommand = new SqlCommand("select id,name,Fee,Duration from Course", con);
            //  SqlCommand sqlcommand = new SqlCommand("select * from employees", con);
            SqlDataReader dr = sqlcommand.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("Id=" + dr["id"] + " Name=" + dr["name"] + " Fee=" + dr["fee"]+" Duration="+dr["Duration"]);
            }
        }
    }
}
 
