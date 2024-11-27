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
           getData(); // Load data when the form loads
            this.Viewproduct.CellClick += new DataGridViewCellEventHandler(this.Viewproduct_CellClick);
            Seachbar.KeyUp += new KeyEventHandler(searchbar_KeyUp); // Attach search event
           
        }

        // Search functionality
        private void searchbar_KeyUp(object sender, KeyEventArgs e)
        {
            string searchText = Seachbar.Text.Trim(); // Get the search text from the searchbar
            getData(searchText); // Call getData with the search term to filter the products
        }

        // Method to load product data into the DataGridView
        public void getData(string search = "")
        {
            string qry = "SELECT pID, pName, pPrice, CategoryID FROM Product WHERE pName LIKE @search";
            Hashtable ht = new Hashtable();
            ht.Add("@search", "%" + search + "%");

            try
            {
                mainclass.LoadData(qry, Viewproduct, ht); // Load data into the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to initialize the DataGridView
        private void InitializeDataGridView()
        {
            Viewproduct.AutoGenerateColumns = false; // Disable auto generation of columns
            Viewproduct.Columns.Clear(); // Clear existing columns

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
            // Ensure the clicked row is valid
            if (e.RowIndex >= 0)
            {
                // Get the ProductID from the clicked row
                int productId = Convert.ToInt32(Viewproduct.Rows[e.RowIndex].Cells["pID"].Value);


                if (Viewproduct.Columns[e.ColumnIndex].Name == "Delete") // Delete button clicked
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string qry = "DELETE FROM Product WHERE pID = @id";
                        Hashtable ht = new Hashtable();
                        ht.Add("@id", productId); // Pass product ID to the query

                        try
                        {
                            // Execute the delete operation
                            int rowsAffected = mainclass.SQL(qry, ht);
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Product deleted successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Delete failed. The product might not exist.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        // Refresh the DataGridView after deletion
                        getData();  // Ensure getData is called to reload the grid
                    }
                }
                else if (Viewproduct.Columns[e.ColumnIndex].Name == "Edit") // Edit button clicked
                {
                    // Retrieve data from the selected row
                    string productName = Viewproduct.Rows[e.RowIndex].Cells["pName"].Value.ToString();
                    decimal productPrice = Convert.ToDecimal(Viewproduct.Rows[e.RowIndex].Cells["pPrice"].Value);
                    int categoryId = Convert.ToInt32(Viewproduct.Rows[e.RowIndex].Cells["CategoryID"].Value);

                    // Create and show the ProductDetails form for editing
                    ProductDetails pd = new ProductDetails();
                    pd.id = productId; // Pass the ProductID to the ProductDetails form
                    pd.productname.Text = productName; // Pass Product Name
                    pd.Price.Text = productPrice.ToString(); // Pass Product Price
                    pd.catcombo.Text = categoryId.ToString(); // Pass Category ID
                    pd.ShowDialog(); // Show the ProductDetails form

                    // Refresh the data grid after editing (optional)
                    getData();  // Ensure getData is called to reload the grid after an edit
                }
            }
        }

        // Event handler for form load
        private void frmProduct_Load(object sender, EventArgs e)
        {
            getData(); // Load data when the form loads
        }

        // Add a new product
        private void Add_Click(object sender, EventArgs e)
        {
            ProductDetails f = new ProductDetails();
            f.ShowDialog(); // Show the ProductDetails form for adding a new product
            getData();
            
        }

        private void frmProduct_Load_1(object sender, EventArgs e)
        {

        }
    }
}