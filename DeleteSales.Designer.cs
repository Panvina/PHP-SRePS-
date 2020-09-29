namespace PHP
{
    partial class frmDeleteSales
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
			this.btnDelete = new System.Windows.Forms.Button();
			this.txtID = new System.Windows.Forms.TextBox();
			this.lblID = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnExit.Location = new System.Drawing.Point(46, 311);
			this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(300, 75);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "Back to home page";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnDelete.Location = new System.Drawing.Point(46, 231);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(300, 55);
			this.btnDelete.TabIndex = 6;
			this.btnDelete.Text = "Delete Record";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(45, 100);
			this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(300, 26);
			this.txtID.TabIndex = 7;
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			this.lblID.Location = new System.Drawing.Point(41, 67);
			this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(90, 29);
			this.lblID.TabIndex = 8;
			this.lblID.Text = "Sales ID";
			// 
			// frmDeleteSales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(398, 422);
			this.Controls.Add(this.lblID);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnExit);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmDeleteSales";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Delete Sales";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
    }
}