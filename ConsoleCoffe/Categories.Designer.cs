﻿namespace ConsoleCoffe
{
    partial class Categories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Seachbar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Catego = new System.Windows.Forms.DataGridView();
            this.Sr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvg = new System.Windows.Forms.DataGridViewImageColumn();
            this.dvgdel = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Catego)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(764, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search:";
            // 
            // Seachbar
            // 
            this.Seachbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seachbar.Location = new System.Drawing.Point(780, 105);
            this.Seachbar.Name = "Seachbar";
            this.Seachbar.Size = new System.Drawing.Size(206, 38);
            this.Seachbar.TabIndex = 2;
            this.Seachbar.Text = "Search Here";
            this.Seachbar.TextChanged += new System.EventHandler(this.Seachbar_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(321, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 69);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category List";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Catego
            // 
            this.Catego.AllowUserToAddRows = false;
            this.Catego.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Catego.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Catego.BackgroundColor = System.Drawing.Color.Gray;
            this.Catego.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Catego.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sr,
            this.id,
            this.name,
            this.dvg,
            this.dvgdel});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Catego.DefaultCellStyle = dataGridViewCellStyle6;
            this.Catego.Location = new System.Drawing.Point(42, 169);
            this.Catego.Name = "Catego";
            this.Catego.ReadOnly = true;
            this.Catego.RowHeadersWidth = 51;
            this.Catego.RowTemplate.Height = 24;
            this.Catego.Size = new System.Drawing.Size(950, 334);
            this.Catego.TabIndex = 3;
            this.Catego.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Catego_CellClick);
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
            this.name.MinimumWidth = 100;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 150;
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
            this.dataGridViewImageColumn1.ReadOnly = true;
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
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.White;
            this.Add.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Add.Image = global::ConsoleCoffe.Properties.Resources.add_removebg_preview;
            this.Add.Location = new System.Drawing.Point(68, 61);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(74, 71);
            this.Add.TabIndex = 0;
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1034, 548);
            this.Controls.Add(this.Catego);
            this.Controls.Add(this.Seachbar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Categories";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.Categories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Catego)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Seachbar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Catego;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sr;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewImageColumn dvg;
        private System.Windows.Forms.DataGridViewImageColumn dvgdel;
    }
}