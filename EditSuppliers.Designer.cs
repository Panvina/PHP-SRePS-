namespace PHP
{
    partial class frmEditSuppliers
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
            this.lblRecordResult = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCompanyPhone = new System.Windows.Forms.Label();
            this.lblCompanyEmail = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.cmbSupplierID = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblNameError = new System.Windows.Forms.Label();
            this.lblEmailError = new System.Windows.Forms.Label();
            this.lblPhoneError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRecordResult
            // 
            this.lblRecordResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRecordResult.AutoSize = true;
            this.lblRecordResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordResult.Location = new System.Drawing.Point(66, 300);
            this.lblRecordResult.Name = "lblRecordResult";
            this.lblRecordResult.Size = new System.Drawing.Size(188, 17);
            this.lblRecordResult.TabIndex = 32;
            this.lblRecordResult.Text = "Success! X records affected.";
            this.lblRecordResult.Visible = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEdit.Location = new System.Drawing.Point(54, 335);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(200, 36);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit Record";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(55, 182);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(201, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(55, 116);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(201, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblCompanyPhone
            // 
            this.lblCompanyPhone.AutoSize = true;
            this.lblCompanyPhone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblCompanyPhone.Location = new System.Drawing.Point(50, 223);
            this.lblCompanyPhone.Name = "lblCompanyPhone";
            this.lblCompanyPhone.Size = new System.Drawing.Size(181, 19);
            this.lblCompanyPhone.TabIndex = 25;
            this.lblCompanyPhone.Text = "Company Phone Number";
            // 
            // lblCompanyEmail
            // 
            this.lblCompanyEmail.AutoSize = true;
            this.lblCompanyEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblCompanyEmail.Location = new System.Drawing.Point(51, 161);
            this.lblCompanyEmail.Name = "lblCompanyEmail";
            this.lblCompanyEmail.Size = new System.Drawing.Size(114, 19);
            this.lblCompanyEmail.TabIndex = 24;
            this.lblCompanyEmail.Text = "Company Email";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblCompanyName.Location = new System.Drawing.Point(51, 95);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(117, 19);
            this.lblCompanyName.TabIndex = 23;
            this.lblCompanyName.Text = "Company Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblID.Location = new System.Drawing.Point(51, 32);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(88, 19);
            this.lblID.TabIndex = 22;
            this.lblID.Text = "Supplier ID:";
            // 
            // cmbSupplierID
            // 
            this.cmbSupplierID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplierID.FormattingEnabled = true;
            this.cmbSupplierID.ItemHeight = 13;
            this.cmbSupplierID.Location = new System.Drawing.Point(54, 54);
            this.cmbSupplierID.Name = "cmbSupplierID";
            this.cmbSupplierID.Size = new System.Drawing.Size(201, 21);
            this.cmbSupplierID.TabIndex = 21;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(54, 377);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 36);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Back to home page";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(57, 245);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(201, 20);
            this.txtPhone.TabIndex = 4;
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameError.ForeColor = System.Drawing.Color.Red;
            this.lblNameError.Location = new System.Drawing.Point(54, 139);
            this.lblNameError.MaximumSize = new System.Drawing.Size(200, 65);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(69, 13);
            this.lblNameError.TabIndex = 69;
            this.lblNameError.Text = "Invalid Name";
            this.lblNameError.Visible = false;
            // 
            // lblEmailError
            // 
            this.lblEmailError.AutoSize = true;
            this.lblEmailError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailError.ForeColor = System.Drawing.Color.Red;
            this.lblEmailError.Location = new System.Drawing.Point(54, 205);
            this.lblEmailError.MaximumSize = new System.Drawing.Size(200, 65);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.Size = new System.Drawing.Size(66, 13);
            this.lblEmailError.TabIndex = 68;
            this.lblEmailError.Text = "Invalid Email";
            this.lblEmailError.Visible = false;
            // 
            // lblPhoneError
            // 
            this.lblPhoneError.AutoSize = true;
            this.lblPhoneError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneError.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneError.Location = new System.Drawing.Point(54, 267);
            this.lblPhoneError.Name = "lblPhoneError";
            this.lblPhoneError.Size = new System.Drawing.Size(112, 13);
            this.lblPhoneError.TabIndex = 67;
            this.lblPhoneError.Text = "Invalid Phone Number";
            this.lblPhoneError.Visible = false;
            // 
            // frmEditSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 433);
            this.Controls.Add(this.lblNameError);
            this.Controls.Add(this.lblEmailError);
            this.Controls.Add(this.lblPhoneError);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblRecordResult);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCompanyPhone);
            this.Controls.Add(this.lblCompanyEmail);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.cmbSupplierID);
            this.Controls.Add(this.btnExit);
            this.Name = "frmEditSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditSuppliers";
            this.Load += new System.EventHandler(this.frmEditSuppliers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecordResult;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCompanyPhone;
        private System.Windows.Forms.Label lblCompanyEmail;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cmbSupplierID;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.Label lblEmailError;
        private System.Windows.Forms.Label lblPhoneError;
    }
}