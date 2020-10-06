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
			((System.ComponentModel.ISupportInitialize)(this.dgvSum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
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
			this.lblInvalidYear.Location = new System.Drawing.Point(532, 199);
			this.lblInvalidYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblInvalidYear.Name = "lblInvalidYear";
			this.lblInvalidYear.Size = new System.Drawing.Size(240, 20);
			this.lblInvalidYear.TabIndex = 29;
			this.lblInvalidYear.Text = "Invalid Year: Needs to be 4 digits";
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
			this.txtYear.Location = new System.Drawing.Point(534, 165);
			this.txtYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtYear.Name = "txtYear";
			this.txtYear.Size = new System.Drawing.Size(151, 26);
			this.txtYear.TabIndex = 1;
			this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
			// 
			// lblMonth
			// 
			this.lblMonth.AutoSize = true;
			this.lblMonth.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.lblMonth.Location = new System.Drawing.Point(530, 22);
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
			this.lblInvalidMonth.Location = new System.Drawing.Point(532, 89);
			this.lblInvalidMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblInvalidMonth.Name = "lblInvalidMonth";
			this.lblInvalidMonth.Size = new System.Drawing.Size(152, 20);
			this.lblInvalidMonth.TabIndex = 25;
			this.lblInvalidMonth.Text = "Invalid Month: 01-12";
			this.lblInvalidMonth.Visible = false;
			// 
			// txtMonth
			// 
			this.txtMonth.Location = new System.Drawing.Point(534, 55);
			this.txtMonth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtMonth.Name = "txtMonth";
			this.txtMonth.Size = new System.Drawing.Size(151, 26);
			this.txtMonth.TabIndex = 0;
			this.txtMonth.TextChanged += new System.EventHandler(this.txtMonth_TextChanged);
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnSearch.Location = new System.Drawing.Point(538, 240);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(161, 60);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// lblYear
			// 
			this.lblYear.AutoSize = true;
			this.lblYear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.lblYear.Location = new System.Drawing.Point(530, 131);
			this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblYear.Name = "lblYear";
			this.lblYear.Size = new System.Drawing.Size(115, 29);
			this.lblYear.TabIndex = 22;
			this.lblYear.Text = "Enter Year";
			// 
			// btnBack
			// 
			this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnBack.Location = new System.Drawing.Point(654, 805);
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
			this.btnGen.Location = new System.Drawing.Point(538, 310);
			this.btnGen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnGen.Name = "btnGen";
			this.btnGen.Size = new System.Drawing.Size(161, 60);
			this.btnGen.TabIndex = 3;
			this.btnGen.Text = "Generate Report";
			this.btnGen.UseVisualStyleBackColor = true;
			this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
			// 
			// frmGenerateCSV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(872, 898);
			this.Controls.Add(this.btnGen);
			this.Controls.Add(this.dgvSum);
			this.Controls.Add(this.lblInvalidYear);
			this.Controls.Add(this.dgvDisplay);
			this.Controls.Add(this.txtYear);
			this.Controls.Add(this.lblMonth);
			this.Controls.Add(this.lblInvalidMonth);
			this.Controls.Add(this.txtMonth);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.lblYear);
			this.Controls.Add(this.btnBack);
			this.Name = "frmGenerateCSV";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Generate Report";
			this.Load += new System.EventHandler(this.frmGenerateCSV_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvSum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

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
	}
}