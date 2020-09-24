namespace PHP
{
    partial class frmEditSales
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
			this.cmbSalesID = new System.Windows.Forms.ComboBox();
			this.lblSalesID = new System.Windows.Forms.Label();
			this.lblProductID = new System.Windows.Forms.Label();
			this.lblQuantity = new System.Windows.Forms.Label();
			this.lblDate = new System.Windows.Forms.Label();
			this.tpDate = new System.Windows.Forms.DateTimePicker();
			this.txtProductID = new System.Windows.Forms.TextBox();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.btnEdit = new System.Windows.Forms.Button();
			this.lblProductIDError = new System.Windows.Forms.Label();
			this.lblQuantityError = new System.Windows.Forms.Label();
			this.lblRecordResult = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnExit.Location = new System.Drawing.Point(49, 503);
			this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(300, 55);
			this.btnExit.TabIndex = 7;
			this.btnExit.Text = "Exit to home page";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// cmbSalesID
			// 
			this.cmbSalesID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSalesID.FormattingEnabled = true;
			this.cmbSalesID.Location = new System.Drawing.Point(51, 55);
			this.cmbSalesID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cmbSalesID.Name = "cmbSalesID";
			this.cmbSalesID.Size = new System.Drawing.Size(300, 28);
			this.cmbSalesID.TabIndex = 8;
			this.cmbSalesID.SelectedIndexChanged += new System.EventHandler(this.cmbSalesID_IndexChanged);
			// 
			// lblSalesID
			// 
			this.lblSalesID.AutoSize = true;
			this.lblSalesID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.lblSalesID.Location = new System.Drawing.Point(46, 21);
			this.lblSalesID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSalesID.Name = "lblSalesID";
			this.lblSalesID.Size = new System.Drawing.Size(97, 29);
			this.lblSalesID.TabIndex = 9;
			this.lblSalesID.Text = "Sales ID:";
			// 
			// lblProductID
			// 
			this.lblProductID.AutoSize = true;
			this.lblProductID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.lblProductID.Location = new System.Drawing.Point(47, 119);
			this.lblProductID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblProductID.Name = "lblProductID";
			this.lblProductID.Size = new System.Drawing.Size(118, 29);
			this.lblProductID.TabIndex = 10;
			this.lblProductID.Text = "Product ID";
			// 
			// lblQuantity
			// 
			this.lblQuantity.AutoSize = true;
			this.lblQuantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.lblQuantity.Location = new System.Drawing.Point(47, 220);
			this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.Size = new System.Drawing.Size(100, 29);
			this.lblQuantity.TabIndex = 11;
			this.lblQuantity.Text = "Quantity";
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.lblDate.Location = new System.Drawing.Point(45, 316);
			this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(60, 29);
			this.lblDate.TabIndex = 12;
			this.lblDate.Text = "Date";
			// 
			// tpDate
			// 
			this.tpDate.CalendarFont = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.tpDate.Location = new System.Drawing.Point(50, 349);
			this.tpDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpDate.Name = "tpDate";
			this.tpDate.Size = new System.Drawing.Size(299, 26);
			this.tpDate.TabIndex = 13;
			// 
			// txtProductID
			// 
			this.txtProductID.Location = new System.Drawing.Point(52, 151);
			this.txtProductID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtProductID.Name = "txtProductID";
			this.txtProductID.Size = new System.Drawing.Size(300, 26);
			this.txtProductID.TabIndex = 14;
			// 
			// txtQuantity
			// 
			this.txtQuantity.Location = new System.Drawing.Point(52, 253);
			this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(300, 26);
			this.txtQuantity.TabIndex = 15;
			// 
			// btnEdit
			// 
			this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnEdit.Location = new System.Drawing.Point(49, 438);
			this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(300, 55);
			this.btnEdit.TabIndex = 16;
			this.btnEdit.Text = "Edit Record";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// lblProductIDError
			// 
			this.lblProductIDError.AutoSize = true;
			this.lblProductIDError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProductIDError.ForeColor = System.Drawing.Color.Red;
			this.lblProductIDError.Location = new System.Drawing.Point(46, 182);
			this.lblProductIDError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblProductIDError.Name = "lblProductIDError";
			this.lblProductIDError.Size = new System.Drawing.Size(134, 20);
			this.lblProductIDError.TabIndex = 17;
			this.lblProductIDError.Text = "Invalid Product ID";
			// 
			// lblQuantityError
			// 
			this.lblQuantityError.AutoSize = true;
			this.lblQuantityError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblQuantityError.ForeColor = System.Drawing.Color.Red;
			this.lblQuantityError.Location = new System.Drawing.Point(51, 284);
			this.lblQuantityError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblQuantityError.Name = "lblQuantityError";
			this.lblQuantityError.Size = new System.Drawing.Size(117, 20);
			this.lblQuantityError.TabIndex = 18;
			this.lblQuantityError.Text = "Invalid Quantity";
			// 
			// lblRecordResult
			// 
			this.lblRecordResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblRecordResult.AutoSize = true;
			this.lblRecordResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRecordResult.Location = new System.Drawing.Point(67, 400);
			this.lblRecordResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblRecordResult.Name = "lblRecordResult";
			this.lblRecordResult.Size = new System.Drawing.Size(262, 25);
			this.lblRecordResult.TabIndex = 19;
			this.lblRecordResult.Text = "Success! X records affected.";
			// 
			// frmEditSales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(398, 569);
			this.Controls.Add(this.lblRecordResult);
			this.Controls.Add(this.lblQuantityError);
			this.Controls.Add(this.lblProductIDError);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.txtQuantity);
			this.Controls.Add(this.txtProductID);
			this.Controls.Add(this.tpDate);
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.lblQuantity);
			this.Controls.Add(this.lblProductID);
			this.Controls.Add(this.lblSalesID);
			this.Controls.Add(this.cmbSalesID);
			this.Controls.Add(this.btnExit);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmEditSales";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Edit Sale";
			this.Load += new System.EventHandler(this.EditSales_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbSalesID;
        private System.Windows.Forms.Label lblSalesID;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker tpDate;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblProductIDError;
        private System.Windows.Forms.Label lblQuantityError;
        private System.Windows.Forms.Label lblRecordResult;
    }
}