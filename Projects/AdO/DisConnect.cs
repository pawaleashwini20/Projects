using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Projects.AdO
{
    static class DBConnect1
    {
        static public SqlConnection Connect()
        {
            SqlConnection con = null;
            String cstr ="server=LAPTOP-BEPSO077\\SQLEXPRESS;Database=HR;Integrated Security=True";
            try
            {
                con = new SqlConnection(cstr);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return con;
            return con;
            return con;
        }
    }
    class MyAdo
    {
        static void Main(string[] args)
        {
            SqlConnection con = DBConnect1.Connect();
            SqlCommand cmd = new SqlCommand("select last_name,hire_date from employees",con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["last_name"]+" "+reader[1]);
            }
        }
        public static void AddEmp()
        {
            string str = "insert into student values(@id,@name,@marks)";
            SqlConnection con = DBConnect1.Connect();
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", 1);
            cmd.Parameters.AddWithValue("@name", "Ashu");
            cmd.Parameters.AddWithValue("@marks", 99);  
            int c = cmd.ExecuteNonQuery();
            Console.WriteLine(c);
        }
        public static void ShowAll()
        {
            SqlConnection con = DBConnect.getConnection();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Empoyees", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);

        
        }
    }
    class DisConnect
    {
        static void Main(string[] args)
        {
            SqlConnection con = DBConnect1.Connect();
            SqlDataAdapter sda = new SqlDataAdapter("select * from stud", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "stud");
            foreach (DataRow dr in ds.Tables["stud"].Rows)     
            {
                Console.WriteLine(dr[0]+" "+dr[1]+""+dr[2]);
            }
        }
    
    }
}
