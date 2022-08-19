using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
namespace Projects.AdO
{
    static class DBConnect
    { 
        public static SqlConnection getConnection()
        {
            string str="server=LAPTOP-BEPSO077\\SQLEXPRESS;Database=HR;Integrated Security=True";
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
    
    class DemoInsert
        {
        static void Main(string[] args)
        {
            SqlConnection con = DBConnect.getConnection();
            Console.WriteLine("Enter id,Name,marks");
            int id = int.Parse(Console.ReadLine());
            String name = Console.ReadLine();
            int marks = int.Parse(Console.ReadLine());
            SqlCommand cmd=new SqlCommand("insert into stud values(@id,@name,@marks)",con);
            cmd.Parameters.AddWithValue("@id",id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@marks", marks);
            int i=cmd.ExecuteNonQuery();
            
            if (i > 0)
            {
                Console.WriteLine("Record Inserted....");
            }
       }
        
      /*    static void Main(string[] args)
            {
                SqlConnection con = DBConnect.getConnection();
                SqlCommand cmd = new SqlCommand("insert into stud values(3,'Ashwini',98)",con);
                int i = cmd.ExecuteNonQuery();
                if (i>0)
                {
                    Console.WriteLine("Record Inserted....");
                }
            }*/

    }
}
 

