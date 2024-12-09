using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleCoffe
{
    public partial class Kitchen : Form
    {
        public Kitchen()
        {
            InitializeComponent();
        }

        private void GetOrders()
        {
            flowLayoutPanel1.Controls.Clear();
            string qry = @"SELECT * FROM tblMain WHERE Stat = 'Pending'"; // Fixed query

            SqlCommand cmd1 = new SqlCommand(qry, mainclass.con);
            DataTable dt1 = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(cmd1);
            ad.Fill(dt1);

            FlowLayoutPanel p1;
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                p1 = new FlowLayoutPanel();
                p1.AutoSize = true;
                p1.Width = 350;  // Fixed the redundant line of code
                p1.Height = 350;
                p1.FlowDirection = FlowDirection.TopDown;
                p1.BorderStyle = BorderStyle.FixedSingle;
                p1.Margin = new Padding(10, 10, 10, 10);

                FlowLayoutPanel g1 = new FlowLayoutPanel();
                g1.AutoSize = true;
                g1.BackColor = Color.FromArgb(50, 55, 89);
                g1.Width = 125;
                g1.Height = 350;
                g1.FlowDirection = FlowDirection.TopDown;
                g1.Margin = new Padding(0, 0, 0, 0);

                Label lbl = new Label();
                lbl.ForeColor = Color.White;
                lbl.Margin = new Padding(10, 10, 3, 0);
                lbl.AutoSize = true;

                Label lbl2 = new Label();
                lbl2.ForeColor = Color.White;
                lbl2.Margin = new Padding(10, 5, 3, 0);
                lbl2.AutoSize = true;

                lbl.Text = "Order Time: " + dt1.Rows[i]["aTime"].ToString();
                lbl2.Text = "Order Type: " + dt1.Rows[i]["orderType"].ToString(); // Fixed this assignment

                g1.Controls.Add(lbl);
                g1.Controls.Add(lbl2);
                p1.Controls.Add(g1);

                int mid = Convert.ToInt32(dt1.Rows[i]["MainID"].ToString());

                string qr2 = @"SELECT * FROM tblMain m 
                               INNER JOIN tblDetails d ON m.MainID = d.MainID 
                               INNER JOIN Product p ON p.pID = d.proID 
                               WHERE m.MainID = @MainID";

                SqlCommand cmd2 = new SqlCommand(qr2, mainclass.con);
                cmd2.Parameters.AddWithValue("@MainID", mid);  // Use parameterized queries to prevent SQL injection
                DataTable dt2 = new DataTable();
                SqlDataAdapter ad2 = new SqlDataAdapter(cmd2);
                ad2.Fill(dt2);

                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    Label lbl5 = new Label();
                    lbl5.ForeColor = Color.White;
                    lbl5.Margin = new Padding(10, 5, 3, 0);
                    lbl5.AutoSize = true;
                    int no = j + 1;  // Corrected counter for item numbering

                    lbl5.Text = no + ". " + dt2.Rows[j]["pName"].ToString() + " " + dt2.Rows[j]["qty"].ToString() + " ";

                    p1.Controls.Add(lbl5);
                }

                Button btn2 = new Button();
                btn2.Size = new Size(100, 35);
                btn2.BackColor = Color.FromArgb(241, 85, 126);
                btn2.Margin = new Padding(60, 5, 3, 10);
                btn2.Text = "Complete";
                btn2.Tag = dt1.Rows[i]["MainID"].ToString();

                p1.Controls.Add(btn2);
                btn2.Click += new EventHandler(btn2_click);

                flowLayoutPanel1.Controls.Add(p1);
            }
        }

        private void btn2_click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Button).Tag.ToString());

            // Ask for confirmation before completing the order
            DialogResult Result = MessageBox.Show("Are you sure you want to complete this order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.Yes)
            {
                string Qry = @"UPDATE tblMain SET Stat = 'Complete' WHERE MainID = @ID";
                Hashtable ht = new Hashtable();
                ht.Add("@ID", id);

                if (mainclass.SQL(Qry, ht) > 0)
                {
                    MessageBox.Show("Order marked as complete.");
                    GetOrders(); // Refresh the orders after completion
                }
                else
                {
                    MessageBox.Show("Failed to mark order as complete.");
                }
            }
        }

        private void Kitchen_Load(object sender, EventArgs e)
        {
            GetOrders();
        }
    }
}
