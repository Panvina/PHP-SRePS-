namespace PHP
{
    partial class frmLogin
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
			this.Connect = new System.Windows.Forms.Button();
			this.lblLogin = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Connect
			// 
			this.Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.Connect.Location = new System.Drawing.Point(217, 228);
			this.Connect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Connect.Name = "Connect";
			this.Connect.Size = new System.Drawing.Size(280, 92);
			this.Connect.TabIndex = 0;
			this.Connect.Text = "Connect";
			this.Connect.UseVisualStyleBackColor = true;
			this.Connect.Click += new System.EventHandler(this.Connect_Click);
			// 
			// lblLogin
			// 
			this.lblLogin.AutoSize = true;
			this.lblLogin.Font = new System.Drawing.Font("Calibri", 15F);
			this.lblLogin.Location = new System.Drawing.Point(108, 175);
			this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblLogin.Name = "lblLogin";
			this.lblLogin.Size = new System.Drawing.Size(543, 37);
			this.lblLogin.TabIndex = 3;
			this.lblLogin.Text = "Press connect to access the invoice system";
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(720, 569);
			this.Controls.Add(this.lblLogin);
			this.Controls.Add(this.Connect);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PHP-SRePS";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Label lblLogin;
    }
}