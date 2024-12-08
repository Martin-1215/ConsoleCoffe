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
    public partial class FrmDashBoard : Form
    {
        public FrmDashBoard()
        {
            InitializeComponent();
        }

        public void AddControls(Form f)

        {
            CenterPanel1.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            CenterPanel1.Controls.Add(f);
            f.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmDashBoard_Load(object sender, EventArgs e)
        {
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            AddControls(new Home());
        }

        private void POSBtn_Click(object sender, EventArgs e)
        {
           POS pos = new POS();
            pos.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Report_Click(object sender, EventArgs e)
        {
            AddControls(new frmReports());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddControls(new frmRegister());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddControls(new Categories());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddControls(new Kitchen());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddControls(new frmProduct());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
