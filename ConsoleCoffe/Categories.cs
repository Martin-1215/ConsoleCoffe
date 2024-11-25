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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
            InitializeDataGridView();

        }

        private void InitializeDataGridView()
        {
            // Disable auto column generation
            Catego.AutoGenerateColumns = false;

            // Clear existing columns if necessary
            Catego.Columns.Clear();

            // Define the columns explicitly
            Catego.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "catID",
                HeaderText = "Category ID",
                DataPropertyName = "catID" // Bind to the catID field in the data source
            });

            Catego.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "catName",
                HeaderText = "Category Name",
                DataPropertyName = "catName" // Bind to the catName field in the data source
            });

            // Add Edit Button Column
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
            {
                Name = "dvg", // Change to a meaningful name
                HeaderText = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true // Display "Edit" text in all rows
            };
            Catego.Columns.Add(editButtonColumn);

            // Add Delete Button Column
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "dvgdel", // Change to a meaningful name
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true // Display "Delete" text in all rows
            };
            Catego.Columns.Add(deleteButtonColumn);
        }

        // Method to load data into the DataGridView based on the search text
        public void getData(string search = "")
        {
            string qry = "SELECT * FROM Category WHERE catName LIKE @search";
            Hashtable ht = new Hashtable();
            ht.Add("@search", "%" + search + "%");

            mainclass.LoadData(qry, Catego, ht); // Load data into the DataGridView
        }
        // Event handler for Add button click
        public virtual void Add_Click(object sender, EventArgs e)
        {
            AddCategory frm = new AddCategory();
            frm.ShowDialog(); // Show the AddCategory form as a dialog
            getData(); // Refresh the data grid view after adding
        }
        // Event handler for form load
        private void Categories_Load(object sender, EventArgs e)
        {
            getData(); // Load initial data on form load
        }

        // Event handler for search bar text changes
        private void Seachbar_TextChanged(object sender, EventArgs e)
        {
            // Update displayed data based on search input
            getData(Seachbar.Text);
        }

        // Event handler for DataGridView cell clicks
        private void Catego_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the cell clicked is for editing
            if (Catego.CurrentCell.OwningColumn.Name == "dvg") // Change to the actual name of your edit column
            {
                AddCategory frm = new AddCategory();
                frm.id = Convert.ToInt32(Catego.CurrentRow.Cells["catid"].Value); // Assuming catID is the ID
                frm.txtname.Text = Convert.ToString(Catego.CurrentRow.Cells["catName"].Value); // Assuming catName is the category name
                frm.ShowDialog(); // Show the edit form as a dialog

                // Refresh the data grid view after editing
                getData();
            }

            // Check if the cell clicked is for deletion
            if (Catego.CurrentCell.OwningColumn.Name == "dvgdel") // Change to the actual name of your delete column
            {
                int id = Convert.ToInt32(Catego.CurrentRow.Cells["catID"].Value); // Get the ID of the category to delete
                string qry = "DELETE FROM Category WHERE catID = @id"; // Parameterized query for deletion
                Hashtable ht = new Hashtable();
                ht.Add("@id", id);

                // Execute the delete operation
                if (mainclass.SQL(qry, ht) > 0)
                {
                    MessageBox.Show("Delete Successful");
                }
                else
                {
                    MessageBox.Show("Delete Failed");
                }
                getData(); // Refresh the data grid view after deletion
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}