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
    public partial class AddCategory : Form
    {
        public int id = 0; // Identifier for update or insert

        public AddCategory()
        {
            InitializeComponent();
        }

        public virtual void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void Save_Click(object sender, EventArgs e)
        {
            string qry = "";
            Hashtable ht = new Hashtable();

            if (id == 0) // Insert
            {
                qry = "INSERT INTO Category (catName) VALUES (@Name)"; // Ensure proper column names
                ht.Add("@Name", txtname.Text);
            }
            else // Update
            {
                qry = "UPDATE Category SET catName = @Name WHERE catID = @id"; // Ensure proper column names
                ht.Add("@id", id);
                ht.Add("@Name", txtname.Text);
            }

            try
            {
                if (mainclass.SQL(qry, ht) > 0)
                {
                    MessageBox.Show("Saved Successfully");
                    id = 0;
                    txtname.Clear(); // Clear the text box after saving
                    txtname.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving category: {ex.Message}");
            }
            finally
            {
                this.Hide();
            }
        }
        private void AddCategory_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
