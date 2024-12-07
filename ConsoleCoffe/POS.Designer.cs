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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.NewPosBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CategoryPannel = new System.Windows.Forms.FlowLayoutPanel();
            this.CatBu = new System.Windows.Forms.Button();
            this.ProductPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ucProduct1 = new ConsoleCoffe.ucProduct();
            this.ucProduct2 = new ConsoleCoffe.ucProduct();
            this.ucProduct3 = new ConsoleCoffe.ucProduct();
            this.dataGridViewPOS = new System.Windows.Forms.DataGridView();
            this.Seachbar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvidPOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.CategoryPannel.SuspendLayout();
            this.ProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPOS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.l);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 619);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1384, 78);
            this.panel1.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(1070, 15);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(302, 54);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "00.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l
            // 
            this.l.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.ForeColor = System.Drawing.Color.White;
            this.l.Location = new System.Drawing.Point(911, 15);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(161, 54);
            this.l.TabIndex = 9;
            this.l.Text = "Total:";
            this.l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.exit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.NewPosBtn);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1384, 104);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.Location = new System.Drawing.Point(1337, 12);
            this.exit.Margin = new System.Windows.Forms.Padding(4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(35, 27);
            this.exit.TabIndex = 8;
            this.exit.Text = "x";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(141, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 62);
            this.label1.TabIndex = 7;
            this.label1.Text = "POS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(922, 22);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(65, 62);
            this.button6.TabIndex = 6;
            this.button6.Text = "Dine In";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(838, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 62);
            this.button5.TabIndex = 5;
            this.button5.Text = "Take Out";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // NewPosBtn
            // 
            this.NewPosBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPosBtn.Location = new System.Drawing.Point(756, 22);
            this.NewPosBtn.Name = "NewPosBtn";
            this.NewPosBtn.Size = new System.Drawing.Size(65, 62);
            this.NewPosBtn.TabIndex = 1;
            this.NewPosBtn.Text = "New";
            this.NewPosBtn.UseVisualStyleBackColor = true;
            this.NewPosBtn.Click += new System.EventHandler(this.NewPosBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = global::ConsoleCoffe.Properties.Resources._462568849_941227144536412_2916676744882120622_n_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CategoryPannel
            // 
            this.CategoryPannel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CategoryPannel.Controls.Add(this.CatBu);
            this.CategoryPannel.Location = new System.Drawing.Point(0, 149);
            this.CategoryPannel.Name = "CategoryPannel";
            this.CategoryPannel.Size = new System.Drawing.Size(207, 453);
            this.CategoryPannel.TabIndex = 2;
            // 
            // CatBu
            // 
            this.CatBu.Location = new System.Drawing.Point(3, 3);
            this.CatBu.Name = "CatBu";
            this.CatBu.Size = new System.Drawing.Size(204, 49);
            this.CatBu.TabIndex = 0;
            this.CatBu.Text = "text";
            this.CatBu.UseVisualStyleBackColor = true;
            // 
            // ProductPanel
            // 
            this.ProductPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductPanel.AutoScroll = true;
            this.ProductPanel.Controls.Add(this.ucProduct1);
            this.ProductPanel.Controls.Add(this.ucProduct2);
            this.ProductPanel.Controls.Add(this.ucProduct3);
            this.ProductPanel.Location = new System.Drawing.Point(213, 149);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(537, 453);
            this.ProductPanel.TabIndex = 3;
            this.ProductPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // ucProduct1
            // 
            this.ucProduct1.id = 0;
            this.ucProduct1.Location = new System.Drawing.Point(3, 4);
            this.ucProduct1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucProduct1.Name = "ucProduct1";
            this.ucProduct1.PCategory = null;
            this.ucProduct1.PImage = ((System.Drawing.Image)(resources.GetObject("ucProduct1.PImage")));
            this.ucProduct1.Pname = "Product name";
            this.ucProduct1.PPrice = null;
            this.ucProduct1.Size = new System.Drawing.Size(216, 221);
            this.ucProduct1.TabIndex = 0;
            // 
            // ucProduct2
            // 
            this.ucProduct2.id = 0;
            this.ucProduct2.Location = new System.Drawing.Point(225, 4);
            this.ucProduct2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucProduct2.Name = "ucProduct2";
            this.ucProduct2.PCategory = null;
            this.ucProduct2.PImage = ((System.Drawing.Image)(resources.GetObject("ucProduct2.PImage")));
            this.ucProduct2.Pname = "Product name";
            this.ucProduct2.PPrice = null;
            this.ucProduct2.Size = new System.Drawing.Size(200, 221);
            this.ucProduct2.TabIndex = 1;
            // 
            // ucProduct3
            // 
            this.ucProduct3.id = 0;
            this.ucProduct3.Location = new System.Drawing.Point(3, 233);
            this.ucProduct3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucProduct3.Name = "ucProduct3";
            this.ucProduct3.PCategory = null;
            this.ucProduct3.PImage = ((System.Drawing.Image)(resources.GetObject("ucProduct3.PImage")));
            this.ucProduct3.Pname = "Product name";
            this.ucProduct3.PPrice = null;
            this.ucProduct3.Size = new System.Drawing.Size(216, 220);
            this.ucProduct3.TabIndex = 2;
            // 
            // dataGridViewPOS
            // 
            this.dataGridViewPOS.AllowUserToAddRows = false;
            this.dataGridViewPOS.AllowUserToDeleteRows = false;
            this.dataGridViewPOS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvidPOS,
            this.dgvid,
            this.dgvName,
            this.dgvQty,
            this.dgvPrice,
            this.dgvAmount});
            this.dataGridViewPOS.Location = new System.Drawing.Point(756, 149);
            this.dataGridViewPOS.Name = "dataGridViewPOS";
            this.dataGridViewPOS.ReadOnly = true;
            this.dataGridViewPOS.RowHeadersWidth = 51;
            this.dataGridViewPOS.Size = new System.Drawing.Size(616, 453);
            this.dataGridViewPOS.TabIndex = 4;
            this.dataGridViewPOS.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewPOS_CellFormatting);
            // 
            // Seachbar
            // 
            this.Seachbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seachbar.Location = new System.Drawing.Point(108, 113);
            this.Seachbar.Name = "Seachbar";
            this.Seachbar.Size = new System.Drawing.Size(206, 30);
            this.Seachbar.TabIndex = 6;
            this.Seachbar.TextChanged += new System.EventHandler(this.Seachbar_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(2, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search";
            // 
            // dgvidPOS
            // 
            this.dgvidPOS.FillWeight = 50F;
            this.dgvidPOS.HeaderText = "Sr#";
            this.dgvidPOS.MinimumWidth = 50;
            this.dgvidPOS.Name = "dgvidPOS";
            this.dgvidPOS.ReadOnly = true;
            this.dgvidPOS.Width = 125;
            // 
            // dgvid
            // 
            this.dgvid.HeaderText = "ID";
            this.dgvid.MinimumWidth = 6;
            this.dgvid.Name = "dgvid";
            this.dgvid.ReadOnly = true;
            this.dgvid.Width = 125;
            // 
            // dgvName
            // 
            this.dgvName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvName.HeaderText = "Name";
            this.dgvName.MinimumWidth = 6;
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            // 
            // dgvQty
            // 
            this.dgvQty.FillWeight = 30F;
            this.dgvQty.HeaderText = "Qty";
            this.dgvQty.MinimumWidth = 30;
            this.dgvQty.Name = "dgvQty";
            this.dgvQty.ReadOnly = true;
            this.dgvQty.Width = 125;
            // 
            // dgvPrice
            // 
            this.dgvPrice.FillWeight = 50F;
            this.dgvPrice.HeaderText = "Price";
            this.dgvPrice.MinimumWidth = 50;
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.ReadOnly = true;
            this.dgvPrice.Width = 125;
            // 
            // dgvAmount
            // 
            this.dgvAmount.FillWeight = 50F;
            this.dgvAmount.HeaderText = "Amount";
            this.dgvAmount.MinimumWidth = 50;
            this.dgvAmount.Name = "dgvAmount";
            this.dgvAmount.ReadOnly = true;
            this.dgvAmount.Width = 125;
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 697);
            this.Controls.Add(this.Seachbar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewPOS);
            this.Controls.Add(this.ProductPanel);
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
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.CategoryPannel.ResumeLayout(false);
            this.ProductPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button NewPosBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel CategoryPannel;
        private System.Windows.Forms.FlowLayoutPanel ProductPanel;
        private System.Windows.Forms.DataGridView dataGridViewPOS;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox Seachbar;
        private System.Windows.Forms.Label label2;
        private ucProduct ucProduct1;
        private ucProduct ucProduct2;
        private ucProduct ucProduct3;
        private System.Windows.Forms.Button CatBu;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvidPOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAmount;
    }
}