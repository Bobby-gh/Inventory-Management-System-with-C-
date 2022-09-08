namespace BobCs
{
    partial class InventorySystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventorySystem));
            this.btnstock = new System.Windows.Forms.Button();
            this.btnreport = new System.Windows.Forms.Button();
            this.btnuser = new System.Windows.Forms.Button();
            this.btncategory = new System.Windows.Forms.Button();
            this.btProduct = new System.Windows.Forms.Button();
            this.btoverview = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.category1 = new BobCs.Category();
            this.stocks1 = new BobCs.Stocks();
            this.users1 = new BobCs.Users();
            this.repot1 = new BobCs.repot();
            this.product1 = new BobCs.Product();
            this.dashboard1 = new BobCs.Dashboard();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnstock
            // 
            this.btnstock.FlatAppearance.BorderSize = 0;
            this.btnstock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstock.ForeColor = System.Drawing.Color.White;
            this.btnstock.Location = new System.Drawing.Point(12, 274);
            this.btnstock.Name = "btnstock";
            this.btnstock.Size = new System.Drawing.Size(125, 40);
            this.btnstock.TabIndex = 7;
            this.btnstock.Text = "Stock";
            this.btnstock.UseVisualStyleBackColor = true;
            this.btnstock.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // btnreport
            // 
            this.btnreport.FlatAppearance.BorderSize = 0;
            this.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.ForeColor = System.Drawing.Color.White;
            this.btnreport.Location = new System.Drawing.Point(12, 399);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(125, 40);
            this.btnreport.TabIndex = 6;
            this.btnreport.Text = "Report";
            this.btnreport.UseVisualStyleBackColor = true;
            this.btnreport.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // btnuser
            // 
            this.btnuser.FlatAppearance.BorderSize = 0;
            this.btnuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuser.ForeColor = System.Drawing.Color.White;
            this.btnuser.Location = new System.Drawing.Point(12, 332);
            this.btnuser.Name = "btnuser";
            this.btnuser.Size = new System.Drawing.Size(125, 40);
            this.btnuser.TabIndex = 5;
            this.btnuser.Text = "Users";
            this.btnuser.UseVisualStyleBackColor = true;
            this.btnuser.Click += new System.EventHandler(this.button7_Click);
            // 
            // btncategory
            // 
            this.btncategory.FlatAppearance.BorderSize = 0;
            this.btncategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncategory.ForeColor = System.Drawing.Color.White;
            this.btncategory.Location = new System.Drawing.Point(35, 215);
            this.btncategory.Name = "btncategory";
            this.btncategory.Size = new System.Drawing.Size(102, 40);
            this.btncategory.TabIndex = 4;
            this.btncategory.Text = "Category";
            this.btncategory.UseVisualStyleBackColor = true;
            this.btncategory.Click += new System.EventHandler(this.button6_Click);
            // 
            // btProduct
            // 
            this.btProduct.FlatAppearance.BorderSize = 0;
            this.btProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProduct.ForeColor = System.Drawing.Color.White;
            this.btProduct.Location = new System.Drawing.Point(23, 159);
            this.btProduct.Name = "btProduct";
            this.btProduct.Size = new System.Drawing.Size(114, 40);
            this.btProduct.TabIndex = 3;
            this.btProduct.Text = "Product";
            this.btProduct.UseVisualStyleBackColor = true;
            this.btProduct.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // btoverview
            // 
            this.btoverview.FlatAppearance.BorderSize = 0;
            this.btoverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btoverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoverview.ForeColor = System.Drawing.Color.White;
            this.btoverview.Location = new System.Drawing.Point(35, 100);
            this.btoverview.Name = "btoverview";
            this.btoverview.Size = new System.Drawing.Size(102, 40);
            this.btoverview.TabIndex = 2;
            this.btoverview.Text = "Overview";
            this.btoverview.UseVisualStyleBackColor = true;
            this.btoverview.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(140, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(907, 51);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(298, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 76);
            this.panel4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumBlue;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory System";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(710, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 51);
            this.panel2.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(103, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 23);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(168, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 23);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(136, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.btnstock);
            this.panel1.Controls.Add(this.btnreport);
            this.panel1.Controls.Add(this.btnuser);
            this.panel1.Controls.Add(this.btncategory);
            this.panel1.Controls.Add(this.btProduct);
            this.panel1.Controls.Add(this.btoverview);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 596);
            this.panel1.TabIndex = 0;
            // 
            // category1
            // 
            this.category1.BackColor = System.Drawing.Color.White;
            this.category1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.category1.Location = new System.Drawing.Point(140, 51);
            this.category1.Name = "category1";
            this.category1.Size = new System.Drawing.Size(907, 545);
            this.category1.TabIndex = 5;
            // 
            // stocks1
            // 
            this.stocks1.BackColor = System.Drawing.Color.White;
            this.stocks1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stocks1.Location = new System.Drawing.Point(140, 51);
            this.stocks1.Name = "stocks1";
            this.stocks1.Size = new System.Drawing.Size(907, 545);
            this.stocks1.TabIndex = 4;
            this.stocks1.Load += new System.EventHandler(this.stocks1_Load);
            // 
            // users1
            // 
            this.users1.BackColor = System.Drawing.Color.White;
            this.users1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.users1.Location = new System.Drawing.Point(140, 51);
            this.users1.Name = "users1";
            this.users1.Size = new System.Drawing.Size(907, 545);
            this.users1.TabIndex = 3;
            // 
            // repot1
            // 
            this.repot1.BackColor = System.Drawing.Color.White;
            this.repot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repot1.Location = new System.Drawing.Point(140, 51);
            this.repot1.Name = "repot1";
            this.repot1.Size = new System.Drawing.Size(907, 545);
            this.repot1.TabIndex = 2;
            // 
            // product1
            // 
            this.product1.BackColor = System.Drawing.Color.White;
            this.product1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.product1.Location = new System.Drawing.Point(140, 51);
            this.product1.Name = "product1";
            this.product1.Size = new System.Drawing.Size(907, 545);
            this.product1.TabIndex = 6;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.SystemColors.Menu;
            this.dashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard1.Location = new System.Drawing.Point(140, 51);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(907, 545);
            this.dashboard1.TabIndex = 7;
            // 
            // InventorySystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1047, 596);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.product1);
            this.Controls.Add(this.category1);
            this.Controls.Add(this.stocks1);
            this.Controls.Add(this.users1);
            this.Controls.Add(this.repot1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventorySystem";
            this.Text = " ";
            this.Load += new System.EventHandler(this.InventorySystem_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnstock;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Button btnuser;
        private System.Windows.Forms.Button btncategory;
        private System.Windows.Forms.Button btProduct;
        private System.Windows.Forms.Button btoverview;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private repot repot1;
        private Users users1;
        private Stocks stocks1;
        private Category category1;
        private Product product1;
        private Dashboard dashboard1;
    }
}