﻿namespace PHP
{
    partial class AddSales
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
			this.txtDate = new System.Windows.Forms.TextBox();
			this.lblDate = new System.Windows.Forms.Label();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.cmbProductID = new System.Windows.Forms.ComboBox();
			this.lblProduct = new System.Windows.Forms.Label();
			this.lblQuantity = new System.Windows.Forms.Label();
			this.lblIDError = new System.Windows.Forms.Label();
			this.lblDateError = new System.Windows.Forms.Label();
			this.lblQuantityError = new System.Windows.Forms.Label();
			this.lblRowsAffected = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtDate
			// 
			this.txtDate.Location = new System.Drawing.Point(46, 291);
			this.txtDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtDate.Name = "txtDate";
			this.txtDate.Size = new System.Drawing.Size(300, 26);
			this.txtDate.TabIndex = 1;
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDate.Location = new System.Drawing.Point(41, 258);
			this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(61, 28);
			this.lblDate.TabIndex = 2;
			this.lblDate.Text = "Date:";
			// 
			// btnSubmit
			// 
			this.btnSubmit.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubmit.Location = new System.Drawing.Point(46, 401);
			this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(300, 56);
			this.btnSubmit.TabIndex = 2;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(46, 480);
			this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(300, 75);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "Exit to home page";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// txtQuantity
			// 
			this.txtQuantity.Location = new System.Drawing.Point(46, 160);
			this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(300, 26);
			this.txtQuantity.TabIndex = 1;
			// 
			// cmbProductID
			// 
			this.cmbProductID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbProductID.FormattingEnabled = true;
			this.cmbProductID.Location = new System.Drawing.Point(46, 48);
			this.cmbProductID.Name = "cmbProductID";
			this.cmbProductID.Size = new System.Drawing.Size(300, 28);
			this.cmbProductID.TabIndex = 0;
			// 
			// lblProduct
			// 
			this.lblProduct.AutoSize = true;
			this.lblProduct.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProduct.Location = new System.Drawing.Point(41, 17);
			this.lblProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblProduct.Name = "lblProduct";
			this.lblProduct.Size = new System.Drawing.Size(83, 28);
			this.lblProduct.TabIndex = 7;
			this.lblProduct.Text = "Product";
			// 
			// lblQuantity
			// 
			this.lblQuantity.AutoSize = true;
			this.lblQuantity.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblQuantity.Location = new System.Drawing.Point(41, 127);
			this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.Size = new System.Drawing.Size(92, 28);
			this.lblQuantity.TabIndex = 8;
			this.lblQuantity.Text = "Quantity";
			// 
			// lblIDError
			// 
			this.lblIDError.AutoSize = true;
			this.lblIDError.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIDError.ForeColor = System.Drawing.Color.Red;
			this.lblIDError.Location = new System.Drawing.Point(42, 79);
			this.lblIDError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblIDError.Name = "lblIDError";
			this.lblIDError.Size = new System.Drawing.Size(144, 23);
			this.lblIDError.TabIndex = 9;
			this.lblIDError.Text = "Invalid ProductID";
			this.lblIDError.Visible = false;
			// 
			// lblDateError
			// 
			this.lblDateError.AutoSize = true;
			this.lblDateError.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDateError.ForeColor = System.Drawing.Color.Red;
			this.lblDateError.Location = new System.Drawing.Point(42, 322);
			this.lblDateError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDateError.Name = "lblDateError";
			this.lblDateError.Size = new System.Drawing.Size(209, 23);
			this.lblDateError.TabIndex = 10;
			this.lblDateError.Text = "Invalid Date (yyyy-mm-dd)";
			this.lblDateError.Visible = false;
			// 
			// lblQuantityError
			// 
			this.lblQuantityError.AutoSize = true;
			this.lblQuantityError.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblQuantityError.ForeColor = System.Drawing.Color.Red;
			this.lblQuantityError.Location = new System.Drawing.Point(42, 191);
			this.lblQuantityError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblQuantityError.MaximumSize = new System.Drawing.Size(300, 100);
			this.lblQuantityError.Name = "lblQuantityError";
			this.lblQuantityError.Size = new System.Drawing.Size(296, 46);
			this.lblQuantityError.TabIndex = 11;
			this.lblQuantityError.Text = "Invalid Quantity, enter a value greater than 0";
			this.lblQuantityError.Visible = false;
			// 
			// lblRowsAffected
			// 
			this.lblRowsAffected.AutoSize = true;
			this.lblRowsAffected.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRowsAffected.ForeColor = System.Drawing.Color.Black;
			this.lblRowsAffected.Location = new System.Drawing.Point(42, 373);
			this.lblRowsAffected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblRowsAffected.Name = "lblRowsAffected";
			this.lblRowsAffected.Size = new System.Drawing.Size(0, 23);
			this.lblRowsAffected.TabIndex = 12;
			this.lblRowsAffected.Visible = false;
			// 
			// AddSales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(397, 569);
			this.Controls.Add(this.lblRowsAffected);
			this.Controls.Add(this.lblQuantityError);
			this.Controls.Add(this.lblDateError);
			this.Controls.Add(this.lblIDError);
			this.Controls.Add(this.lblQuantity);
			this.Controls.Add(this.lblProduct);
			this.Controls.Add(this.cmbProductID);
			this.Controls.Add(this.txtQuantity);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.txtDate);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "AddSales";
			this.Text = "AddSales";
			this.Load += new System.EventHandler(this.AddSales_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.TextBox txtQuantity;
		private System.Windows.Forms.ComboBox cmbProductID;
		private System.Windows.Forms.Label lblProduct;
		private System.Windows.Forms.Label lblQuantity;
		private System.Windows.Forms.Label lblIDError;
		private System.Windows.Forms.Label lblDateError;
		private System.Windows.Forms.Label lblQuantityError;
		private System.Windows.Forms.Label lblRowsAffected;
	}
}