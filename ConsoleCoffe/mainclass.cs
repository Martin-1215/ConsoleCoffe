using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;

namespace ConsoleCoffe
{
    internal class mainclass
    {
        private static readonly string conString = "Data Source=LAPTOP-U6OEJ7C1\\SQLEXPRESS; Initial Catalog=ConsoleCoffee;Integrated Security=True";

        public static bool IsValidUser(string username, string password)
        {
            bool isValid = false;
            string qry = "SELECT * FROM users WHERE username = @username AND upass = @password";

            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(qry, con))
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

        public static int SQL(string qry, Hashtable ht)
        {
            int res = 0; // Result counter
            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.CommandType = CommandType.Text;
                    foreach (DictionaryEntry item in ht)
                    {
                        cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value); // Simplified parameter addition
                    }
                    try
                    {
                        con.Open();
                        res = cmd.ExecuteNonQuery(); // Use ExecuteNonQuery for insert/update/delete
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error executing query: {ex.Message}");
                    }
                }
            }
            return res; // Return number of affected rows
        }

        public static bool TestConnection()
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    con.Open();
                    return true; // Connection successful
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"SQL Connection Error: {ex.Message}");
                    return false; // Connection failed
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return false; // Connection failed
                }
            }
        }

        public static void LoadData(string qry, DataGridView gv, Hashtable ht)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(qry, con))
                    {
                        cmd.CommandType = CommandType.Text;

                        // Adding parameters from Hashtable
                        foreach (DictionaryEntry entry in ht)
                        {
                            cmd.Parameters.AddWithValue(entry.Key.ToString(), entry.Value);
                        }

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt); // Fill the DataTable

                        gv.DataSource = dt; // Bind DataTable to DataGridView

                        // Optionally, clear the DataGridView if no data is found
                        if (dt.Rows.Count == 0)
                        {
                            gv.DataSource = null; // Clear the DataGridView
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading data: {ex.Message}");
                }
            }
        }

        public static void CVFill(string qry, ComboBox cb)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    con.Open(); // Ensure the connection is open

                    using (SqlCommand cmd = new SqlCommand(qry, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            // Ensure the DataTable has the expected columns
                            if (dt.Columns.Contains("name") && dt.Columns.Contains("id"))
                            {
                                cb.DisplayMember = "name"; // Ensure this column exists in dt
                                cb.ValueMember = "id"; // Ensure this column exists in dt
                                cb.DataSource = dt;
                                cb.SelectedIndex = -1; // Clear any selected item
                            }
                            else
                            {
                                MessageBox.Show("The expected columns 'name' or 'id' do not exist in the result set.");
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while filling the ComboBox: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message);
                }
                // No need for finally block to close the connection, as 'using' takes care of that
            }
        }
    }
}