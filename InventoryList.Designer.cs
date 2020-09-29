namespace PHP
{
    partial class frmInventoryList
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
			this.dgvInventory = new System.Windows.Forms.DataGridView();
			this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pHPdbDataSet = new PHP.PHPdbDataSet();
			this.btnBack = new System.Windows.Forms.Button();
			this.inventoryTableAdapter = new PHP.PHPdbDataSetTableAdapters.InventoryTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pHPdbDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvInventory
			// 
			this.dgvInventory.AllowUserToAddRows = false;
			this.dgvInventory.AllowUserToDeleteRows = false;
			this.dgvInventory.AllowUserToResizeColumns = false;
			this.dgvInventory.AllowUserToResizeRows = false;
			this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvInventory.Location = new System.Drawing.Point(13, 14);
			this.dgvInventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvInventory.Name = "dgvInventory";
			this.dgvInventory.ReadOnly = true;
			this.dgvInventory.RowHeadersVisible = false;
			this.dgvInventory.RowHeadersWidth = 62;
			this.dgvInventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvInventory.Size = new System.Drawing.Size(622, 505);
			this.dgvInventory.TabIndex = 0;
			this.dgvInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// inventoryBindingSource
			// 
			this.inventoryBindingSource.DataMember = "Inventory";
			this.inventoryBindingSource.DataSource = this.pHPdbDataSet;
			// 
			// pHPdbDataSet
			// 
			this.pHPdbDataSet.DataSetName = "PHPdbDataSet";
			this.pHPdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// btnBack
			// 
			this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnBack.Location = new System.Drawing.Point(435, 550);
			this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(200, 81);
			this.btnBack.TabIndex = 1;
			this.btnBack.Text = "Back to Homepage";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// inventoryTableAdapter
			// 
			this.inventoryTableAdapter.ClearBeforeFill = true;
			// 
			// frmInventoryList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(648, 645);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.dgvInventory);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmInventoryList";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Inventory List";
			this.Load += new System.EventHandler(this.InventoryList_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pHPdbDataSet)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Button btnBack;
        private PHPdbDataSet pHPdbDataSet;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private PHPdbDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
	}
}