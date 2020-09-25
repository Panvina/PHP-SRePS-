namespace PHP
{
    partial class frmDisplaySales
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
			this.components = new System.ComponentModel.Container();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.lblIdPrompt = new System.Windows.Forms.Label();
			this.pHPdbDataSet = new PHP.PHPdbDataSet();
			this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ordersTableAdapter = new PHP.PHPdbDataSetTableAdapters.OrdersTableAdapter();
			this.lblWarning = new System.Windows.Forms.Label();
			this.txtIdInput = new System.Windows.Forms.TextBox();
			this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SaleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvDisplay = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.pHPdbDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
			this.SuspendLayout();
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnExit.Location = new System.Drawing.Point(987, 597);
			this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(200, 81);
			this.btnExit.TabIndex = 6;
			this.btnExit.Text = "Back to home page";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnSearch.Location = new System.Drawing.Point(546, 306);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(132, 52);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// lblIdPrompt
			// 
			this.lblIdPrompt.AutoSize = true;
			this.lblIdPrompt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.lblIdPrompt.Location = new System.Drawing.Point(531, 166);
			this.lblIdPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblIdPrompt.Name = "lblIdPrompt";
			this.lblIdPrompt.Size = new System.Drawing.Size(87, 29);
			this.lblIdPrompt.TabIndex = 9;
			this.lblIdPrompt.Text = "Sale ID:";
			// 
			// pHPdbDataSet
			// 
			this.pHPdbDataSet.DataSetName = "PHPdbDataSet";
			this.pHPdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// ordersBindingSource
			// 
			this.ordersBindingSource.DataMember = "Orders";
			this.ordersBindingSource.DataSource = this.pHPdbDataSet;
			// 
			// ordersTableAdapter
			// 
			this.ordersTableAdapter.ClearBeforeFill = true;
			// 
			// lblWarning
			// 
			this.lblWarning.AutoSize = true;
			this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.lblWarning.ForeColor = System.Drawing.Color.Red;
			this.lblWarning.Location = new System.Drawing.Point(532, 231);
			this.lblWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblWarning.Name = "lblWarning";
			this.lblWarning.Size = new System.Drawing.Size(111, 20);
			this.lblWarning.TabIndex = 11;
			this.lblWarning.Text = "Invalid Sale ID";
			this.lblWarning.Visible = false;
			// 
			// txtIdInput
			// 
			this.txtIdInput.Location = new System.Drawing.Point(536, 200);
			this.txtIdInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtIdInput.Name = "txtIdInput";
			this.txtIdInput.Size = new System.Drawing.Size(148, 26);
			this.txtIdInput.TabIndex = 1;
			// 
			// Date
			// 
			this.Date.HeaderText = "Date";
			this.Date.MinimumWidth = 8;
			this.Date.Name = "Date";
			this.Date.Width = 150;
			// 
			// Quantity
			// 
			this.Quantity.HeaderText = "Quantity";
			this.Quantity.MinimumWidth = 8;
			this.Quantity.Name = "Quantity";
			this.Quantity.Width = 150;
			// 
			// ProductID
			// 
			this.ProductID.HeaderText = "Product ID";
			this.ProductID.MinimumWidth = 8;
			this.ProductID.Name = "ProductID";
			this.ProductID.Width = 150;
			// 
			// SaleID
			// 
			this.SaleID.HeaderText = "Sale ID";
			this.SaleID.MinimumWidth = 8;
			this.SaleID.Name = "SaleID";
			this.SaleID.Width = 150;
			// 
			// dgvDisplay
			// 
			this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleID,
            this.ProductID,
            this.Quantity,
            this.Date});
			this.dgvDisplay.Location = new System.Drawing.Point(281, 394);
			this.dgvDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvDisplay.Name = "dgvDisplay";
			this.dgvDisplay.RowHeadersWidth = 62;
			this.dgvDisplay.Size = new System.Drawing.Size(664, 111);
			this.dgvDisplay.TabIndex = 10;
			// 
			// frmDisplaySales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 692);
			this.Controls.Add(this.lblWarning);
			this.Controls.Add(this.dgvDisplay);
			this.Controls.Add(this.lblIdPrompt);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtIdInput);
			this.Controls.Add(this.btnExit);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmDisplaySales";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Display Sales";
			this.Load += new System.EventHandler(this.DisplaySales_Load);
			((System.ComponentModel.ISupportInitialize)(this.pHPdbDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblIdPrompt;
        private PHPdbDataSet pHPdbDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private PHPdbDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.TextBox txtIdInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleID;
        private System.Windows.Forms.DataGridView dgvDisplay;
    }
}