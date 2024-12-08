using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;


namespace ConsoleCoffe
{
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
            

        }

        public int mainID = 0;
        public string OrderType = "";

        private void POS_Load(object sender, EventArgs e)
        {
            dataGridViewPOS.BorderStyle = BorderStyle.FixedSingle;
            addCathegory();

            ProductPanel.Controls.Clear();
            LoadProducts();

           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OrderType = "Dine In";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OrderType = "Take Out";
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addCathegory()
        {
            string qry = "Select * From Category";
            SqlCommand cmd = new SqlCommand(qry, mainclass.con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            CategoryPannel.Controls.Clear();


            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    // Create a new Button for each row
                    Button b = new Button();

                    // Set properties for the button
                    b.Text = row["catName"].ToString(); // Assuming "CatName" is the correct column name in your table
                    b.Size = new Size(200, 40); // Adjust button size (optional)
                    b.BackColor = Color.FromArgb(50, 55, 89); // Set background color (optional)
                    b.ForeColor = Color.White; // Set text color (optional)
                    b.Click += new EventHandler(_CLick);
                    // Add the button to the panel
                    CategoryPannel.Controls.Add(b);
                }



            }


        }

        private void _CLick(object sender, EventArgs e)
        {
            // Cast the sender to a Button to get the category name
            Button categoryButton = sender as Button;
            if (categoryButton == null) return;

            // Get the selected category name
            string selectedCategory = categoryButton.Text.ToLower();

            // Iterate over all products and filter by category and search text
            foreach (var item in ProductPanel.Controls)
            {
                // Cast the item as ucProduct
                var pro = item as ucProduct;
                if (pro == null) continue;

                // Filter visibility based on category and search bar text
                pro.Visible = pro.PCategory.ToLower().Contains(selectedCategory) &&
                              pro.PName.Text.ToLower().Contains(Seachbar.Text.Trim().ToLower());
            }
        }

        private void AddItems(int id, string name, string cat, string price, Image pimage,string ProdID)
        {
            var w = new ucProduct()
            {
                Pname = name,
                PPrice = price,
                PCategory = cat,
                PImage = pimage,
                id = Convert.ToInt32(id),
                pID = Convert.ToInt32(ProdID)
                




            };

            ProductPanel.Controls.Add(w);
            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;

                foreach (DataGridViewRow item in dataGridViewPOS.Rows)
                {
                    if (Convert.ToInt32(item.Cells["dgvid"].Value.ToString()) == wdg.id)
                    {
                        item.Cells["dgvQty"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) + 1;

                        item.Cells["dgvAmount"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) * double.Parse(item.Cells["dgvPrice"].Value.ToString());

                        return;
                    }

                };

                dataGridViewPOS.Rows.Add(new object[] { 0, wdg.Pname, 1, wdg.PPrice, wdg.PPrice , wdg.pID});
                GetTotal();

            };
        }

        private void LoadProducts()
        {
            string qry = "Select * From Product inner join Category  on  catID  = CategoryID";
            SqlCommand cmd = new SqlCommand(qry, mainclass.con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {


                Byte[] imagearray = (byte[])item["pImage"];
                byte[] imagebytearray = imagearray;

                AddItems((int)item["pID"], item["pName"].ToString(), item["catName"].ToString(), item["pPrice"].ToString(), Image.FromStream(new MemoryStream(imagearray)), item["pID"].ToString());




            }
        }

       

        private void NewPosBtn_Click(object sender, EventArgs e)
            {
                dataGridViewPOS.Rows.Clear();
                mainID = 0;
            lblTotal.Text = "00:00";

            }

        private void Seachbar_TextChanged(object sender, EventArgs e)
        {

            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PName.Text.ToLower().Contains(Seachbar.Text.Trim().ToLower());
            }
        }

        private void dataGridViewPOS_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in dataGridViewPOS.Rows)
            {
                count ++;
                row.Cells[0].Value = count;

            }

        }

        private void GetTotal()
        {
            double total = 0;
            lblTotal.Text = "PHP 00.00";  // Default text for clarity if there are no items

            // Loop through each row in the DataGridView
            foreach (DataGridViewRow row in dataGridViewPOS.Rows)
            {
                // Check if the "dgvAmount" cell is not null or empty and contains a valid value
                if (row.Cells["dgvAmount"].Value != null &&
                    double.TryParse(row.Cells["dgvAmount"].Value.ToString(), out double amount))
                {
                    total += amount; // Accumulate the valid amount
                }
            }

            // Display the total in the lblTotal control, formatted with two decimal places
            lblTotal.Text = "PHP " + total.ToString("N2");
        }

        private void Pay_Click(object sender, EventArgs e)
        {
            string qry = "";
            string qryy = "";
            int DetailsID = 0;

            // Insert or update main record in tblMain
            if (mainID == 0)
            {
                // Insert new record into tblMain and get the generated MainID
                qry = @"INSERT INTO tblMain (aDate, aTime, orderType, total, received, cChange ,Stat) 
                VALUES (@aDate, @aTime, @orderType, @total, @received, @cChange, @Stat); 
                SELECT SCOPE_IDENTITY();";
            }
            else
            {
                // Update existing record in tblMain
                qry = @"UPDATE tblMain 
                SET total = @total, received = @received, [Change] = @cChange 
                WHERE MainID = @ID, Stat = @Stat";
            }

            SqlCommand cmd = new SqlCommand(qry, mainclass.con);
            cmd.Parameters.AddWithValue("@ID", mainID);
            cmd.Parameters.AddWithValue("@aDate", Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@aTime", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@orderType", OrderType);
            cmd.Parameters.AddWithValue("@Stat", "Pending".ToString());
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(lblTotal.Text.Replace("PHP", "").Trim()));
            cmd.Parameters.AddWithValue("@received", Convert.ToDouble(0));  // Modify as needed
            cmd.Parameters.AddWithValue("@cChange", Convert.ToDouble(0));  // Modify as needed

            try
            {
                if (mainclass.con.State == ConnectionState.Closed) { mainclass.con.Open(); }
                if (mainID == 0)
                {
                    mainID = Convert.ToInt32(cmd.ExecuteScalar()); // Get the newly generated MainID
                }
                else
                {
                    cmd.ExecuteNonQuery(); // Update the record
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error with SQL command for tblMain: " + ex.Message);
            }
            finally
            {
                if (mainclass.con.State == ConnectionState.Open) { mainclass.con.Close(); }
            }

            // Now handle the tblDetails insertion/updating
            foreach (DataGridViewRow row in dataGridViewPOS.Rows)
            {
                DetailsID = Convert.ToInt32(row.Cells["dgvid"].Value);

                SqlCommand cmd2;

                // If DetailsID is greater than 0, update existing record, else insert new record
                if (DetailsID > 0)
                {
                     qryy = @"INSERT INTO tblDetails (MainID, proID, qty, Price, amount) 
                     VALUES (@MainID, @proID, @qty, @Price, @amount)";
                    cmd2 = new SqlCommand(qryy, mainclass.con);
                }
                else
                {qryy = @"UPDATE tblDetails 
                     SET proID = @proID, qty = @qty, Price = @Price, amount = @amount 
                     WHERE DetailsID = @ID";
                    cmd2 = new SqlCommand(qryy, mainclass.con);
                    cmd2.Parameters.AddWithValue("@ID", DetailsID);
                   
                }

                cmd2.Parameters.AddWithValue("@MainID", mainID); // Correct MainID
                cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["prodID"].Value));
                cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvQty"].Value));
                cmd2.Parameters.AddWithValue("@Price", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value));

                try
                {
                    if (mainclass.con.State == ConnectionState.Closed) { mainclass.con.Open(); }
                    cmd2.ExecuteNonQuery();  // Execute the insert or update query
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error with SQL command for tblDetails: " + ex.Message);
                }
                finally
                {
                    if (mainclass.con.State == ConnectionState.Open) { mainclass.con.Close(); }
                }
            }

            MessageBox.Show("Paid!");
            mainID = 0;  // Reset
            dataGridViewPOS.Rows.Clear(); // Clear the DataGridView
        }
    }
}



