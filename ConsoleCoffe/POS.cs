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
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
        }

        private void POS_Load(object sender, EventArgs e)
        {
            dataGridViewPOS.BorderStyle = BorderStyle.FixedSingle;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Console.WriteLine("helloWorld");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDashBoard frmM = new FrmDashBoard();
            frmM.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
