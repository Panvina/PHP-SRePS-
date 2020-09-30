using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PHP
{
    public partial class frmAddSuppliers : Form
    {
        public frmAddSuppliers()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomepage home = new frmHomepage();
            home.Show();
        }

        public bool ValidateInputs()
        {
            lblEmailError.Visible = false;
            lblPhoneError.Visible = false;

            int parsedValue;
            if (!int.TryParse(txtID.Text, out parsedValue))
            {
                lblIDError.Visible = true;
                return false;
            }
            else if (txtID.Text.Length != 6)
            {
                lblIDError.Visible = true;
                return false;
            }

            if (txtName.Text == "")
            {
                lblNameError.Visible = true;
                return false;
            }

            try
            {
                var addr = new System.Net.Mail.MailAddress(txtEmail.Text);
            }
            catch
            {
                lblEmailError.Visible = true;
                return false;
            }

            if (!int.TryParse(txtPhone.Text, out parsedValue)) //Phone numbers must be integers (even if storing them in a varchar field)
            {
                lblPhoneError.Visible = true;
                return false;
            }
            if (txtPhone.Text.Length != 10) //Phone numbers are 10 digits
            {
                lblPhoneError.Visible = true;
                return false;
            }

            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblRowsAffected.Visible = false;

            if (ValidateInputs())
            {
                string query = $"INSERT INTO Suppliers (SupplierID, CompanyName, CompanyEmail, CompanyPhone) VALUES ({txtID.Text}, {txtName.Text}, '{txtEmail.Text}', {txtPhone.Text})";
                SqlCommand command = new SqlCommand(query, frmLogin.con);
                lblRowsAffected.Text = $"{command.ExecuteNonQuery()} affected rows.";

                lblRowsAffected.Visible = true;

                txtID.Text = "";
                txtName.Text = "";
                txtEmail.Text = "";
                txtPhone.Text = "";
            }
        }
    }
}
