namespace PHP
{
    partial class frmDisplayMonthlySales
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
			this.btnBack = new System.Windows.Forms.Button();
			this.lblYear = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtMonth = new System.Windows.Forms.TextBox();
			this.lblMonthError = new System.Windows.Forms.Label();
			this.lblMonth = new System.Windows.Forms.Label();
			this.txtYear = new System.Windows.Forms.TextBox();
			this.lblInvalidYear = new System.Windows.Forms.Label();
			this.dgvDisplay = new System.Windows.Forms.DataGridView();
			this.dgvSum = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSum)).BeginInit();
			this.SuspendLayout();
			// 
			// btnBack
			// 
			this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnBack.Location = new System.Drawing.Point(658, 808);
			this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(200, 82);
			this.btnBack.TabIndex = 2;
			this.btnBack.Text = "Back to Homepage";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// lblYear
			// 
			this.lblYear.AutoSize = true;
			this.lblYear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.lblYear.Location = new System.Drawing.Point(534, 134);
			this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblYear.Name = "lblYear";
			this.lblYear.Size = new System.Drawing.Size(115, 29);
			this.lblYear.TabIndex = 10;
			this.lblYear.Text = "Enter Year";
			this.lblYear.Click += new System.EventHandler(this.lblYear_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnSearch.Location = new System.Drawing.Point(542, 243);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(132, 52);
			this.btnSearch.TabIndex = 12;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtMonth
			// 
			this.txtMonth.Location = new System.Drawing.Point(538, 58);
			this.txtMonth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtMonth.Name = "txtMonth";
			this.txtMonth.Size = new System.Drawing.Size(151, 26);
			this.txtMonth.TabIndex = 14;
			// 
			// lblMonthError
			// 
			this.lblMonthError.AutoSize = true;
			this.lblMonthError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.lblMonthError.ForeColor = System.Drawing.Color.Red;
			this.lblMonthError.Location = new System.Drawing.Point(536, 92);
			this.lblMonthError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMonthError.Name = "lblMonthError";
			this.lblMonthError.Size = new System.Drawing.Size(152, 20);
			this.lblMonthError.TabIndex = 15;
			this.lblMonthError.Text = "Invalid Month: 01-12";
			this.lblMonthError.Visible = false;
			// 
			// lblMonth
			// 
			this.lblMonth.AutoSize = true;
			this.lblMonth.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.lblMonth.Location = new System.Drawing.Point(534, 25);
			this.lblMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMonth.Name = "lblMonth";
			this.lblMonth.Size = new System.Drawing.Size(140, 29);
			this.lblMonth.TabIndex = 16;
			this.lblMonth.Text = "Enter Month";
			// 
			// txtYear
			// 
			this.txtYear.Location = new System.Drawing.Point(538, 168);
			this.txtYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtYear.Name = "txtYear";
			this.txtYear.Size = new System.Drawing.Size(151, 26);
			this.txtYear.TabIndex = 17;
			this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
			// 
			// lblInvalidYear
			// 
			this.lblInvalidYear.AutoSize = true;
			this.lblInvalidYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.lblInvalidYear.ForeColor = System.Drawing.Color.Red;
			this.lblInvalidYear.Location = new System.Drawing.Point(536, 202);
			this.lblInvalidYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblInvalidYear.Name = "lblInvalidYear";
			this.lblInvalidYear.Size = new System.Drawing.Size(330, 20);
			this.lblInvalidYear.TabIndex = 19;
			this.lblInvalidYear.Text = "Invalid Year: Needs to be 4 digits (2020,1999)";
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
			this.dgvDisplay.Enabled = false;
			this.dgvDisplay.Location = new System.Drawing.Point(14, 14);
			this.dgvDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvDisplay.MultiSelect = false;
			this.dgvDisplay.Name = "dgvDisplay";
			this.dgvDisplay.ReadOnly = true;
			this.dgvDisplay.RowHeadersWidth = 62;
			this.dgvDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDisplay.Size = new System.Drawing.Size(510, 432);
			this.dgvDisplay.TabIndex = 18;
			// 
			// dgvSum
			// 
			this.dgvSum.AllowUserToAddRows = false;
			this.dgvSum.AllowUserToDeleteRows = false;
			this.dgvSum.AllowUserToResizeColumns = false;
			this.dgvSum.AllowUserToResizeRows = false;
			this.dgvSum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSum.Cursor = System.Windows.Forms.Cursors.Default;
			this.dgvSum.Enabled = false;
			this.dgvSum.Location = new System.Drawing.Point(14, 455);
			this.dgvSum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvSum.MultiSelect = false;
			this.dgvSum.Name = "dgvSum";
			this.dgvSum.ReadOnly = true;
			this.dgvSum.RowHeadersWidth = 62;
			this.dgvSum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSum.Size = new System.Drawing.Size(510, 432);
			this.dgvSum.TabIndex = 20;
			// 
			// frmDisplayMonthlySales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(872, 902);
			this.Controls.Add(this.dgvSum);
			this.Controls.Add(this.lblInvalidYear);
			this.Controls.Add(this.dgvDisplay);
			this.Controls.Add(this.txtYear);
			this.Controls.Add(this.lblMonth);
			this.Controls.Add(this.lblMonthError);
			this.Controls.Add(this.txtMonth);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.lblYear);
			this.Controls.Add(this.btnBack);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmDisplayMonthlySales";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Monthly Sales Report";
			this.Load += new System.EventHandler(this.frmDisplayMonthlySales_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSum)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label lblMonthError;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblInvalidYear;
        private System.Windows.Forms.DataGridView dgvDisplay;
		private System.Windows.Forms.DataGridView dgvSum;
	}
}