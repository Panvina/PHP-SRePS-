namespace PHP
{
    partial class frmHomepage
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
			this.grbSales = new System.Windows.Forms.GroupBox();
			this.grbReport = new System.Windows.Forms.GroupBox();
			this.grbProducts = new System.Windows.Forms.GroupBox();
			this.grbSales.SuspendLayout();
			this.grbReport.SuspendLayout();
			this.grbProducts.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(31, 19);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(804, 49);
			this.label1.TabIndex = 0;
			this.label1.Text = "PEOPLE\'S HEALTH PHARMACY INVOICE SYSTEM";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// product
			// 
			this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.product.Location = new System.Drawing.Point(24, 29);
			this.product.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.product.Name = "product";
			this.product.Size = new System.Drawing.Size(201, 88);
			this.product.TabIndex = 1;
			this.product.Text = "Show Current Inventory";
			this.product.UseVisualStyleBackColor = true;
			this.product.Click += new System.EventHandler(this.product_Click);
			// 
			// exit
			// 
			this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.exit.Location = new System.Drawing.Point(589, 454);
			this.exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.exit.Name = "exit";
			this.exit.Size = new System.Drawing.Size(201, 88);
			this.exit.TabIndex = 2;
			this.exit.Text = "Exit";
			this.exit.UseVisualStyleBackColor = true;
			this.exit.Click += new System.EventHandler(this.exit_Click);
			// 
			// addSales
			// 
			this.addSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.addSales.Location = new System.Drawing.Point(23, 27);
			this.addSales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.addSales.Name = "addSales";
			this.addSales.Size = new System.Drawing.Size(201, 88);
			this.addSales.TabIndex = 3;
			this.addSales.Text = "Add Sales Report";
			this.addSales.UseVisualStyleBackColor = true;
			this.addSales.Click += new System.EventHandler(this.addSales_Click);
			// 
			// deleteSales
			// 
			this.deleteSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.deleteSales.Location = new System.Drawing.Point(23, 362);
			this.deleteSales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.deleteSales.Name = "deleteSales";
			this.deleteSales.Size = new System.Drawing.Size(201, 88);
			this.deleteSales.TabIndex = 4;
			this.deleteSales.Text = "Delete Sales Report";
			this.deleteSales.UseVisualStyleBackColor = true;
			this.deleteSales.Click += new System.EventHandler(this.deleteSales_Click);
			// 
			// editSales
			// 
			this.editSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.editSales.Location = new System.Drawing.Point(23, 138);
			this.editSales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.editSales.Name = "editSales";
			this.editSales.Size = new System.Drawing.Size(201, 88);
			this.editSales.TabIndex = 5;
			this.editSales.Text = "Edit Sales Report";
			this.editSales.UseVisualStyleBackColor = true;
			this.editSales.Click += new System.EventHandler(this.editSales_Click);
			// 
			// displaySales
			// 
			this.displaySales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.displaySales.Location = new System.Drawing.Point(23, 250);
			this.displaySales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.displaySales.Name = "displaySales";
			this.displaySales.Size = new System.Drawing.Size(201, 88);
			this.displaySales.TabIndex = 6;
			this.displaySales.Text = "Display Sales Report";
			this.displaySales.UseVisualStyleBackColor = true;
			this.displaySales.Click += new System.EventHandler(this.displaySales_Click);
			// 
			// btnAllSales
			// 
			this.btnAllSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnAllSales.Location = new System.Drawing.Point(323, 455);
			this.btnAllSales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnAllSales.Name = "btnAllSales";
			this.btnAllSales.Size = new System.Drawing.Size(201, 88);
			this.btnAllSales.TabIndex = 7;
			this.btnAllSales.Text = "Show All Sales";
			this.btnAllSales.UseVisualStyleBackColor = true;
			this.btnAllSales.Click += new System.EventHandler(this.btnAllSales_Click);
			// 
			// btnDisplayMonthlySales
			// 
			this.btnDisplayMonthlySales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnDisplayMonthlySales.Location = new System.Drawing.Point(21, 138);
			this.btnDisplayMonthlySales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnDisplayMonthlySales.Name = "btnDisplayMonthlySales";
			this.btnDisplayMonthlySales.Size = new System.Drawing.Size(201, 88);
			this.btnDisplayMonthlySales.TabIndex = 8;
			this.btnDisplayMonthlySales.Text = "Display Monthly Sales Report";
			this.btnDisplayMonthlySales.UseVisualStyleBackColor = true;
			this.btnDisplayMonthlySales.Click += new System.EventHandler(this.btnDisplayMonthlySales_Click);
			// 
			// btnDisplayYearlySales
			// 
			this.btnDisplayYearlySales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnDisplayYearlySales.Location = new System.Drawing.Point(21, 250);
			this.btnDisplayYearlySales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnDisplayYearlySales.Name = "btnDisplayYearlySales";
			this.btnDisplayYearlySales.Size = new System.Drawing.Size(201, 88);
			this.btnDisplayYearlySales.TabIndex = 9;
			this.btnDisplayYearlySales.Text = "Display Yearly Sales Report";
			this.btnDisplayYearlySales.UseVisualStyleBackColor = true;
			this.btnDisplayYearlySales.Click += new System.EventHandler(this.btnDisplayYearlySales_Click);
			// 
			// btnDisplayWeeklySales
			// 
			this.btnDisplayWeeklySales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnDisplayWeeklySales.Location = new System.Drawing.Point(21, 29);
			this.btnDisplayWeeklySales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnDisplayWeeklySales.Name = "btnDisplayWeeklySales";
			this.btnDisplayWeeklySales.Size = new System.Drawing.Size(201, 88);
			this.btnDisplayWeeklySales.TabIndex = 10;
			this.btnDisplayWeeklySales.Text = "Display Weekly Sales Report";
			this.btnDisplayWeeklySales.UseVisualStyleBackColor = true;
			// 
			// grbSales
			// 
			this.grbSales.Controls.Add(this.editSales);
			this.grbSales.Controls.Add(this.addSales);
			this.grbSales.Controls.Add(this.displaySales);
			this.grbSales.Controls.Add(this.deleteSales);
			this.grbSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbSales.Location = new System.Drawing.Point(40, 93);
			this.grbSales.Name = "grbSales";
			this.grbSales.Size = new System.Drawing.Size(245, 469);
			this.grbSales.TabIndex = 11;
			this.grbSales.TabStop = false;
			this.grbSales.Text = "Sales";
			// 
			// grbReport
			// 
			this.grbReport.Controls.Add(this.btnDisplayWeeklySales);
			this.grbReport.Controls.Add(this.btnDisplayYearlySales);
			this.grbReport.Controls.Add(this.btnDisplayMonthlySales);
			this.grbReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbReport.Location = new System.Drawing.Point(302, 93);
			this.grbReport.Name = "grbReport";
			this.grbReport.Size = new System.Drawing.Size(245, 353);
			this.grbReport.TabIndex = 12;
			this.grbReport.TabStop = false;
			this.grbReport.Text = "Reporting";
			// 
			// grbProducts
			// 
			this.grbProducts.Controls.Add(this.product);
			this.grbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbProducts.Location = new System.Drawing.Point(565, 93);
			this.grbProducts.Name = "grbProducts";
			this.grbProducts.Size = new System.Drawing.Size(245, 353);
			this.grbProducts.TabIndex = 13;
			this.grbProducts.TabStop = false;
			this.grbProducts.Text = "Products";
			// 
			// frmHomepage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(854, 592);
			this.Controls.Add(this.grbProducts);
			this.Controls.Add(this.grbReport);
			this.Controls.Add(this.grbSales);
			this.Controls.Add(this.btnAllSales);
			this.Controls.Add(this.exit);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmHomepage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Homepage";
			this.Load += new System.EventHandler(this.Homepage_Load);
			this.grbSales.ResumeLayout(false);
			this.grbReport.ResumeLayout(false);
			this.grbProducts.ResumeLayout(false);
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
		private System.Windows.Forms.GroupBox grbSales;
		private System.Windows.Forms.GroupBox grbReport;
		private System.Windows.Forms.GroupBox grbProducts;
	}
}