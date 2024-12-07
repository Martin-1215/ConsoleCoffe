namespace ConsoleCoffe
{
    partial class ucProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProduct));
            this.txtImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtImage
            // 
            this.txtImage.Image = ((System.Drawing.Image)(resources.GetObject("txtImage.Image")));
            this.txtImage.Location = new System.Drawing.Point(38, 18);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(117, 100);
            this.txtImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtImage.TabIndex = 0;
            this.txtImage.TabStop = false;
            this.txtImage.Click += new System.EventHandler(this.txtImage_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 77);
            this.panel1.TabIndex = 1;
            // 
            // PName
            // 
            this.PName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PName.Location = new System.Drawing.Point(-3, 19);
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(204, 27);
            this.PName.TabIndex = 0;
            this.PName.Text = "Product name";
            this.PName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtImage);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(205, 222);
            this.Load += new System.EventHandler(this.ucProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox txtImage;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label PName;
    }
}
