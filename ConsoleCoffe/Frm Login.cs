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
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (mainclass.IsValidUser(txtUser.Text,txtPass.Text) == false)
            {
                MessageBox.Show("Invalid User Or Password !! Please Try Again");

                return;

            }
            else
            {
                this.Hide();

                FrmDashBoard frmM = new FrmDashBoard();
                frmM.Show();



            }



        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
