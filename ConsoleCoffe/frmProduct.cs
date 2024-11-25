using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleCoffe
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
            InitializeDataGridView(); // Set up DataGridView columns
        }

        // Event handler for Add button click
        private void Add_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails();
            pd.ShowDialog(); // Show the product details form
            getData(); // Refresh data after adding a product
        }

        // Method to load product data into the DataGridView
        public void getData(string search = "")
        {
            // Update the query to properly fetch product data
            string qry = "SELECT pID, pName, pPrice, CategoryID FROM Product WHERE pName LIKE @search";
            Hashtable ht = new Hashtable();
            ht.Add("@search", "%" + search + "%");

            mainclass.LoadData(qry, Viewproduct, ht); // Load data into the DataGridView
        }

        // Method to initialize the DataGridView
        private void InitializeDataGridView()
        {
            Viewproduct.AutoGenerateColumns = false; // Disable auto generation of columns

            // Define columns explicitly
            Viewproduct.Columns.Clear(); // Clear any existing columns

            // Define Product ID Column
            Viewproduct.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "pID",
                HeaderText = "Product ID",
                DataPropertyName = "pID"
            });

            // Define Product Name Column
            Viewproduct.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "pName",
                HeaderText = "Product Name",
                DataPropertyName = "pName"
            });

            // Define Product Price Column
            Viewproduct.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "pPrice",
                HeaderText = "Price",
                DataPropertyName = "pPrice"
            });

            // Define Category ID Column
            Viewproduct.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CategoryID",
                HeaderText = "Category ID",
                DataPropertyName = "CategoryID"
            });

            // Add Edit button column
            Viewproduct.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Edit",
                HeaderText = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true // Use the same button text for all rows
            });

            // Add Delete button column
            Viewproduct.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true // Use the same button text for all rows
            });
        }

        // Event handler for DataGridView cell clicks
        private void Viewproduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the clicked row is valid
            {
                if (Viewproduct.Columns[e.ColumnIndex].Name == "Edit") // Check for Edit button click
                {
                    int productId = Convert.ToInt32(Viewproduct.Rows[e.RowIndex].Cells["pID"].Value);
                    ProductDetails pd = new ProductDetails();
                    pd.id = productId; // Set the ID for the product to edit
                    pd.ShowDialog(); // Show the edit form

                    getData(); // Refresh the DataGridView after editing
                }
                else if (Viewproduct.Columns[e.ColumnIndex].Name == "Delete") // Check for Delete button click
                {
                    int productId = Convert.ToInt32(Viewproduct.Rows[e.RowIndex].Cells["pID"].Value);
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string qry = "DELETE FROM Product WHERE pID = @id"; // Parameterized query for deletion
                        Hashtable ht = new Hashtable();
                        ht.Add("@id", productId);

                        // Execute the delete operation
                        if (mainclass.SQL(qry, ht) > 0)
                        {
                            MessageBox.Show("Delete Successful");
                        }
                        else
                        {
                            MessageBox.Show("Delete Failed");
                        }
                        getData(); // Refresh the DataGridView after deletion
                    }
                }
            }
        }

        // Event handler for form load
        private void frmProduct_Load(object sender, EventArgs e)
        {
            getData(); // Load data when the form loads
        }

        private void Viewproduct_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}




