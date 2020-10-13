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
    public partial class frmDeleteSuppliers : Form
    {
        public frmDeleteSuppliers()
        {
            InitializeComponent();
        }

        private bool ValidateID()
        {
            int parsedValue;
            if (!int.TryParse(txtID.Text, out parsedValue))
            {
                return false;
            }

            SqlCommand command = new SqlCommand($"SELECT COUNT(*) FROM Suppliers WHERE SupplierID = {txtID.Text}", frmLogin.con);
            command.Parameters.AddWithValue(txtID.Text, txtID.Text);
            var res = (int)command.ExecuteScalar();
            if (res <= 0)
            {
                MessageBox.Show("Sale not found");
                return false;
            }

            return true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ValidateID())
            {
                SqlCommand command = new SqlCommand($"DELETE FROM Suppliers WHERE SupplierID = {txtID.Text}", frmLogin.con);
                command.Parameters.AddWithValue(txtID.Text, txtID.Text);
                command.ExecuteNonQuery();
                txtID.Text = "";
                MessageBox.Show("Supplier deleted");
            }
            else
            {
                MessageBox.Show("Supplier not found");
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
