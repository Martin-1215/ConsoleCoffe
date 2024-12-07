using System;
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
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace ConsoleCoffe
{
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
            

        }

        public int mainID = 0;

        private void POS_Load(object sender, EventArgs e)
        {
            dataGridViewPOS.BorderStyle = BorderStyle.FixedSingle;
            addCathegory();

            ProductPanel.Controls.Clear();
            LoadProducts();

           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Console.WriteLine("helloWorld");
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

        private void AddItems(int id, string name, string cat, string price, Image pimage)
        {
            var w = new ucProduct()
            {
                Pname = name,
                PPrice = price,
                PCategory = cat,
                PImage = pimage,
                id = Convert.ToInt32(id)




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

                dataGridViewPOS.Rows.Add(new object[] { 0, wdg.Pname, 1, wdg.PPrice, wdg.PPrice });
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

                AddItems((int)item["pID"], item["pName"].ToString(), item["catName"].ToString(), item["pPrice"].ToString(), Image.FromStream(new MemoryStream(imagearray)));




            }
        }

       

        private void NewPosBtn_Click(object sender, EventArgs e)
            {
                dataGridViewPOS.Rows.Clear();
                mainID = 0;

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
            lblTotal.Text = "";

            foreach (DataGridViewRow item in dataGridViewPOS.Rows)
            {
                // Check if the "dgvAmount" cell contains a valid value
                total += double.Parse(item.Cells["dgvAmount"].Value.ToString());
            }

            lblTotal.Text = "PHP " + total.ToString("N2"); // Optional: Format the total to show two decimal places
        }

    }
}



