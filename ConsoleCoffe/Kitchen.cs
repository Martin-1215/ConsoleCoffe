using System;
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
            string qry = @"Select * From tblMain Where Stat = 'Pending'"; // Fixed query

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
                p1.FlowDirection = FlowDirection.TopDown;
                p1.BorderStyle = BorderStyle.FixedSingle;
                p1.Margin = new Padding(10, 10, 10, 10);

                FlowLayoutPanel g1 = new FlowLayoutPanel();
                g1.AutoSize = true;
                g1.BackColor = Color.FromArgb(50, 55, 89);
                g1.Width = 125;
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

                Label lbl3 = new Label();
                lbl3.ForeColor = Color.White;
                lbl3.Margin = new Padding(10, 5, 3, 0);
                lbl3.AutoSize = true;

                Label lbl4 = new Label();
                lbl4.ForeColor = Color.White;
                lbl4.Margin = new Padding(10, 5, 3, 0);
                lbl4.AutoSize = true;

                lbl.Text = "Order Time: " + dt1.Rows[i]["aTime"].ToString();
                lbl2.Text = "Order Type: " + dt1.Rows[i]["orderType"].ToString(); // Fixed this assignment

                g1.Controls.Add(lbl);
                g1.Controls.Add(lbl2);
                p1.Controls.Add(g1);

                int mid = 0;
                mid = Convert.ToInt32(dt1.Rows[i]["MainID"].ToString());

                string qr2 = @"Select * From tblMain m inner join tblDetails d on m.MainID = d.MainID inner join Product p on p.pID = d.pID Where m.MainID = "+mid+"";

                SqlCommand cmd2 = new SqlCommand(qr2, mainclass.con);
                DataTable dt2 = new DataTable();
                SqlDataAdapter ad2 = new SqlDataAdapter(cmd2);
                ad2.Fill(dt2);


                for(int j = 0;j< dt2.Rows.Count;j++)
                {
                    Label lbl5 = new Label();
                    lbl5.ForeColor = Color.White;
                    lbl5.Margin = new Padding(10, 5, 3, 0);
                    lbl5.AutoSize = true;
                    int no = j = 1;

                    lbl5.Text = "" + no + "" + dt2.Rows[j]["pName"].ToString() + "" + dt2.Rows[j]["qty"].ToString();

                    p1.Controls.Add(lbl5);  



                }


                Button btn2 = new Button();
                btn2.Size = new Size(100, 35);
                btn2.BackColor = Color.FromArgb(241, 85, 126);
                btn2.Margin = new Padding(60,5,3,10);
                btn2.Text = "Complete";
                btn2.Tag = dt1.Rows[i]["MainID"].ToString();


                p1.Controls.Add(btn2 );
                btn2.Click += new EventHandler(btn2_click);









                flowLayoutPanel1.Controls.Add(p1);
            }
        }

        private void btn2_click(object sender, EventArgs e)
        {
          int id = Convert.ToInt32((sender as Button).Tag.ToString());
        }

        private void Kitchen_Load(object sender, EventArgs e)
        {
            GetOrders();
        }
    }


    }
