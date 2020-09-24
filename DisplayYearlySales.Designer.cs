namespace PHP
{
    partial class DisplayYearlySales
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
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblInvalidYear = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(675, 405);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 43);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back to Homepage";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(299, 31);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(82, 19);
            this.lblYear.TabIndex = 11;
            this.lblYear.Text = "Enter Year";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(289, 68);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(102, 20);
            this.txtYear.TabIndex = 18;
            // 
            // lblInvalidYear
            // 
            this.lblInvalidYear.AutoSize = true;
            this.lblInvalidYear.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidYear.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidYear.Location = new System.Drawing.Point(215, 102);
            this.lblInvalidYear.Name = "lblInvalidYear";
            this.lblInvalidYear.Size = new System.Drawing.Size(247, 15);
            this.lblInvalidYear.TabIndex = 20;
            this.lblInvalidYear.Text = "Invalid Year: Needs to be 4 digits (2020,1999)";
            this.lblInvalidYear.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(289, 120);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 34);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.AllowUserToAddRows = false;
            this.dgvDisplay.AllowUserToDeleteRows = false;
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(136, 157);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.ReadOnly = true;
            this.dgvDisplay.RowHeadersWidth = 62;
            this.dgvDisplay.Size = new System.Drawing.Size(440, 281);
            this.dgvDisplay.TabIndex = 22;
            // 
            // DisplayYearlySales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDisplay);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblInvalidYear);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.btnBack);
            this.Name = "DisplayYearlySales";
            this.Text = "DisplayYearlySales";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblInvalidYear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvDisplay;
    }
}