namespace PHP
{
    partial class frmDeleteSales
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
			this.btnExit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.txtID = new System.Windows.Forms.TextBox();
			this.lblID = new System.Windows.Forms.Label();
			this.cmbSales = new System.Windows.Forms.ComboBox();
			this.lblQuantity = new System.Windows.Forms.Label();
			this.lblProductName = new System.Windows.Forms.Label();
			this.lblProductID = new System.Windows.Forms.Label();
			this.lblDate = new System.Windows.Forms.Label();
			this.txtProductID = new System.Windows.Forms.TextBox();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.txtDate = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnExit.Location = new System.Drawing.Point(46, 463);
			this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(300, 75);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "Back to home page";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnDelete.Location = new System.Drawing.Point(46, 395);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(300, 55);
			this.btnDelete.TabIndex = 6;
			this.btnDelete.Text = "Delete Record";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// txtID
			// 
			this.txtID.Enabled = false;
			this.txtID.Location = new System.Drawing.Point(45, 42);
			this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(300, 26);
			this.txtID.TabIndex = 7;
			this.txtID.Visible = false;
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.lblID.Location = new System.Drawing.Point(41, 9);
			this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(90, 29);
			this.lblID.TabIndex = 8;
			this.lblID.Text = "Sales ID";
			// 
			// cmbSales
			// 
			this.cmbSales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSales.FormattingEnabled = true;
			this.cmbSales.Location = new System.Drawing.Point(45, 44);
			this.cmbSales.Name = "cmbSales";
			this.cmbSales.Size = new System.Drawing.Size(301, 28);
			this.cmbSales.TabIndex = 9;
			this.cmbSales.SelectedIndexChanged += new System.EventHandler(this.cmbSales_SelectedIndexChanged);
			// 
			// lblQuantity
			// 
			this.lblQuantity.AutoSize = true;
			this.lblQuantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.lblQuantity.Location = new System.Drawing.Point(40, 244);
			this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.Size = new System.Drawing.Size(100, 29);
			this.lblQuantity.TabIndex = 10;
			this.lblQuantity.Text = "Quantity";
			// 
			// lblProductName
			// 
			this.lblProductName.AutoSize = true;
			this.lblProductName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.lblProductName.Location = new System.Drawing.Point(40, 168);
			this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new System.Drawing.Size(157, 29);
			this.lblProductName.TabIndex = 11;
			this.lblProductName.Text = "Product Name";
			// 
			// lblProductID
			// 
			this.lblProductID.AutoSize = true;
			this.lblProductID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.lblProductID.Location = new System.Drawing.Point(41, 91);
			this.lblProductID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblProductID.Name = "lblProductID";
			this.lblProductID.Size = new System.Drawing.Size(118, 29);
			this.lblProductID.TabIndex = 12;
			this.lblProductID.Text = "Product ID";
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.lblDate.Location = new System.Drawing.Point(41, 319);
			this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(60, 29);
			this.lblDate.TabIndex = 13;
			this.lblDate.Text = "Date";
			// 
			// txtProductID
			// 
			this.txtProductID.Location = new System.Drawing.Point(46, 124);
			this.txtProductID.Name = "txtProductID";
			this.txtProductID.ReadOnly = true;
			this.txtProductID.Size = new System.Drawing.Size(300, 26);
			this.txtProductID.TabIndex = 14;
			// 
			// txtProductName
			// 
			this.txtProductName.Location = new System.Drawing.Point(46, 200);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.ReadOnly = true;
			this.txtProductName.Size = new System.Drawing.Size(300, 26);
			this.txtProductName.TabIndex = 15;
			// 
			// txtQuantity
			// 
			this.txtQuantity.Location = new System.Drawing.Point(46, 276);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.ReadOnly = true;
			this.txtQuantity.Size = new System.Drawing.Size(300, 26);
			this.txtQuantity.TabIndex = 16;
			// 
			// txtDate
			// 
			this.txtDate.Location = new System.Drawing.Point(45, 349);
			this.txtDate.Name = "txtDate";
			this.txtDate.ReadOnly = true;
			this.txtDate.Size = new System.Drawing.Size(300, 26);
			this.txtDate.TabIndex = 17;
			// 
			// frmDeleteSales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(398, 550);
			this.Controls.Add(this.txtDate);
			this.Controls.Add(this.txtQuantity);
			this.Controls.Add(this.txtProductName);
			this.Controls.Add(this.txtProductID);
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.lblProductID);
			this.Controls.Add(this.lblProductName);
			this.Controls.Add(this.lblQuantity);
			this.Controls.Add(this.cmbSales);
			this.Controls.Add(this.lblID);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnExit);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmDeleteSales";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Delete Sales";
			this.Load += new System.EventHandler(this.frmDeleteSales_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.ComboBox cmbSales;
		private System.Windows.Forms.Label lblQuantity;
		private System.Windows.Forms.Label lblProductName;
		private System.Windows.Forms.Label lblProductID;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.TextBox txtProductID;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.TextBox txtQuantity;
		private System.Windows.Forms.TextBox txtDate;
	}
}