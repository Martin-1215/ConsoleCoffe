using System;
using System.Windows.Forms;

namespace ConsoleCoffe
{
    partial class frmProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.Seachbar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Viewproduct = new System.Windows.Forms.DataGridView();
            this.Sr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvg = new System.Windows.Forms.DataGridViewImageColumn();
            this.dvgdel = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Viewproduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(329, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 49);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product List";
            // 
            // Seachbar
            // 
            this.Seachbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seachbar.Location = new System.Drawing.Point(763, 62);
            this.Seachbar.Name = "Seachbar";
            this.Seachbar.Size = new System.Drawing.Size(206, 30);
            this.Seachbar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(758, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // Viewproduct
            // 
            this.Viewproduct.AllowUserToAddRows = false;
            this.Viewproduct.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Viewproduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Viewproduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Viewproduct.BackgroundColor = System.Drawing.Color.White;
            this.Viewproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Viewproduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sr,
            this.id,
            this.name,
            this.pPrice,
            this.Cat,
            this.img,
            this.dvg,
            this.dvgdel});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(137)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Viewproduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.Viewproduct.Location = new System.Drawing.Point(37, 145);
            this.Viewproduct.Name = "Viewproduct";
            this.Viewproduct.ReadOnly = true;
            this.Viewproduct.RowHeadersWidth = 51;
            this.Viewproduct.RowTemplate.Height = 24;
            this.Viewproduct.Size = new System.Drawing.Size(950, 334);
            this.Viewproduct.TabIndex = 5;
            this.Viewproduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Viewproduct_CellClick_1);
            // 
            // Sr
            // 
            this.Sr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Sr.FillWeight = 70F;
            this.Sr.HeaderText = "Sr#";
            this.Sr.MinimumWidth = 70;
            this.Sr.Name = "Sr";
            this.Sr.ReadOnly = true;
            this.Sr.Width = 70;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // pPrice
            // 
            this.pPrice.HeaderText = "Price";
            this.pPrice.MinimumWidth = 6;
            this.pPrice.Name = "pPrice";
            this.pPrice.ReadOnly = true;
            this.pPrice.Width = 125;
            // 
            // Cat
            // 
            this.Cat.HeaderText = "Category";
            this.Cat.MinimumWidth = 6;
            this.Cat.Name = "Cat";
            this.Cat.ReadOnly = true;
            this.Cat.Width = 125;
            // 
            // img
            // 
            this.img.HeaderText = "Image";
            this.img.MinimumWidth = 6;
            this.img.Name = "img";
            this.img.ReadOnly = true;
            this.img.Width = 125;
            // 
            // dvg
            // 
            this.dvg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvg.FillWeight = 50F;
            this.dvg.HeaderText = "";
            this.dvg.Image = global::ConsoleCoffe.Properties.Resources.edit_removebg_preview;
            this.dvg.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dvg.MinimumWidth = 50;
            this.dvg.Name = "dvg";
            this.dvg.ReadOnly = true;
            this.dvg.Width = 50;
            // 
            // dvgdel
            // 
            this.dvgdel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgdel.FillWeight = 50F;
            this.dvgdel.HeaderText = "";
            this.dvgdel.Image = global::ConsoleCoffe.Properties.Resources.delete_removebg_preview;
            this.dvgdel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dvgdel.MinimumWidth = 50;
            this.dvgdel.Name = "dvgdel";
            this.dvgdel.ReadOnly = true;
            this.dvgdel.Width = 50;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 50F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::ConsoleCoffe.Properties.Resources.edit_removebg_preview;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 50;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.FillWeight = 50F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::ConsoleCoffe.Properties.Resources.delete_removebg_preview;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 50;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Black;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(37, 54);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 74);
            this.Add.TabIndex = 6;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1016, 501);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Viewproduct);
            this.Controls.Add(this.Seachbar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProduct";
            this.Text = "frmProduct";
            this.Load += new System.EventHandler(this.frmProduct_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.Viewproduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Add_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Viewproduct_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Seachbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Viewproduct;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sr;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn img;
        private System.Windows.Forms.DataGridViewImageColumn dvg;
        private System.Windows.Forms.DataGridViewImageColumn dvgdel;
    }
}