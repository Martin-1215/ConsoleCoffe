using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPass.UseSystemPasswordChar = true; // Mask password input
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // Check if fields are empty
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Please enter both username and password.");
                txtUser.Focus(); // Set focus to the username field
                return;
            }

            // Validate user credentials
            if (!mainclass.IsValidUser(txtUser.Text, txtPass.Text))
            {
                MessageBox.Show("Invalid User Or Password! Please Try Again.");
                txtUser.Clear(); // Clear the username field
                txtPass.Clear(); // Clear the password field
                txtUser.Focus(); // Set focus back to the username field
                return;
            }

            // Hide the current form and show the dashboard
            this.Hide();
            FrmDashBoard frmM = new FrmDashBoard();
            frmM.Show();
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
    }
}