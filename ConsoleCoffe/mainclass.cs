using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleCoffe
{
    internal class mainclass
    {
        public static readonly string con_string = "Data Source=DESKTOP-73UJIM6\\MSSQLSERVER01; Initial Catalog=ConsoleCoffe;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(con_string);
        

        public static bool IsValidUser(string user, string pass)
        {
           
            bool IsValid = false;

            string qry = @"Select * users where username = '"+user+"'and upass = '"+pass+"' ";

            SqlCommand cmd = new SqlCommand(qry,con);
          
            DataTable dt = new DataTable();

          SqlDataAdapter da = new SqlDataAdapter(cmd);
          da.Fill(dt);


            if (dt.Rows.Count > 0 )
            {
                 IsValid = true;

            }



            return IsValid;
            
        }

    }
}
