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
            this.btnAllSales = new System.Windows.Forms.Button();
            this.btnDisplayMonthlySales = new System.Windows.Forms.Button();
            this.btnDisplayYearlySales = new System.Windows.Forms.Button();
            this.btnDisplayWeeklySales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "PEOPLE HEALTH PHARMACY INVOICE SYSTEM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // product
            // 
            this.product.Location = new System.Drawing.Point(311, 296);
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
            this.exit.Location = new System.Drawing.Point(497, 339);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(137, 46);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // addSales
            // 
            this.addSales.Location = new System.Drawing.Point(170, 84);
            this.addSales.Name = "addSales";
            this.addSales.Size = new System.Drawing.Size(134, 57);
            this.addSales.TabIndex = 3;
            this.addSales.Text = "Add Sales Report";
            this.addSales.UseVisualStyleBackColor = true;
            this.addSales.Click += new System.EventHandler(this.addSales_Click);
            // 
            // deleteSales
            // 
            this.deleteSales.Location = new System.Drawing.Point(311, 229);
            this.deleteSales.Name = "deleteSales";
            this.deleteSales.Size = new System.Drawing.Size(134, 57);
            this.deleteSales.TabIndex = 4;
            this.deleteSales.Text = "Delete Sales Report";
            this.deleteSales.UseVisualStyleBackColor = true;
            this.deleteSales.Click += new System.EventHandler(this.deleteSales_Click);
            // 
            // editSales
            // 
            this.editSales.Location = new System.Drawing.Point(145, 229);
            this.editSales.Name = "editSales";
            this.editSales.Size = new System.Drawing.Size(134, 57);
            this.editSales.TabIndex = 5;
            this.editSales.Text = "Edit Sales Report";
            this.editSales.UseVisualStyleBackColor = true;
            this.editSales.Click += new System.EventHandler(this.editSales_Click);
            // 
            // displaySales
            // 
            this.displaySales.Location = new System.Drawing.Point(332, 84);
            this.displaySales.Name = "displaySales";
            this.displaySales.Size = new System.Drawing.Size(134, 57);
            this.displaySales.TabIndex = 6;
            this.displaySales.Text = "Display Sales Report";
            this.displaySales.UseVisualStyleBackColor = true;
            this.displaySales.Click += new System.EventHandler(this.displaySales_Click);
            // 
            // btnAllSales
            // 
            this.btnAllSales.Location = new System.Drawing.Point(137, 305);
            this.btnAllSales.Name = "btnAllSales";
            this.btnAllSales.Size = new System.Drawing.Size(142, 49);
            this.btnAllSales.TabIndex = 7;
            this.btnAllSales.Text = "Show All Sales";
            this.btnAllSales.UseVisualStyleBackColor = true;
            this.btnAllSales.Click += new System.EventHandler(this.btnAllSales_Click);
            // 
            // btnDisplayMonthlySales
            // 
            this.btnDisplayMonthlySales.Location = new System.Drawing.Point(258, 156);
            this.btnDisplayMonthlySales.Name = "btnDisplayMonthlySales";
            this.btnDisplayMonthlySales.Size = new System.Drawing.Size(134, 57);
            this.btnDisplayMonthlySales.TabIndex = 8;
            this.btnDisplayMonthlySales.Text = "Display Monthly Sales Report";
            this.btnDisplayMonthlySales.UseVisualStyleBackColor = true;
            this.btnDisplayMonthlySales.Click += new System.EventHandler(this.btnDisplayMonthlySales_Click);
            // 
            // btnDisplayYearlySales
            // 
            this.btnDisplayYearlySales.Location = new System.Drawing.Point(107, 156);
            this.btnDisplayYearlySales.Name = "btnDisplayYearlySales";
            this.btnDisplayYearlySales.Size = new System.Drawing.Size(134, 57);
            this.btnDisplayYearlySales.TabIndex = 9;
            this.btnDisplayYearlySales.Text = "Display Yearly Sales Report";
            this.btnDisplayYearlySales.UseVisualStyleBackColor = true;
            this.btnDisplayYearlySales.Click += new System.EventHandler(this.btnDisplayYearlySales_Click);
            // 
            // btnDisplayWeeklySales
            // 
            this.btnDisplayWeeklySales.Location = new System.Drawing.Point(415, 156);
            this.btnDisplayWeeklySales.Name = "btnDisplayWeeklySales";
            this.btnDisplayWeeklySales.Size = new System.Drawing.Size(134, 57);
            this.btnDisplayWeeklySales.TabIndex = 10;
            this.btnDisplayWeeklySales.Text = "Display Weekly Sales Report";
            this.btnDisplayWeeklySales.UseVisualStyleBackColor = true;
            this.btnDisplayWeeklySales.Click += new System.EventHandler(this.btnDisplayWeeklySales_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 385);
            this.Controls.Add(this.btnDisplayWeeklySales);
            this.Controls.Add(this.btnDisplayYearlySales);
            this.Controls.Add(this.btnDisplayMonthlySales);
            this.Controls.Add(this.btnAllSales);
            this.Controls.Add(this.displaySales);
            this.Controls.Add(this.editSales);
            this.Controls.Add(this.deleteSales);
            this.Controls.Add(this.addSales);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.product);
            this.Controls.Add(this.label1);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
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
        private System.Windows.Forms.Button btnAllSales;
        private System.Windows.Forms.Button btnDisplayMonthlySales;
        private System.Windows.Forms.Button btnDisplayYearlySales;
        private System.Windows.Forms.Button btnDisplayWeeklySales;
    }
}