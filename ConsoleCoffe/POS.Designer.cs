namespace ConsoleCoffe
{
    partial class POS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NewPosBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CategoryPannel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewPOS = new System.Windows.Forms.DataGridView();
            this.Sr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPOS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(137)))), ((int)(((byte)(121)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 619);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1384, 78);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(137)))), ((int)(((byte)(121)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.NewPosBtn);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1384, 90);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 62);
            this.label1.TabIndex = 7;
            this.label1.Text = "POS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(725, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(65, 62);
            this.button6.TabIndex = 6;
            this.button6.Text = "Dine In";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(644, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 62);
            this.button5.TabIndex = 5;
            this.button5.Text = "Take Out";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(563, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 62);
            this.button4.TabIndex = 4;
            this.button4.Text = "Delivery";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(482, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 62);
            this.button3.TabIndex = 3;
            this.button3.Text = "KOT";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(401, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 62);
            this.button2.TabIndex = 2;
            this.button2.Text = "Bill List";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // NewPosBtn
            // 
            this.NewPosBtn.Location = new System.Drawing.Point(320, 12);
            this.NewPosBtn.Name = "NewPosBtn";
            this.NewPosBtn.Size = new System.Drawing.Size(65, 62);
            this.NewPosBtn.TabIndex = 1;
            this.NewPosBtn.Text = "New";
            this.NewPosBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ConsoleCoffe.Properties.Resources._462568849_941227144536412_2916676744882120622_n_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CategoryPannel
            // 
            this.CategoryPannel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CategoryPannel.Location = new System.Drawing.Point(0, 149);
            this.CategoryPannel.Name = "CategoryPannel";
            this.CategoryPannel.Size = new System.Drawing.Size(160, 453);
            this.CategoryPannel.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(175, 149);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(709, 453);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // dataGridViewPOS
            // 
            this.dataGridViewPOS.AllowUserToAddRows = false;
            this.dataGridViewPOS.AllowUserToDeleteRows = false;
            this.dataGridViewPOS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sr,
            this.ProductName,
            this.QtyProduct,
            this.PriceProduct,
            this.AmountProduct});
            this.dataGridViewPOS.Location = new System.Drawing.Point(890, 149);
            this.dataGridViewPOS.Name = "dataGridViewPOS";
            this.dataGridViewPOS.ReadOnly = true;
            this.dataGridViewPOS.RowHeadersWidth = 51;
            this.dataGridViewPOS.Size = new System.Drawing.Size(482, 453);
            this.dataGridViewPOS.TabIndex = 4;
            // 
            // Sr
            // 
            this.Sr.FillWeight = 50F;
            this.Sr.HeaderText = "Sr#";
            this.Sr.MinimumWidth = 50;
            this.Sr.Name = "Sr";
            this.Sr.ReadOnly = true;
            this.Sr.Width = 125;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.HeaderText = "Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // QtyProduct
            // 
            this.QtyProduct.FillWeight = 30F;
            this.QtyProduct.HeaderText = "Qty";
            this.QtyProduct.MinimumWidth = 30;
            this.QtyProduct.Name = "QtyProduct";
            this.QtyProduct.ReadOnly = true;
            this.QtyProduct.Width = 125;
            // 
            // PriceProduct
            // 
            this.PriceProduct.FillWeight = 50F;
            this.PriceProduct.HeaderText = "Price";
            this.PriceProduct.MinimumWidth = 50;
            this.PriceProduct.Name = "PriceProduct";
            this.PriceProduct.ReadOnly = true;
            this.PriceProduct.Width = 125;
            // 
            // AmountProduct
            // 
            this.AmountProduct.FillWeight = 50F;
            this.AmountProduct.HeaderText = "Amount";
            this.AmountProduct.MinimumWidth = 50;
            this.AmountProduct.Name = "AmountProduct";
            this.AmountProduct.ReadOnly = true;
            this.AmountProduct.Width = 125;
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 697);
            this.Controls.Add(this.dataGridViewPOS);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.CategoryPannel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "POS";
            this.Text = "POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.POS_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button NewPosBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel CategoryPannel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridViewPOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountProduct;
    }
}