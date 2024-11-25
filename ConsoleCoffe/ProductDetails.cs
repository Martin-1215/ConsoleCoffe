using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleCoffe
{
    public partial class ProductDetails : Form
    {
        public ProductDetails()
        {
            InitializeComponent();
        }

        private string filepath;
        public int id = 0; // Product ID
        public int cID = 0; // Category ID

        // Expose product name and image as public properties
        public string ProductName
        {
            get { return productname.Text; } // Access the text of the product name control
            set { productname.Text = value; }
        }

        public decimal ProductPrice // Assuming price is a decimal
        {
            get
            {
                decimal.TryParse(Price.Text, out decimal price);
                return price;
            }
            set { Price.Text = value.ToString(); }
        }

        public Image ProductImage
        {
            get { return Producimage.Image; }
            set { Producimage.Image = value; }
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    filepath = ofd.FileName;
                    Producimage.Image = new Bitmap(filepath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {
            string qry = "SELECT catID AS id, catName AS name FROM Category";
            mainclass.CVFill(qry, catcombo);

            if (cID > 0)
            {
                catcombo.SelectedValue = cID;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(ProductName) || string.IsNullOrWhiteSpace(Price.Text) || catcombo.SelectedValue == null)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            string qry = id == 0
                ? "INSERT INTO Product (pName, pPrice, CategoryID, pImage) VALUES (@Name, @Price, @cat, @img)"
                : "UPDATE Product SET pName = @Name, pPrice = @Price, CategoryID = @cat, pImage = @img WHERE pID = @id";

            byte[] imageByteArray;

            // Convert image to byte array
            using (MemoryStream ms = new MemoryStream())
            {
                if (Producimage.Image != null)
                {
                    Producimage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imageByteArray = ms.ToArray();
                }
                else
                {
                    MessageBox.Show("Please select an image.");
                    return;
                }
            }

            Hashtable ht = new Hashtable
            {
                { "@id", id },
                { "@Name", ProductName.Trim() }, // Use the public property
                { "@Price", ProductPrice }, // Use the property for price
                { "@cat", Convert.ToInt32(catcombo.SelectedValue) },
                { "@img", imageByteArray }
            };

            try
            {
                if (mainclass.SQL(qry, ht) > 0)
                {
                    MessageBox.Show("Saved Successfully!");
                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving: " + ex.Message);
            }
        }

        private void ResetForm()
        {
            id = 0;
            ProductName = ""; // Reset product name using property
            Price.Text = ""; // Reset price
            catcombo.SelectedIndex = -1; // Reset category selection
            Producimage.Image = null; // Clear the image
            productname.Focus();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}