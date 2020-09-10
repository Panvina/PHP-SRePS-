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
            this.showAllSales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "PEOPLE HEALTH PHARMACY INVOICE SYSTEM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // product
            // 
            this.product.Location = new System.Drawing.Point(223, 316);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(142, 58);
            this.product.TabIndex = 1;
            this.product.Text = "Show Current Inventory";
            this.product.UseVisualStyleBackColor = true;
            this.product.Click += new System.EventHandler(this.product_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(479, 328);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(137, 46);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // addSales
            // 
            this.addSales.Location = new System.Drawing.Point(139, 94);
            this.addSales.Name = "addSales";
            this.addSales.Size = new System.Drawing.Size(134, 57);
            this.addSales.TabIndex = 3;
            this.addSales.Text = "Add Sales Report";
            this.addSales.UseVisualStyleBackColor = true;
            this.addSales.Click += new System.EventHandler(this.addSales_Click);
            // 
            // deleteSales
            // 
            this.deleteSales.Location = new System.Drawing.Point(315, 172);
            this.deleteSales.Name = "deleteSales";
            this.deleteSales.Size = new System.Drawing.Size(134, 57);
            this.deleteSales.TabIndex = 4;
            this.deleteSales.Text = "Delete Sales Report";
            this.deleteSales.UseVisualStyleBackColor = true;
            this.deleteSales.Click += new System.EventHandler(this.deleteSales_Click);
            // 
            // editSales
            // 
            this.editSales.Location = new System.Drawing.Point(141, 172);
            this.editSales.Name = "editSales";
            this.editSales.Size = new System.Drawing.Size(134, 57);
            this.editSales.TabIndex = 5;
            this.editSales.Text = "Edit Sales Report";
            this.editSales.UseVisualStyleBackColor = true;
            this.editSales.Click += new System.EventHandler(this.editSales_Click);
            // 
            // displaySales
            // 
            this.displaySales.Location = new System.Drawing.Point(315, 94);
            this.displaySales.Name = "displaySales";
            this.displaySales.Size = new System.Drawing.Size(134, 57);
            this.displaySales.TabIndex = 6;
            this.displaySales.Text = "Display Sales Report";
            this.displaySales.UseVisualStyleBackColor = true;
            this.displaySales.Click += new System.EventHandler(this.displaySales_Click);
            // 
            // showAllSales
            // 
            this.showAllSales.Location = new System.Drawing.Point(223, 258);
            this.showAllSales.Name = "showAllSales";
            this.showAllSales.Size = new System.Drawing.Size(142, 52);
            this.showAllSales.TabIndex = 7;
            this.showAllSales.Text = "Show All Sales";
            this.showAllSales.UseVisualStyleBackColor = true;
            this.showAllSales.Click += new System.EventHandler(this.showAllSales_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 411);
            this.Controls.Add(this.showAllSales);
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
        private System.Windows.Forms.Button showAllSales;
    }
}