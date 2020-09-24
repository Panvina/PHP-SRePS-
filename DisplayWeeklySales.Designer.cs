namespace PHP
{
    partial class DisplayWeeklySales
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.lblWeek = new System.Windows.Forms.Label();
            this.lblInvalidYear = new System.Windows.Forms.Label();
            this.txtWeek = new System.Windows.Forms.TextBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.lblMonthError = new System.Windows.Forms.Label();
            this.tpDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(679, 404);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 43);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back to Homepage";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(338, 117);
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
            this.dgvDisplay.Location = new System.Drawing.Point(142, 157);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.ReadOnly = true;
            this.dgvDisplay.RowHeadersWidth = 62;
            this.dgvDisplay.Size = new System.Drawing.Size(440, 281);
            this.dgvDisplay.TabIndex = 22;
            // 
            // lblWeek
            // 
            this.lblWeek.AutoSize = true;
            this.lblWeek.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeek.Location = new System.Drawing.Point(405, 26);
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(145, 19);
            this.lblWeek.TabIndex = 11;
            this.lblWeek.Text = "Enter Week Number";
            // 
            // lblInvalidYear
            // 
            this.lblInvalidYear.AutoSize = true;
            this.lblInvalidYear.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidYear.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidYear.Location = new System.Drawing.Point(372, 96);
            this.lblInvalidYear.Name = "lblInvalidYear";
            this.lblInvalidYear.Size = new System.Drawing.Size(247, 15);
            this.lblInvalidYear.TabIndex = 20;
            this.lblInvalidYear.Text = "Invalid Year: Needs to be 4 digits (2020,1999)";
            this.lblInvalidYear.Visible = false;
            // 
            // txtWeek
            // 
            this.txtWeek.Location = new System.Drawing.Point(427, 60);
            this.txtWeek.Name = "txtWeek";
            this.txtWeek.Size = new System.Drawing.Size(102, 20);
            this.txtWeek.TabIndex = 18;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(249, 26);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(91, 19);
            this.lblMonth.TabIndex = 23;
            this.lblMonth.Text = "Enter Month";
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(253, 60);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(102, 20);
            this.txtMonth.TabIndex = 24;
            // 
            // lblMonthError
            // 
            this.lblMonthError.AutoSize = true;
            this.lblMonthError.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthError.ForeColor = System.Drawing.Color.Red;
            this.lblMonthError.Location = new System.Drawing.Point(242, 96);
            this.lblMonthError.Name = "lblMonthError";
            this.lblMonthError.Size = new System.Drawing.Size(113, 15);
            this.lblMonthError.TabIndex = 25;
            this.lblMonthError.Text = "Invalid Month: 01-12";
            this.lblMonthError.Visible = false;
            // 
            // tpDate
            // 
            this.tpDate.CalendarFont = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpDate.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpDate.Location = new System.Drawing.Point(476, 122);
            this.tpDate.Name = "tpDate";
            this.tpDate.Size = new System.Drawing.Size(202, 23);
            this.tpDate.TabIndex = 26;
            this.tpDate.ValueChanged += new System.EventHandler(this.tpDate_ValueChanged);
            // 
            // DisplayWeeklySales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tpDate);
            this.Controls.Add(this.lblMonthError);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.dgvDisplay);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblInvalidYear);
            this.Controls.Add(this.txtWeek);
            this.Controls.Add(this.lblWeek);
            this.Controls.Add(this.btnBack);
            this.Name = "DisplayWeeklySales";
            this.Text = "DisplayWeeklySales";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.Label lblWeek;
        private System.Windows.Forms.Label lblInvalidYear;
        private System.Windows.Forms.TextBox txtWeek;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label lblMonthError;
        private System.Windows.Forms.DateTimePicker tpDate;
    }
}