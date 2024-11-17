using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConsoleCoffe
{
    internal class mainclass
    {
        private static readonly string conString = "Data Source=DESKTOP-73UJIM6\\MSSQLSERVER01; Initial Catalog=ConsoleCoffeDB;Integrated Security=True";

        public static bool IsValidUser(string username, string password)
        {
            bool isValid = false;

            // Correct SQL syntax
            string query = "SELECT * FROM users WHERE username = @username AND upass = @password";

            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            isValid = reader.HasRows; // Check if the query returned any rows
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return isValid;
        }
       
        

    }
}
