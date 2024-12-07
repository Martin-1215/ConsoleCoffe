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
    public partial class ucProduct : UserControl
    {
        public ucProduct()
        {
            InitializeComponent();
        }

        public event EventHandler onSelect = null;

        public int id { get; set; }

        public string PPrice { get; set; }

        public string PCategory { get; set; }

        public string Pname
        {
            get { return PName.Text; }
            set { PName.Text = value; }
        }

        public Image PImage
        {
            get { return txtImage.Image; }
            set { txtImage.Image = value; }
        }



        private void ucProduct_Load(object sender, EventArgs e)
        {

        }

        private void txtImage_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
    }
}
