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
            Seachbar.KeyUp += new KeyEventHandler(searchbar_KeyUp);
            getData(); // Load data when the form loads
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
            // Update the query to fetch product data with a search filter
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
                int productId = Convert.ToInt32(Viewproduct.Rows[e.RowIndex].Cells["pID"].Value); // Get the ProductID from the clicked row

                if (Viewproduct.Columns[e.ColumnIndex].Name == "Edit") // Check if the Edit button was clicked
                {
                    ProductDetails pd = new ProductDetails();
                    pd.id = productId; // Pass the ProductID to the ProductDetails form
                    pd.ShowDialog(); // Show the ProductDetails form
                    getData(); // Refresh the DataGridView after editing
                }
                else if (Viewproduct.Columns[e.ColumnIndex].Name == "Delete") // Check if the Delete button was clicked
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
                            // Handle any errors that occur during the delete operation
                            MessageBox.Show($"An error occurred: {ex.Message}");
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
    }
}
