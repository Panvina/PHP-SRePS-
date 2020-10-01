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
    public partial class DeleteProduct : Form
    {
        public DeleteProduct()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomepage home = new frmHomepage();
            home.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {

                try
                {
                    int proID = int.Parse(txtProductID.Text);
                    string query = "DELETE FROM Products WHERE ProductID = " + proID;
                    SqlCommand command = new SqlCommand(query, frmLogin.con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("The product is deleted.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The productID cannot be deleted. " +
                        "Please check that the productID exists before you try again!");
                }
            }
        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductID.Text))
            {
                e.Cancel = true;
                txtProductID.Focus();
                errorProvider.SetError(txtProductID, "ProductID cannot be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtProductID, "");
            }
        }
    }
}
