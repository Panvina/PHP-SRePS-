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
			((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
			this.SuspendLayout();
			// 
			// btnBack
			// 
			this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnBack.Location = new System.Drawing.Point(987, 597);
			this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(200, 81);
			this.btnBack.TabIndex = 2;
			this.btnBack.Text = "Back to Homepage";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// lblYear
			// 
			this.lblYear.AutoSize = true;
			this.lblYear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.lblYear.Location = new System.Drawing.Point(569, 49);
			this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblYear.Name = "lblYear";
			this.lblYear.Size = new System.Drawing.Size(115, 29);
			this.lblYear.TabIndex = 10;
			this.lblYear.Text = "Enter Year";
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnSearch.Location = new System.Drawing.Point(478, 163);
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
			this.txtMonth.Location = new System.Drawing.Point(388, 82);
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
			this.lblMonthError.Location = new System.Drawing.Point(384, 117);
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
			this.lblMonth.Location = new System.Drawing.Point(383, 49);
			this.lblMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMonth.Name = "lblMonth";
			this.lblMonth.Size = new System.Drawing.Size(140, 29);
			this.lblMonth.TabIndex = 16;
			this.lblMonth.Text = "Enter Month";
			// 
			// txtYear
			// 
			this.txtYear.Location = new System.Drawing.Point(574, 82);
			this.txtYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtYear.Name = "txtYear";
			this.txtYear.Size = new System.Drawing.Size(151, 26);
			this.txtYear.TabIndex = 17;
			// 
			// lblInvalidYear
			// 
			this.lblInvalidYear.AutoSize = true;
			this.lblInvalidYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.lblInvalidYear.ForeColor = System.Drawing.Color.Red;
			this.lblInvalidYear.Location = new System.Drawing.Point(570, 117);
			this.lblInvalidYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblInvalidYear.Name = "lblInvalidYear";
			this.lblInvalidYear.Size = new System.Drawing.Size(330, 20);
			this.lblInvalidYear.TabIndex = 19;
			this.lblInvalidYear.Text = "Invalid Year: Needs to be 4 digits (2020,1999)";
			this.lblInvalidYear.Visible = false;
			// 
			// dgvDisplay
			// 
			this.dgvDisplay.AllowUserToAddRows = false;
			this.dgvDisplay.AllowUserToDeleteRows = false;
			this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDisplay.Location = new System.Drawing.Point(240, 225);
			this.dgvDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvDisplay.Name = "dgvDisplay";
			this.dgvDisplay.ReadOnly = true;
			this.dgvDisplay.RowHeadersWidth = 62;
			this.dgvDisplay.Size = new System.Drawing.Size(660, 432);
			this.dgvDisplay.TabIndex = 18;
			// 
			// frmDisplayMonthlySales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 692);
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
			((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
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
    }
}