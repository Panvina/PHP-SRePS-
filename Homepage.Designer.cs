namespace PHP
{
    partial class Homepage
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
            this.label1 = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.addSales = new System.Windows.Forms.Button();
            this.deleteSales = new System.Windows.Forms.Button();
            this.editSales = new System.Windows.Forms.Button();
            this.displaySales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "This is the homepage.  Remove this text after";
            // 
            // product
            // 
            this.product.Location = new System.Drawing.Point(470, 232);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(123, 29);
            this.product.TabIndex = 1;
            this.product.Text = "Show All Products";
            this.product.UseVisualStyleBackColor = true;
            this.product.Click += new System.EventHandler(this.product_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(470, 316);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(124, 33);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // addSales
            // 
            this.addSales.Location = new System.Drawing.Point(29, 84);
            this.addSales.Name = "addSales";
            this.addSales.Size = new System.Drawing.Size(132, 47);
            this.addSales.TabIndex = 3;
            this.addSales.Text = "Add Sales Report";
            this.addSales.UseVisualStyleBackColor = true;
            this.addSales.Click += new System.EventHandler(this.addSales_Click);
            // 
            // deleteSales
            // 
            this.deleteSales.Location = new System.Drawing.Point(29, 194);
            this.deleteSales.Name = "deleteSales";
            this.deleteSales.Size = new System.Drawing.Size(111, 24);
            this.deleteSales.TabIndex = 4;
            this.deleteSales.Text = "Delete Sales Report";
            this.deleteSales.UseVisualStyleBackColor = true;
            this.deleteSales.Click += new System.EventHandler(this.deleteSales_Click);
            // 
            // editSales
            // 
            this.editSales.Location = new System.Drawing.Point(29, 238);
            this.editSales.Name = "editSales";
            this.editSales.Size = new System.Drawing.Size(111, 23);
            this.editSales.TabIndex = 5;
            this.editSales.Text = "Edit Sales Report";
            this.editSales.UseVisualStyleBackColor = true;
            this.editSales.Click += new System.EventHandler(this.editSales_Click);
            // 
            // displaySales
            // 
            this.displaySales.Location = new System.Drawing.Point(29, 275);
            this.displaySales.Name = "displaySales";
            this.displaySales.Size = new System.Drawing.Size(111, 23);
            this.displaySales.TabIndex = 6;
            this.displaySales.Text = "Display Sales Report";
            this.displaySales.UseVisualStyleBackColor = true;
            this.displaySales.Click += new System.EventHandler(this.displaySales_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 385);
            this.Controls.Add(this.displaySales);
            this.Controls.Add(this.editSales);
            this.Controls.Add(this.deleteSales);
            this.Controls.Add(this.addSales);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.product);
            this.Controls.Add(this.label1);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button product;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button addSales;
        private System.Windows.Forms.Button deleteSales;
        private System.Windows.Forms.Button editSales;
        private System.Windows.Forms.Button displaySales;
    }
}