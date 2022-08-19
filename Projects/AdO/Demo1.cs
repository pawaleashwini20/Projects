using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Projects.AdO
{
   static class Demo1
   {
        static public void Main(string[] args)
        {
            String str = "server=LAPTOP-BEPSO077\\SQLEXPRESS;Database=HR;Integrated Security=True";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(str);
                //con.Open();

                Console.WriteLine("Connection Establish....");

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
