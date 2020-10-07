namespace PHP
{
    partial class LowStockAlert
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.checkBoxNotifyHome = new System.Windows.Forms.CheckBox();
            this.checkBoxNotifyProd = new System.Windows.Forms.CheckBox();
            this.checkBoxNoNotify = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBackToHomepage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(63, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notify me when the quantity is below:";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(66, 89);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(237, 20);
            this.tbQuantity.TabIndex = 1;
            this.tbQuantity.Text = "0";
            // 
            // checkBoxNotifyHome
            // 
            this.checkBoxNotifyHome.AutoSize = true;
            this.checkBoxNotifyHome.Location = new System.Drawing.Point(66, 126);
            this.checkBoxNotifyHome.Name = "checkBoxNotifyHome";
            this.checkBoxNotifyHome.Size = new System.Drawing.Size(156, 17);
            this.checkBoxNotifyHome.TabIndex = 2;
            this.checkBoxNotifyHome.Text = "Notify me on the homepage";
            this.checkBoxNotifyHome.UseVisualStyleBackColor = true;
            // 
            // checkBoxNotifyProd
            // 
            this.checkBoxNotifyProd.AutoSize = true;
            this.checkBoxNotifyProd.Location = new System.Drawing.Point(66, 150);
            this.checkBoxNotifyProd.Name = "checkBoxNotifyProd";
            this.checkBoxNotifyProd.Size = new System.Drawing.Size(157, 17);
            this.checkBoxNotifyProd.TabIndex = 3;
            this.checkBoxNotifyProd.Text = "Notify me on the product list";
            this.checkBoxNotifyProd.UseVisualStyleBackColor = true;
            // 
            // checkBoxNoNotify
            // 
            this.checkBoxNoNotify.AutoSize = true;
            this.checkBoxNoNotify.Location = new System.Drawing.Point(66, 173);
            this.checkBoxNoNotify.Name = "checkBoxNoNotify";
            this.checkBoxNoNotify.Size = new System.Drawing.Size(103, 17);
            this.checkBoxNoNotify.TabIndex = 4;
            this.checkBoxNoNotify.Text = "Do not notify me";
            this.checkBoxNoNotify.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(66, 210);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(237, 32);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBackToHomepage
            // 
            this.btnBackToHomepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnBackToHomepage.Location = new System.Drawing.Point(66, 248);
            this.btnBackToHomepage.Name = "btnBackToHomepage";
            this.btnBackToHomepage.Size = new System.Drawing.Size(237, 44);
            this.btnBackToHomepage.TabIndex = 6;
            this.btnBackToHomepage.Text = "Back to homepage";
            this.btnBackToHomepage.UseVisualStyleBackColor = true;
            this.btnBackToHomepage.Click += new System.EventHandler(this.btnBackToHomepage_Click);
            // 
            // LowStockAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 331);
            this.Controls.Add(this.btnBackToHomepage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.checkBoxNoNotify);
            this.Controls.Add(this.checkBoxNotifyProd);
            this.Controls.Add(this.checkBoxNotifyHome);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.label1);
            this.Name = "LowStockAlert";
            this.Text = "LowStockAlert";
            this.Load += new System.EventHandler(this.LowStockAlert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.CheckBox checkBoxNotifyHome;
        private System.Windows.Forms.CheckBox checkBoxNotifyProd;
        private System.Windows.Forms.CheckBox checkBoxNoNotify;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBackToHomepage;
    }
}