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
			this.btnDisplayInventory = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnAddSales = new System.Windows.Forms.Button();
			this.btnDeleteSales = new System.Windows.Forms.Button();
			this.btnEditSales = new System.Windows.Forms.Button();
			this.btnDisplaySales = new System.Windows.Forms.Button();
			this.btnAllSales = new System.Windows.Forms.Button();
			this.btnDisplayMonthlySales = new System.Windows.Forms.Button();
			this.btnDisplayYearlySales = new System.Windows.Forms.Button();
			this.btnDisplayWeeklySales = new System.Windows.Forms.Button();
			this.grbSales = new System.Windows.Forms.GroupBox();
			this.grbReport = new System.Windows.Forms.GroupBox();
			this.btnExport = new System.Windows.Forms.Button();
			this.grbProducts = new System.Windows.Forms.GroupBox();
			this.btnAddProduct = new System.Windows.Forms.Button();
			this.btnDeleteProduct = new System.Windows.Forms.Button();
			this.btnEditInventory = new System.Windows.Forms.Button();
			this.grbSuppliers = new System.Windows.Forms.GroupBox();
			this.btnDeleteSupplier = new System.Windows.Forms.Button();
			this.btnDisplaySupplier = new System.Windows.Forms.Button();
			this.btnAddSupplier = new System.Windows.Forms.Button();
			this.btnEditSupplier = new System.Windows.Forms.Button();
			this.grbSales.SuspendLayout();
			this.grbReport.SuspendLayout();
			this.grbProducts.SuspendLayout();
			this.grbSuppliers.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(32, 18);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(804, 49);
			this.label1.TabIndex = 0;
			this.label1.Text = "PEOPLE\'S HEALTH PHARMACY INVOICE SYSTEM";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// btnDisplayInventory
			// 
			this.btnDisplayInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnDisplayInventory.Location = new System.Drawing.Point(24, 249);
			this.btnDisplayInventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnDisplayInventory.Name = "btnDisplayInventory";
			this.btnDisplayInventory.Size = new System.Drawing.Size(201, 88);
			this.btnDisplayInventory.TabIndex = 1;
			this.btnDisplayInventory.Text = "Display  Current Inventory";
			this.btnDisplayInventory.UseVisualStyleBackColor = true;
			this.btnDisplayInventory.Click += new System.EventHandler(this.product_Click);
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnExit.Location = new System.Drawing.Point(590, 603);
			this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(201, 88);
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.exit_Click);
			// 
			// btnAddSales
			// 
			this.btnAddSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnAddSales.Location = new System.Drawing.Point(22, 28);
			this.btnAddSales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnAddSales.Name = "btnAddSales";
			this.btnAddSales.Size = new System.Drawing.Size(201, 88);
			this.btnAddSales.TabIndex = 3;
			this.btnAddSales.Text = "Add Sales Report";
			this.btnAddSales.UseVisualStyleBackColor = true;
			this.btnAddSales.Click += new System.EventHandler(this.addSales_Click);
			// 
			// btnDeleteSales
			// 
			this.btnDeleteSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnDeleteSales.Location = new System.Drawing.Point(22, 362);
			this.btnDeleteSales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnDeleteSales.Name = "btnDeleteSales";
			this.btnDeleteSales.Size = new System.Drawing.Size(201, 88);
			this.btnDeleteSales.TabIndex = 4;
			this.btnDeleteSales.Text = "Delete Sales Report";
			this.btnDeleteSales.UseVisualStyleBackColor = true;
			this.btnDeleteSales.Click += new System.EventHandler(this.deleteSales_Click);
			// 
			// btnEditSales
			// 
			this.btnEditSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnEditSales.Location = new System.Drawing.Point(22, 138);
			this.btnEditSales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnEditSales.Name = "btnEditSales";
			this.btnEditSales.Size = new System.Drawing.Size(201, 88);
			this.btnEditSales.TabIndex = 5;
			this.btnEditSales.Text = "Edit Sales Report";
			this.btnEditSales.UseVisualStyleBackColor = true;
			this.btnEditSales.Click += new System.EventHandler(this.editSales_Click);
			// 
			// btnDisplaySales
			// 
			this.btnDisplaySales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnDisplaySales.Location = new System.Drawing.Point(22, 249);
			this.btnDisplaySales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnDisplaySales.Name = "btnDisplaySales";
			this.btnDisplaySales.Size = new System.Drawing.Size(201, 88);
			this.btnDisplaySales.TabIndex = 6;
			this.btnDisplaySales.Text = "Display Sales Report";
			this.btnDisplaySales.UseVisualStyleBackColor = true;
			this.btnDisplaySales.Click += new System.EventHandler(this.displaySales_Click);
			// 
			// btnAllSales
			// 
			this.btnAllSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnAllSales.Location = new System.Drawing.Point(322, 603);
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
			this.btnDisplayYearlySales.Location = new System.Drawing.Point(21, 249);
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
			this.btnDisplayWeeklySales.Click += new System.EventHandler(this.btnDisplayWeeklySales_Click);
			// 
			// grbSales
			// 
			this.grbSales.Controls.Add(this.btnEditSales);
			this.grbSales.Controls.Add(this.btnAddSales);
			this.grbSales.Controls.Add(this.btnDisplaySales);
			this.grbSales.Controls.Add(this.btnDeleteSales);
			this.grbSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbSales.Location = new System.Drawing.Point(40, 92);
			this.grbSales.Name = "grbSales";
			this.grbSales.Size = new System.Drawing.Size(244, 469);
			this.grbSales.TabIndex = 11;
			this.grbSales.TabStop = false;
			this.grbSales.Text = "Sales";
			// 
			// grbReport
			// 
			this.grbReport.Controls.Add(this.btnExport);
			this.grbReport.Controls.Add(this.btnDisplayWeeklySales);
			this.grbReport.Controls.Add(this.btnDisplayYearlySales);
			this.grbReport.Controls.Add(this.btnDisplayMonthlySales);
			this.grbReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbReport.Location = new System.Drawing.Point(842, 92);
			this.grbReport.Name = "grbReport";
			this.grbReport.Size = new System.Drawing.Size(244, 469);
			this.grbReport.TabIndex = 12;
			this.grbReport.TabStop = false;
			this.grbReport.Text = "Reporting";
			// 
			// btnExport
			// 
			this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnExport.Location = new System.Drawing.Point(21, 362);
			this.btnExport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(201, 88);
			this.btnExport.TabIndex = 11;
			this.btnExport.Text = "Export Monthly Report";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// grbProducts
			// 
			this.grbProducts.Controls.Add(this.btnAddProduct);
			this.grbProducts.Controls.Add(this.btnDeleteProduct);
			this.grbProducts.Controls.Add(this.btnEditInventory);
			this.grbProducts.Controls.Add(this.btnDisplayInventory);
			this.grbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbProducts.Location = new System.Drawing.Point(308, 92);
			this.grbProducts.Name = "grbProducts";
			this.grbProducts.Size = new System.Drawing.Size(244, 469);
			this.grbProducts.TabIndex = 13;
			this.grbProducts.TabStop = false;
			this.grbProducts.Text = "Products";
			// 
			// btnAddProduct
			// 
			this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnAddProduct.Location = new System.Drawing.Point(24, 28);
			this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnAddProduct.Name = "btnAddProduct";
			this.btnAddProduct.Size = new System.Drawing.Size(201, 88);
			this.btnAddProduct.TabIndex = 5;
			this.btnAddProduct.Text = "Add New Product";
			this.btnAddProduct.UseVisualStyleBackColor = true;
			this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
			// 
			// btnDeleteProduct
			// 
			this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnDeleteProduct.Location = new System.Drawing.Point(24, 362);
			this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnDeleteProduct.Name = "btnDeleteProduct";
			this.btnDeleteProduct.Size = new System.Drawing.Size(201, 88);
			this.btnDeleteProduct.TabIndex = 4;
			this.btnDeleteProduct.Text = "Delete Product";
			this.btnDeleteProduct.UseVisualStyleBackColor = true;
			this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
			// 
			// btnEditInventory
			// 
			this.btnEditInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnEditInventory.Location = new System.Drawing.Point(24, 138);
			this.btnEditInventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnEditInventory.Name = "btnEditInventory";
			this.btnEditInventory.Size = new System.Drawing.Size(201, 88);
			this.btnEditInventory.TabIndex = 3;
			this.btnEditInventory.Text = "Edit Product";
			this.btnEditInventory.UseVisualStyleBackColor = true;
			this.btnEditInventory.Click += new System.EventHandler(this.btnEditInventory_Click);
			// 
			// grbSuppliers
			// 
			this.grbSuppliers.Controls.Add(this.btnDeleteSupplier);
			this.grbSuppliers.Controls.Add(this.btnDisplaySupplier);
			this.grbSuppliers.Controls.Add(this.btnAddSupplier);
			this.grbSuppliers.Controls.Add(this.btnEditSupplier);
			this.grbSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbSuppliers.Location = new System.Drawing.Point(574, 92);
			this.grbSuppliers.Name = "grbSuppliers";
			this.grbSuppliers.Size = new System.Drawing.Size(244, 469);
			this.grbSuppliers.TabIndex = 14;
			this.grbSuppliers.TabStop = false;
			this.grbSuppliers.Text = "Suppliers";
			// 
			// btnDeleteSupplier
			// 
			this.btnDeleteSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnDeleteSupplier.Location = new System.Drawing.Point(24, 362);
			this.btnDeleteSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnDeleteSupplier.Name = "btnDeleteSupplier";
			this.btnDeleteSupplier.Size = new System.Drawing.Size(201, 88);
			this.btnDeleteSupplier.TabIndex = 4;
			this.btnDeleteSupplier.Text = "Delete Supplier";
			this.btnDeleteSupplier.UseVisualStyleBackColor = true;
			this.btnDeleteSupplier.Click += new System.EventHandler(this.btnDeleteSupplier_Click);
			// 
			// btnDisplaySupplier
			// 
			this.btnDisplaySupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnDisplaySupplier.Location = new System.Drawing.Point(24, 249);
			this.btnDisplaySupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnDisplaySupplier.Name = "btnDisplaySupplier";
			this.btnDisplaySupplier.Size = new System.Drawing.Size(201, 88);
			this.btnDisplaySupplier.TabIndex = 3;
			this.btnDisplaySupplier.Text = "Display All Suppliers";
			this.btnDisplaySupplier.UseVisualStyleBackColor = true;
			this.btnDisplaySupplier.Click += new System.EventHandler(this.btnDisplaySupplier_Click);
			// 
			// btnAddSupplier
			// 
			this.btnAddSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnAddSupplier.Location = new System.Drawing.Point(24, 29);
			this.btnAddSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnAddSupplier.Name = "btnAddSupplier";
			this.btnAddSupplier.Size = new System.Drawing.Size(201, 88);
			this.btnAddSupplier.TabIndex = 1;
			this.btnAddSupplier.Text = "Add New Supplier";
			this.btnAddSupplier.UseVisualStyleBackColor = true;
			this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
			// 
			// btnEditSupplier
			// 
			this.btnEditSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnEditSupplier.Location = new System.Drawing.Point(24, 138);
			this.btnEditSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnEditSupplier.Name = "btnEditSupplier";
			this.btnEditSupplier.Size = new System.Drawing.Size(201, 88);
			this.btnEditSupplier.TabIndex = 2;
			this.btnEditSupplier.Text = "Edit Supplier";
			this.btnEditSupplier.UseVisualStyleBackColor = true;
			this.btnEditSupplier.Click += new System.EventHandler(this.btnEditSupplier_Click);
			// 
			// frmHomepage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1116, 709);
			this.Controls.Add(this.grbSuppliers);
			this.Controls.Add(this.grbProducts);
			this.Controls.Add(this.grbReport);
			this.Controls.Add(this.grbSales);
			this.Controls.Add(this.btnAllSales);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmHomepage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Homepage";
			this.grbSales.ResumeLayout(false);
			this.grbReport.ResumeLayout(false);
			this.grbProducts.ResumeLayout(false);
			this.grbSuppliers.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisplayInventory;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddSales;
        private System.Windows.Forms.Button btnDeleteSales;
        private System.Windows.Forms.Button btnEditSales;
        private System.Windows.Forms.Button btnDisplaySales;
        private System.Windows.Forms.Button btnAllSales;
        private System.Windows.Forms.Button btnDisplayMonthlySales;
        private System.Windows.Forms.Button btnDisplayYearlySales;
        private System.Windows.Forms.Button btnDisplayWeeklySales;
		private System.Windows.Forms.GroupBox grbSales;
		private System.Windows.Forms.GroupBox grbReport;
		private System.Windows.Forms.GroupBox grbProducts;
        private System.Windows.Forms.GroupBox grbSuppliers;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnEditInventory;
        private System.Windows.Forms.Button btnEditSupplier;
        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.Button btnDisplaySupplier;
		private System.Windows.Forms.Button btnExport;
	}
}