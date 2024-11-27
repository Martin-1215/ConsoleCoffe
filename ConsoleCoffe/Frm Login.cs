using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleCoffe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            string username = txtUser.Text;
            string password = txtPass.Text;

            if (mainclass.IsValidUser(username, password))
            {
                MessageBox.Show("Log-in Successful! ");
               this.Hide();
            FrmDashBoard frmM = new FrmDashBoard();
            frmM.Show(); // Proceed to the next step, e.g., open a new form or navigate to the main application.
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }


            // Check if fields are empty
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Please enter both username and password.");
                txtUser.Focus(); // Set focus to the username field
                return;
            }

            // Validate user credentials
            if (mainclass.IsValidUser(txtUser.Text, txtPass.Text))
            {
                
                txtUser.Clear(); // Clear the username field
                txtPass.Clear(); // Clear the password field
                txtUser.Focus(); // Set focus back to the username field
                return;
            }

            // Hide the current form and show the dashboard
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Showpass_Click(object sender, EventArgs e)
        {
            // Toggle the UseSystemPasswordChar property
            txtPass.UseSystemPasswordChar = !txtPass.UseSystemPasswordChar;

            // Change the button text based on the visibility of the password
            Showpass.Text = txtPass.UseSystemPasswordChar ? "Show" : "Hide";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            


        }

       private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Trigger login when Enter is pressed in the password field
                LoginBtn.PerformClick();
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Move focus to the password field when Enter is pressed in the username field
                txtPass.Focus();
            }
        }
        private bool ValidateCredentials(string username, string password)
        {
            // Dummy validation, replace with actual logic
            return username == "user" && password == "password";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}