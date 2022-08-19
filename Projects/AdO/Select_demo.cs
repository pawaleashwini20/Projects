using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
namespace Projects.AdO
{
    class Select_demo
    {
        static public void Main(string[] args)
        {
            String str = "server=LAPTOP-BEPSO077\\SQLEXPRESS;Database=HR;Integrated Security=True";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(str);
                con.Open();

                Console.WriteLine("Connection Establish....");
                SqlCommand sqlcommand = new SqlCommand("select id,name,marks from stud", con);
              //  SqlCommand sqlcommand = new SqlCommand("select * from employees", con);
                SqlDataReader dr = sqlcommand.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("id=" +dr["id"]+"name=" + dr["name"] + "marks=" + dr["marks"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (con != null)
                    con.Close();

            }
        }

    }
}
