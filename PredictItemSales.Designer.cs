namespace PHP
{
    partial class PredictItemSales
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblChooseProduct = new System.Windows.Forms.Label();
            this.lblInvalidYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblMonthError = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.lblPrediction = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPredict = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(457, 394);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 53);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back to Homepage";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(70, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(31, 186);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(200, 20);
            this.txtProductName.TabIndex = 7;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(31, 115);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(200, 20);
            this.txtProductID.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(85, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "ProductID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblChooseProduct
            // 
            this.lblChooseProduct.AutoSize = true;
            this.lblChooseProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblChooseProduct.Location = new System.Drawing.Point(12, 61);
            this.lblChooseProduct.Name = "lblChooseProduct";
            this.lblChooseProduct.Size = new System.Drawing.Size(288, 19);
            this.lblChooseProduct.TabIndex = 9;
            this.lblChooseProduct.Text = "Choose the following product to predict:";
            // 
            // lblInvalidYear
            // 
            this.lblInvalidYear.AutoSize = true;
            this.lblInvalidYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblInvalidYear.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidYear.Location = new System.Drawing.Point(301, 209);
            this.lblInvalidYear.Name = "lblInvalidYear";
            this.lblInvalidYear.Size = new System.Drawing.Size(223, 13);
            this.lblInvalidYear.TabIndex = 25;
            this.lblInvalidYear.Text = "Invalid Year: Needs to be 4 digits (2020,1999)";
            this.lblInvalidYear.Visible = false;
            this.lblInvalidYear.Click += new System.EventHandler(this.lblInvalidYear_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(352, 186);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(102, 20);
            this.txtYear.TabIndex = 24;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblMonth.Location = new System.Drawing.Point(349, 93);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(97, 19);
            this.lblMonth.TabIndex = 23;
            this.lblMonth.Text = "Enter Month";
            // 
            // lblMonthError
            // 
            this.lblMonthError.AutoSize = true;
            this.lblMonthError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblMonthError.ForeColor = System.Drawing.Color.Red;
            this.lblMonthError.Location = new System.Drawing.Point(350, 137);
            this.lblMonthError.Name = "lblMonthError";
            this.lblMonthError.Size = new System.Drawing.Size(104, 13);
            this.lblMonthError.TabIndex = 22;
            this.lblMonthError.Text = "Invalid Month: 01-12";
            this.lblMonthError.Visible = false;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(352, 115);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(102, 20);
            this.txtMonth.TabIndex = 21;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblYear.Location = new System.Drawing.Point(349, 164);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(79, 19);
            this.lblYear.TabIndex = 20;
            this.lblYear.Text = "Enter Year";
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.AutoSize = true;
            this.lblSelectDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblSelectDate.Location = new System.Drawing.Point(336, 61);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(168, 19);
            this.lblSelectDate.TabIndex = 26;
            this.lblSelectDate.Text = "Select Month and Year ";
            // 
            // lblPrediction
            // 
            this.lblPrediction.AutoSize = true;
            this.lblPrediction.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblPrediction.Location = new System.Drawing.Point(198, 327);
            this.lblPrediction.Name = "lblPrediction";
            this.lblPrediction.Size = new System.Drawing.Size(143, 19);
            this.lblPrediction.TabIndex = 27;
            this.lblPrediction.Text = "Previous Item sales:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 359);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 20);
            this.textBox1.TabIndex = 28;
            // 
            // btnPredict
            // 
            this.btnPredict.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnPredict.Location = new System.Drawing.Point(202, 269);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(133, 34);
            this.btnPredict.TabIndex = 29;
            this.btnPredict.Text = "Predict";
            this.btnPredict.UseVisualStyleBackColor = true;
            // 
            // PredictItemSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.btnPredict);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPrediction);
            this.Controls.Add(this.lblSelectDate);
            this.Controls.Add(this.lblInvalidYear);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblMonthError);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblChooseProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Name = "PredictItemSales";
            this.Text = "PredictItemSales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblChooseProduct;
        private System.Windows.Forms.Label lblInvalidYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblMonthError;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblSelectDate;
        private System.Windows.Forms.Label lblPrediction;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPredict;
    }
}