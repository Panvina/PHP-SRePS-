namespace PHP
{
    partial class frmAllSales
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
			this.dgvSales = new System.Windows.Forms.DataGridView();
			this.salesIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pHPdbDataSet = new PHP.PHPdbDataSet();
			this.btnBack = new System.Windows.Forms.Button();
			this.salesTableAdapter = new PHP.PHPdbDataSetTableAdapters.SalesTableAdapter();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pHPdbDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvSales
			// 
			this.dgvSales.AllowUserToAddRows = false;
			this.dgvSales.AllowUserToDeleteRows = false;
			this.dgvSales.AutoGenerateColumns = false;
			this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salesIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
			this.dgvSales.DataSource = this.salesBindingSource;
			this.dgvSales.Location = new System.Drawing.Point(70, 126);
			this.dgvSales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvSales.Name = "dgvSales";
			this.dgvSales.ReadOnly = true;
			this.dgvSales.RowHeadersWidth = 62;
			this.dgvSales.Size = new System.Drawing.Size(660, 432);
			this.dgvSales.TabIndex = 0;
			this.dgvSales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSales_CellContentClick);
			// 
			// salesIDDataGridViewTextBoxColumn
			// 
			this.salesIDDataGridViewTextBoxColumn.DataPropertyName = "SalesID";
			this.salesIDDataGridViewTextBoxColumn.HeaderText = "SalesID";
			this.salesIDDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.salesIDDataGridViewTextBoxColumn.Name = "salesIDDataGridViewTextBoxColumn";
			this.salesIDDataGridViewTextBoxColumn.ReadOnly = true;
			this.salesIDDataGridViewTextBoxColumn.Width = 50;
			// 
			// productIDDataGridViewTextBoxColumn
			// 
			this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
			this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
			this.productIDDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
			this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
			this.productIDDataGridViewTextBoxColumn.Width = 150;
			// 
			// quantityDataGridViewTextBoxColumn
			// 
			this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
			this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
			this.quantityDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
			this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
			this.quantityDataGridViewTextBoxColumn.Width = 50;
			// 
			// dateDataGridViewTextBoxColumn
			// 
			this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
			this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
			this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
			this.dateDataGridViewTextBoxColumn.ReadOnly = true;
			this.dateDataGridViewTextBoxColumn.Width = 150;
			// 
			// salesBindingSource
			// 
			this.salesBindingSource.DataMember = "Sales";
			this.salesBindingSource.DataSource = this.pHPdbDataSet;
			// 
			// pHPdbDataSet
			// 
			this.pHPdbDataSet.DataSetName = "PHPdbDataSet";
			this.pHPdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// btnBack
			// 
			this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnBack.Location = new System.Drawing.Point(530, 577);
			this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(200, 81);
			this.btnBack.TabIndex = 1;
			this.btnBack.Text = "Back to Homepage";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// salesTableAdapter
			// 
			this.salesTableAdapter.ClearBeforeFill = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(65, 38);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 29);
			this.label1.TabIndex = 2;
			this.label1.Text = "Search Sales ID";
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Location = new System.Drawing.Point(70, 72);
			this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(148, 26);
			this.textBoxSearch.TabIndex = 3;
			this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
			// 
			// frmAllSales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(818, 672);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.dgvSales);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmAllSales";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "All Sales";
			this.Load += new System.EventHandler(this.AllSales_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pHPdbDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Button btnBack;
        private PHPdbDataSet pHPdbDataSet;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private PHPdbDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn salesIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}