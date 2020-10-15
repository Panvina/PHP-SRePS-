namespace PHP
{
	partial class frmGenerateCSV
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
			this.dgvSum = new System.Windows.Forms.DataGridView();
			this.lblInvalidYear = new System.Windows.Forms.Label();
			this.dgvDisplay = new System.Windows.Forms.DataGridView();
			this.txtYear = new System.Windows.Forms.TextBox();
			this.lblMonth = new System.Windows.Forms.Label();
			this.lblInvalidMonth = new System.Windows.Forms.Label();
			this.txtMonth = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.lblYear = new System.Windows.Forms.Label();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnGen = new System.Windows.Forms.Button();
			this.grbGenerateReport = new System.Windows.Forms.GroupBox();
			this.grbRetrieveReport = new System.Windows.Forms.GroupBox();
			this.btnSummary = new System.Windows.Forms.Button();
			this.btnAllItems = new System.Windows.Forms.Button();
			this.lblSelReport = new System.Windows.Forms.Label();
			this.cmbSelectReport = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvSum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
			this.grbGenerateReport.SuspendLayout();
			this.grbRetrieveReport.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvSum
			// 
			this.dgvSum.AllowUserToAddRows = false;
			this.dgvSum.AllowUserToDeleteRows = false;
			this.dgvSum.AllowUserToResizeColumns = false;
			this.dgvSum.AllowUserToResizeRows = false;
			this.dgvSum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSum.Cursor = System.Windows.Forms.Cursors.Default;
			this.dgvSum.Location = new System.Drawing.Point(10, 452);
			this.dgvSum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvSum.MultiSelect = false;
			this.dgvSum.Name = "dgvSum";
			this.dgvSum.ReadOnly = true;
			this.dgvSum.RowHeadersVisible = false;
			this.dgvSum.RowHeadersWidth = 62;
			this.dgvSum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSum.Size = new System.Drawing.Size(510, 432);
			this.dgvSum.TabIndex = 30;
			// 
			// lblInvalidYear
			// 
			this.lblInvalidYear.AutoSize = true;
			this.lblInvalidYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.lblInvalidYear.ForeColor = System.Drawing.Color.Red;
			this.lblInvalidYear.Location = new System.Drawing.Point(3, 198);
			this.lblInvalidYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblInvalidYear.Name = "lblInvalidYear";
			this.lblInvalidYear.Size = new System.Drawing.Size(92, 20);
			this.lblInvalidYear.TabIndex = 29;
			this.lblInvalidYear.Text = "Invalid Year";
			this.lblInvalidYear.Visible = false;
			this.lblInvalidYear.Click += new System.EventHandler(this.lblInvalidYear_Click);
			// 
			// dgvDisplay
			// 
			this.dgvDisplay.AllowUserToAddRows = false;
			this.dgvDisplay.AllowUserToDeleteRows = false;
			this.dgvDisplay.AllowUserToResizeColumns = false;
			this.dgvDisplay.AllowUserToResizeRows = false;
			this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDisplay.Cursor = System.Windows.Forms.Cursors.Default;
			this.dgvDisplay.Location = new System.Drawing.Point(10, 11);
			this.dgvDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvDisplay.MultiSelect = false;
			this.dgvDisplay.Name = "dgvDisplay";
			this.dgvDisplay.ReadOnly = true;
			this.dgvDisplay.RowHeadersVisible = false;
			this.dgvDisplay.RowHeadersWidth = 62;
			this.dgvDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDisplay.Size = new System.Drawing.Size(510, 432);
			this.dgvDisplay.TabIndex = 28;
			// 
			// txtYear
			// 
			this.txtYear.Location = new System.Drawing.Point(9, 164);
			this.txtYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtYear.Name = "txtYear";
			this.txtYear.Size = new System.Drawing.Size(161, 26);
			this.txtYear.TabIndex = 1;
			this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
			// 
			// lblMonth
			// 
			this.lblMonth.AutoSize = true;
			this.lblMonth.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.lblMonth.Location = new System.Drawing.Point(1, 21);
			this.lblMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMonth.Name = "lblMonth";
			this.lblMonth.Size = new System.Drawing.Size(140, 29);
			this.lblMonth.TabIndex = 26;
			this.lblMonth.Text = "Enter Month";
			// 
			// lblInvalidMonth
			// 
			this.lblInvalidMonth.AutoSize = true;
			this.lblInvalidMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.lblInvalidMonth.ForeColor = System.Drawing.Color.Red;
			this.lblInvalidMonth.Location = new System.Drawing.Point(3, 88);
			this.lblInvalidMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblInvalidMonth.Name = "lblInvalidMonth";
			this.lblInvalidMonth.Size = new System.Drawing.Size(152, 20);
			this.lblInvalidMonth.TabIndex = 25;
			this.lblInvalidMonth.Text = "Invalid Month: 01-12";
			this.lblInvalidMonth.Visible = false;
			// 
			// txtMonth
			// 
			this.txtMonth.Location = new System.Drawing.Point(9, 55);
			this.txtMonth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtMonth.Name = "txtMonth";
			this.txtMonth.Size = new System.Drawing.Size(161, 26);
			this.txtMonth.TabIndex = 0;
			this.txtMonth.TextChanged += new System.EventHandler(this.txtMonth_TextChanged);
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnSearch.Location = new System.Drawing.Point(9, 239);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(190, 60);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// lblYear
			// 
			this.lblYear.AutoSize = true;
			this.lblYear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.lblYear.Location = new System.Drawing.Point(1, 130);
			this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblYear.Name = "lblYear";
			this.lblYear.Size = new System.Drawing.Size(115, 29);
			this.lblYear.TabIndex = 22;
			this.lblYear.Text = "Enter Year";
			// 
			// btnBack
			// 
			this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnBack.Location = new System.Drawing.Point(535, 802);
			this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(200, 82);
			this.btnBack.TabIndex = 4;
			this.btnBack.Text = "Back to Homepage";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
			// 
			// btnGen
			// 
			this.btnGen.Enabled = false;
			this.btnGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnGen.Location = new System.Drawing.Point(9, 309);
			this.btnGen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnGen.Name = "btnGen";
			this.btnGen.Size = new System.Drawing.Size(190, 60);
			this.btnGen.TabIndex = 3;
			this.btnGen.Text = "Generate Report";
			this.btnGen.UseVisualStyleBackColor = true;
			this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
			// 
			// grbGenerateReport
			// 
			this.grbGenerateReport.Controls.Add(this.btnGen);
			this.grbGenerateReport.Controls.Add(this.lblInvalidYear);
			this.grbGenerateReport.Controls.Add(this.txtYear);
			this.grbGenerateReport.Controls.Add(this.lblMonth);
			this.grbGenerateReport.Controls.Add(this.lblInvalidMonth);
			this.grbGenerateReport.Controls.Add(this.txtMonth);
			this.grbGenerateReport.Controls.Add(this.btnSearch);
			this.grbGenerateReport.Controls.Add(this.lblYear);
			this.grbGenerateReport.Location = new System.Drawing.Point(529, 12);
			this.grbGenerateReport.Name = "grbGenerateReport";
			this.grbGenerateReport.Size = new System.Drawing.Size(206, 384);
			this.grbGenerateReport.TabIndex = 31;
			this.grbGenerateReport.TabStop = false;
			this.grbGenerateReport.Text = "Generate";
			this.grbGenerateReport.Enter += new System.EventHandler(this.grbGenerateReport_Enter);
			// 
			// grbRetrieveReport
			// 
			this.grbRetrieveReport.Controls.Add(this.btnSummary);
			this.grbRetrieveReport.Controls.Add(this.btnAllItems);
			this.grbRetrieveReport.Controls.Add(this.lblSelReport);
			this.grbRetrieveReport.Controls.Add(this.cmbSelectReport);
			this.grbRetrieveReport.Location = new System.Drawing.Point(529, 402);
			this.grbRetrieveReport.Name = "grbRetrieveReport";
			this.grbRetrieveReport.Size = new System.Drawing.Size(206, 251);
			this.grbRetrieveReport.TabIndex = 32;
			this.grbRetrieveReport.TabStop = false;
			this.grbRetrieveReport.Text = "Retrieve";
			// 
			// btnSummary
			// 
			this.btnSummary.Enabled = false;
			this.btnSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnSummary.Location = new System.Drawing.Point(9, 175);
			this.btnSummary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSummary.Name = "btnSummary";
			this.btnSummary.Size = new System.Drawing.Size(190, 60);
			this.btnSummary.TabIndex = 31;
			this.btnSummary.Text = "Summary";
			this.btnSummary.UseVisualStyleBackColor = true;
			this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
			// 
			// btnAllItems
			// 
			this.btnAllItems.Enabled = false;
			this.btnAllItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnAllItems.Location = new System.Drawing.Point(9, 105);
			this.btnAllItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnAllItems.Name = "btnAllItems";
			this.btnAllItems.Size = new System.Drawing.Size(190, 60);
			this.btnAllItems.TabIndex = 30;
			this.btnAllItems.Text = "All Items";
			this.btnAllItems.UseVisualStyleBackColor = true;
			this.btnAllItems.Click += new System.EventHandler(this.btnAllItems_Click);
			// 
			// lblSelReport
			// 
			this.lblSelReport.AutoSize = true;
			this.lblSelReport.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.lblSelReport.Location = new System.Drawing.Point(7, 22);
			this.lblSelReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSelReport.Name = "lblSelReport";
			this.lblSelReport.Size = new System.Drawing.Size(146, 29);
			this.lblSelReport.TabIndex = 30;
			this.lblSelReport.Text = "Select Report";
			// 
			// cmbSelectReport
			// 
			this.cmbSelectReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSelectReport.FormattingEnabled = true;
			this.cmbSelectReport.Location = new System.Drawing.Point(9, 59);
			this.cmbSelectReport.Name = "cmbSelectReport";
			this.cmbSelectReport.Size = new System.Drawing.Size(190, 28);
			this.cmbSelectReport.TabIndex = 0;
			this.cmbSelectReport.SelectedIndexChanged += new System.EventHandler(this.cmbSelectReport_SelectedIndexChanged);
			// 
			// frmGenerateCSV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(744, 898);
			this.Controls.Add(this.grbRetrieveReport);
			this.Controls.Add(this.grbGenerateReport);
			this.Controls.Add(this.dgvSum);
			this.Controls.Add(this.dgvDisplay);
			this.Controls.Add(this.btnBack);
			this.Name = "frmGenerateCSV";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " ";
			this.Load += new System.EventHandler(this.frmGenerateCSV_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvSum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
			this.grbGenerateReport.ResumeLayout(false);
			this.grbGenerateReport.PerformLayout();
			this.grbRetrieveReport.ResumeLayout(false);
			this.grbRetrieveReport.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvSum;
		private System.Windows.Forms.Label lblInvalidYear;
		private System.Windows.Forms.DataGridView dgvDisplay;
		private System.Windows.Forms.TextBox txtYear;
		private System.Windows.Forms.Label lblMonth;
		private System.Windows.Forms.Label lblInvalidMonth;
		private System.Windows.Forms.TextBox txtMonth;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Label lblYear;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnGen;
		private System.Windows.Forms.GroupBox grbGenerateReport;
		private System.Windows.Forms.GroupBox grbRetrieveReport;
		private System.Windows.Forms.Label lblSelReport;
		private System.Windows.Forms.ComboBox cmbSelectReport;
		private System.Windows.Forms.Button btnSummary;
		private System.Windows.Forms.Button btnAllItems;
	}
}