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

namespace PHP
{
    public partial class frmEditSuppliers : Form
    {
        public frmEditSuppliers()
        {
            InitializeComponent();
        }

        private void frmEditSuppliers_Load(object sender, EventArgs e)
        {
            string query = "SELECT SupplierID from Suppliers";
            SqlCommand command = new SqlCommand(query, frmLogin.con);
            command.Transaction = frmLogin.con.BeginTransaction();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    cmbSupplierID.Items.Add(reader[0].ToString());
                }
            }

            command.Transaction.Commit();
            lblRecordResult.Visible = false;
        }

        public bool ValidateInputs()
        {
            lblEmailError.Visible = false;
            lblPhoneError.Visible = false;

            if (txtName.Text == "")
            {
                lblNameError.Visible = true;
                lblRecordResult.Visible = false;
                return false;
            }

            try
            {
                var addr = new System.Net.Mail.MailAddress(txtEmail.Text);
            }
            catch
            {
                lblEmailError.Visible = true;
                lblRecordResult.Visible = false;
                return false;
            }

            int parsedValue;
            if (!int.TryParse(txtPhone.Text, out parsedValue))
            {
                lblPhoneError.Visible = true;
                lblRecordResult.Visible = false;
                return false;
            }

            if (txtPhone.Text.Length != 10)
            {
                lblPhoneError.Visible = true;
                lblRecordResult.Visible = false;
                return false;
            }

            return true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string query = $"UPDATE Suppliers SET CompanyName='{txtName.Text}', CompanyEmail='{txtEmail.Text}', CompanyPhone='{txtPhone.Text}' WHERE SupplierID='{cmbSupplierID.SelectedItem}'";

                SqlCommand command = new SqlCommand(query, frmLogin.con);
                command.Transaction = frmLogin.con.BeginTransaction();

                int rowsAffected = command.ExecuteNonQuery();

                lblRecordResult.Text = $"Success! {rowsAffected} records affected.";
                lblRecordResult.Visible = true;

                command.Transaction.Commit();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomepage home = new frmHomepage();
            home.Show();
        }
    }
}
