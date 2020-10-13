namespace PHP
{
    partial class EditProduct
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
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.lblUnitsOnOrder = new System.Windows.Forms.Label();
            this.lblUnitsInStock = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtUnitsOnOrder = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cmbSupplierID = new System.Windows.Forms.ComboBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.cmbProductID = new System.Windows.Forms.ComboBox();
            this.txtUnitsInStock = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProductNameError = new System.Windows.Forms.Label();
            this.lblPriceError = new System.Windows.Forms.Label();
            this.lblUnitsInStockError = new System.Windows.Forms.Label();
            this.lblUnitsOnOrderError = new System.Windows.Forms.Label();
            this.lblRecordResult = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblInvalidMinMax = new System.Windows.Forms.Label();
            this.cmbCategoryID = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(63, 36);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(55, 13);
            this.lblProductID.TabIndex = 1;
            this.lblProductID.Text = "ProductID";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(55, 91);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "Product Name";
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Location = new System.Drawing.Point(55, 202);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(59, 13);
            this.lblSupplierID.TabIndex = 6;
            this.lblSupplierID.Text = "Supplier ID";
            // 
            // lblUnitsOnOrder
            // 
            this.lblUnitsOnOrder.AutoSize = true;
            this.lblUnitsOnOrder.Location = new System.Drawing.Point(56, 356);
            this.lblUnitsOnOrder.Name = "lblUnitsOnOrder";
            this.lblUnitsOnOrder.Size = new System.Drawing.Size(77, 13);
            this.lblUnitsOnOrder.TabIndex = 12;
            this.lblUnitsOnOrder.Text = "Units On Order";
            // 
            // lblUnitsInStock
            // 
            this.lblUnitsInStock.AutoSize = true;
            this.lblUnitsInStock.Location = new System.Drawing.Point(56, 301);
            this.lblUnitsInStock.Name = "lblUnitsInStock";
            this.lblUnitsInStock.Size = new System.Drawing.Size(74, 13);
            this.lblUnitsInStock.TabIndex = 10;
            this.lblUnitsInStock.Text = "Units In Stock";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(66, 496);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 37);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(66, 539);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 49);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Back to homepage";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtUnitsOnOrder
            // 
            this.txtUnitsOnOrder.Location = new System.Drawing.Point(58, 372);
            this.txtUnitsOnOrder.Name = "txtUnitsOnOrder";
            this.txtUnitsOnOrder.Size = new System.Drawing.Size(200, 20);
            this.txtUnitsOnOrder.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(58, 260);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 20);
            this.txtPrice.TabIndex = 6;
            // 
            // cmbSupplierID
            // 
            this.cmbSupplierID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplierID.FormattingEnabled = true;
            this.cmbSupplierID.Location = new System.Drawing.Point(58, 218);
            this.cmbSupplierID.Name = "cmbSupplierID";
            this.cmbSupplierID.Size = new System.Drawing.Size(200, 21);
            this.cmbSupplierID.TabIndex = 9;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(58, 107);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(200, 20);
            this.txtProductName.TabIndex = 4;
            // 
            // cmbProductID
            // 
            this.cmbProductID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductID.FormattingEnabled = true;
            this.cmbProductID.Location = new System.Drawing.Point(58, 52);
            this.cmbProductID.Name = "cmbProductID";
            this.cmbProductID.Size = new System.Drawing.Size(200, 21);
            this.cmbProductID.TabIndex = 13;
            this.cmbProductID.SelectedIndexChanged += new System.EventHandler(this.cmbProductID_SelectedIndexChanged);
            // 
            // txtUnitsInStock
            // 
            this.txtUnitsInStock.Location = new System.Drawing.Point(58, 317);
            this.txtUnitsInStock.Name = "txtUnitsInStock";
            this.txtUnitsInStock.Size = new System.Drawing.Size(200, 20);
            this.txtUnitsInStock.TabIndex = 14;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(55, 244);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Price";
            // 
            // lblProductNameError
            // 
            this.lblProductNameError.AutoSize = true;
            this.lblProductNameError.ForeColor = System.Drawing.Color.Red;
            this.lblProductNameError.Location = new System.Drawing.Point(57, 129);
            this.lblProductNameError.Name = "lblProductNameError";
            this.lblProductNameError.Size = new System.Drawing.Size(109, 13);
            this.lblProductNameError.TabIndex = 16;
            this.lblProductNameError.Text = "Invalid Product Name";
            // 
            // lblPriceError
            // 
            this.lblPriceError.AutoSize = true;
            this.lblPriceError.ForeColor = System.Drawing.Color.Red;
            this.lblPriceError.Location = new System.Drawing.Point(57, 283);
            this.lblPriceError.Name = "lblPriceError";
            this.lblPriceError.Size = new System.Drawing.Size(65, 13);
            this.lblPriceError.TabIndex = 17;
            this.lblPriceError.Text = "Invalid Price";
            // 
            // lblUnitsInStockError
            // 
            this.lblUnitsInStockError.AutoSize = true;
            this.lblUnitsInStockError.ForeColor = System.Drawing.Color.Red;
            this.lblUnitsInStockError.Location = new System.Drawing.Point(58, 338);
            this.lblUnitsInStockError.Name = "lblUnitsInStockError";
            this.lblUnitsInStockError.Size = new System.Drawing.Size(108, 13);
            this.lblUnitsInStockError.TabIndex = 18;
            this.lblUnitsInStockError.Text = "Invalid Units In Stock";
            // 
            // lblUnitsOnOrderError
            // 
            this.lblUnitsOnOrderError.AutoSize = true;
            this.lblUnitsOnOrderError.ForeColor = System.Drawing.Color.Red;
            this.lblUnitsOnOrderError.Location = new System.Drawing.Point(58, 395);
            this.lblUnitsOnOrderError.Name = "lblUnitsOnOrderError";
            this.lblUnitsOnOrderError.Size = new System.Drawing.Size(111, 13);
            this.lblUnitsOnOrderError.TabIndex = 19;
            this.lblUnitsOnOrderError.Text = "Invalid Units On Order";
            // 
            // lblRecordResult
            // 
            this.lblRecordResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRecordResult.AutoSize = true;
            this.lblRecordResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordResult.Location = new System.Drawing.Point(70, 474);
            this.lblRecordResult.Name = "lblRecordResult";
            this.lblRecordResult.Size = new System.Drawing.Size(188, 17);
            this.lblRecordResult.TabIndex = 20;
            this.lblRecordResult.Text = "Success! X records affected.";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(58, 432);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(72, 20);
            this.txtMin.TabIndex = 21;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(186, 432);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(72, 20);
            this.txtMax.TabIndex = 22;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(79, 416);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(24, 13);
            this.lblMin.TabIndex = 23;
            this.lblMin.Text = "Min";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(211, 416);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(27, 13);
            this.lblMax.TabIndex = 24;
            this.lblMax.Text = "Max";
            // 
            // lblInvalidMinMax
            // 
            this.lblInvalidMinMax.AutoSize = true;
            this.lblInvalidMinMax.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidMinMax.Location = new System.Drawing.Point(55, 459);
            this.lblInvalidMinMax.Name = "lblInvalidMinMax";
            this.lblInvalidMinMax.Size = new System.Drawing.Size(117, 13);
            this.lblInvalidMinMax.TabIndex = 25;
            this.lblInvalidMinMax.Text = "Invalid Min/Max inputs.";
            // 
            // cmbCategoryID
            // 
            this.cmbCategoryID.FormattingEnabled = true;
            this.cmbCategoryID.Location = new System.Drawing.Point(58, 169);
            this.cmbCategoryID.Name = "cmbCategoryID";
            this.cmbCategoryID.Size = new System.Drawing.Size(200, 21);
            this.cmbCategoryID.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Category";
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 633);
            this.Controls.Add(this.cmbCategoryID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblInvalidMinMax);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.lblRecordResult);
            this.Controls.Add(this.lblUnitsOnOrderError);
            this.Controls.Add(this.lblUnitsInStockError);
            this.Controls.Add(this.lblPriceError);
            this.Controls.Add(this.lblProductNameError);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtUnitsInStock);
            this.Controls.Add(this.cmbProductID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbSupplierID);
            this.Controls.Add(this.lblUnitsInStock);
            this.Controls.Add(this.lblUnitsOnOrder);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtUnitsOnOrder);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblSupplierID);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductID);
            this.Name = "EditProduct";
            this.Text = "EditProduct";
            this.Load += new System.EventHandler(this.EditProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.Label lblUnitsOnOrder;
        private System.Windows.Forms.Label lblUnitsInStock;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtUnitsOnOrder;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbSupplierID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.ComboBox cmbProductID;
        private System.Windows.Forms.TextBox txtUnitsInStock;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProductNameError;
        private System.Windows.Forms.Label lblPriceError;
        private System.Windows.Forms.Label lblUnitsInStockError;
        private System.Windows.Forms.Label lblUnitsOnOrderError;
        private System.Windows.Forms.Label lblRecordResult;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblInvalidMinMax;
        private System.Windows.Forms.ComboBox cmbCategoryID;
        private System.Windows.Forms.Label label7;
    }
}