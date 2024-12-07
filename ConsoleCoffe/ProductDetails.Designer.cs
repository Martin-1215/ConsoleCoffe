namespace ConsoleCoffe
{
    partial class ProductDetails
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
            this.T = new System.Windows.Forms.Label();
            this.productname = new System.Windows.Forms.TextBox();
            this.catcombo = new System.Windows.Forms.ComboBox();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Producimage = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Producimage)).BeginInit();
            this.SuspendLayout();
            // 
            // T
            // 
            this.T.AutoSize = true;
            this.T.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T.Location = new System.Drawing.Point(79, 122);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(84, 29);
            this.T.TabIndex = 0;
            this.T.Text = "Name:";
            // 
            // productname
            // 
            this.productname.Location = new System.Drawing.Point(82, 154);
            this.productname.Multiline = true;
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(171, 40);
            this.productname.TabIndex = 1;
            // 
            // catcombo
            // 
            this.catcombo.FormattingEnabled = true;
            this.catcombo.Location = new System.Drawing.Point(84, 280);
            this.catcombo.Name = "catcombo";
            this.catcombo.Size = new System.Drawing.Size(171, 24);
            this.catcombo.TabIndex = 2;
            this.catcombo.SelectedIndexChanged += new System.EventHandler(this.catcombo_SelectedIndexChanged);
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseBtn.Location = new System.Drawing.Point(547, 293);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(102, 40);
            this.BrowseBtn.TabIndex = 3;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(38, 24);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(125, 44);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.Color.Black;
            this.Cancel.Location = new System.Drawing.Point(187, 24);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(133, 44);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 93);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.Cancel);
            this.panel2.Controls.Add(this.Save);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 359);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 80);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Category";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(289, 154);
            this.Price.Multiline = true;
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(174, 40);
            this.Price.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Price:";
            // 
            // Producimage
            // 
            this.Producimage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Producimage.Image = global::ConsoleCoffe.Properties.Resources._462568849_941227144536412_2916676744882120622_n;
            this.Producimage.Location = new System.Drawing.Point(514, 122);
            this.Producimage.Name = "Producimage";
            this.Producimage.Size = new System.Drawing.Size(165, 165);
            this.Producimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Producimage.TabIndex = 11;
            this.Producimage.TabStop = false;
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 439);
            this.Controls.Add(this.Producimage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BrowseBtn);
            this.Controls.Add(this.catcombo);
            this.Controls.Add(this.productname);
            this.Controls.Add(this.T);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductDetails";
            this.Text = "ProductDetails";
            this.Load += new System.EventHandler(this.ProductDetails_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Producimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label T;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Producimage;
        public System.Windows.Forms.TextBox productname;
        public System.Windows.Forms.ComboBox catcombo;
        public System.Windows.Forms.TextBox Price;
    }
}